using HotelCRM.Models;
using HotelCRM.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;


namespace HotelCRM.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!CurrentUserSession.IsLoggedIn)
            {
                MessageBox.Show("Сессия истекла.");
                Application.Restart();
            }

            toolStripStatusLabelUser.Text = $"Пользователь: {CurrentUserSession.LoggedInUser.Username}";
            toolStripStatusLabelRole.Text = $"Роль: {CurrentUserSession.LoggedInUser.Role}";

            SetupMenuVisibility();
        }

        private void SetupMenuVisibility()
        {
            tariffsMenuItem.Visible = CurrentUserSession.IsAdmin;
            employeesMenuItem.Visible = CurrentUserSession.IsAdmin;
        }

        private void OpenForm(Form form)
        {
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
        }

        private void guestsToolStripMenuItem_Click(object sender, EventArgs e) => OpenForm(new GuestsForm());
        private void roomsToolStripMenuItem_Click(object sender, EventArgs e) => OpenForm(new RoomsForm());
        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e) => OpenForm(new BookingsForm());
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e) => OpenForm(new ReportsForm());

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentUserSession.ClearCurrentUser();
            this.Hide();
            new LoginForm().ShowDialog();
            if (CurrentUserSession.IsLoggedIn)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
