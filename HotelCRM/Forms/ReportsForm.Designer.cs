namespace HotelCRM.Forms
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewReport;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Button buttonGenerateReport;
        private Button buttonExportToExcel;
        private Button buttonClearFields;
        private Label labelStartDate;
        private Label labelEndDate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewReport = new DataGridView();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            buttonGenerateReport = new Button();
            buttonExportToExcel = new Button();
            buttonClearFields = new Button();
            labelStartDate = new Label();
            labelEndDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Location = new Point(12, 119);
            dataGridViewReport.Margin = new Padding(3, 4, 3, 4);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.RowHeadersWidth = 51;
            dataGridViewReport.RowTemplate.Height = 24;
            dataGridViewReport.Size = new Size(760, 385);
            dataGridViewReport.TabIndex = 0;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(146, 15);
            dateTimePickerStart.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 27);
            dateTimePickerStart.TabIndex = 1;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(146, 50);
            dateTimePickerEnd.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 27);
            dateTimePickerEnd.TabIndex = 2;
            // 
            // buttonGenerateReport
            // 
            buttonGenerateReport.Location = new Point(438, 15);
            buttonGenerateReport.Margin = new Padding(3, 4, 3, 4);
            buttonGenerateReport.Name = "buttonGenerateReport";
            buttonGenerateReport.Size = new Size(120, 38);
            buttonGenerateReport.TabIndex = 3;
            buttonGenerateReport.Text = "Сформировать";
            buttonGenerateReport.UseVisualStyleBackColor = true;
            buttonGenerateReport.Click += buttonGenerateReport_Click;
            // 
            // buttonExportToExcel
            // 
            buttonExportToExcel.Location = new Point(670, 15);
            buttonExportToExcel.Margin = new Padding(3, 4, 3, 4);
            buttonExportToExcel.Name = "buttonExportToExcel";
            buttonExportToExcel.Size = new Size(100, 38);
            buttonExportToExcel.TabIndex = 4;
            buttonExportToExcel.Text = "Экспорт в Excel";
            buttonExportToExcel.UseVisualStyleBackColor = true;
            buttonExportToExcel.Click += buttonExportToExcel_Click;
            // 
            // buttonClearFields
            // 
            buttonClearFields.Location = new Point(564, 15);
            buttonClearFields.Margin = new Padding(3, 4, 3, 4);
            buttonClearFields.Name = "buttonClearFields";
            buttonClearFields.Size = new Size(100, 38);
            buttonClearFields.TabIndex = 5;
            buttonClearFields.Text = "Очистить поля";
            buttonClearFields.UseVisualStyleBackColor = true;
            buttonClearFields.Click += buttonClearFields_Click;
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Location = new Point(43, 21);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(97, 20);
            labelStartDate.TabIndex = 0;
            labelStartDate.Text = "Дата начала:";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Location = new Point(16, 55);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(124, 20);
            labelEndDate.TabIndex = 1;
            labelEndDate.Text = "Дата окончания:";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(labelStartDate);
            Controls.Add(labelEndDate);
            Controls.Add(buttonGenerateReport);
            Controls.Add(buttonExportToExcel);
            Controls.Add(dataGridViewReport);
            Controls.Add(dateTimePickerStart);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(buttonClearFields);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReportsForm";
            Text = "Отчеты";
            Load += ReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}