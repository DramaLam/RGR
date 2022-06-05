using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR
{
    public partial class NewApplication : Form
    {
        public NewApplication()
        {
            InitializeComponent();

            TextBoxWatermarkExtensionMethod.SetWatermark(textBox3, "Минимальная цена");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox4, "Максимальная цена");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox1, "Выберите в календаре");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox2, "Выберите в календаре");


            MessageBox.Show("1. Выберите в календаре желаемые даты проката, чтобы увидеть список свободных автомобилей. \n 2.Укажите желаемую цену проката за 1 день(не обязательно). \n 3.Нажмите кнопку 'Поиск', чтобы увидеть список свободных автомобилей на выбранные даты. \n 4.Просмотрите список и выберите в окне 'Выбор желаемой модели' модель понравившегося автомобиля. \n 5.Нажмите на кнопку 'Оформить заявку' для оформления заявки. \n\n Вы всегда можете открыт это окно снова воспользовавшись кнопкой 'Помощь' \n\n При наличие вопросов свяжитесь с нашим специалистом по номеру +79113455973 и мы с радостью вам поможем!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            Hide();
            clientForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Выберите в календаре желаемые даты проката, чтобы увидеть список свободных автомобилей. \n 2.Укажите желаемую цену проката за 1 день(не обязательно). \n 3.Нажмите кнопку 'Поиск', чтобы увидеть список свободных автомобилей на выбранные даты. \n 4.Просмотрите список и выберите в окне 'Выбор желаемой модели' модель понравившегося автомобиля. \n 5.Нажмите на кнопку 'Оформить заявку' для оформления заявки. \n\n Вы всегда можете открыт это окно снова воспользовавшись кнопкой 'Помощь' \n\n При наличие вопросов свяжитесь с нашим специалистом по номеру +79113455973 и мы с радостью вам поможем!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if ((Convert.ToDateTime(textBox1.Text) >= DateTime.Now) && (Convert.ToDateTime(textBox2.Text) > DateTime.Now) && (Convert.ToDateTime(textBox1.Text) < Convert.ToDateTime(textBox2.Text)) && ((Convert.ToDateTime(textBox2.Text) - Convert.ToDateTime(textBox1.Text)).Days < 14))
                {
                    if (textBox3.Text == "" && textBox4.Text == "")
                    {
                        try
                        {
                            SqlDataReader reader = Server.DB_calls.availableCars(textBox1.Text, textBox2.Text);

                            listView1.Items.Clear();
                            comboBox1.Items.Clear();

                            while (reader.Read())
                            {
                                string model = reader.GetString(0);
                                string mark = reader.GetString(1);
                                string color = reader.GetString(2);
                                double power = reader.GetDouble(3);
                                decimal price = reader.GetDecimal(4);

                                ListViewItem item = new ListViewItem(new string[]
                                {
                                    Convert.ToString(model),
                                    Convert.ToString(mark),
                                    Convert.ToString(color),
                                    Convert.ToString(power),
                                    Convert.ToString(price)
                                });

                                listView1.Items.Add(item);

                                try
                                {
                                    comboBox1.Items.Add(model);
                                    //this.Controls.Add(this.comboBox1);
                                }
                                catch
                                {
                                    MessageBox.Show("Ошибка данных");
                                }
                            }


                            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        }
                        catch
                        {
                            MessageBox.Show("Произошла ошибка. Попробуйте снова позже");
                        }
                    }
                    else
                    {
                        if (textBox3.Text != "" || textBox4.Text != "")
                        {
                            try
                            {
                                SqlDataReader reader = Server.DB_calls.availableCarsPrice(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

                                listView1.Items.Clear();
                                comboBox1.Items.Clear();

                                while (reader.Read())
                                {
                                    string model = reader.GetString(0);
                                    string mark = reader.GetString(1);
                                    string color = reader.GetString(2);
                                    double power = reader.GetDouble(3);
                                    decimal price = reader.GetDecimal(4);

                                    ListViewItem item = new ListViewItem(new string[]
                                    {
                                    Convert.ToString(model),
                                    Convert.ToString(mark),
                                    Convert.ToString(color),
                                    Convert.ToString(power),
                                    Convert.ToString(price)
                                    });

                                    listView1.Items.Add(item);

                                    try
                                    {
                                        comboBox1.Items.Add(model);
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Укажите модель автомобиля");
                                    }
                                }


                                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                            }
                            catch
                            {
                                if  (textBox4.Text == "" && textBox3.Text != "")
                                {
                                    MessageBox.Show("Введите желательную максимальную стоимость");
                                }
                                else
                                {
                                    if (textBox3.Text == "" && textBox4.Text != "")
                                    {
                                        MessageBox.Show("Введите желательную минимальную стоимость");
                                    }

                                    else
                                    {
                                        MessageBox.Show("Произошла ошибка. Попробуйте снова позже");
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("В качестве даты проката можно выбрать завтрашний день или последующие \n Дата конца проката обязательная должна быть больше даты начала проката! \n \n Автомобиль может быть арендован на срок не больше 14 дней");
                }
            }
            else
            {
                MessageBox.Show("Укажите желаемые даты проката!");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString().ToString();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox2.Text = monthCalendar2.SelectionStart.ToShortDateString().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Server.DB_calls.applicationAdd(Convert.ToString(comboBox1.SelectedItem), textBox1.Text, textBox2.Text, Program.aut.textBox1.Text));
                Server.DB_calls.returnAdd();
                Server.DB_calls.chequeAdd(); 

                ClientForm clientForm = new ClientForm();
                Hide();
                clientForm.Show();
            }
            catch
            {
                MessageBox.Show("Ошибка данных");
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
