namespace HotelCRM.Forms
{
    partial class CleaningForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewTasks;
        private TextBox textBoxRoomID;
        private TextBox textBoxArea;
        private TextBox textBoxEmployeeID;
        private ComboBox comboBoxTaskType;
        private TextBox textBoxDescription;
        private DateTimePicker dateTimePickerDate;
        private Button buttonCreateTask;
        private Button buttonCompleteTask;
        private Button buttonClearFields;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewTasks = new DataGridView();
            textBoxRoomID = new TextBox();
            textBoxArea = new TextBox();
            textBoxEmployeeID = new TextBox();
            comboBoxTaskType = new ComboBox();
            textBoxDescription = new TextBox();
            dateTimePickerDate = new DateTimePicker();
            buttonCreateTask = new Button();
            buttonCompleteTask = new Button();
            buttonClearFields = new Button();
            labelRoomID = new Label();
            labelArea = new Label();
            labelEmployeeID = new Label();
            labelTaskType = new Label();
            labelDescription = new Label();
            labelDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(12, 15);
            dataGridViewTasks.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.RowHeadersWidth = 51;
            dataGridViewTasks.RowTemplate.Height = 24;
            dataGridViewTasks.Size = new Size(760, 375);
            dataGridViewTasks.TabIndex = 0;
            dataGridViewTasks.CellClick += dataGridViewTasks_CellClick;
            // 
            // textBoxRoomID
            // 
            textBoxRoomID.Location = new Point(135, 400);
            textBoxRoomID.Margin = new Padding(3, 4, 3, 4);
            textBoxRoomID.Name = "textBoxRoomID";
            textBoxRoomID.Size = new Size(200, 27);
            textBoxRoomID.TabIndex = 1;
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(135, 438);
            textBoxArea.Margin = new Padding(3, 4, 3, 4);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(200, 27);
            textBoxArea.TabIndex = 2;
            // 
            // textBoxEmployeeID
            // 
            textBoxEmployeeID.Location = new Point(135, 475);
            textBoxEmployeeID.Margin = new Padding(3, 4, 3, 4);
            textBoxEmployeeID.Name = "textBoxEmployeeID";
            textBoxEmployeeID.Size = new Size(200, 27);
            textBoxEmployeeID.TabIndex = 3;
            // 
            // comboBoxTaskType
            // 
            comboBoxTaskType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTaskType.FormattingEnabled = true;
            comboBoxTaskType.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly", "Deep" });
            comboBoxTaskType.Location = new Point(135, 512);
            comboBoxTaskType.Margin = new Padding(3, 4, 3, 4);
            comboBoxTaskType.Name = "comboBoxTaskType";
            comboBoxTaskType.Size = new Size(200, 28);
            comboBoxTaskType.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(135, 550);
            textBoxDescription.Margin = new Padding(3, 4, 3, 4);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(200, 74);
            textBoxDescription.TabIndex = 5;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(135, 638);
            dateTimePickerDate.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(200, 27);
            dateTimePickerDate.TabIndex = 6;
            // 
            // buttonCreateTask
            // 
            buttonCreateTask.Location = new Point(447, 699);
            buttonCreateTask.Margin = new Padding(3, 4, 3, 4);
            buttonCreateTask.Name = "buttonCreateTask";
            buttonCreateTask.Size = new Size(100, 38);
            buttonCreateTask.TabIndex = 7;
            buttonCreateTask.Text = "Создать задачу";
            buttonCreateTask.UseVisualStyleBackColor = true;
            buttonCreateTask.Click += buttonCreateTask_Click;
            // 
            // buttonCompleteTask
            // 
            buttonCompleteTask.Location = new Point(553, 699);
            buttonCompleteTask.Margin = new Padding(3, 4, 3, 4);
            buttonCompleteTask.Name = "buttonCompleteTask";
            buttonCompleteTask.Size = new Size(100, 38);
            buttonCompleteTask.TabIndex = 8;
            buttonCompleteTask.Text = "Завершить";
            buttonCompleteTask.UseVisualStyleBackColor = true;
            buttonCompleteTask.Click += buttonCompleteTask_Click;
            // 
            // buttonClearFields
            // 
            buttonClearFields.Location = new Point(659, 699);
            buttonClearFields.Margin = new Padding(3, 4, 3, 4);
            buttonClearFields.Name = "buttonClearFields";
            buttonClearFields.Size = new Size(100, 38);
            buttonClearFields.TabIndex = 9;
            buttonClearFields.Text = "Очистить поля";
            buttonClearFields.UseVisualStyleBackColor = true;
            buttonClearFields.Click += buttonClearFields_Click;
            // 
            // labelRoomID
            // 
            labelRoomID.AutoSize = true;
            labelRoomID.Location = new Point(61, 404);
            labelRoomID.Name = "labelRoomID";
            labelRoomID.Size = new Size(71, 20);
            labelRoomID.TabIndex = 10;
            labelRoomID.Text = "Room ID:";
            // 
            // labelArea
            // 
            labelArea.AutoSize = true;
            labelArea.Location = new Point(63, 441);
            labelArea.Name = "labelArea";
            labelArea.Size = new Size(69, 20);
            labelArea.TabIndex = 11;
            labelArea.Text = "Область:";
            // 
            // labelEmployeeID
            // 
            labelEmployeeID.AutoSize = true;
            labelEmployeeID.Location = new Point(22, 479);
            labelEmployeeID.Name = "labelEmployeeID";
            labelEmployeeID.Size = new Size(110, 20);
            labelEmployeeID.TabIndex = 12;
            labelEmployeeID.Text = "ID сотрудника:";
            // 
            // labelTaskType
            // 
            labelTaskType.AutoSize = true;
            labelTaskType.Location = new Point(42, 516);
            labelTaskType.Name = "labelTaskType";
            labelTaskType.Size = new Size(90, 20);
            labelTaskType.TabIndex = 13;
            labelTaskType.Text = "Тип задачи:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(50, 554);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(82, 20);
            labelDescription.TabIndex = 14;
            labelDescription.Text = "Описание:";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(88, 641);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(44, 20);
            labelDate.TabIndex = 15;
            labelDate.Text = "Дата:";
            // 
            // CleaningForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 750);
            Controls.Add(buttonCreateTask);
            Controls.Add(buttonCompleteTask);
            Controls.Add(buttonClearFields);
            Controls.Add(labelRoomID);
            Controls.Add(labelArea);
            Controls.Add(labelEmployeeID);
            Controls.Add(labelTaskType);
            Controls.Add(labelDescription);
            Controls.Add(labelDate);
            Controls.Add(dataGridViewTasks);
            Controls.Add(textBoxRoomID);
            Controls.Add(textBoxArea);
            Controls.Add(textBoxEmployeeID);
            Controls.Add(comboBoxTaskType);
            Controls.Add(textBoxDescription);
            Controls.Add(dateTimePickerDate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CleaningForm";
            Text = "Задачи уборки";
            Load += CleaningForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelRoomID;
        private Label labelArea;
        private Label labelEmployeeID;
        private Label labelTaskType;
        private Label labelDescription;
        private Label labelDate;
    }
}