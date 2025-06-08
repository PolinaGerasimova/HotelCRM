using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelCRM.Models;
using HotelCRM.Helpers;
using Microsoft.EntityFrameworkCore;


namespace HotelCRM.Forms
{
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm()
        {
            InitializeComponent();
        }

        private void MaintenanceForm_Load(object sender, EventArgs e)
        {
            LoadMaintenanceTasksAsync();
        }

        private async Task LoadMaintenanceTasksAsync(string searchTerm = null)
        {
            try
            {
                using (var context = new HotelContext())
                {
                    var tasks = await context.RoomMaintenances.ToListAsync();
                    dataGridViewTasks.DataSource = tasks;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки задач техобслуживания: " + ex.Message);
            }
        }

        private async void buttonCreateTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxRoomID.Text))
            {
                MessageBox.Show("Введите ID номера.");
                return;
            }

            if (!int.TryParse(textBoxRoomID.Text, out int roomID))
            {
                MessageBox.Show("Неверный формат RoomID.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {
                MessageBox.Show("Введите описание задачи.");
                return;
            }

            var task = new RoomMaintenance
            {
                RoomID = roomID,
                TaskDescription = textBoxDescription.Text.Trim(),
                ReportedDate = DateTime.Now,
                Status = "Reported"
            };

            try
            {
                using (var context = new HotelContext())
                {
                    context.RoomMaintenances.Add(task);
                    await context.SaveChangesAsync();
                    await LoadMaintenanceTasksAsync();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления задачи: " + ex.Message);
            }
        }

        private async void buttonCompleteTask_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите задачу для завершения.");
                return;
            }

            var selectedRow = dataGridViewTasks.SelectedRows[0];
            var taskToComplete = selectedRow.DataBoundItem as RoomMaintenance;

            if (taskToComplete == null)
            {
                MessageBox.Show("Не удалось получить данные о задаче.");
                return;
            }

            taskToComplete.Status = "Completed";
            taskToComplete.ActualCompletionDate = DateTime.Now;

            try
            {
                using (var context = new HotelContext())
                {
                    context.RoomMaintenances.Update(taskToComplete);
                    await context.SaveChangesAsync();
                    await LoadMaintenanceTasksAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка завершения задачи: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            textBoxRoomID.Clear();
            textBoxDescription.Clear();
            dataGridViewTasks.ClearSelection();
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewTasks.Rows.Count - 1)
            {
                var row = dataGridViewTasks.Rows[e.RowIndex];
                var selectedTask = row.DataBoundItem as RoomMaintenance;
                if (selectedTask != null)
                {
                    textBoxRoomID.Text = selectedTask.RoomID.ToString();
                    textBoxDescription.Text = selectedTask.TaskDescription;
                }
            }
        }
    }
}
