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
    public partial class GuestsForm : Form
    {
        public GuestsForm()
        {
            InitializeComponent();
        }

        private async void GuestsForm_Load(object sender, EventArgs e)
        {
            await LoadGuestsAsync();
        }

        private async Task LoadGuestsAsync(string searchTerm = null)
        {
            try
            {
                using (var context = new HotelContext())
                {
                    var query = context.Guests.AsQueryable();

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query = query.Where(g => g.LastName.Contains(searchTerm) ||
                                                g.FirstName.Contains(searchTerm) ||
                                                g.PhoneNumber.Contains(searchTerm));
                    }

                    var guests = await query.ToListAsync();
                    dataGridViewGuests.DataSource = guests;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки гостей: " + ex.Message);
            }
        }

        private async void buttonAddGuest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLastName.Text) || string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                MessageBox.Show("Фамилия и Имя обязательны.");
                return;
            }

            var guest = new Guest
            {
                LastName = textBoxLastName.Text.Trim(),
                FirstName = textBoxFirstName.Text.Trim(),
                MiddleName = textBoxMiddleName.Text.Trim(),
                PhoneNumber = textBoxPhoneNumber.Text.Trim(),
                PassportSeries = textBoxPassportSeries.Text.Trim(),
                PassportNumber = textBoxPassportNumber.Text.Trim(),
                PassportIssueDate = dateTimePickerPassportIssueDate.Checked ? dateTimePickerPassportIssueDate.Value.Date : (DateTime?)null,
                PassportIssuedBy = textBoxPassportIssuedBy.Text.Trim(),
                BirthDate = dateTimePickerBirthDate.Checked ? dateTimePickerBirthDate.Value.Date : (DateTime?)null,
                Email = textBoxEmail.Text.Trim(),
                Notes = textBoxNotes.Text.Trim()
            };

            try
            {
                using (var context = new HotelContext())
                {
                    context.Guests.Add(guest);
                    await context.SaveChangesAsync();
                    await LoadGuestsAsync();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления гостя: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            textBoxLastName.Clear();
            textBoxFirstName.Clear();
            textBoxMiddleName.Clear();
            textBoxPhoneNumber.Clear();
            textBoxPassportSeries.Clear();
            textBoxPassportNumber.Clear();
            textBoxPassportIssuedBy.Clear();
            textBoxEmail.Clear();
            textBoxNotes.Clear();
            dataGridViewGuests.ClearSelection();
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridViewGuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewGuests.Rows.Count - 1)
            {
                var row = dataGridViewGuests.Rows[e.RowIndex];
                var selectedGuest = row.DataBoundItem as Guest;
                if (selectedGuest != null)
                {
                    textBoxLastName.Text = selectedGuest.LastName;
                    textBoxFirstName.Text = selectedGuest.FirstName;
                    textBoxMiddleName.Text = selectedGuest.MiddleName;
                    textBoxPhoneNumber.Text = selectedGuest.PhoneNumber;
                    textBoxPassportSeries.Text = selectedGuest.PassportSeries;
                    textBoxPassportNumber.Text = selectedGuest.PassportNumber;
                    textBoxPassportIssuedBy.Text = selectedGuest.PassportIssuedBy;
                    textBoxEmail.Text = selectedGuest.Email;
                    textBoxNotes.Text = selectedGuest.Notes;
                    dateTimePickerPassportIssueDate.Value = selectedGuest.PassportIssueDate ?? DateTime.Today;
                    dateTimePickerPassportIssueDate.Checked = selectedGuest.PassportIssueDate.HasValue;
                    dateTimePickerBirthDate.Value = selectedGuest.BirthDate ?? DateTime.Today;
                    dateTimePickerBirthDate.Checked = selectedGuest.BirthDate.HasValue;
                }
            }
        }

        private async void buttonUpdateGuest_Click(object sender, EventArgs e)
        {
            if (dataGridViewGuests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите гостя для обновления.");
                return;
            }

            var selectedRow = dataGridViewGuests.SelectedRows[0];
            var guestToUpdate = selectedRow.DataBoundItem as Guest;

            if (guestToUpdate == null)
            {
                MessageBox.Show("Не удалось получить данные гостя.");
                return;
            }

            guestToUpdate.LastName = textBoxLastName.Text.Trim();
            guestToUpdate.FirstName = textBoxFirstName.Text.Trim();
            guestToUpdate.MiddleName = textBoxMiddleName.Text.Trim();
            guestToUpdate.PhoneNumber = textBoxPhoneNumber.Text.Trim();
            guestToUpdate.PassportSeries = textBoxPassportSeries.Text.Trim();
            guestToUpdate.PassportNumber = textBoxPassportNumber.Text.Trim();
            guestToUpdate.PassportIssueDate = dateTimePickerPassportIssueDate.Checked ? dateTimePickerPassportIssueDate.Value.Date : (DateTime?)null;
            guestToUpdate.PassportIssuedBy = textBoxPassportIssuedBy.Text.Trim();
            guestToUpdate.BirthDate = dateTimePickerBirthDate.Checked ? dateTimePickerBirthDate.Value.Date : (DateTime?)null;
            guestToUpdate.Email = textBoxEmail.Text.Trim();
            guestToUpdate.Notes = textBoxNotes.Text.Trim();

            try
            {
                using (var context = new HotelContext())
                {
                    context.Guests.Update(guestToUpdate);
                    await context.SaveChangesAsync();
                    await LoadGuestsAsync();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления гостя: " + ex.Message);
            }
        }

        private async void buttonDeleteGuest_Click(object sender, EventArgs e)
        {
            if (dataGridViewGuests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите гостя для удаления.");
                return;
            }

            var selectedRow = dataGridViewGuests.SelectedRows[0];
            var guestToDelete = selectedRow.DataBoundItem as Guest;

            if (guestToDelete == null)
            {
                MessageBox.Show("Не удалось получить данные гостя.");
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите удалить этого гостя?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (var context = new HotelContext())
                    {
                        context.Guests.Remove(guestToDelete);
                        await context.SaveChangesAsync();
                        await LoadGuestsAsync();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления гостя: " + ex.Message);
                }
            }
        }
    }
}
