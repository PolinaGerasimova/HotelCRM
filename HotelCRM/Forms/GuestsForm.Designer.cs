namespace HotelCRM.Forms
{
    partial class GuestsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewGuests;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private TextBox textBoxMiddleName;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxPassportSeries;
        private TextBox textBoxPassportNumber;
        private TextBox textBoxPassportIssuedBy;
        private TextBox textBoxEmail;
        private TextBox textBoxNotes;
        private DateTimePicker dateTimePickerPassportIssueDate;
        private DateTimePicker dateTimePickerBirthDate;
        private Button buttonAddGuest;
        private Button buttonUpdateGuest;
        private Button buttonDeleteGuest;
        private Button buttonClearFields;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewGuests = new DataGridView();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxMiddleName = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxPassportSeries = new TextBox();
            textBoxPassportNumber = new TextBox();
            textBoxPassportIssuedBy = new TextBox();
            textBoxEmail = new TextBox();
            textBoxNotes = new TextBox();
            dateTimePickerPassportIssueDate = new DateTimePicker();
            dateTimePickerBirthDate = new DateTimePicker();
            buttonAddGuest = new Button();
            buttonUpdateGuest = new Button();
            buttonDeleteGuest = new Button();
            buttonClearFields = new Button();
            labelLastName = new Label();
            labelFirstName = new Label();
            labelMiddleName = new Label();
            labelPhoneNumber = new Label();
            labelPassportSeries = new Label();
            labelPassportNumber = new Label();
            labelPassportIssuedBy = new Label();
            labelEmail = new Label();
            labelNotes = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewGuests
            // 
            dataGridViewGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGuests.Location = new Point(12, 12);
            dataGridViewGuests.Name = "dataGridViewGuests";
            dataGridViewGuests.RowHeadersWidth = 51;
            dataGridViewGuests.RowTemplate.Height = 24;
            dataGridViewGuests.Size = new Size(760, 300);
            dataGridViewGuests.TabIndex = 0;
            dataGridViewGuests.CellClick += dataGridViewGuests_CellClick;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(120, 400);
            textBoxLastName.Margin = new Padding(3, 4, 3, 4);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(200, 27);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(120, 438);
            textBoxFirstName.Margin = new Padding(3, 4, 3, 4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(200, 27);
            textBoxFirstName.TabIndex = 2;
            // 
            // textBoxMiddleName
            // 
            textBoxMiddleName.Location = new Point(120, 475);
            textBoxMiddleName.Margin = new Padding(3, 4, 3, 4);
            textBoxMiddleName.Name = "textBoxMiddleName";
            textBoxMiddleName.Size = new Size(200, 27);
            textBoxMiddleName.TabIndex = 3;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(120, 512);
            textBoxPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(200, 27);
            textBoxPhoneNumber.TabIndex = 4;
            // 
            // textBoxPassportSeries
            // 
            textBoxPassportSeries.Location = new Point(120, 550);
            textBoxPassportSeries.Margin = new Padding(3, 4, 3, 4);
            textBoxPassportSeries.Name = "textBoxPassportSeries";
            textBoxPassportSeries.Size = new Size(200, 27);
            textBoxPassportSeries.TabIndex = 5;
            // 
            // textBoxPassportNumber
            // 
            textBoxPassportNumber.Location = new Point(120, 588);
            textBoxPassportNumber.Margin = new Padding(3, 4, 3, 4);
            textBoxPassportNumber.Name = "textBoxPassportNumber";
            textBoxPassportNumber.Size = new Size(200, 27);
            textBoxPassportNumber.TabIndex = 6;
            // 
            // textBoxPassportIssuedBy
            // 
            textBoxPassportIssuedBy.Location = new Point(120, 625);
            textBoxPassportIssuedBy.Margin = new Padding(3, 4, 3, 4);
            textBoxPassportIssuedBy.Name = "textBoxPassportIssuedBy";
            textBoxPassportIssuedBy.Size = new Size(200, 27);
            textBoxPassportIssuedBy.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(120, 662);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(200, 27);
            textBoxEmail.TabIndex = 8;
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(120, 700);
            textBoxNotes.Margin = new Padding(3, 4, 3, 4);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(200, 74);
            textBoxNotes.TabIndex = 9;
            // 
            // dateTimePickerPassportIssueDate
            // 
            dateTimePickerPassportIssueDate.Location = new Point(120, 782);
            dateTimePickerPassportIssueDate.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerPassportIssueDate.Name = "dateTimePickerPassportIssueDate";
            dateTimePickerPassportIssueDate.Size = new Size(200, 27);
            dateTimePickerPassportIssueDate.TabIndex = 10;
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Location = new Point(120, 825);
            dateTimePickerBirthDate.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(200, 27);
            dateTimePickerBirthDate.TabIndex = 11;
            // 
            // buttonAddGuest
            // 
            buttonAddGuest.Location = new Point(366, 761);
            buttonAddGuest.Margin = new Padding(3, 4, 3, 4);
            buttonAddGuest.Name = "buttonAddGuest";
            buttonAddGuest.Size = new Size(90, 38);
            buttonAddGuest.TabIndex = 12;
            buttonAddGuest.Text = "Добавить";
            buttonAddGuest.UseVisualStyleBackColor = true;
            buttonAddGuest.Click += buttonAddGuest_Click;
            // 
            // buttonUpdateGuest
            // 
            buttonUpdateGuest.Location = new Point(462, 761);
            buttonUpdateGuest.Margin = new Padding(3, 4, 3, 4);
            buttonUpdateGuest.Name = "buttonUpdateGuest";
            buttonUpdateGuest.Size = new Size(90, 38);
            buttonUpdateGuest.TabIndex = 13;
            buttonUpdateGuest.Text = "Обновить";
            buttonUpdateGuest.UseVisualStyleBackColor = true;
            buttonUpdateGuest.Click += buttonUpdateGuest_Click;
            // 
            // buttonDeleteGuest
            // 
            buttonDeleteGuest.Location = new Point(558, 761);
            buttonDeleteGuest.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteGuest.Name = "buttonDeleteGuest";
            buttonDeleteGuest.Size = new Size(90, 38);
            buttonDeleteGuest.TabIndex = 14;
            buttonDeleteGuest.Text = "Удалить";
            buttonDeleteGuest.UseVisualStyleBackColor = true;
            buttonDeleteGuest.Click += buttonDeleteGuest_Click;
            // 
            // buttonClearFields
            // 
            buttonClearFields.Location = new Point(698, 761);
            buttonClearFields.Margin = new Padding(3, 4, 3, 4);
            buttonClearFields.Name = "buttonClearFields";
            buttonClearFields.Size = new Size(90, 38);
            buttonClearFields.TabIndex = 15;
            buttonClearFields.Text = "Очистить поля";
            buttonClearFields.UseVisualStyleBackColor = true;
            buttonClearFields.Click += buttonClearFields_Click;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(12, 404);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(76, 20);
            labelLastName.TabIndex = 0;
            labelLastName.Text = "Фамилия:";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(12, 441);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(42, 20);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "Имя:";
            // 
            // labelMiddleName
            // 
            labelMiddleName.AutoSize = true;
            labelMiddleName.Location = new Point(12, 479);
            labelMiddleName.Name = "labelMiddleName";
            labelMiddleName.Size = new Size(75, 20);
            labelMiddleName.TabIndex = 2;
            labelMiddleName.Text = "Отчество:";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(12, 516);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(72, 20);
            labelPhoneNumber.TabIndex = 3;
            labelPhoneNumber.Text = "Телефон:";
            // 
            // labelPassportSeries
            // 
            labelPassportSeries.AutoSize = true;
            labelPassportSeries.Location = new Point(12, 554);
            labelPassportSeries.Name = "labelPassportSeries";
            labelPassportSeries.Size = new Size(124, 20);
            labelPassportSeries.TabIndex = 4;
            labelPassportSeries.Text = "Серия паспорта:";
            // 
            // labelPassportNumber
            // 
            labelPassportNumber.AutoSize = true;
            labelPassportNumber.Location = new Point(12, 591);
            labelPassportNumber.Name = "labelPassportNumber";
            labelPassportNumber.Size = new Size(129, 20);
            labelPassportNumber.TabIndex = 5;
            labelPassportNumber.Text = "Номер паспорта:";
            // 
            // labelPassportIssuedBy
            // 
            labelPassportIssuedBy.AutoSize = true;
            labelPassportIssuedBy.Location = new Point(12, 629);
            labelPassportIssuedBy.Name = "labelPassportIssuedBy";
            labelPassportIssuedBy.Size = new Size(88, 20);
            labelPassportIssuedBy.TabIndex = 6;
            labelPassportIssuedBy.Text = "Кем выдан:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(12, 666);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 20);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "Email:";
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Location = new Point(12, 704);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(102, 20);
            labelNotes.TabIndex = 8;
            labelNotes.Text = "Примечания:";
            // 
            // GuestsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 812);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(labelMiddleName);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelPassportSeries);
            Controls.Add(labelPassportNumber);
            Controls.Add(labelPassportIssuedBy);
            Controls.Add(labelEmail);
            Controls.Add(labelNotes);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxMiddleName);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxPassportSeries);
            Controls.Add(textBoxPassportNumber);
            Controls.Add(textBoxPassportIssuedBy);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNotes);
            Controls.Add(dateTimePickerPassportIssueDate);
            Controls.Add(dateTimePickerBirthDate);
            Controls.Add(buttonAddGuest);
            Controls.Add(buttonUpdateGuest);
            Controls.Add(buttonDeleteGuest);
            Controls.Add(buttonClearFields);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GuestsForm";
            Text = "Гости";
            Load += GuestsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelLastName;
        private Label labelFirstName;
        private Label labelMiddleName;
        private Label labelPhoneNumber;
        private Label labelPassportSeries;
        private Label labelPassportNumber;
        private Label labelPassportIssuedBy;
        private Label labelEmail;
        private Label labelNotes;
    }
}