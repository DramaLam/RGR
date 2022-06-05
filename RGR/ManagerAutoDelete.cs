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
    public partial class ManagerAutoDelete : Form
    {
        public ManagerAutoDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerAutoList managerAutoList = new ManagerAutoList();
            Hide();
            managerAutoList.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Server.DB_calls.autoDelete(Convert.ToString(Program.mAuto.comboBox1.SelectedItem)));
        }
    }
}
