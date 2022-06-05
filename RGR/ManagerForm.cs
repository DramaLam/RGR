using System;
using System.Linq;
using System.Data.SqlClient;


namespace RGR
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();

            try
            {
                SqlDataReader reader2 = Server.DB_calls.showClientsOfYear();

                listView1.Items.Clear();

                while (reader2.Read())
                {

                    int reg = reader2.GetInt32(0);
                    string fio = reader2.GetString(1);
                    DateTime regDate = reader2.GetDateTime(2);


                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(reg),
                        Convert.ToString(fio),
                        Convert.ToString(regDate)
                    });

                    listView1.Items.Add(item);
                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                MessageBox.Show("Îøèáêà. Íåò äàííûõ");
            }

            try
            {
                SqlDataReader reader = Server.DB_calls.damagedAuto();

                listView2.Items.Clear();

                while (reader.Read())
                {

                    string reg = reader.GetString(0);
                    string model = reader.GetString(1);
                    string mark = reader.GetString(2);
                    string fio = reader.GetString(3);
                    decimal repair = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);


                    ListViewItem item = new ListViewItem(new string[]
                    {
                        Convert.ToString(reg),
                        Convert.ToString(model),
                        Convert.ToString(mark),
                        Convert.ToString(fio),
                        Convert.ToString(repair)
                    });

                    listView2.Items.Add(item);
                }
                listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                MessageBox.Show("Îøèáêà. Íåò äàííûõ");
            }

            // Òàáë.3

            try
            {
                SqlDataReader reader3 = Server.DB_calls.diagram();
                while (reader3.Read())
                {
                    string type = reader3.GetString(0);
                    int count = reader3.GetInt32(1);
                    decimal sum = reader3.IsDBNull(2) ? 0 : reader3.GetDecimal(2);

                    ListViewItem item = new ListViewItem(new string[]
                     {
                        Convert.ToString(type),
                        Convert.ToString(count),
                        Convert.ToString(sum)
                    });
                    listView3.Items.Add(item);
                }
                listView3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            
            catch
            {
                MessageBox.Show("Îøèáêà. Íåò äàííûõ");
            }
        }

        private void ñïèñîêÂñåõÀâòîìîáèëåéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerAutoList autoList = new ManagerAutoList();
            Hide();
            autoList.Show();
        }

        private void ñïèñîêÊëèåíòîâToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerClientList clientList = new ManagerClientList();
            Hide();
            clientList.Show();
        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autorisation autorisation = new Autorisation();
            Close();
            autorisation.Show();
        }

        private void äîáàâèòüÍîâûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAuto addAuto = new AddAuto();
            Hide();
            addAuto.Show();
        }

        private void çàÿâêèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerApplication managerApplication = new ManagerApplication();
            Hide();
            managerApplication.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();

            try
            {
                SqlDataReader reader = Server.DB_calls.IncomePerYear(textBox1.Text);

                //textBox1.Clear();
                textBox2.Clear();

                while (reader.Read())
                {
                    decimal year = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);

                    textBox2.Text = Convert.ToString(year);
                }

            }
            catch
            {

                MessageBox.Show("Ââåäèòå ãîä!!");

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}