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
    public partial class frm_Info : Form
    {
        public frm_Info()
        {
            InitializeComponent();
        }
        public frm_Info(String InfoText) : this()
        {
            tb_Info.Text = InfoText;
        }
    }
}
