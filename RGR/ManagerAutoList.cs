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
    public partial class ManagerAutoList : Form
    {
        public ManagerAutoList()
        {
            Program.mAuto = this;

            InitializeComponent();

            try
            {
                SqlDataReader reader = Server.DB_calls.showAutoManager();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    string reg = reader.GetString(0);
                    string model = reader.GetString(1);
                    string mark = reader.GetString(2);
                    string color = reader.GetString(3);
                    string status = reader.GetString(4);
                    double power = reader.GetDouble(5);
                    decimal price = reader.GetDecimal(6);

                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(reg),
                        Convert.ToString(model),
                        Convert.ToString(mark),
                        Convert.ToString(color),
                        Convert.ToString(status),
                        Convert.ToString(power),
                        Convert.ToString(price)
                    });

                    listView1.Items.Add(item);


                    try
                    {
                        comboBox1.Items.Add(reg);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка чтения данных номера");
                    }
                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                MessageBox.Show("Ошибка. Нет данных");
            }
        }

        private void AutoList_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autorisation autorisation = new Autorisation();
            Close();
            autorisation.Show();
        }

        private void главнаяСтраницаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerForm manager = new ManagerForm();
            Hide();
            manager.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerAutoList autoList = new ManagerAutoList();
            Close();
            autoList.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Server.DB_calls.autoUpdatePrice(Convert.ToString(comboBox1.SelectedItem), textBox2.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Server.DB_calls.autoUpdateStatus(Convert.ToString(comboBox1.SelectedItem), textBox1.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManagerAutoDelete manager = new ManagerAutoDelete();
            //Hide();
            manager.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для изменение информации автомобиля сначала выберите регистрационный номер автомоибля, а затем введите изменяемые значения в нужное поле. Для завершения операции нажмите под полем кнопку 'Подтвердить' \n Для удаления автомобиля выберите его регистрационный номер и нажмите на кнопку 'Удалить'");
        }
    }
}
