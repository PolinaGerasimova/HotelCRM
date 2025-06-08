namespace HotelCRM.Forms
{
    partial class RoomsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewRooms;
        private TextBox textBoxRoomNumber;
        private TextBox textBoxDescription;
        private NumericUpDown numericUpDownCategoryID;
        private NumericUpDown numericUpDownOccupancy;
        private NumericUpDown numericUpDownPrice;
        private ComboBox comboBoxStatus;
        private Button buttonAddRoom;
        private Button buttonUpdateRoom;
        private Button buttonDeleteRoom;
        private Button buttonClearFields;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewRooms = new DataGridView();
            textBoxRoomNumber = new TextBox();
            textBoxDescription = new TextBox();
            numericUpDownCategoryID = new NumericUpDown();
            numericUpDownOccupancy = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            comboBoxStatus = new ComboBox();
            buttonAddRoom = new Button();
            buttonUpdateRoom = new Button();
            buttonDeleteRoom = new Button();
            buttonClearFields = new Button();
            labelRoomNumber = new Label();
            labelDescription = new Label();
            labelCategoryID = new Label();
            labelOccupancy = new Label();
            labelBasePrice = new Label();
            labelStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCategoryID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOccupancy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRooms.Location = new Point(12, 15);
            dataGridViewRooms.Margin = new Padding(3, 4, 3, 4);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.RowHeadersWidth = 51;
            dataGridViewRooms.RowTemplate.Height = 24;
            dataGridViewRooms.Size = new Size(760, 375);
            dataGridViewRooms.TabIndex = 0;
            dataGridViewRooms.CellClick += dataGridViewRooms_CellClick;
            // 
            // textBoxRoomNumber
            // 
            textBoxRoomNumber.Location = new Point(150, 400);
            textBoxRoomNumber.Margin = new Padding(3, 4, 3, 4);
            textBoxRoomNumber.Name = "textBoxRoomNumber";
            textBoxRoomNumber.Size = new Size(200, 27);
            textBoxRoomNumber.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(150, 438);
            textBoxDescription.Margin = new Padding(3, 4, 3, 4);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(200, 74);
            textBoxDescription.TabIndex = 2;
            // 
            // numericUpDownCategoryID
            // 
            numericUpDownCategoryID.Location = new Point(150, 525);
            numericUpDownCategoryID.Margin = new Padding(3, 4, 3, 4);
            numericUpDownCategoryID.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownCategoryID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCategoryID.Name = "numericUpDownCategoryID";
            numericUpDownCategoryID.Size = new Size(200, 27);
            numericUpDownCategoryID.TabIndex = 3;
            numericUpDownCategoryID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownOccupancy
            // 
            numericUpDownOccupancy.Location = new Point(150, 562);
            numericUpDownOccupancy.Margin = new Padding(3, 4, 3, 4);
            numericUpDownOccupancy.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDownOccupancy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownOccupancy.Name = "numericUpDownOccupancy";
            numericUpDownOccupancy.Size = new Size(200, 27);
            numericUpDownOccupancy.TabIndex = 4;
            numericUpDownOccupancy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownPrice.Location = new Point(150, 600);
            numericUpDownPrice.Margin = new Padding(3, 4, 3, 4);
            numericUpDownPrice.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(200, 27);
            numericUpDownPrice.TabIndex = 5;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Available", "Occupied", "Cleaning", "Maintenance", "OutOfOrder" });
            comboBoxStatus.Location = new Point(150, 638);
            comboBoxStatus.Margin = new Padding(3, 4, 3, 4);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(200, 28);
            comboBoxStatus.TabIndex = 6;
            // 
            // buttonAddRoom
            // 
            buttonAddRoom.Location = new Point(354, 699);
            buttonAddRoom.Margin = new Padding(3, 4, 3, 4);
            buttonAddRoom.Name = "buttonAddRoom";
            buttonAddRoom.Size = new Size(100, 38);
            buttonAddRoom.TabIndex = 7;
            buttonAddRoom.Text = "Добавить";
            buttonAddRoom.UseVisualStyleBackColor = true;
            buttonAddRoom.Click += buttonAddRoom_Click;
            // 
            // buttonUpdateRoom
            // 
            buttonUpdateRoom.Location = new Point(460, 699);
            buttonUpdateRoom.Margin = new Padding(3, 4, 3, 4);
            buttonUpdateRoom.Name = "buttonUpdateRoom";
            buttonUpdateRoom.Size = new Size(100, 38);
            buttonUpdateRoom.TabIndex = 8;
            buttonUpdateRoom.Text = "Обновить";
            buttonUpdateRoom.UseVisualStyleBackColor = true;
            buttonUpdateRoom.Click += buttonUpdateRoom_Click;
            // 
            // buttonDeleteRoom
            // 
            buttonDeleteRoom.Location = new Point(566, 699);
            buttonDeleteRoom.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteRoom.Name = "buttonDeleteRoom";
            buttonDeleteRoom.Size = new Size(100, 38);
            buttonDeleteRoom.TabIndex = 9;
            buttonDeleteRoom.Text = "Удалить";
            buttonDeleteRoom.UseVisualStyleBackColor = true;
            buttonDeleteRoom.Click += buttonDeleteRoom_Click;
            // 
            // buttonClearFields
            // 
            buttonClearFields.Location = new Point(672, 699);
            buttonClearFields.Margin = new Padding(3, 4, 3, 4);
            buttonClearFields.Name = "buttonClearFields";
            buttonClearFields.Size = new Size(100, 38);
            buttonClearFields.TabIndex = 10;
            buttonClearFields.Text = "Очистить поля";
            buttonClearFields.UseVisualStyleBackColor = true;
            buttonClearFields.Click += buttonClearFields_Click;
            // 
            // labelRoomNumber
            // 
            labelRoomNumber.AutoSize = true;
            labelRoomNumber.Location = new Point(12, 404);
            labelRoomNumber.Name = "labelRoomNumber";
            labelRoomNumber.Size = new Size(60, 20);
            labelRoomNumber.TabIndex = 0;
            labelRoomNumber.Text = "Номер:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(12, 441);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(82, 20);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Описание:";
            // 
            // labelCategoryID
            // 
            labelCategoryID.AutoSize = true;
            labelCategoryID.Location = new Point(12, 529);
            labelCategoryID.Name = "labelCategoryID";
            labelCategoryID.Size = new Size(103, 20);
            labelCategoryID.TabIndex = 2;
            labelCategoryID.Text = "Категория ID:";
            // 
            // labelOccupancy
            // 
            labelOccupancy.AutoSize = true;
            labelOccupancy.Location = new Point(12, 566);
            labelOccupancy.Name = "labelOccupancy";
            labelOccupancy.Size = new Size(144, 20);
            labelOccupancy.TabIndex = 3;
            labelOccupancy.Text = "Макс. вместимость:";
            // 
            // labelBasePrice
            // 
            labelBasePrice.AutoSize = true;
            labelBasePrice.Location = new Point(12, 604);
            labelBasePrice.Name = "labelBasePrice";
            labelBasePrice.Size = new Size(105, 20);
            labelBasePrice.TabIndex = 4;
            labelBasePrice.Text = "Цена за ночь:";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(12, 641);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(55, 20);
            labelStatus.TabIndex = 5;
            labelStatus.Text = "Статус:";
            // 
            // RoomsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 750);
            Controls.Add(labelRoomNumber);
            Controls.Add(labelDescription);
            Controls.Add(labelCategoryID);
            Controls.Add(labelOccupancy);
            Controls.Add(labelBasePrice);
            Controls.Add(labelStatus);
            Controls.Add(dataGridViewRooms);
            Controls.Add(textBoxRoomNumber);
            Controls.Add(textBoxDescription);
            Controls.Add(numericUpDownCategoryID);
            Controls.Add(numericUpDownOccupancy);
            Controls.Add(numericUpDownPrice);
            Controls.Add(comboBoxStatus);
            Controls.Add(buttonAddRoom);
            Controls.Add(buttonUpdateRoom);
            Controls.Add(buttonDeleteRoom);
            Controls.Add(buttonClearFields);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RoomsForm";
            Text = "Номера";
            Load += RoomsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCategoryID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOccupancy).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelRoomNumber;
        private Label labelDescription;
        private Label labelCategoryID;
        private Label labelOccupancy;
        private Label labelBasePrice;
        private Label labelStatus;
    }
}