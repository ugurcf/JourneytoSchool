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
    public partial class AddExampleForm : Form
    {
        public AddExampleForm()
        {
            InitializeComponent();
        }
        SqlCommand cm;
        SqlDataAdapter da;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-ONB0MHF9;Initial Catalog=JourneyMethod;Integrated Security=True");

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void AddExampleForm_Load(object sender, EventArgs e)
        {
            btnAdd.TabStop = false;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnCancel.TabStop = false;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Tbl_Dataset(Age,Distance,Friends,Method) VALUES  (@Age,@Distance,@Friends,@Method)";
            cm = new SqlCommand(sorgu, conn);
            cm.Parameters.AddWithValue("@Age", txtBoxAge.Text);
            cm.Parameters.AddWithValue("@Distance", txtBoxDistance.Text);
            cm.Parameters.AddWithValue("@Friends", txtBoxFriends.Text);
            cm.Parameters.AddWithValue("@Method", txtBoxMethod.Text);
            conn.Open();
            cm.ExecuteNonQuery();
            conn.Close();
            TrainForm tf = new TrainForm();
            tf.Show();
            this.Hide();

            
        }
    }
}
