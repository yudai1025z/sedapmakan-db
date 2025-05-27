using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace IOOPassignment
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public bool Login(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection())
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
