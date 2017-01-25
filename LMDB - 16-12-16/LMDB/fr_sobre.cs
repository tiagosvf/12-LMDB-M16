using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMDB
{
    public partial class fr_sobre : Form
    {
        public fr_sobre()
        {
            InitializeComponent();

            listView1.Items.Add("http://plainicon.com/download-icon/57215/magnifying-glass");
            listView1.Items.Add("http://stackoverflow.com/questions/25254943/add-sqlparameter-to-bind-like-x");

            listView1.Items.Add("http://stackoverflow.com/a/19975701");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
