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
    public partial class TrainForm : Form
    {
        public TrainForm()
        {
            InitializeComponent();
        }

        private void btnAddExample_Click(object sender, EventArgs e)
        {
            AddExampleForm aef = new AddExampleForm();
            aef.Show();
        }
    }
}
