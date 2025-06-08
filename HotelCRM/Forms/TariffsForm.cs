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
    public partial class TariffsForm : Form
    {
        public TariffsForm()
        {
            InitializeComponent();
        }

        private void TariffsForm_Load(object sender, EventArgs e)
        {
            LoadTariffsAsync();
        }

        private async Task LoadTariffsAsync(string searchTerm = null)
        {
            try
            {
                using (var context = new HotelContext())
                {
                    var query = context.Tariffs.AsQueryable();

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query = query.Where(t => t.TariffName.Contains(searchTerm));
                    }

                    var tariffs = await query.ToListAsync();
                    dataGridViewTariffs.DataSource = tariffs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки тарифов: " + ex.Message);
            }
        }

        private async void buttonAddTariff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTariffName.Text))
            {
                MessageBox.Show("Введите название тарифа.");
                return;
            }

            if (numericUpDownDiscount.Value < 0 || numericUpDownDiscount.Value > 100)
            {
                MessageBox.Show("Скидка должна быть в пределах от 0 до 100%");
                return;
            }

            var tariff = new Tariff
            {
                TariffName = textBoxTariffName.Text.Trim(),
                DiscountPercentage = numericUpDownDiscount.Value,
                StartDate = dateTimePickerStart.Value.Date,
                EndDate = dateTimePickerEnd.Value.Date,
                IsActive = checkBoxActive.Checked
            };

            try
            {
                using (var context = new HotelContext())
                {
                    context.Tariffs.Add(tariff);
                    await context.SaveChangesAsync();
                    await LoadTariffsAsync();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления тарифа: " + ex.Message);
            }
        }

        private async void buttonUpdateTariff_Click(object sender, EventArgs e)
        {
            if (dataGridViewTariffs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите тариф для обновления.");
                return;
            }

            var selectedRow = dataGridViewTariffs.SelectedRows[0];
            var tariffToUpdate = selectedRow.DataBoundItem as Tariff;

            if (tariffToUpdate == null)
            {
                MessageBox.Show("Не удалось получить данные о тарифе.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxTariffName.Text))
            {
                MessageBox.Show("Введите название тарифа.");
                return;
            }

            if (numericUpDownDiscount.Value < 0 || numericUpDownDiscount.Value > 100)
            {
                MessageBox.Show("Скидка должна быть в пределах от 0 до 100%");
                return;
            }

            tariffToUpdate.TariffName = textBoxTariffName.Text.Trim();
            tariffToUpdate.DiscountPercentage = numericUpDownDiscount.Value;
            tariffToUpdate.StartDate = dateTimePickerStart.Value.Date;
            tariffToUpdate.EndDate = dateTimePickerEnd.Value.Date;
            tariffToUpdate.IsActive = checkBoxActive.Checked;

            try
            {
                using (var context = new HotelContext())
                {
                    context.Tariffs.Update(tariffToUpdate);
                    await context.SaveChangesAsync();
                    await LoadTariffsAsync();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления тарифа: " + ex.Message);
            }
        }

        private async void buttonDeleteTariff_Click(object sender, EventArgs e)
        {
            if (dataGridViewTariffs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите тариф для удаления.");
                return;
            }

            var selectedRow = dataGridViewTariffs.SelectedRows[0];
            var tariffToDelete = selectedRow.DataBoundItem as Tariff;

            if (MessageBox.Show("Вы уверены, что хотите удалить этот тариф?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (var context = new HotelContext())
                    {
                        context.Tariffs.Remove(tariffToDelete);
                        await context.SaveChangesAsync();
                        await LoadTariffsAsync();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления тарифа: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            textBoxTariffName.Clear();
            numericUpDownDiscount.Value = 0;
            dateTimePickerStart.Value = DateTime.Today;
            dateTimePickerEnd.Value = DateTime.Today.AddDays(7);
            checkBoxActive.Checked = true;
            dataGridViewTariffs.ClearSelection();
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridViewTariffs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewTariffs.Rows.Count - 1)
            {
                var row = dataGridViewTariffs.Rows[e.RowIndex];
                var selectedTariff = row.DataBoundItem as Tariff;
                if (selectedTariff != null)
                {
                    textBoxTariffName.Text = selectedTariff.TariffName;
                    numericUpDownDiscount.Value = selectedTariff.DiscountPercentage;
                    dateTimePickerStart.Value = selectedTariff.StartDate;
                    dateTimePickerEnd.Value = selectedTariff.EndDate;
                    checkBoxActive.Checked = selectedTariff.IsActive;
                }
            }
        }
    }
}
