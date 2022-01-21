using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                lblParam1.Visible = true;
                lblParam2.Visible = false;
                lblParam3.Visible = false;

                lblParam1.Text = "R";

                txtParam1.Visible = true;
                txtParam2.Visible = false;
                txtParam3.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                lblParam1.Visible = true;
                lblParam2.Visible = true;
                lblParam3.Visible = false;

                lblParam1.Text = "S";
                lblParam2.Text = "H";

                txtParam1.Visible = true;
                txtParam2.Visible = true;
                txtParam3.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                lblParam1.Visible = true;
                lblParam2.Visible = true;
                lblParam3.Visible = true;

                lblParam1.Text = "A";
                lblParam2.Text = "B";
                lblParam3.Text = "C";

                txtParam1.Visible = true;
                txtParam2.Visible = true;
                txtParam3.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
#if DEBUG
            button3.Visible = true;
#endif
        }

        private static Random rand = new Random();

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = rand.Next(comboBox1.Items.Count);

            txtParam1.Text = rand.Next(100).ToString();
            txtParam2.Text = rand.Next(100).ToString();
            txtParam3.Text = rand.Next(100).ToString();
        }
    }
}
