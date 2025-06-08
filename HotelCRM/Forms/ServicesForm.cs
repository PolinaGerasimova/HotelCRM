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
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {
            LoadServicesAsync();
        }

        private async Task LoadServicesAsync(string searchTerm = null)
        {
            try
            {
                using (var context = new HotelContext())
                {
                    var query = context.Services.AsQueryable();

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query = query.Where(s => s.ServiceName.Contains(searchTerm) ||
                                                 s.Description.Contains(searchTerm));
                    }

                    var services = await query.ToListAsync();
                    dataGridViewServices.DataSource = services;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки услуг: " + ex.Message);
            }
        }

        private async void buttonAddService_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxServiceName.Text))
            {
                MessageBox.Show("Введите название услуги.");
                return;
            }

            if (numericUpDownPrice.Value <= 0)
            {
                MessageBox.Show("Цена должна быть больше нуля.");
                return;
            }

            var service = new Service
            {
                ServiceName = textBoxServiceName.Text.Trim(),
                Price = numericUpDownPrice.Value,
                Description = textBoxDescription.Text.Trim()
            };

            try
            {
                using (var context = new HotelContext())
                {
                    context.Services.Add(service);
                    await context.SaveChangesAsync();
                    await LoadServicesAsync();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления услуги: " + ex.Message);
            }
        }

        private async void buttonUpdateService_Click(object sender, EventArgs e)
        {
            if (dataGridViewServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите услугу для обновления.");
                return;
            }

            var selectedRow = dataGridViewServices.SelectedRows[0];
            var serviceToUpdate = selectedRow.DataBoundItem as Service;

            if (serviceToUpdate == null)
            {
                MessageBox.Show("Не удалось получить данные о услуге.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxServiceName.Text))
            {
                MessageBox.Show("Введите название услуги.");
                return;
            }

            if (numericUpDownPrice.Value <= 0)
            {
                MessageBox.Show("Цена должна быть больше нуля.");
                return;
            }

            serviceToUpdate.ServiceName = textBoxServiceName.Text.Trim();
            serviceToUpdate.Price = numericUpDownPrice.Value;
            serviceToUpdate.Description = textBoxDescription.Text.Trim();

            try
            {
                using (var context = new HotelContext())
                {
                    context.Services.Update(serviceToUpdate);
                    await context.SaveChangesAsync();
                    await LoadServicesAsync();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления услуги: " + ex.Message);
            }
        }

        private async void buttonDeleteService_Click(object sender, EventArgs e)
        {
            if (dataGridViewServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите услугу для удаления.");
                return;
            }

            var selectedRow = dataGridViewServices.SelectedRows[0];
            var serviceToDelete = selectedRow.DataBoundItem as Service;

            if (MessageBox.Show("Вы уверены, что хотите удалить эту услугу?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (var context = new HotelContext())
                    {
                        context.Services.Remove(serviceToDelete);
                        await context.SaveChangesAsync();
                        await LoadServicesAsync();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления услуги: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            textBoxServiceName.Clear();
            numericUpDownPrice.Value = 0;
            textBoxDescription.Clear();
            dataGridViewServices.ClearSelection();
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridViewServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewServices.Rows.Count - 1)
            {
                var row = dataGridViewServices.Rows[e.RowIndex];
                var service = row.DataBoundItem as Service;

                if (service != null)
                {
                    textBoxServiceName.Text = service.ServiceName;
                    numericUpDownPrice.Value = service.Price;
                    textBoxDescription.Text = service.Description;
                }
            }
        }
    }
}
