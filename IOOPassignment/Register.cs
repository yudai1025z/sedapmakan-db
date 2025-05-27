using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IOOPassignment
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(DatabaseHelper.ConnStr);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
