using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RGR
{
    public partial class ManagerApplication : Form
    {
        public ManagerApplication()
        {
            InitializeComponent();
            
            // Возвраты
            try
            {
                SqlDataReader reader3 = Server.DB_calls.showReturnManager();

                listView1.Items.Clear();

                while (reader3.Read())
                {
                    int applicationCode = reader3.GetInt32(0);
                    //string status = reader.GetString(1);
                    string status = reader3.IsDBNull(1) ? "Ожидание возврата" : reader3.GetString(1);
                    DateTime dateTime = new DateTime();
                    DateTime returnDate = reader3.IsDBNull(2) ? dateTime : reader3.GetDateTime(2);

                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(applicationCode),
                        Convert.ToString(status),
                        Convert.ToString(returnDate)
                    });

                    listView1.Items.Add(item);
                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                MessageBox.Show("Ошибка. Нет данных");
            }

            // Счета
            try
            {
                SqlDataReader reader2 = Server.DB_calls.showProfitManager();

                listView2.Items.Clear();

                while (reader2.Read())
                {
                    int applicationCode = reader2.GetInt32(0);
                    decimal payment = reader2.IsDBNull(1) ? 0 : reader2.GetDecimal(1);
                    decimal surcharge = reader2.IsDBNull(2) ? 0 : reader2.GetDecimal(2);
                    decimal repair = reader2.IsDBNull(3) ? 0 : reader2.GetDecimal(3);
                    decimal pay = payment + surcharge + repair;

                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(applicationCode),
                        Convert.ToString(pay),
                        Convert.ToString(payment),
                        Convert.ToString(surcharge),
                        Convert.ToString(repair)
                    });

                    listView2.Items.Add(item);

                    try
                    {
                        comboBox3.Items.Add(applicationCode);
                    }
                    catch
                    {
                        MessageBox.Show("Укажите код заявки");
                    }

                }
                listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                MessageBox.Show("Ошибка. Нет данных");
            }

            // Заявки
            try
            {
                SqlDataReader reader = Server.DB_calls.application_Manager();

                listView3.Items.Clear();

                while (reader.Read())
                {
                    int applicationCode = reader.GetInt32(0);
                    string model = reader.GetString(1);
                    string color = reader.GetString(2);
                    DateTime startD = reader.GetDateTime(3);
                    DateTime endD = reader.GetDateTime(4);
                    int clientID = reader.GetInt32(5);
                    string autoID = reader.GetString(6);
                    string status = reader.GetString(7);

                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(applicationCode),
                        Convert.ToString(model),
                        Convert.ToString(color),
                        Convert.ToString(startD),
                        Convert.ToString(endD),
                        Convert.ToString(clientID),
                        Convert.ToString(autoID),
                        Convert.ToString(status)

                    });

                    listView3.Items.Add(item);

                    try
                    {
                        comboBox1.Items.Add(applicationCode);
                    }
                    catch
                    {
                        MessageBox.Show("Укажите код заявки");
                    }
                }
                listView3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                MessageBox.Show("Ошибка. Нет данных");
            }

            // comboBox
            comboBox2.Items.Add("Выполнена");
            comboBox2.Items.Add("Принята");
            comboBox2.Items.Add("На рассмотрение");
            comboBox2.Items.Add("Отменена");
        }

        private void главнаяСтраницаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerForm manager = new ManagerForm();
            Hide();
            manager.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autorisation autorisation = new Autorisation();
            Close();
            autorisation.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Server.DB_calls.appUpdate(Convert.ToString(comboBox1.SelectedItem), Convert.ToString(comboBox2.SelectedItem)));

                if (Convert.ToString(comboBox2.SelectedItem) == "Принята")
                {
                    MessageBox.Show(Server.DB_calls.chequeUpdate(Convert.ToString(comboBox1.SelectedItem)));
                }
            }
            catch
            {
                MessageBox.Show("Ошибка. Проверьте все ли окна заполнены");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Server.DB_calls.dateReturnUpdate(Convert.ToString(comboBox3.SelectedItem), textBox1.Text));
            }
            catch
            {
                MessageBox.Show("Ошибка. Проверьте все ли окна заполнены");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Server.DB_calls.dateChequeUpdate(Convert.ToString(comboBox3.SelectedItem), textBox2.Text));
                MessageBox.Show(Server.DB_calls.dateChequeUpdate(Convert.ToString(comboBox3.SelectedItem), textBox3.Text));
            }
            catch
            {
                MessageBox.Show("Ошибка. Проверьте все ли окна заполнены");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString().ToString();
        }
    }
}
