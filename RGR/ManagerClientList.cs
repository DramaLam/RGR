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
    public partial class ManagerClientList : Form
    {
        public ManagerClientList()
        {
            InitializeComponent();

            try
            {
                SqlDataReader reader = Server.DB_calls.showClientManager();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    int reg = reader.GetInt32(0);
                    string fio = reader.GetString(1);
                    DateTime birthday = reader.GetDateTime(2);
                    string pasSeries = reader.GetString(3);
                    string pasNumber = reader.GetString(4);
                    string address = reader.GetString(5);
                    string phone = reader.GetString(6);
                    DateTime regDate = reader.GetDateTime(7);

                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(reg),
                        Convert.ToString(fio),
                        Convert.ToString(birthday),
                        Convert.ToString(pasSeries),
                        Convert.ToString(pasNumber),
                        Convert.ToString(address),
                        Convert.ToString(phone),
                        Convert.ToString(regDate)
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
    }
}
