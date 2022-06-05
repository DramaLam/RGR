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
using static RGR.Program;

namespace RGR
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();

            //Каталог
            try
            {
                SqlDataReader reader = Server.DB_calls.showAutoClient();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    string mark = reader.GetString(0); 
                    string model = reader.GetString(1);
                    double power = reader.GetDouble(2);
                    string color = reader.GetString(3);
                    decimal price = reader.GetDecimal(4);

                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(mark),
                        Convert.ToString(model),
                        Convert.ToString(power),
                        Convert.ToString(color),
                        Convert.ToString(price),
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
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autorisation autorisation = new Autorisation();
            Hide();
            autorisation.Show();
        }

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientPersonal сlientPersonal = new ClientPersonal();
            Hide();
            сlientPersonal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewApplication newApplication = new NewApplication();
            Hide();
            newApplication.Show();
        }
    }

}
