using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string ConnString = "server=127.0.0.1,3306;user id=root;database=nmn";
            SqlConnection connect = new SqlConnection(ConnString);
            connect.Open();
        }
    }
}
