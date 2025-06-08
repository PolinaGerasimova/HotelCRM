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
    public partial class CleaningForm : Form
    {
        public CleaningForm()
        {
            InitializeComponent();
        }

        private void CleaningForm_Load(object sender, EventArgs e)
        {
            LoadCleaningTasksAsync();
        }

        private async Task LoadCleaningTasksAsync(string searchTerm = null)
        {
            try
            {
                using (var context = new HotelContext())
                {
                    var tasks = await context.CleaningTasks.ToListAsync();
                    dataGridViewTasks.DataSource = tasks;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки задач уборки: " + ex.Message);
            }
        }

        private async void buttonCreateTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxRoomID.Text) ||
                string.IsNullOrWhiteSpace(textBoxArea.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmployeeID.Text))
            {
                MessageBox.Show("Введите все обязательные поля: Room ID, Area Name, Employee ID");
                return;
            }

            if (!int.TryParse(textBoxRoomID.Text, out int roomID))
            {
                MessageBox.Show("Неверный формат Room ID.");
                return;
            }

            if (!int.TryParse(textBoxEmployeeID.Text, out int employeeID))
            {
                MessageBox.Show("Неверный формат Employee ID.");
                return;
            }

            var task = new CleaningTask
            {
                RoomID = roomID,
                AreaName = textBoxArea.Text.Trim(),
                EmployeeID = employeeID,
                ScheduledDate = dateTimePickerDate.Value.Date,
                TaskType = comboBoxTaskType.SelectedItem?.ToString() ?? "Daily",
                Description = textBoxDescription.Text.Trim(),
                Status = "Scheduled"
            };

            try
            {
                using (var context = new HotelContext())
                {
                    context.CleaningTasks.Add(task);
                    await context.SaveChangesAsync();
                    await LoadCleaningTasksAsync();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления задачи уборки: " + ex.Message);
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
            var taskToComplete = selectedRow.DataBoundItem as CleaningTask;

            if (taskToComplete == null)
            {
                MessageBox.Show("Не удалось получить данные задачи.");
                return;
            }

            taskToComplete.Status = "Completed";
            taskToComplete.CompletionDate = DateTime.Now;

            try
            {
                using (var context = new HotelContext())
                {
                    context.CleaningTasks.Update(taskToComplete);
                    await context.SaveChangesAsync();
                    await LoadCleaningTasksAsync();
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
            textBoxArea.Clear();
            textBoxEmployeeID.Clear();
            comboBoxTaskType.SelectedIndex = 0;
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
                var selectedTask = row.DataBoundItem as CleaningTask;
                if (selectedTask != null)
                {
                    textBoxRoomID.Text = selectedTask.RoomID.ToString();
                    textBoxArea.Text = selectedTask.AreaName;
                    textBoxEmployeeID.Text = selectedTask.EmployeeID?.ToString() ?? string.Empty;
                    comboBoxTaskType.SelectedItem = selectedTask.TaskType;
                    textBoxDescription.Text = selectedTask.Description;
                    dateTimePickerDate.Value = selectedTask.ScheduledDate;
                }
            }
        }
    }
}
