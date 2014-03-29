using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro_To_Business_Project
{
    public partial class frmNewFolderFile : Form
    {
        public frmNewFolderFile()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            strName();
            this.Close();
        }

        public string strName()
        {
            return txtName.Text;
        }
    }
}
