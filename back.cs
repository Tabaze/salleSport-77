using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salleSport
{
    public partial class back : Form
    {
        public back()
        {
            InitializeComponent();
        }

   var connection = System.Configuration.ConfigurationManager.ConnectionStrings["gestionSportEntities"].ConnectionString;
        SqlConnection cn = new SqlConnection(connection); 
     
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d = new FolderBrowserDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
