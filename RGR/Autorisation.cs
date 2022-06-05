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
using System.Runtime.InteropServices;
using static RGR.Program;

namespace RGR
{
    public partial class Autorisation : Form
    {
        public Autorisation()
        {
            Program.aut = this;

            InitializeComponent();

            TextBoxWatermarkExtensionMethod.SetWatermark(textBox1, "Телефон");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox2, "Пароль");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            Hide();
            addClient.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox1.Text == "0000" && textBox2.Text == "root")
                {
                    ManagerForm manager = new ManagerForm();
                    Hide();
                    manager.Show();
                }
                else
                {
                    SqlDataReader reader = Server.DB_calls.searchClient(textBox1.Text, textBox2.Text);
                    while (reader.Read())
                    {
                        int ID = reader.GetInt32(0);
                        textBox3.Text = Convert.ToString(ID);
                    }

                    if (textBox3.Text == "")
                    {
                        MessageBox.Show("Неправильные логин или пароль. \nЕсли вы забыли пароль, можете обратиться к нашему менеджеру по телефону +79113455973\n\n\nВы у нас впервые? \nТогда зарегистрируйтесь с помощью кнопки 'Регистрация' ");
                    }
                    else
                    {
                        ClientForm clientForm = new ClientForm();
                        Hide();
                        clientForm.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы ввели не все данные");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public static class TextBoxWatermarkExtensionMethod
    {
        private const uint ECM_FIRST = 0x1500;
        private const uint EM_SETCUEBANNER = ECM_FIRST + 1;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public static void SetWatermark(this TextBox textBox, string watermarkText)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, watermarkText);
        }

    }

}
