namespace HotelCRM.Forms
{
    partial class MaintenanceForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewTasks;
        private TextBox textBoxRoomID;
        private TextBox textBoxDescription;
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
            textBoxDescription = new TextBox();
            buttonCreateTask = new Button();
            buttonCompleteTask = new Button();
            buttonClearFields = new Button();
            labelRoomID = new Label();
            labelDescription = new Label();
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
            textBoxRoomID.Location = new Point(120, 400);
            textBoxRoomID.Margin = new Padding(3, 4, 3, 4);
            textBoxRoomID.Name = "textBoxRoomID";
            textBoxRoomID.Size = new Size(200, 27);
            textBoxRoomID.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(120, 438);
            textBoxDescription.Margin = new Padding(3, 4, 3, 4);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(200, 74);
            textBoxDescription.TabIndex = 2;
            // 
            // buttonCreateTask
            // 
            buttonCreateTask.Location = new Point(460, 511);
            buttonCreateTask.Margin = new Padding(3, 4, 3, 4);
            buttonCreateTask.Name = "buttonCreateTask";
            buttonCreateTask.Size = new Size(100, 38);
            buttonCreateTask.TabIndex = 3;
            buttonCreateTask.Text = "Создать задачу";
            buttonCreateTask.UseVisualStyleBackColor = true;
            buttonCreateTask.Click += buttonCreateTask_Click;
            // 
            // buttonCompleteTask
            // 
            buttonCompleteTask.Location = new Point(566, 511);
            buttonCompleteTask.Margin = new Padding(3, 4, 3, 4);
            buttonCompleteTask.Name = "buttonCompleteTask";
            buttonCompleteTask.Size = new Size(100, 38);
            buttonCompleteTask.TabIndex = 4;
            buttonCompleteTask.Text = "Завершить";
            buttonCompleteTask.UseVisualStyleBackColor = true;
            buttonCompleteTask.Click += buttonCompleteTask_Click;
            // 
            // buttonClearFields
            // 
            buttonClearFields.Location = new Point(672, 511);
            buttonClearFields.Margin = new Padding(3, 4, 3, 4);
            buttonClearFields.Name = "buttonClearFields";
            buttonClearFields.Size = new Size(100, 38);
            buttonClearFields.TabIndex = 5;
            buttonClearFields.Text = "Очистить поля";
            buttonClearFields.UseVisualStyleBackColor = true;
            buttonClearFields.Click += buttonClearFields_Click;
            // 
            // labelRoomID
            // 
            labelRoomID.AutoSize = true;
            labelRoomID.Location = new Point(12, 404);
            labelRoomID.Name = "labelRoomID";
            labelRoomID.Size = new Size(87, 20);
            labelRoomID.TabIndex = 0;
            labelRoomID.Text = "ID Номера:";
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
            // MaintenanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(labelRoomID);
            Controls.Add(labelDescription);
            Controls.Add(dataGridViewTasks);
            Controls.Add(textBoxRoomID);
            Controls.Add(textBoxDescription);
            Controls.Add(buttonCreateTask);
            Controls.Add(buttonCompleteTask);
            Controls.Add(buttonClearFields);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MaintenanceForm";
            Text = "Задачи техобслуживания";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelRoomID;
        private Label labelDescription;
    }
}