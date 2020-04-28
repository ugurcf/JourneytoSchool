using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JourneytoSchool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            TrainForm tf = new TrainForm();
            tf.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            TestForm tf = new TestForm();
            tf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTest.TabStop = false;
            btnTest.FlatStyle = FlatStyle.Flat;
            btnTest.FlatAppearance.BorderSize = 0;
            btnTrain.TabStop = false;
            btnTrain.FlatStyle = FlatStyle.Flat;
            btnTrain.FlatAppearance.BorderSize = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
