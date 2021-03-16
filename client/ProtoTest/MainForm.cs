using Google.Protobuf;
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
using System.Configuration;

namespace ProtoTest
{
    public partial class MainForm : Form
    {
        BindingSource usersBindingSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
            LoadAllUsers();
        }

        void LoadAllUsers()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["requestUriString"]);
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                ListUsers users = ListUsers.Parser.ParseFrom(response.GetResponseStream());

                usersBindingSource.DataSource = users;
                usersBindingSource.DataMember = "users";
                dataGridView.DataSource = usersBindingSource;
                dataGridView.Columns[0].Visible = false;
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            UserInput userInput = new UserInput(UserInput.FormType.Create);
            if (userInput.ShowDialog() == DialogResult.OK)
            {
                User user = userInput.User;
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["requestUriString"]);
                    request.Method = "POST";
                    request.ContentType = "application/x-protobuf;charset=UTF-8";
                    using (Stream stream = request.GetRequestStream())
                    {
                        user.WriteTo(stream);
                    }
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    user = User.Parser.ParseFrom(response.GetResponseStream());
                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                usersBindingSource.Add(user);
            }
        }

        private void dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Удалить выбранного пользователя?", "DELETE", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["requestUriString"] + ((User)usersBindingSource.Current).Id);
                    request.Method = "DELETE";
                    request.GetResponse();
                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UserInput userInput = new UserInput(UserInput.FormType.Update);
            userInput.User = (User)usersBindingSource.Current;
            if (userInput.ShowDialog() == DialogResult.OK)
            {
                User user = userInput.User;
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["requestUriString"] + ((User)usersBindingSource.Current).Id);
                    request.Method = "PUT";
                    request.ContentType = "application/x-protobuf;charset=UTF-8";
                    using (Stream stream = request.GetRequestStream())
                    {
                        user.WriteTo(stream);
                    }
                    request.GetResponse();
                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                ((User)usersBindingSource.Current).Name = user.Name;
                ((User)usersBindingSource.Current).Surname = user.Surname;
                ((User)usersBindingSource.Current).Age = user.Age;
                ((User)usersBindingSource.Current).Email = user.Email;
            }
        }
    }
}