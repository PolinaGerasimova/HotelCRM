using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using HotelCRM.Forms;
using HotelCRM.Helpers;
using Microsoft.EntityFrameworkCore;


namespace HotelCRM
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("������� ��� ������������ � ������.");
                return;
            }

            try
            {
                using (var context = new HotelContext())
                {
                    var user = await context.Users.FirstOrDefaultAsync(u => u.Username == username && u.IsActive);
                    if (user == null)
                    {
                        MessageBox.Show("������������ �� ������ ��� ������� ������ ��������������.");
                        return;
                    }

                    if (PasswordHasher.VerifyPassword(password, user.PasswordHash))
                    {
                        CurrentUserSession.SetCurrentUser(user);
                        this.Hide();
                        new MainForm().ShowDialog();
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("�������� ����� ��� ������.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������: " + ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
