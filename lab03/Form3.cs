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

namespace lab03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string connection = "Data Source=BAHAU;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True;User ID=sa;password=2411";
            string query = $"SELECT * FROM STUDENT WHERE Name LIKE '%{textBox1.Text}%'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            var ds = new DataSet();

            adapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
    }
}
