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

namespace JourneytoSchool
{
    public partial class TrainForm : Form
    {
        public TrainForm()
        {
            InitializeComponent();
        }
        //GENEL DB Tanımlamaları
        SqlCommand cm;
        SqlDataAdapter da;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-ONB0MHF9;Initial Catalog=JourneyMethod;Integrated Security=True");

        public void showExamples()  //DB'den verilerimizi çekmek için oluşturulmuş method
        {
            conn.Open();
            da = new SqlDataAdapter("SELECT *FROM Tbl_Dataset",conn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
            dataGridView1.Columns["ExampleNo"].Visible = false;
        }

        private void btnAddExample_Click(object sender, EventArgs e)
        {
            AddExampleForm aef = new AddExampleForm();
            aef.Show();
        }

        private void TrainForm_Load(object sender, EventArgs e)
        {
            btnAddExample.TabStop = false;
            btnAddExample.FlatStyle = FlatStyle.Flat;
            btnAddExample.FlatAppearance.BorderSize = 0;
            btnDelete.TabStop = false;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            showExamples(); // verilerimizi getirdim DB'den.
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = this.dataGridView1.SelectedRows[0];
            string exampleNumber = row.Cells["ExampleNo"].Value.ToString();

            cm = new SqlCommand();
            cm.CommandText = "DELETE FROM Tbl_Dataset WHERE ExampleNo=@ExampleNo";
            conn.Open();
            cm.Connection = conn;
            cm.Parameters.AddWithValue("@ExampleNo", row.Cells["ExampleNo"].Value);
            
            cm.ExecuteNonQuery();
            conn.Close();
            showExamples();
            MessageBox.Show("Example " + exampleNumber + " Deleted.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
