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
    public partial class ClientPersonal : Form
    {
        public ClientPersonal()
        {
            InitializeComponent();

            //Клиент
            try
            {
                SqlDataReader reader1 = Server.DB_calls.clientInfo(Program.aut.textBox1.Text);

                while (reader1.Read())
                {
                    string fio = reader1.GetString(0);
                    DateTime birthday = reader1.GetDateTime(1);
                    string pasSeries = reader1.GetString(2);
                    string pasNumber = reader1.GetString(3);
                    string address = reader1.GetString(4);

                    textBox1.Text = Convert.ToString(fio);
                    textBox2.Text = Convert.ToString(birthday);
                    textBox3.Text = Convert.ToString(pasSeries);
                    textBox4.Text = Convert.ToString(pasNumber);
                    textBox5.Text = Convert.ToString(address);
                    textBox6.Text = Program.aut.textBox1.Text;
                }

            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Попробуйте снова позже");
            }

            //Заявки
            try
            {
                SqlDataReader reader = Server.DB_calls.clientApplication(Program.aut.textBox1.Text);

                listView1.Items.Clear();

                while (reader.Read())
                {
                    string model = reader.GetString(0);
                    string mark = reader.GetString(1);
                    string color = reader.GetString(2);
                    string status = reader.GetString(3);
                    DateTime startD = reader.GetDateTime(4);
                    DateTime endD = reader.GetDateTime(5);
                    DateTime dateTime = new DateTime();
                    DateTime returnD = reader.IsDBNull(6) ? dateTime : reader.GetDateTime(6); 

                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(model),
                        Convert.ToString(mark),
                        Convert.ToString(color),
                        Convert.ToString(status),
                        Convert.ToString(startD),
                        Convert.ToString(endD),
                        Convert.ToString(returnD)
                    });

                    listView1.Items.Add(item);
                }

                
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Попробуйте снова позже");
            }

            //Возвраты и счета
            try
                {
                SqlDataReader reader2 = Server.DB_calls.сlientCheque(Program.aut.textBox1.Text);

                listView2.Items.Clear();

                while (reader2.Read())
                {
                    string model = reader2.GetString(0);
                    string mark = reader2.GetString(1);
                    DateTime startD = reader2.GetDateTime(2);
                    DateTime endD = reader2.GetDateTime(3);
                    DateTime dateTime = new DateTime();
                    DateTime returnD = reader2.IsDBNull(4) ? dateTime : reader2.GetDateTime(4);
                    decimal payment = reader2.IsDBNull(5) ? 0 : reader2.GetDecimal(5);
                    decimal surcharge = reader2.IsDBNull(6) ? 0 : reader2.GetDecimal(6);
                    string state = reader2.IsDBNull(7) ? "Ожидает оценки" : reader2.GetString(7);
                    decimal repair = reader2.IsDBNull(8) ? 0 : reader2.GetDecimal(8);
                    decimal pay = payment + surcharge + repair;

                    ListViewItem item = new ListViewItem(new string[]
                    {
                    Convert.ToString(model),
                    Convert.ToString(mark),
                    Convert.ToString(startD),
                    Convert.ToString(endD),
                    Convert.ToString(returnD),
                    Convert.ToString(payment),
                    Convert.ToString(surcharge),
                    Convert.ToString(state),
                    Convert.ToString(repair),
                    Convert.ToString(pay)
                    });

                    listView2.Items.Add(item);
                }
                listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Попробуйте снова позже");
            }
        }

        private void главнаяСтраницаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm();
            Hide();
            client.Show();
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
            MessageBox.Show("В этом окне представлена информация об оформленных вами заявкам");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В этом окне представлена информация о счетах по формленным вами заявкам");
        }
    }
}
