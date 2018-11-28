using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItem = null;
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (listBox1.SelectedIndex == 6)
                    label2.Text = "Ура! Сьогодні у нас вихідний, а саме " + listBox1.SelectedItem;
                else
                    label2.Text = "Сьогодні у нас " + listBox1.SelectedItem;
            }
            else
                MessageBox.Show("Елемент не вибраний із списку", "Помилка");

        }
    }
}
