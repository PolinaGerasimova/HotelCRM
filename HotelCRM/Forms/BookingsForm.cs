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
    public partial class BookingsForm : Form
    {
        public BookingsForm()
        {
            InitializeComponent();
        }

        private async void BookingsForm_Load(object sender, EventArgs e)
        {
            await LoadBookingsAsync();
        }

        private async Task LoadBookingsAsync(string searchTerm = null)
        {
            try
            {
                using (var context = new HotelContext())
                {
                    var query = context.Bookings.AsQueryable();

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query = query.Where(b => b.Status.Contains(searchTerm));
                    }

                    var bookings = await query.ToListAsync();
                    dataGridViewBookings.DataSource = bookings;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки бронирований: " + ex.Message);
            }
        }

        private async void buttonCreateBooking_Click(object sender, EventArgs e)
        {
            if (comboBoxGuest.SelectedItem == null || comboBoxRoom.SelectedItem == null)
            {
                MessageBox.Show("Выберите гостя и номер.");
                return;
            }

            var booking = new Booking
            {
                GuestID = ((Guest)comboBoxGuest.SelectedItem).GuestID,
                RoomID = ((Room)comboBoxRoom.SelectedItem).RoomID,
                CheckInDate = dateTimePickerCheckIn.Value.Date,
                CheckOutDate = dateTimePickerCheckOut.Value.Date,
                NumberOfGuests = (int)numericUpDownGuests.Value,
                Status = "Confirmed"
            };

            try
            {
                using (var context = new HotelContext())
                {
                    context.Bookings.Add(booking);
                    await context.SaveChangesAsync();
                    await LoadBookingsAsync();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка создания бронирования: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            comboBoxGuest.SelectedIndex = -1;
            comboBoxRoom.SelectedIndex = -1;
            dateTimePickerCheckIn.Value = DateTime.Now;
            dateTimePickerCheckOut.Value = DateTime.Now.AddDays(1);
            numericUpDownGuests.Value = 1;
            dataGridViewBookings.ClearSelection();
        }

        private void buttonCancelBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите отменить это бронирование?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var selectedRow = dataGridViewBookings.SelectedRows[0];
                    var bookingToDelete = selectedRow.DataBoundItem as Booking;

                    if (bookingToDelete != null)
                    {
                        DeleteBooking(bookingToDelete);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите бронирование для отмены.");
            }
        }

        private async void DeleteBooking(Booking booking)
        {
            try
            {
                using (var context = new HotelContext())
                {
                    context.Bookings.Remove(booking);
                    await context.SaveChangesAsync();
                    await LoadBookingsAsync();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления бронирования: " + ex.Message);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBookingsAsync(textBoxSearch.Text.Trim());
        }
    }
}
