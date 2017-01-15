using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_PF
{
    public partial class frm_Main : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                return true;
            else if (keyData == Keys.Alt || keyData == Keys.F4)
                return true;

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public frm_Main()
        {
            InitializeComponent();
            this.Focus();

            this.KeyPress += frm_Main_KeyPress;
        }

        #region "Pasek menu"
        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Info _info = new frm_Info("Autorzy aplikacji:" + Environment.NewLine + "Sebastian Wojtalik" + Environment.NewLine + "Przemysław Foltyn");
            _info.ShowDialog(this);
        }
        #endregion

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(String.Format("Form.KeyPress: {0}", e.KeyChar.ToString()));

            switch ((Keys)e.KeyChar)
            {
                case Keys.Escape:
                    e.Handled = true;
                    break;
                default:
                    break;
            }
        }
    }
}
