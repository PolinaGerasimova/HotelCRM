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
using System.Windows.Forms.VisualStyles;
using Microsoft.EntityFrameworkCore;


namespace HotelCRM.Forms
{
    public partial class RoomsForm : Form
    {
        public RoomsForm()
        {
            InitializeComponent();
        }

        private async void RoomsForm_Load(object sender, EventArgs e)
        {
            await LoadRoomsAsync();
        }

        private async Task LoadRoomsAsync(string searchTerm = null)
        {
            try
            {
                using (var context = new HotelContext())
                {
                    var query = context.Rooms.AsQueryable();

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query = query.Where(r => r.RoomNumber.Contains(searchTerm));
                    }

                    var rooms = await query.ToListAsync();
                    dataGridViewRooms.DataSource = rooms;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки номеров: " + ex.Message);
            }
        }

        private async void buttonAddRoom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxRoomNumber.Text))
            {
                MessageBox.Show("Введите номер комнаты.");
                return;
            }

            var room = new Room
            {
                RoomNumber = textBoxRoomNumber.Text.Trim(),
                CategoryID = (int)numericUpDownCategoryID.Value,
                Description = textBoxDescription.Text.Trim(),
                MaxOccupancy = (int)numericUpDownOccupancy.Value,
                BasePricePerNight = numericUpDownPrice.Value,
                Status = comboBoxStatus.SelectedItem?.ToString() ?? "Available"
            };

            try
            {
                using (var context = new HotelContext())
                {
                    context.Rooms.Add(room);
                    await context.SaveChangesAsync();
                    await LoadRoomsAsync();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления номера: " + ex.Message);
            }
        }

        private async void buttonUpdateRoom_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите номер для обновления.");
                return;
            }

            var selectedRow = dataGridViewRooms.SelectedRows[0];
            var roomToUpdate = selectedRow.DataBoundItem as Room;

            if (roomToUpdate == null)
            {
                MessageBox.Show("Не удалось получить данные о номере.");
                return;
            }

            roomToUpdate.RoomNumber = textBoxRoomNumber.Text.Trim();
            roomToUpdate.CategoryID = (int)numericUpDownCategoryID.Value;
            roomToUpdate.Description = textBoxDescription.Text.Trim();
            roomToUpdate.MaxOccupancy = (int)numericUpDownOccupancy.Value;
            roomToUpdate.BasePricePerNight = numericUpDownPrice.Value;
            roomToUpdate.Status = comboBoxStatus.SelectedItem?.ToString() ?? "Available";

            try
            {
                using (var context = new HotelContext())
                {
                    context.Rooms.Update(roomToUpdate);
                    await context.SaveChangesAsync();
                    await LoadRoomsAsync();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления номера: " + ex.Message);
            }
        }

        private async void buttonDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите номер для удаления.");
                return;
            }

            var selectedRow = dataGridViewRooms.SelectedRows[0];
            var roomToDelete = selectedRow.DataBoundItem as Room;

            if (MessageBox.Show("Вы уверены, что хотите удалить этот номер?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (var context = new HotelContext())
                    {
                        context.Rooms.Remove(roomToDelete);
                        await context.SaveChangesAsync();
                        await LoadRoomsAsync();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления номера: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            textBoxRoomNumber.Clear();
            textBoxDescription.Clear();
            numericUpDownCategoryID.Value = 1;
            numericUpDownOccupancy.Value = 1;
            numericUpDownPrice.Value = 0;
            comboBoxStatus.SelectedIndex = 0;
            dataGridViewRooms.ClearSelection();
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridViewRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewRooms.Rows.Count - 1)
            {
                var row = dataGridViewRooms.Rows[e.RowIndex];
                var selectedRoom = row.DataBoundItem as Room;
                if (selectedRoom != null)
                {
                    textBoxRoomNumber.Text = selectedRoom.RoomNumber;
                    numericUpDownCategoryID.Value = selectedRoom.CategoryID;
                    textBoxDescription.Text = selectedRoom.Description;
                    numericUpDownOccupancy.Value = selectedRoom.MaxOccupancy;
                    numericUpDownPrice.Value = selectedRoom.BasePricePerNight;
                    comboBoxStatus.SelectedItem = selectedRoom.Status;
                }
            }
        }
    }
}
