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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }
        
        private void TestForm_Load(object sender, EventArgs e)
        {
            btnTest.TabStop = false;
            btnTest.FlatStyle = FlatStyle.Flat;
            btnTest.FlatAppearance.BorderSize = 0;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int Age =Convert.ToInt32(txtBoxAge.Text);
            int Dist=Convert.ToInt32(Math.Floor(Convert.ToDecimal(txtBoxDist.Text)));
            int Friend = Convert.ToInt32(txtBoxFriends.Text);
            if(Age<=6 || Dist==0)
            {
                lblResult.Text = "Not Valid";
            }
            if (Dist > 30)
            {
                lblResult.Text = "%97.5 Car";
            }
            if(Dist<1 && Age>12 && Friend == 0)
            {
                lblResult.Text = "%92 Walk";
            }
            if (Age>=9 && Age <=11 && Dist < 4)
            {
                lblResult.Text = "%67 Car";
            }
            if (Age >= 9 && Age <= 11 && Dist < 4 && Dist>=2 && Friend>1 && Friend<=3)
            {
                lblResult.Text = "%58 Car";
            }
            if (Age >= 9 && Age <= 11 && Dist < 4 && Dist >= 2 && Friend > 4 && Friend <= 20)
            {
                lblResult.Text = "%86 Car";
            }
            if (Age >= 9 && Age <= 11 && Dist < 4 && Dist>= 2 && Friend >= 0 && Friend <=6)
            {
                lblResult.Text = "%75 Car";
            }
            if (Age >= 9 && Age <= 11 && Dist <15 && Dist >= 10 && Friend >= 0 && Friend <= 2000)
            {
                lblResult.Text = "%96 Car";
            }
            
        }
    }
}
