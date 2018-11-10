using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class CurrentLinkPopup : Form
    {
        List<string> MainFormConsumerLogLInks = null;
        List<string> MainFormSoapLogLinks = null;
        List<string> MainFormSkewLogLinks = null;

        public CurrentLinkPopup()
        {
            InitializeComponent();
            this.Icon = EDALogTool_ver1.Properties.Resources.log;
        }

        public CurrentLinkPopup(List<string> Link1, List<string> Link2, List<string> Link3)
        {
            InitializeComponent();
            this.MainFormConsumerLogLInks = Link1;
            this.MainFormSoapLogLinks = Link2;
            this.MainFormSkewLogLinks = Link3;
            this.Icon = EDALogTool_ver1.Properties.Resources.log;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBoxConsumerLogLinks.Clear();
            richTextBoxSoapMessageLinks.Clear();
            richTextBoxSkewLogLinks.Clear();

            foreach (string str in MainFormConsumerLogLInks)
            {
                richTextBoxConsumerLogLinks.AppendText(str + Environment.NewLine);
            }
            foreach (string str in MainFormSoapLogLinks)
            {
                richTextBoxSoapMessageLinks.AppendText(str + Environment.NewLine);
            }
            foreach (string str in MainFormSkewLogLinks)
            {
                richTextBoxSkewLogLinks.AppendText(str + Environment.NewLine);
            }
        }
    }
}
