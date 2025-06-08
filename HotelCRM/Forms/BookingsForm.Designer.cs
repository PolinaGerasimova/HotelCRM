using HotelCRM.Models;

namespace HotelCRM.Forms
{
    partial class BookingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewBookings;
        private ComboBox comboBoxGuest;
        private ComboBox comboBoxRoom;
        private DateTimePicker dateTimePickerCheckIn;
        private DateTimePicker dateTimePickerCheckOut;
        private NumericUpDown numericUpDownGuests;
        private TextBox textBoxSearch;
        private Button buttonCreateBooking;
        private Button buttonCancelBooking;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewBookings = new DataGridView();
            comboBoxGuest = new ComboBox();
            comboBoxRoom = new ComboBox();
            dateTimePickerCheckIn = new DateTimePicker();
            dateTimePickerCheckOut = new DateTimePicker();
            numericUpDownGuests = new NumericUpDown();
            textBoxSearch = new TextBox();
            buttonCreateBooking = new Button();
            buttonCancelBooking = new Button();
            labelGuest = new Label();
            labelRoom = new Label();
            labelCheckIn = new Label();
            labelCheckOut = new Label();
            labelGuestsCount = new Label();
            labelSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGuests).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBookings
            // 
            dataGridViewBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookings.Location = new Point(12, 15);
            dataGridViewBookings.Margin = new Padding(3, 4, 3, 4);
            dataGridViewBookings.Name = "dataGridViewBookings";
            dataGridViewBookings.RowHeadersWidth = 51;
            dataGridViewBookings.RowTemplate.Height = 24;
            dataGridViewBookings.Size = new Size(760, 375);
            dataGridViewBookings.TabIndex = 0;
            dataGridViewBookings.CellClick += dataGridViewBookings_CellClick;
            // 
            // comboBoxGuest
            // 
            comboBoxGuest.DisplayMember = "FullName";
            comboBoxGuest.FormattingEnabled = true;
            comboBoxGuest.Location = new Point(156, 400);
            comboBoxGuest.Margin = new Padding(3, 4, 3, 4);
            comboBoxGuest.Name = "comboBoxGuest";
            comboBoxGuest.Size = new Size(200, 28);
            comboBoxGuest.TabIndex = 1;
            // 
            // comboBoxRoom
            // 
            comboBoxRoom.DisplayMember = "RoomNumber";
            comboBoxRoom.FormattingEnabled = true;
            comboBoxRoom.Location = new Point(156, 437);
            comboBoxRoom.Margin = new Padding(3, 4, 3, 4);
            comboBoxRoom.Name = "comboBoxRoom";
            comboBoxRoom.Size = new Size(200, 28);
            comboBoxRoom.TabIndex = 2;
            // 
            // dateTimePickerCheckIn
            // 
            dateTimePickerCheckIn.Location = new Point(156, 474);
            dateTimePickerCheckIn.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            dateTimePickerCheckIn.Size = new Size(200, 27);
            dateTimePickerCheckIn.TabIndex = 3;
            // 
            // dateTimePickerCheckOut
            // 
            dateTimePickerCheckOut.Location = new Point(156, 510);
            dateTimePickerCheckOut.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            dateTimePickerCheckOut.Size = new Size(200, 27);
            dateTimePickerCheckOut.TabIndex = 4;
            // 
            // numericUpDownGuests
            // 
            numericUpDownGuests.Location = new Point(156, 546);
            numericUpDownGuests.Margin = new Padding(3, 4, 3, 4);
            numericUpDownGuests.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDownGuests.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownGuests.Name = "numericUpDownGuests";
            numericUpDownGuests.Size = new Size(200, 27);
            numericUpDownGuests.TabIndex = 5;
            numericUpDownGuests.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(156, 582);
            textBoxSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(200, 27);
            textBoxSearch.TabIndex = 6;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonCreateBooking
            // 
            buttonCreateBooking.Location = new Point(566, 699);
            buttonCreateBooking.Margin = new Padding(3, 4, 3, 4);
            buttonCreateBooking.Name = "buttonCreateBooking";
            buttonCreateBooking.Size = new Size(100, 38);
            buttonCreateBooking.TabIndex = 7;
            buttonCreateBooking.Text = "Создать";
            buttonCreateBooking.UseVisualStyleBackColor = true;
            buttonCreateBooking.Click += buttonCreateBooking_Click;
            // 
            // buttonCancelBooking
            // 
            buttonCancelBooking.Location = new Point(672, 699);
            buttonCancelBooking.Margin = new Padding(3, 4, 3, 4);
            buttonCancelBooking.Name = "buttonCancelBooking";
            buttonCancelBooking.Size = new Size(100, 38);
            buttonCancelBooking.TabIndex = 8;
            buttonCancelBooking.Text = "Отменить";
            buttonCancelBooking.UseVisualStyleBackColor = true;
            buttonCancelBooking.Click += buttonCancelBooking_Click;
            // 
            // labelGuest
            // 
            labelGuest.AutoSize = true;
            labelGuest.Location = new Point(105, 403);
            labelGuest.Name = "labelGuest";
            labelGuest.Size = new Size(49, 20);
            labelGuest.TabIndex = 0;
            labelGuest.Text = "Гость:";
            // 
            // labelRoom
            // 
            labelRoom.AutoSize = true;
            labelRoom.Location = new Point(94, 440);
            labelRoom.Name = "labelRoom";
            labelRoom.Size = new Size(60, 20);
            labelRoom.TabIndex = 1;
            labelRoom.Text = "Номер:";
            // 
            // labelCheckIn
            // 
            labelCheckIn.AutoSize = true;
            labelCheckIn.Location = new Point(60, 477);
            labelCheckIn.Name = "labelCheckIn";
            labelCheckIn.Size = new Size(94, 20);
            labelCheckIn.TabIndex = 2;
            labelCheckIn.Text = "Дата заезда:";
            // 
            // labelCheckOut
            // 
            labelCheckOut.AutoSize = true;
            labelCheckOut.Location = new Point(56, 514);
            labelCheckOut.Name = "labelCheckOut";
            labelCheckOut.Size = new Size(98, 20);
            labelCheckOut.TabIndex = 3;
            labelCheckOut.Text = "Дата выезда:";
            // 
            // labelGuestsCount
            // 
            labelGuestsCount.AutoSize = true;
            labelGuestsCount.Location = new Point(44, 551);
            labelGuestsCount.Name = "labelGuestsCount";
            labelGuestsCount.Size = new Size(110, 20);
            labelGuestsCount.TabIndex = 4;
            labelGuestsCount.Text = "Кол-во гостей:";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(25, 588);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(129, 20);
            labelSearch.TabIndex = 5;
            labelSearch.Text = "Поиск по статусу:";
            // 
            // BookingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 750);
            Controls.Add(labelGuest);
            Controls.Add(labelRoom);
            Controls.Add(labelCheckIn);
            Controls.Add(labelCheckOut);
            Controls.Add(labelGuestsCount);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(comboBoxGuest);
            Controls.Add(comboBoxRoom);
            Controls.Add(dateTimePickerCheckIn);
            Controls.Add(dateTimePickerCheckOut);
            Controls.Add(numericUpDownGuests);
            Controls.Add(buttonCreateBooking);
            Controls.Add(buttonCancelBooking);
            Controls.Add(dataGridViewBookings);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BookingsForm";
            Text = "Бронирования";
            Load += BookingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookings).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGuests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridViewBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewBookings.Rows.Count - 1)
            {
                var row = dataGridViewBookings.Rows[e.RowIndex];
                var selectedBooking = row.DataBoundItem as Booking;
                if (selectedBooking != null)
                {
                    comboBoxGuest.SelectedItem = selectedBooking.GuestID;
                    comboBoxRoom.SelectedItem = selectedBooking.RoomID;
                    dateTimePickerCheckIn.Value = selectedBooking.CheckInDate;
                    dateTimePickerCheckOut.Value = selectedBooking.CheckOutDate;
                    numericUpDownGuests.Value = selectedBooking.NumberOfGuests;
                }
            }
        }

        private Label labelGuest;
        private Label labelRoom;
        private Label labelCheckIn;
        private Label labelCheckOut;
        private Label labelGuestsCount;
        private Label labelSearch;
    }
}