namespace HotelCRM.Forms
{
    partial class TariffsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewTariffs;
        private TextBox textBoxTariffName;
        private NumericUpDown numericUpDownDiscount;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private CheckBox checkBoxActive;
        private Button buttonAddTariff;
        private Button buttonUpdateTariff;
        private Button buttonDeleteTariff;
        private Button buttonClearFields;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewTariffs = new DataGridView();
            textBoxTariffName = new TextBox();
            numericUpDownDiscount = new NumericUpDown();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            checkBoxActive = new CheckBox();
            buttonAddTariff = new Button();
            buttonUpdateTariff = new Button();
            buttonDeleteTariff = new Button();
            buttonClearFields = new Button();
            labelTariffName = new Label();
            labelDiscount = new Label();
            labelStartDate = new Label();
            labelEndDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTariffs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTariffs
            // 
            dataGridViewTariffs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTariffs.Location = new Point(12, 15);
            dataGridViewTariffs.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTariffs.Name = "dataGridViewTariffs";
            dataGridViewTariffs.RowHeadersWidth = 51;
            dataGridViewTariffs.RowTemplate.Height = 24;
            dataGridViewTariffs.Size = new Size(760, 472);
            dataGridViewTariffs.TabIndex = 0;
            dataGridViewTariffs.CellClick += dataGridViewTariffs_CellClick;
            // 
            // textBoxTariffName
            // 
            textBoxTariffName.Location = new Point(150, 495);
            textBoxTariffName.Margin = new Padding(3, 4, 3, 4);
            textBoxTariffName.Name = "textBoxTariffName";
            textBoxTariffName.Size = new Size(200, 27);
            textBoxTariffName.TabIndex = 1;
            // 
            // numericUpDownDiscount
            // 
            numericUpDownDiscount.DecimalPlaces = 2;
            numericUpDownDiscount.Location = new Point(150, 533);
            numericUpDownDiscount.Margin = new Padding(3, 4, 3, 4);
            numericUpDownDiscount.Name = "numericUpDownDiscount";
            numericUpDownDiscount.Size = new Size(200, 27);
            numericUpDownDiscount.TabIndex = 2;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(150, 570);
            dateTimePickerStart.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 27);
            dateTimePickerStart.TabIndex = 3;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(150, 607);
            dateTimePickerEnd.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 27);
            dateTimePickerEnd.TabIndex = 4;
            // 
            // checkBoxActive
            // 
            checkBoxActive.AutoSize = true;
            checkBoxActive.Location = new Point(150, 645);
            checkBoxActive.Margin = new Padding(3, 4, 3, 4);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Size = new Size(95, 24);
            checkBoxActive.TabIndex = 5;
            checkBoxActive.Text = "Активен?";
            checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // buttonAddTariff
            // 
            buttonAddTariff.Location = new Point(354, 699);
            buttonAddTariff.Margin = new Padding(3, 4, 3, 4);
            buttonAddTariff.Name = "buttonAddTariff";
            buttonAddTariff.Size = new Size(100, 38);
            buttonAddTariff.TabIndex = 6;
            buttonAddTariff.Text = "Добавить";
            buttonAddTariff.UseVisualStyleBackColor = true;
            buttonAddTariff.Click += buttonAddTariff_Click;
            // 
            // buttonUpdateTariff
            // 
            buttonUpdateTariff.Location = new Point(460, 699);
            buttonUpdateTariff.Margin = new Padding(3, 4, 3, 4);
            buttonUpdateTariff.Name = "buttonUpdateTariff";
            buttonUpdateTariff.Size = new Size(100, 38);
            buttonUpdateTariff.TabIndex = 7;
            buttonUpdateTariff.Text = "Обновить";
            buttonUpdateTariff.UseVisualStyleBackColor = true;
            buttonUpdateTariff.Click += buttonUpdateTariff_Click;
            // 
            // buttonDeleteTariff
            // 
            buttonDeleteTariff.Location = new Point(566, 699);
            buttonDeleteTariff.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteTariff.Name = "buttonDeleteTariff";
            buttonDeleteTariff.Size = new Size(100, 38);
            buttonDeleteTariff.TabIndex = 8;
            buttonDeleteTariff.Text = "Удалить";
            buttonDeleteTariff.UseVisualStyleBackColor = true;
            buttonDeleteTariff.Click += buttonDeleteTariff_Click;
            // 
            // buttonClearFields
            // 
            buttonClearFields.Location = new Point(672, 699);
            buttonClearFields.Margin = new Padding(3, 4, 3, 4);
            buttonClearFields.Name = "buttonClearFields";
            buttonClearFields.Size = new Size(100, 38);
            buttonClearFields.TabIndex = 9;
            buttonClearFields.Text = "Очистить поля";
            buttonClearFields.UseVisualStyleBackColor = true;
            buttonClearFields.Click += buttonClearFields_Click;
            // 
            // labelTariffName
            // 
            labelTariffName.AutoSize = true;
            labelTariffName.Location = new Point(12, 499);
            labelTariffName.Name = "labelTariffName";
            labelTariffName.Size = new Size(134, 20);
            labelTariffName.TabIndex = 10;
            labelTariffName.Text = "Название тарифа:";
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point(60, 536);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(86, 20);
            labelDiscount.TabIndex = 11;
            labelDiscount.Text = "Скидка (%):";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Location = new Point(49, 574);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(97, 20);
            labelStartDate.TabIndex = 12;
            labelStartDate.Text = "Дата начала:";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Location = new Point(22, 611);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(124, 20);
            labelEndDate.TabIndex = 13;
            labelEndDate.Text = "Дата окончания:";
            // 
            // TariffsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 750);
            Controls.Add(labelTariffName);
            Controls.Add(labelDiscount);
            Controls.Add(labelStartDate);
            Controls.Add(labelEndDate);
            Controls.Add(dataGridViewTariffs);
            Controls.Add(textBoxTariffName);
            Controls.Add(numericUpDownDiscount);
            Controls.Add(dateTimePickerStart);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(checkBoxActive);
            Controls.Add(buttonAddTariff);
            Controls.Add(buttonUpdateTariff);
            Controls.Add(buttonDeleteTariff);
            Controls.Add(buttonClearFields);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TariffsForm";
            Text = "Тарифы";
            Load += TariffsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTariffs).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelTariffName;
        private Label labelDiscount;
        private Label labelStartDate;
        private Label labelEndDate;
    }
}