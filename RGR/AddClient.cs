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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();

            TextBoxWatermarkExtensionMethod.SetWatermark(textBox1, "Иванов Иван Иванович");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox2, "20.05.1996");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox3, "1234");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox4, "123456");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox5, "г.Мурманск, ул.Шевченко, д.5, кв.56");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox6, "79021234556");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox7, "neivan66");

            button3.Visible = true;
            button4.Visible = false;
            monthCalendar1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autorisation autorisation = new Autorisation();
            Hide();
            autorisation.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                if (((DateTime.Now.Year - Convert.ToDateTime(textBox2.Text).Year) >= 18) && (textBox6.Text.Length == 11) && (textBox7.Text.Length >= 4))
                {
                    if (checkBox1.Checked)
                    {
                        MessageBox.Show(Server.DB_calls.newClient(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text));

                        Autorisation autorisation = new Autorisation();
                        Hide();
                        autorisation.Show();
                    }
                    else
                    {
                        MessageBox.Show("Вы не подтвердили соглашение на обработку персональных данных!");
                    }
                }

                else
                {
                    MessageBox.Show("Не все поля заполнены верно! \n При возникновение затруднений с заполнением воспользуйтесь кнопкой 'Справка'");
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены! \n При возникновение затруднений с заполнением воспользуйтесь кнопкой 'Справка'");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            monthCalendar1.Show();
            monthCalendar1.BringToFront();
            button3.Visible = false;
            button4.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox2.Text = monthCalendar1.SelectionStart.ToShortDateString().ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            monthCalendar1.Hide();
            button3.Visible = true;
            button4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чтобы создать учетную запись, выполните следующие пункты: \n 1. Заполните свои фамилию, имя и отчество через пробел \n Пример заполнения: Иванов Иван Иванович \n 2. Откройте календарь, воспользовавшись кнопкой рядом с полем, и выберите дату своего рождения \n Пример: 20.05.1996 \n При необходимости вы можете открыть или свернуть календарь той же кнопкой \n 3. В следующих двух полях укажите данные вашего паспорта - серия и номер. Принимаются только паспорта Российской Федерации \n Пример номера: 1234 (первые 4 цифры) \n Пример серии: 123456 (последние 6 цифр) \n 4. Укажите в поле ваш домашний адрес (указанный в паспорте). Через запятую перечислите город, улицу, № дома и № квартиры \n Пример:г.Мурманск, ул.Шевченко, д.5, кв.56 \n 5. Укажите ваш действительный контактный номер мобильного телефона начиная с цифры 7 ('+' в начале номера указывать не нужно)\n Введенный телефон будет использован в качестве логина для входа\n Пример: 79123455678 \n 6. Придумайте пароль для входа в систему \n Для уточнения информации для пароля воспользуйтесь кнопкой, расположенной рядос с полем для ввода пароля\n Пример: neivan66 \n 7. Поставьте галочку, кликнув курсором мышки, в поле возле надписи 'Я соглашаюсь на обработку персональных данных'\n Данным действием вы соглашаетесь на обработку персональных данных в соответствие с законами РФ\n 8. Нажмите на кнопку 'Сохранить', чтобы завершить создание учетной записи \n 9.Нажмите на кнопку 'Назад', чтобы вернуться к окну авторизации \n \n При наличие вопросов свяжитесь с нашим специалистом по номеру +79113455973 и мы с радостью вам поможем!");
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пароль может содержать русские и английские буквы, арабские цифры. Количество символов не должно быть меньше 4 и не больше 8");
        }
    }
}
