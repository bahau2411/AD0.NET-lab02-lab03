using Microsoft.Data.SqlClient;
using System.Data;

namespace Lab02
{
    public partial class Form1 : Form
    {
        SqlConnection connection = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        
        string query = "";
        string datasource = "BAHAU";
        string database = "STUDENT_MANAGEMENT";
        string username = "sa";
        string password = "2411";
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            connection = DBUtils.GetDBConnection(datasource, database, username, password);
            query = "SELECT * FROM STUDENT";
            adapter = new SqlDataAdapter(query, "Data Source=BAHAU;Initial Catalog=STUDENT_MANAGEMENT;Persist Security Info=True;TrustServerCertificate=True;User ID=sa; password=2411");
            ds = new DataSet();
            adapter.Fill(ds, "STUDENT");
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            stdDataGridView.DataSource = ds.Tables[0];

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            int result = 0;
            DataRow row = ds.Tables[0].NewRow();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            row[0] = studentIDBox.Text;
            row[1] = studentNameBox.Text;
            row[2] = classIDBox.Text;

            ds.Tables[0].Rows.Add(row);
            try
            {
                result = adapter.Update(ds, ds.Tables[0].TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (result > 0) MessageBox.Show("Insert successfully!");
        }
        int position = -1;


       

        private void stdDataGridView_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            
            position = e.Cell.RowIndex;

            if (position == -1)
            {
                MessageBox.Show("Failed");
                return;
            }

            DataRow row = ds.Tables[0].Rows[position];

            studentIDBox.Text = row[0].ToString();
            studentNameBox.Text = row[1].ToString();
            classIDBox.Text = row[2].ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (position == -1)
            {
                MessageBox.Show("Failed");
                return;
            }
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataRow row = ds.Tables[0].Rows[position];
            row.BeginEdit();
            row[0] = studentIDBox.Text;
            row[1] = studentNameBox.Text;
            row[2] = classIDBox.Text;
            row.EndEdit();

            int result = adapter.Update(ds.Tables[0]);

            if(result > 0)
            {
                MessageBox.Show("Update Successfully");
            }
            else
            {
                MessageBox.Show("Update Successfully");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (position == -1)
            {
                MessageBox.Show("Failed");
                return;
            }
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataRow row = ds.Tables[0].Rows[position];
            row.Delete();
            int result = adapter.Update(ds.Tables[0]);

            if (result > 0)
            {
                MessageBox.Show("Delete Successfully");
            }
            else
            {
                MessageBox.Show("Delete Successfully");
            }
        }
    }
}