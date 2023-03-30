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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Событие загрузки формы
        private void Form2_Load(object sender, EventArgs e)
        {
            // Создание экземпляра подключения к БД
            CeilingsDBEntities db = new CeilingsDBEntities();
            // Присваивание данных из таблицы БД в список
            List<Client> list = db.Clients.ToList();

            // Вывод данных из списка через цикл в поле для вывода
            foreach (Client item in list)
            {
                String data1 = item.Id.ToString();
                String data2 = item.category.ToString();
                String data3 = item.fio.ToString();
                String data4 = item.company.ToString();
                String data5 = item.telephone.ToString();
                String data6 = item.email.ToString();
                String data7 = item.service.ToString();
                String data8 = item.date.ToString();
                String data9 = item.price.ToString();
                textBox1.Text += $"{data1} / {data2} / {data3} / {data4} / {data5} / {data6} / {data7} / {data8} / {data9}";
                textBox1.Text += Environment.NewLine;
                textBox1.Text += Environment.NewLine;
            }
        }

        // Событие клика по кнопке
        private void button1_Click(object sender, EventArgs e)
        {
            // Создание экземпляра подключения к БД
            CeilingsDBEntities db = new CeilingsDBEntities();

            // Создание новой записи списка
            Client client = new Client
            {
                Id = Int32.Parse(textBox2.Text),
                category = textBox3.Text,
                fio = textBox4.Text,
                company = textBox5.Text,
                telephone = textBox6.Text,
                email = textBox7.Text,
                service = textBox8.Text,
                date = textBox9.Text,
                price = Int32.Parse(textBox10.Text)
            };

            // Добавление в таблицу БД новых данных списка
            db.Clients.Add(client);
            // Сохранение изменений в БД
            db.SaveChanges();

            // Присваивание данных из таблицы БД в список
            List<Client> list = db.Clients.ToList();

            // Вывод данных из списка через цикл в поле для вывода
            foreach (Client item in list)
            {
                String data1 = item.Id.ToString();
                String data2 = item.category.ToString();
                String data3 = item.fio.ToString();
                String data4 = item.company.ToString();
                String data5 = item.telephone.ToString();
                String data6 = item.email.ToString();
                String data7 = item.service.ToString();
                String data8 = item.date.ToString();
                String data9 = item.price.ToString();
                textBox1.Text += $"{data1} / {data2} / {data3} / {data4} / {data5} / {data6} / {data7} / {data8} / {data9}";
                textBox1.Text += Environment.NewLine;
                textBox1.Text += Environment.NewLine;
            }
        }

        // Событие клика по кнопке
        private void button2_Click(object sender, EventArgs e)
        {
            // Создание экземпляра подключения к БД
            CeilingsDBEntities db = new CeilingsDBEntities();

            int Id = Int32.Parse(textBox2.Text);

            // Выбор записи с указанным Id
            Client client = db.Clients
            .Where(o => o.Id == Id)
            .FirstOrDefault();

            // Удаление записи из таблицы БД
            db.Clients.Remove(client);
            // Сохранение изменений в БД
            db.SaveChanges();

            // Присваивание данных из таблицы БД в список
            List<Client> list = db.Clients.ToList();

            // Вывод данных из списка через цикл в поле для вывода
            foreach (Client item in list)
            {
                String data1 = item.Id.ToString();
                String data2 = item.category.ToString();
                String data3 = item.fio.ToString();
                String data4 = item.company.ToString();
                String data5 = item.telephone.ToString();
                String data6 = item.email.ToString();
                String data7 = item.service.ToString();
                String data8 = item.date.ToString();
                String data9 = item.price.ToString();
                textBox1.Text += $"{data1} / {data2} / {data3} / {data4} / {data5} / {data6} / {data7} / {data8} / {data9}";
                textBox1.Text += Environment.NewLine;
                textBox1.Text += Environment.NewLine;
            }
        }
    }
}
