using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceilings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Событие клика по кнопке
        private void button1_Click(object sender, EventArgs e)
        {
            // Создание экземпляра новой формы
            Form2 form = new Form2();
            // Отображение новой формы
            form.Show();
        }

        // Событие клика по кнопке
        private void button2_Click(object sender, EventArgs e)
        {
            // Создание экземпляра новой формы
            Form3 form = new Form3();
            // Отображение новой формы
            form.Show();
        }

        // Событие клика по кнопке
        private void button3_Click(object sender, EventArgs e)
        {
            // Создание экземпляра новой формы
            Form4 form = new Form4();
            // Отображение новой формы
            form.Show();
        }
    }
}
