using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace UI
{
    public partial class MainForm : Form
    {
        private List<IFigure> figures = new List<IFigure>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var form = new AddForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        IFigure figure = null;

                        if (form.comboBox1.SelectedIndex == 0)
                        {
                            figure = new Sphere(double.Parse(form.txtParam1.Text));
                        }
                        else if (form.comboBox1.SelectedIndex == 1)
                        {
                            figure = new Pyramid(double.Parse(form.txtParam1.Text), double.Parse(form.txtParam2.Text));
                        }
                        else if (form.comboBox1.SelectedIndex == 2)
                        {
                            figure = new Parallelepiped(double.Parse(form.txtParam1.Text), double.Parse(form.txtParam2.Text), double.Parse(form.txtParam3.Text));
                        }

                        figures.Add(figure);
                        listBox1.Items.Add(figure);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            figures.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
        
        private static BinaryFormatter formatter = new BinaryFormatter();
        
        private void button4_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                {
                    // сериализуем весь массив people
                    formatter.Serialize(fs, figures);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate))
                {
                    figures = (List<IFigure>)formatter.Deserialize(fs);

                    listBox1.Items.Clear();
                    foreach (var figure in figures)
                    {
                        listBox1.Items.Add(figure);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var form = new FindForm(figures))
            {
                form.ShowDialog();
            }
        }
    }
}
