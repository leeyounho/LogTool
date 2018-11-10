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
    public partial class TreeViewSearchPopup : Form
    {
        public string ReturnString { get; private set; }

        public TreeViewSearchPopup()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = Cursor.Position;
            InitializeComponent();
        }

        private void textBoxSearchXML_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.Yes;
                ReturnString = textBoxSearchXML.Text;
            }
        }
    }
}
