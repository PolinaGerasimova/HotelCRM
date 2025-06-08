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
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private async void EmployeesForm_Load(object sender, EventArgs e)
        {
            await LoadEmployeesAsync();
        }

        private async Task LoadEmployeesAsync(string searchTerm = null)
        {
            try
            {
                using (var context = new HotelContext())
                {
                    var query = context.Employees.AsQueryable();

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query = query.Where(e => e.FirstName.Contains(searchTerm) ||
                                                 e.LastName.Contains(searchTerm) ||
                                                 e.Role.Contains(searchTerm));
                    }

                    var employees = await query.ToListAsync();
                    dataGridViewEmployees.DataSource = employees;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки сотрудников: " + ex.Message);
            }
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadEmployeesAsync(textBoxSearch.Text.Trim());
        }

        private async void buttonSearchEmployee_Click(object sender, EventArgs e)
        {
            await LoadEmployeesAsync(textBoxSearch.Text.Trim());
        }

        private async void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLastName.Text) || string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                MessageBox.Show("Фамилия и Имя обязательны.");
                return;
            }

            var employee = new Employee
            {
                FirstName = textBoxFirstName.Text.Trim(),
                LastName = textBoxLastName.Text.Trim(),
                MiddleName = textBoxMiddleName.Text.Trim(),
                Role = textBoxRole.Text.Trim(),
                PhoneNumber = textBoxPhone.Text.Trim(),
                EmploymentDate = dateTimePickerHire.Value.Date,
                WorkSchedule = textBoxWorkSchedule.Text.Trim()
            };

            try
            {
                using (var context = new HotelContext())
                {
                    context.Employees.Add(employee);
                    await context.SaveChangesAsync();
                    await LoadEmployeesAsync();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления сотрудника: " + ex.Message);
            }
        }

        private async void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для обновления.");
                return;
            }

            var selectedRow = dataGridViewEmployees.SelectedRows[0];
            var employeeToUpdate = selectedRow.DataBoundItem as Employee;

            if (employeeToUpdate == null)
            {
                MessageBox.Show("Не удалось получить данные сотрудника.");
                return;
            }

            employeeToUpdate.FirstName = textBoxFirstName.Text.Trim();
            employeeToUpdate.LastName = textBoxLastName.Text.Trim();
            employeeToUpdate.MiddleName = textBoxMiddleName.Text.Trim();
            employeeToUpdate.Role = textBoxRole.Text.Trim();
            employeeToUpdate.PhoneNumber = textBoxPhone.Text.Trim();
            employeeToUpdate.WorkSchedule = textBoxWorkSchedule.Text.Trim();
            employeeToUpdate.EmploymentDate = dateTimePickerHire.Value.Date;

            try
            {
                using (var context = new HotelContext())
                {
                    context.Employees.Update(employeeToUpdate);
                    await context.SaveChangesAsync();
                    await LoadEmployeesAsync();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления сотрудника: " + ex.Message);
            }
        }

        private async void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для удаления.");
                return;
            }

            var selectedRow = dataGridViewEmployees.SelectedRows[0];
            var employeeToDelete = selectedRow.DataBoundItem as Employee;

            if (MessageBox.Show("Вы уверены, что хотите удалить этого сотрудника?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (var context = new HotelContext())
                    {
                        context.Employees.Remove(employeeToDelete);
                        await context.SaveChangesAsync();
                        await LoadEmployeesAsync();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления сотрудника: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxMiddleName.Clear();
            textBoxRole.Clear();
            textBoxPhone.Clear();
            textBoxWorkSchedule.Clear();
            dateTimePickerHire.Value = DateTime.Now;
            dataGridViewEmployees.ClearSelection();
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewEmployees.Rows.Count - 1)
            {
                var row = dataGridViewEmployees.Rows[e.RowIndex];
                var selectedEmployee = row.DataBoundItem as Employee;
                if (selectedEmployee != null)
                {
                    textBoxFirstName.Text = selectedEmployee.FirstName;
                    textBoxLastName.Text = selectedEmployee.LastName;
                    textBoxMiddleName.Text = selectedEmployee.MiddleName;
                    textBoxRole.Text = selectedEmployee.Role;
                    textBoxPhone.Text = selectedEmployee.PhoneNumber;
                    textBoxWorkSchedule.Text = selectedEmployee.WorkSchedule;
                    dateTimePickerHire.Value = selectedEmployee.EmploymentDate;
                }
            }
        }

        private void labelSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
