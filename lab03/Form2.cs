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
    public partial class Form2 : Form
    {
        string datasource = "BAHAU";
        string database = "STUDENT_MANAGEMENT";
        string username = "sa";
        string password = "2411";
        

        public Form2()
        {
            InitializeComponent();
        }

        private void cLASSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLASSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTUDENT_MANAGEMENTDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENT_MANAGEMENTDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.sTUDENT_MANAGEMENTDataSet.STUDENT);
            // TODO: This line of code loads data into the 'sTUDENT_MANAGEMENTDataSet.CLASS' table. You can move, or remove it, as needed.
            this.cLASSTableAdapter.Fill(this.sTUDENT_MANAGEMENTDataSet.CLASS);
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=BAHAU;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True;User ID=sa;password=2411";
            string query = "SELECT * FROM STUDENT WHERE ClassID = @ClassID";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@ClassID", comboBox1.Text);
            var ds = new DataSet();

            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
