using Google.Protobuf;
using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtoTest
{
    public partial class UserInput : Form
    {
        private User user;

        public User User
        {
            get { return user; }
            set {
                user = value;
                textBoxName.Text = value.Name;
                textBoxSurname.Text = value.Surname;
                textBoxAge.Text = value.Age.ToString();
                textBoxEmail.Text = value.Email;
             }
        }

        public enum FormType { Create, Update }

        public UserInput(FormType formType)
        {
            InitializeComponent();
            if (formType == FormType.Create)
            {
                Text = "Создание нового пользователя";
            }    
            else
            {
                Text = "Обновление данных пользователей";
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            user = new User
            {
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                Age = Convert.ToInt32(textBoxAge.Text),
                Email = textBoxEmail.Text
            };
            DialogResult = DialogResult.OK;
        }

        private void SwitchButton()
        {
            if (textBoxName.TextLength != 0 && textBoxSurname.TextLength != 0 && textBoxAge.TextLength != 0 && textBoxEmail.TextLength != 0)
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            SwitchButton();
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            SwitchButton();
        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            SwitchButton();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            SwitchButton();
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
