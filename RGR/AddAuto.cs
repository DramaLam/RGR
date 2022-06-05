using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR
{
    public partial class AddAuto : Form
    {
        public AddAuto()
        {
            InitializeComponent();

            TextBoxWatermarkExtensionMethod.SetWatermark(textBox1, "Регистрационный номер");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox2, "Модель");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox3, "Марка");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox4, "Цвет");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox5, "Состояние");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox6, "Мощность двигателя");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox7, "Цена проката за 1 день");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerForm manager = new ManagerForm();
            Hide();
            manager.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Server.DB_calls.newAuto(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text));
            }
            catch 
            {
                MessageBox.Show("Ошибка. Не правильно введены данные");
            }
        }
    }
}
