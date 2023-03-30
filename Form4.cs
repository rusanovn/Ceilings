﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Событие загрузки формы
        private void Form4_Load(object sender, EventArgs e)
        {
            // Создание экземпляра подключения к БД
            CeilingsDBEntities db = new CeilingsDBEntities();
            // Присваивание данных из таблицы БД в список
            List<Seller> list = db.Sellers.ToList();

            // Вывод данных из списка через цикл в поле для вывода
            foreach (Seller item in list)
            {
                String data1 = item.Id.ToString();
                String data2 = item.company.ToString();
                String data3 = item.fio.ToString();
                String data4 = item.telephone.ToString();
                String data5 = item.email.ToString();
                String data6 = item.products.ToString();
                String data7 = item.price.ToString();
                textBox1.Text += $"{data1} / {data2} / {data3} / {data4} / {data5} / {data6} / {data7}";
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
            Seller seller = new Seller
            {
                Id = Int32.Parse(textBox2.Text),
                company = textBox3.Text,
                fio = textBox4.Text,
                telephone = textBox5.Text,
                email = textBox6.Text,
                products = textBox7.Text,
                price = Int32.Parse(textBox8.Text)
            };

            // Добавление в таблицу БД новых данных списка
            db.Sellers.Add(seller);
            // Сохранение изменений в БД
            db.SaveChanges();

            // Присваивание данных из таблицы БД в список
            List<Seller> list = db.Sellers.ToList();

            // Вывод данных из списка через цикл в поле для вывода
            foreach (Seller item in list)
            {
                String data1 = item.Id.ToString();
                String data2 = item.company.ToString();
                String data3 = item.fio.ToString();
                String data4 = item.telephone.ToString();
                String data5 = item.email.ToString();
                String data6 = item.products.ToString();
                String data7 = item.price.ToString();
                textBox1.Text += $"{data1} / {data2} / {data3} / {data4} / {data5} / {data6} / {data7}";
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
            Seller seller = db.Sellers
            .Where(o => o.Id == Id)
            .FirstOrDefault();

            // Удаление записи из таблицы БД
            db.Sellers.Remove(seller);
            // Сохранение изменений в БД
            db.SaveChanges();

            // Присваивание данных из таблицы БД в список
            List<Seller> list = db.Sellers.ToList();

            // Вывод данных из списка через цикл в поле для вывода
            foreach (Seller item in list)
            {
                String data1 = item.Id.ToString();
                String data2 = item.company.ToString();
                String data3 = item.fio.ToString();
                String data4 = item.telephone.ToString();
                String data5 = item.email.ToString();
                String data6 = item.products.ToString();
                String data7 = item.price.ToString();
                textBox1.Text += $"{data1} / {data2} / {data3} / {data4} / {data5} / {data6} / {data7}";
                textBox1.Text += Environment.NewLine;
                textBox1.Text += Environment.NewLine;
            }
        }
    }
}
