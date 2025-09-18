using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr1_3
{
    public partial class Form1 : Form
    {
        private BindingList<stra> policies = new BindingList<stra>();
        private string filePath = "policies.txt";
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns["Type"].DataPropertyName = "Type";
            dataGridView1.Columns["Number"].DataPropertyName = "Number";
            dataGridView1.Columns["SName"].DataPropertyName = "Name";
            dataGridView1.Columns["FDate"].DataPropertyName = "FDate";
            dataGridView1.Columns["LDate"].DataPropertyName = "LDate";
            dataGridView1.Columns["Price"].DataPropertyName = "Price";

            dataGridView1.DataSource = policies;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["FDate"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dataGridView1.Columns["LDate"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dataGridView1.Columns["Price"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void записатиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void додатиЗаписToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) ||
        string.IsNullOrWhiteSpace(textnum.Text) ||
        string.IsNullOrWhiteSpace(comboBox2.Text) ||
        string.IsNullOrWhiteSpace(textfirst.Text) ||
        string.IsNullOrWhiteSpace(textlast.Text) ||
        string.IsNullOrWhiteSpace(textprice.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!");
                return;
            }

            if (!DateTime.TryParse(textfirst.Text, out DateTime FDate))
            {
                MessageBox.Show("Невірний формат дати видачі!");
                return;
            }
            if (!DateTime.TryParse(textlast.Text, out DateTime LDate))
            {
                MessageBox.Show("Невірний формат дати закінчення!");
                return;
            }
            if (LDate <= FDate)
            {
                MessageBox.Show("Дата закінчення не може бути раніше або дорівнювати даті видачі!");
                textlast.Focus();
                return;
            }

            if (!decimal.TryParse(textprice.Text, out decimal price))
            {
                MessageBox.Show("Ціна має бути числом!");
                return;
            }

            stra policy = new stra(comboBox1.Text, textnum.Text, comboBox2.Text, FDate, LDate, price);
            policies.Add(policy);

            comboBox1.SelectedIndex = -1;
            textnum.Clear();
            comboBox2.SelectedIndex = -1;
            textfirst.Clear();
            textlast.Clear();
            textprice.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void зберегтиУФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    foreach (stra policy in policies)
                    {
                        writer.WriteLine($"{policy.Type}|{policy.Number}|{policy.Name}|{policy.FDate:dd.MM.yyyy}|{policy.LDate:dd.MM.yyyy}|{policy.Price}");
                    }
                }
                MessageBox.Show("Дані успішно збережено у файл!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void вивестиЗФайлуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Файл не знайдено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                policies.Clear();

                using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 6)
                        {
                            DateTime fDate, lDate;
                            decimal price;

                            if (DateTime.TryParse(parts[3], out fDate) &&
                                DateTime.TryParse(parts[4], out lDate) &&
                                decimal.TryParse(parts[5], out price))
                            {
                                stra policy = new stra(
                                    parts[0], // тип
                                    parts[1], // номер
                                    parts[2], // піб
                                    fDate,    
                                    lDate,    
                                    price     
                                );
                                policies.Add(policy);
                            }
                        }
                    }
                }
                MessageBox.Show("Дані успішно завантажено з файлу!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при читанні файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void вивестиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void аЯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<stra> sortedList = policies.OrderBy(p => p.Type).ToList();
            policies.Clear();
            foreach (stra item in sortedList)
            {
                policies.Add(item);
            }
        }

        private void яАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<stra> sortedList = policies.OrderByDescending(p => p.Type).ToList();
            policies.Clear();
            foreach (stra item in sortedList)
            {
                policies.Add(item);
            }
        }

        private void мінМаксToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<stra> sortedList = policies.OrderBy(p => p.Price).ToList();
            policies.Clear();
            foreach (stra item in sortedList)
            {
                policies.Add(item);
            }
        }

        private void максМінToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<stra> sortedList = policies.OrderByDescending(p => p.Price).ToList();
            policies.Clear();
            foreach (stra item in sortedList)
            {
                policies.Add(item);
            }
        }

        private void очиститиТаблицюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            policies.Clear();
        }
    }
}
