using Model;
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
    public partial class FindForm : Form
    {
        private List<IFigure> figures;

        public FindForm(List<IFigure> figures)
        {
            this.figures = figures;
            InitializeComponent();
        }

        private void FindForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var figure in figures)
            {
                listBox1.Items.Add(figure);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (textBox1.Text == string.Empty)
            {
                foreach (var figure in figures)
                {
                    listBox1.Items.Add(figure);
                }
            }
            else
            {
                var parsed = double.Parse(textBox1.Text);
                foreach (var figure in figures)
                {
                    if (figure is Sphere sphere 
                        && sphere.R == parsed)
                    {
                        listBox1.Items.Add(figure);
                    }
                    else if (figure is Pyramid pyramid
                        && (pyramid.S == parsed || pyramid.H == parsed))
                    {
                        listBox1.Items.Add(figure);
                    }
                    else if (figure is Parallelepiped parallelepiped 
                        && (parallelepiped.A == parsed || parallelepiped.B == parsed || parallelepiped.C == parsed))
                    {
                        listBox1.Items.Add(figure);
                    }
                }

            }
        }
    }
}
