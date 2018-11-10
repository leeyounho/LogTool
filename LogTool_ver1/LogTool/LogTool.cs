using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication2
{
    /*
     * 2. consumer soap 매칭 (라인 바이 라인인데 리치텍스트박스 때문에 빠르게 하는거 생각해야 함)
     * 1. 파일을 링크하면 자동으로 sort되게 기준은 '.'을 split한 숫자들 -> Link에서
     * 4. xml formatter 빠르게, 검색도 되게, 열리는 자식단계는 옵션으로
     * 필요한거 Soap Message log 샘플 (각 3개 씩)
     * ui에서 xml 샘플에 colon이 들어가는지 확인 -> 들어감
     */
    public partial class EDALogTool : Form
    {
        List<string> linkedfilePaths_ConsumerLog = new List<string>();
        List<string> linkedfilePaths_SoapMessageLog = new List<string>();
        List<string> linkedfilePaths_TOOLDATASKEW = new List<string>();

        string saveFilePath_1;
        string saveFilePath_2;
        string saveFilePath_TOOLDATASKEW;

        string editorPath;

        CurrentLinkPopup currentLink = null;

        public EDALogTool()
        {
            InitializeComponent();
            InitProgram();
        }

        private void InitProgram()
        {
            this.Icon = EDALogTool_ver1.Properties.Resources.log;
            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // 바탕화면
            openFileDialogEditor.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // 바탕화면
            saveFilePath_1 = System.IO.Path.GetDirectoryName(Application.ExecutablePath); // 현재 디렉토리
            saveFilePath_2 = System.IO.Path.GetDirectoryName(Application.ExecutablePath); // 현재 디렉토리
            saveFilePath_TOOLDATASKEW = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            editorPath = "notepad.exe";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.D1)
                {
                    tabControlTrace.SelectTab(0);
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D2)
                {
                    tabControlTrace.SelectTab(1);
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.D3)
                {
                    tabControlTrace.SelectTab(2);
                    e.Handled = true;
                }
            }
        }

        /*
         * 
         * Trace Tab
         * 
         */

        private bool isContainAtLeast(string line, List<string> tgtList)
        {
            //line이 tgtlist중 하나라도 contain하면 true, 하나도 없으면 false 반환

            foreach (string tgtItem in tgtList)
            {
                if (line.Contains(tgtItem)) return true;
            }
            return false;
        }

        private string Decompress(FileInfo fileToDecompress)
        {
            //압축해제
            string newFileName;

            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                string currentFileName = fileToDecompress.FullName;
                newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                        Console.WriteLine("Decompressed: {0}", fileToDecompress.Name);
                    }
                }
            }
            return newFileName;
        }

        private void LinkFilesToList(List<string> From, List<string> To)
        {
            //To 리스트 초기화
            //From 리스트를 To 리스트에 저장한다.
            //만약 gz이면 압축풀고 .log (.txt)파일을 링크한다.

            To.Clear();
            foreach (string newfilePath in From)
            {
                if (Path.GetExtension(newfilePath) == ".gz")
                {
                    To.Add(Decompress(new FileInfo(newfilePath)));
                }
                else if (Path.GetExtension(newfilePath) == ".txt" || Path.GetExtension(newfilePath) == ".log")
                {
                    To.Add(newfilePath);
                }
            }

            //Numerical Sort
            //linkedfilePaths_1.OrderBy(str => str.Split('-')[1]).ThenBy(str=>str.Split('-')[2])
            //    .ThenBy(str=>str.Split('-')[3]).ThenBy(str=>str.Split('-')[4])
            //    .ThenBy(str=>str.Split('.')[1]);
            //DEBUG 파일 링크된 순서
            //linkedfilePaths_1.ForEach(str => MessageBox.Show(str +"\r\n" + str.Split('.')[1]));
        }

        private void WriteLogifContains(string fileToRead, string fileToWrite, List<List<string>> toCompare)
        {
            //toCompare List에 포함된 아이템이 하나라도 있으면 출력

            using (FileStream fs = File.Open(fileToRead, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            using (StreamWriter sw = new StreamWriter(fileToWrite, false))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    bool isContainCompareItem = true;
                    if (radioButtonTOOLDATA.Checked == true)
                        if (!line.Contains("TOOLDATA")) continue;
                    if (radioButtonTOOLEVENTS.Checked == true)
                        if (!line.Contains("TOOLEVENTS")) continue;
                    if (radioButtonTOOLALARM.Checked == true)
                        if (!line.Contains("TOOLALARM")) continue;

                    if (!string.IsNullOrEmpty(textBoxTimeAfter_1.Text) && !string.IsNullOrEmpty(textBoxTimeBefore_1.Text))
                    {
                        string hdrtime = null;

                        hdrtime = Regex.Match(line, @"^\[(.*?)\]").Groups[1].Value;
                        hdrtime = string.Join("",Regex.Split(hdrtime, @"[^\d+]"));
                        hdrtime = hdrtime.Remove(hdrtime.Length - 1);

                        if ((hdrtime!=null)
                            && (Convert.ToUInt64(hdrtime) < Convert.ToUInt64(textBoxTimeAfter_1.Text)
                            || Convert.ToUInt64(hdrtime) > Convert.ToUInt64(textBoxTimeBefore_1.Text)))
                        {
                            continue;
                        }
                    }

                    foreach (List<string> listToCompare in toCompare)
                    {
                        //toCompare안의 List<string>는 AND 조건
                        //listToCompare안의 string은 OR 조건

                        if (!isContainAtLeast(line, listToCompare))
                        {
                            isContainCompareItem = false;
                        }
                    }
                    if (isContainCompareItem)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            if (openAfterCompareToolStripMenuItem.Checked == true)
            {
                Process.Start(editorPath, fileToWrite);
            }
        }

        private void buttonLink1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LinkFilesToList(openFileDialog1.FileNames.ToList<string>(), linkedfilePaths_ConsumerLog);
                if (linkedfilePaths_ConsumerLog.Any()) MessageBox.Show("Linked");
                else MessageBox.Show("Link Failed");
            }
        }

        private void buttonLink2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LinkFilesToList(openFileDialog1.FileNames.ToList<string>(), linkedfilePaths_SoapMessageLog);
                if (linkedfilePaths_SoapMessageLog.Any()) MessageBox.Show("Linked");
                else MessageBox.Show("Link Failed");
            }
        }

        private void buttonFind1_Click(object sender, EventArgs e)
        {
            // Find 버튼을 클릭하면
            // textBoxLink1_1, _2, _3에서 List<string>을 가지고 와서 toCompare에 넣는다.
            // WriteLogifContains는 toCompare를 받아서
            // 조건을 만족하는 line만 출력한다.
            //
            // Time after before 기준은 헤더에 있는 타임 기준으로 한다. (나중에 옵션으로 뺄까 생각 중)

            if (!linkedfilePaths_ConsumerLog.Any())
            {
                MessageBox.Show("Link Files First 1");
                return;
            }

            char[] delimiters = new[] { ',', ' ' };
            List<List<string>> toCompare = new List<List<string>>();
            List<string> radioButtonToCompare = new List<string>();

            if (radioButtonTOOLDATA.Checked == true)
                radioButtonToCompare.Add(radioButtonTOOLDATA.Text);
            else if (radioButtonTOOLEVENTS.Checked == true)
                radioButtonToCompare.Add(radioButtonTOOLEVENTS.Text);
            else if (radioButtonTOOLALARM.Checked == true)
                radioButtonToCompare.Add(radioButtonTOOLALARM.Text);
            if (radioButtonToCompare.Any()) toCompare.Add(radioButtonToCompare);

            if (!string.IsNullOrEmpty(richTextBoxLink1_1.Text))
            {
                List<string> splittedList_1 = richTextBoxLink1_1.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
                toCompare.Add(splittedList_1);
            }
            if (!string.IsNullOrEmpty(richTextBoxLink1_2.Text))
            {
                List<string> splittedList_2 = richTextBoxLink1_2.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
                toCompare.Add(splittedList_2);
            }
            if (!string.IsNullOrEmpty(richTextBoxLink1_3.Text))
            {
                List<string> splittedList_3 = richTextBoxLink1_3.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
                toCompare.Add(splittedList_3);
            }

            // DEBUG List<List<string>>에 값이 잘 들어갔나 확인
            //foreach (List<string> item in toCompare)
            //{
            //    foreach (string str in item)
            //    {
            //        MessageBox.Show(str);
            //    } 
            //}

            if (!string.IsNullOrEmpty(textBoxTimeAfter_1.Text) && !string.IsNullOrEmpty(textBoxTimeBefore_1.Text))
            {
                if (textBoxTimeAfter_1.Text.Length!=16 || textBoxTimeBefore_1.Text.Length!=16)
                {
                    MessageBox.Show("invalid value in time textbox");
                    return;
                }
            }

            foreach (string fileName in linkedfilePaths_ConsumerLog)
            {
                WriteLogifContains(fileName, saveFilePath_1 + @"\Trace.txt", toCompare);
            }
        }

        private void buttonFind2_Click(object sender, EventArgs e)
        {

        }

        private void changeEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogEditor.ShowDialog() == DialogResult.OK)
            {
                editorPath = openFileDialogEditor.FileName;
                MessageBox.Show("Basic editor changed : " + openFileDialogEditor.FileName);
            }
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Ready");
        }

        private void alwaysToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (alwaysToolStripMenuItem.Checked == true) this.TopMost = true;
            else this.TopMost = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBoxLink1_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (autoToolStripMenuItem.Checked == true)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        private void richTextBoxLink2_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (autoToolStripMenuItem.Checked == true)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        private void richTextBoxLink1_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (autoToolStripMenuItem.Checked == true)
            {
                e.KeyChar = Char.ToLower(e.KeyChar);
            }
        }

        private void richTextBoxLink2_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (autoToolStripMenuItem.Checked == true)
            {
                e.KeyChar = Char.ToLower(e.KeyChar);
            }
        }

        private void textBoxTimeAfter_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTimeAfter_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTimeBefore_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTimeBefore_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBoxConsumerLog.Text) && string.IsNullOrEmpty(richTextBoxSoapMessage.Text))
            {
                MessageBox.Show("Please type text at least one side");
                return;
            }

            if (!string.IsNullOrEmpty(richTextBoxConsumerLog.Text) && !string.IsNullOrEmpty(richTextBoxSoapMessage.Text))
            {
                MessageBox.Show("Type text on one side only");
                return;
            }

            if (!string.IsNullOrEmpty(richTextBoxConsumerLog.Text))
            {
                if (!linkedfilePaths_SoapMessageLog.Any())
                {
                    MessageBox.Show("Link Soap Log");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(richTextBoxSoapMessage.Text))
            {
                if (!linkedfilePaths_ConsumerLog.Any())
                {
                    MessageBox.Show("Link Consumer Log");
                    return;
                }
            }

            // Logic
            //SoapMessage가 비어있으면 Consumer -> Soap 변환
            if (string.IsNullOrEmpty(richTextBoxSoapMessage.Text))
            {
                String[] lines = richTextBoxSoapMessage.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string consumerLine in lines)
                {
                    string SAMPLENUMBER = null;
                    string DCP = null;

                    foreach (string fileName in linkedfilePaths_SoapMessageLog)
                    {
                        using (FileStream fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        using (BufferedStream bs = new BufferedStream(fs))
                        using (StreamReader sr = new StreamReader(bs))
                        using (StreamWriter sw = new StreamWriter(saveFilePath_1 + @"\Trace.txt", false))
                        {
                            string line;

                            while ((line = sr.ReadLine()) != null)
                            {

                            }
                        }
                    }
                }
            }
            else // Soap -> Consumer 변환
            {
                foreach (string fileName in linkedfilePaths_ConsumerLog)
                {
                    using (FileStream fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (BufferedStream bs = new BufferedStream(fs))
                    using (StreamReader sr = new StreamReader(bs))
                    using (StreamWriter sw = new StreamWriter(saveFilePath_1 + @"\Trace.txt", false))
                    {

                    }
                }
            }
        }

        private void linkResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linkedfilePaths_ConsumerLog.Clear();
            linkedfilePaths_SoapMessageLog.Clear();
            linkedfilePaths_TOOLDATASKEW.Clear();
            MessageBox.Show("Link Cleared");
        }

        private void toolStripMenuItemShowCurrentLink_Click(object sender, EventArgs e)
        {
            currentLink = new CurrentLinkPopup(linkedfilePaths_ConsumerLog, linkedfilePaths_SoapMessageLog, linkedfilePaths_TOOLDATASKEW);
            currentLink.Show();
        }

        /*
         * 
         * XML Formatter Tab
         * 
         */

        private void buttonConvertXML_Click(object sender, EventArgs e)
        {
            try
            {
                // SECTION 1. Create a DOM Document and load the XML data into it.
                XmlDocument dom = new XmlDocument();
                dom.LoadXml(richTextBoxXML.Text);

                // SECTION 2. Initialize the TreeView control.
                treeViewXML.Nodes.Clear();
                treeViewXML.Nodes.Add(new TreeNode(dom.DocumentElement.Name));
                TreeNode tNode = new TreeNode();
                tNode = treeViewXML.Nodes[0];

                // SECTION 3. Populate the TreeView with the DOM nodes.
                AddNode(dom.DocumentElement, tNode);
                treeViewXML.ExpandAll();
            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;

            // Loop through the XML nodes until the leaf is reached.
            // Add the nodes to the TreeView during the looping process.
            if (inXmlNode.HasChildNodes)
            {
                foreach (XmlAttribute att in inXmlNode.Attributes)
                {
                    inTreeNode.Text = inTreeNode.Text + " " + att.Name + ": " + att.Value;
                }

                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                // Here you need to pull the data from the XmlNode based on the
                // type of node, whether attribute values are required, and so forth.
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TreeViewSearchPopup searchXML = new TreeViewSearchPopup();
            if (searchXML.ShowDialog() == DialogResult.Yes)
            {
                //Search할 결과 저장
                string temp = searchXML.ReturnString;

                //Treeview Search
                SearchRecursiveTreeView(treeViewXML.Nodes[0], temp);
            }
            searchXML.Dispose();
        }

        private void SearchRecursiveTreeView(TreeNode treeNode, string findText)
        {
            Font boldFont = new Font(treeViewXML.Font, FontStyle.Bold);
            Font basicFont = new Font(treeViewXML.Font, FontStyle.Regular);

            foreach (TreeNode tn in treeNode.Nodes)
            {
                tn.ForeColor = Color.Black;
                tn.NodeFont = basicFont;
                if (tn.Text.Contains(findText))
                {
                    tn.ForeColor = Color.Red;
                    tn.NodeFont = boldFont;
                    tn.Text = tn.Text; // winform 에러?인 것같음
                }
                SearchRecursiveTreeView(tn, findText);
            }
        }

        //public void PrintRecursiveTreeView(TreeNode treeNode)
        //{
        //    MessageBox.Show(treeNode.Text);
        //    // Print each node recursively.
        //    foreach (TreeNode tn in treeNode.Nodes)
        //    {
        //        PrintRecursiveTreeView(tn);
        //    }
        //}

        private void ClearSearch(TreeNode treeNode)
        {
            Font boldFont = new Font(treeViewXML.Font, FontStyle.Bold);
            Font basicFont = new Font(treeViewXML.Font, FontStyle.Regular);

            foreach (TreeNode tn in treeNode.Nodes)
            {
                tn.ForeColor = Color.Black;
                tn.NodeFont = basicFont;
                ClearSearch(tn);
            }
        }

        private void searchClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearSearch(treeViewXML.Nodes[0]);
        }

        /*
         * 
         * TOOLDATA Skew Tab
         * 
         */

        private void buttonSkewLink_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LinkFilesToList(openFileDialog1.FileNames.ToList<string>(), linkedfilePaths_TOOLDATASKEW);
                if (linkedfilePaths_TOOLDATASKEW.Any()) MessageBox.Show("Linked");
                else MessageBox.Show("Link Failed");
            }
        }

        private void buttonSkewCompare_Click(object sender, EventArgs e)
        {
            if (!linkedfilePaths_TOOLDATASKEW.Any())
            {
                MessageBox.Show("Link Files First (Skewed Log)");
                return;
            }

            char[] delimiters = new[] { ',', ' ' };
            List<string> splittedList_1 = new List<string>();
            List<string> splittedList_2 = new List<string>();

            if (!string.IsNullOrEmpty(richTextBoxSkewEQPList.Text))
            {
                splittedList_1 = richTextBoxSkewEQPList.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            // DEBUG List<List<string>>에 값이 잘 들어갔나 확인
            //foreach (List<string> item in toCompare)
            //{
            //    foreach (string str in item)
            //    {
            //        MessageBox.Show(str);
            //    } 
            //}

            foreach (string fileName in linkedfilePaths_TOOLDATASKEW)
            {
                TooldataSkew(fileName, saveFilePath_TOOLDATASKEW + @"\ANALYSIS_" + fileName.Split('\\')[fileName.Split('\\').Length-1] , splittedList_1, splittedList_2);
            }
        }

        private void TooldataSkew(string fileToRead, string fileToWrite, List<string> eqpIdList, List<string> DCPList)
        {
            //만약 EQPID List가 비어있으면 Consumer Log에서 모든 EQPID를 불러온다.
            if (!eqpIdList.Any())
            {
                using (FileStream fs = File.Open(fileToRead, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (BufferedStream bs = new BufferedStream(fs))
                using (StreamReader sr = new StreamReader(bs))
                {
                    string line;
                    string EQPID;
                    HashSet<string> Unique_EQPIDList = new HashSet<string>();
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!line.Contains("TOOLDATA")) continue;
                        EQPID = Regex.Match(line, @"EQPID=([A-Z0-9]{7})").Groups[1].Value;
                        Unique_EQPIDList.Add(EQPID);
                    }
                    eqpIdList = Unique_EQPIDList.ToList();
                }
                string eqpMsg = null;
                foreach (string temp in eqpIdList)
                {
                    eqpMsg += " " + temp;
                }
                if (checkBoxEnableMsgBox.Checked==true)
                    MessageBox.Show($"EQPID List is empty. Auto read started.\r\nTarget EQPID List :{eqpMsg}");
            }

            using (FileStream fs = File.Open(fileToRead, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            using (StreamWriter sw = new StreamWriter(fileToWrite,false))
            {
                string line;
                string pattern = @"^.*\sSAMPLETIME=(\d+).*$";

                //DCP Split 옵션켜져있을 때
                if (checkBoxDCPSplit.Checked == true)
                {
                    foreach (string EQP in eqpIdList)
                    {
                        sw.WriteLine($"{EQP} Started".PadRight(100, '#').Substring(0, 100));

                        //EQP에 해당하는 DCP 찾기
                        string dcpPlanId;
                        HashSet<string> uniqueDcpList = new HashSet<string>();
                        List<string> dcpPlanList = null;

                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.Contains("TOOLDATA") && line.Contains(EQP))
                            {
                                dcpPlanId = Regex.Match(line, @"DCPLANID=""(.*?)""").Groups[1].Value;
                                uniqueDcpList.Add(dcpPlanId);
                            }
                        }
                        dcpPlanList = uniqueDcpList.ToList();
                        sr.BaseStream.Position = 0;

                        if (!dcpPlanList.Any()) continue;
                        //끝

                        foreach (string DCP in dcpPlanList)
                        {
                            sw.WriteLine($"{DCP} Started".PadRight(100,'#').Substring(0, 100));
                            string oldLine = null;
                            string oldSAMPLETIME = null, newSAMPLETIME = null;
                            bool firstline = true;

                            while ((line = sr.ReadLine()) != null)
                            {
                                if (line.Contains("TOOLDATA") && line.Contains(EQP))
                                {
                                    if (!line.Contains(DCP)) continue; //DCP
                                    if (firstline)
                                    {
                                        firstline = false;
                                        oldLine = line;
                                        continue;
                                    }

                                    oldSAMPLETIME = Regex.Match(oldLine, pattern).Groups[1].Value;
                                    newSAMPLETIME = Regex.Match(line, pattern).Groups[1].Value;

                                    if (Convert.ToUInt64(oldSAMPLETIME) > Convert.ToUInt64(newSAMPLETIME))
                                    {
                                        sw.WriteLine(FilterAttributes(oldLine));
                                        sw.WriteLine(FilterAttributes(line));
                                        sw.WriteLine();
                                        //sw.WriteLine(Environment.NewLine);
                                    }
                                    oldLine = line;
                                }
                            }
                            sr.BaseStream.Position = 0;
                            sw.WriteLine($"{DCP} Ended".PadRight(150, '#').Substring(0, 100));
                        }
                        sw.WriteLine($"{EQP} Ended".PadRight(100, '#').Substring(0, 100));
                    }
                    if (openAfterCompareToolStripMenuItem.Checked == true)
                    {
                        Process.Start(editorPath, fileToWrite);
                    }
                }
                //DCP Split 옵션켜져있지 않을 때
                else
                {
                    foreach (string EQP in eqpIdList)
                    {
                        sw.WriteLine($"{EQP} Started".PadRight(100, '#').Substring(0, 100));

                        string oldLine = null;
                        string oldSAMPLETIME = null, newSAMPLETIME = null;
                        bool firstline = true;

                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.Contains("TOOLDATA") && line.Contains(EQP))
                            {
                                if (firstline)
                                {
                                    firstline = false;
                                    oldLine = line;
                                    continue;
                                }

                                oldSAMPLETIME = Regex.Match(oldLine, pattern).Groups[1].Value;
                                newSAMPLETIME = Regex.Match(line, pattern).Groups[1].Value;

                                if (Convert.ToUInt64(oldSAMPLETIME) > Convert.ToUInt64(newSAMPLETIME))
                                {
                                    sw.WriteLine(FilterAttributes(oldLine));
                                    sw.WriteLine(FilterAttributes(line));
                                    sw.WriteLine();
                                    //sw.WriteLine(Environment.NewLine);
                                }
                                oldLine = line;
                            }
                        }
                        sr.BaseStream.Position = 0;
                        sw.WriteLine($"{EQP} Ended".PadRight(100, '#').Substring(0, 100));
                    }
                    if (openAfterCompareToolStripMenuItem.Checked == true)
                    {
                        Process.Start(editorPath, fileToWrite);
                    }
                }
            }
        }

        private string FilterAttributes(string line)
        {
            if (checkBoxCARIDMAP.Checked==false)
                line = Regex.Replace(line, @"\sCARIDMAP=\(.*?\)", "");
            if (checkBoxDCPINTERVAL.Checked== false)
                line = Regex.Replace(line, @"\sDCPINTERVAL="".*?""", "");

            if (checkBoxDCPLANID.Checked == false)
                line = Regex.Replace(line, @"\sDCPLANID="".*?""", "");
            if (checkBoxEES_SERVER_TIME.Checked == false)
                line = Regex.Replace(line, @"\sEES_SERVER_TIME="".*?""", "");

            if (checkBoxEQPID.Checked == false)
                line = Regex.Replace(line, @"\sEQPID=[A-Z0-9]+", "");
            if (checkBoxFROM_EDA_CONSUMER.Checked == false)
                line = Regex.Replace(line, @"\sFROM_EDA_CONSUMER=.", "");

            if (checkBoxHDR.Checked == false)
                line = Regex.Replace(line, @"\sHDR=\(.*?\)", "");
            if (checkBoxINNERSAMPLETIME.Checked == false)
                line = Regex.Replace(line, @"\sINNERSAMPLETIME=\d+", "");

            if (checkBoxLOTID.Checked == false)
                line = Regex.Replace(line, @"\sLOTID=\(.*?\)", "");
            if (checkBoxRECPID.Checked == false)
                line = Regex.Replace(line, @"\sRECPID=\(.*?\)", "");

            if (checkBoxSAMPLENUMBER.Checked== false)
                line = Regex.Replace(line, @"\sSAMPLENUMBER=\d+", "");
            if (checkBoxSAMPLETIME.Checked== false)
                line = Regex.Replace(line, @"\sSAMPLETIME=\d+", "");

            if (checkBoxSENSOR_VALUES.Checked== false)
                line = Regex.Replace(line, @"\sSENSOR_VALUES={.*?}", "");
            if (checkBoxTIME_STAMP.Checked == false)
                line = Regex.Replace(line, @"\sTIME_STAMP=.{21}", "");

            if (checkBoxUTC_SERVER_TIME.Checked == false)
                    line = Regex.Replace(line, @"\sUTC_SERVER_TIME=\d+", "");

            return line;
        }

        private void richTextBoxSkewEQPList_TextChanged(object sender, EventArgs e)
        {

        }
    }
}