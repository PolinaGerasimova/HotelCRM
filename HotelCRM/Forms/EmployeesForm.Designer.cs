namespace HotelCRM.Forms
{
    partial class EmployeesForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewEmployees;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxMiddleName;
        private TextBox textBoxRole;
        private TextBox textBoxPhone;
        private TextBox textBoxWorkSchedule;
        private DateTimePicker dateTimePickerHire;
        private Button buttonAddEmployee;
        private Button buttonUpdateEmployee;
        private Button buttonDeleteEmployee;
        private Button buttonClearFields;
        private TextBox textBoxSearch;
        private Button buttonSearchEmployee;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewEmployees = new DataGridView();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxMiddleName = new TextBox();
            textBoxRole = new TextBox();
            textBoxPhone = new TextBox();
            textBoxWorkSchedule = new TextBox();
            dateTimePickerHire = new DateTimePicker();
            buttonAddEmployee = new Button();
            buttonUpdateEmployee = new Button();
            buttonDeleteEmployee = new Button();
            buttonClearFields = new Button();
            textBoxSearch = new TextBox();
            buttonSearchEmployee = new Button();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelMiddleName = new Label();
            labelRole = new Label();
            labelPhone = new Label();
            labelWorkSchedule = new Label();
            labelEmploymentDate = new Label();
            labelSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(12, 15);
            dataGridViewEmployees.Margin = new Padding(3, 4, 3, 4);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowHeadersWidth = 51;
            dataGridViewEmployees.RowTemplate.Height = 24;
            dataGridViewEmployees.Size = new Size(760, 375);
            dataGridViewEmployees.TabIndex = 0;
            dataGridViewEmployees.CellClick += dataGridViewEmployees_CellClick;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(150, 400);
            textBoxFirstName.Margin = new Padding(3, 4, 3, 4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(200, 27);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(150, 438);
            textBoxLastName.Margin = new Padding(3, 4, 3, 4);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(200, 27);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxMiddleName
            // 
            textBoxMiddleName.Location = new Point(150, 475);
            textBoxMiddleName.Margin = new Padding(3, 4, 3, 4);
            textBoxMiddleName.Name = "textBoxMiddleName";
            textBoxMiddleName.Size = new Size(200, 27);
            textBoxMiddleName.TabIndex = 3;
            // 
            // textBoxRole
            // 
            textBoxRole.Location = new Point(150, 512);
            textBoxRole.Margin = new Padding(3, 4, 3, 4);
            textBoxRole.Name = "textBoxRole";
            textBoxRole.Size = new Size(200, 27);
            textBoxRole.TabIndex = 4;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(150, 550);
            textBoxPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(200, 27);
            textBoxPhone.TabIndex = 5;
            // 
            // textBoxWorkSchedule
            // 
            textBoxWorkSchedule.Location = new Point(150, 588);
            textBoxWorkSchedule.Margin = new Padding(3, 4, 3, 4);
            textBoxWorkSchedule.Multiline = true;
            textBoxWorkSchedule.Name = "textBoxWorkSchedule";
            textBoxWorkSchedule.Size = new Size(200, 74);
            textBoxWorkSchedule.TabIndex = 6;
            // 
            // dateTimePickerHire
            // 
            dateTimePickerHire.Location = new Point(150, 671);
            dateTimePickerHire.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerHire.Name = "dateTimePickerHire";
            dateTimePickerHire.Size = new Size(200, 27);
            dateTimePickerHire.TabIndex = 7;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Location = new Point(354, 699);
            buttonAddEmployee.Margin = new Padding(3, 4, 3, 4);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(100, 38);
            buttonAddEmployee.TabIndex = 8;
            buttonAddEmployee.Text = "Добавить";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            buttonAddEmployee.Click += buttonAddEmployee_Click;
            // 
            // buttonUpdateEmployee
            // 
            buttonUpdateEmployee.Location = new Point(672, 699);
            buttonUpdateEmployee.Margin = new Padding(3, 4, 3, 4);
            buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            buttonUpdateEmployee.Size = new Size(100, 38);
            buttonUpdateEmployee.TabIndex = 9;
            buttonUpdateEmployee.Text = "Обновить";
            buttonUpdateEmployee.UseVisualStyleBackColor = true;
            buttonUpdateEmployee.Click += buttonUpdateEmployee_Click;
            // 
            // buttonDeleteEmployee
            // 
            buttonDeleteEmployee.Location = new Point(460, 699);
            buttonDeleteEmployee.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            buttonDeleteEmployee.Size = new Size(100, 38);
            buttonDeleteEmployee.TabIndex = 10;
            buttonDeleteEmployee.Text = "Удалить";
            buttonDeleteEmployee.UseVisualStyleBackColor = true;
            buttonDeleteEmployee.Click += buttonDeleteEmployee_Click;
            // 
            // buttonClearFields
            // 
            buttonClearFields.Location = new Point(566, 699);
            buttonClearFields.Margin = new Padding(3, 4, 3, 4);
            buttonClearFields.Name = "buttonClearFields";
            buttonClearFields.Size = new Size(100, 38);
            buttonClearFields.TabIndex = 11;
            buttonClearFields.Text = "Очистить поля";
            buttonClearFields.UseVisualStyleBackColor = true;
            buttonClearFields.Click += buttonClearFields_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(572, 404);
            textBoxSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(200, 27);
            textBoxSearch.TabIndex = 12;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonSearchEmployee
            // 
            buttonSearchEmployee.Location = new Point(672, 451);
            buttonSearchEmployee.Margin = new Padding(3, 4, 3, 4);
            buttonSearchEmployee.Name = "buttonSearchEmployee";
            buttonSearchEmployee.Size = new Size(100, 38);
            buttonSearchEmployee.TabIndex = 13;
            buttonSearchEmployee.Text = "Поиск";
            buttonSearchEmployee.UseVisualStyleBackColor = true;
            buttonSearchEmployee.Click += buttonSearchEmployee_Click;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(105, 404);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(42, 20);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "Имя:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(71, 441);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(76, 20);
            labelLastName.TabIndex = 1;
            labelLastName.Text = "Фамилия:";
            // 
            // labelMiddleName
            // 
            labelMiddleName.AutoSize = true;
            labelMiddleName.Location = new Point(72, 479);
            labelMiddleName.Name = "labelMiddleName";
            labelMiddleName.Size = new Size(75, 20);
            labelMiddleName.TabIndex = 2;
            labelMiddleName.Text = "Отчество:";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(102, 516);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(45, 20);
            labelRole.TabIndex = 3;
            labelRole.Text = "Роль:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(75, 554);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(72, 20);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Телефон:";
            // 
            // labelWorkSchedule
            // 
            labelWorkSchedule.AutoSize = true;
            labelWorkSchedule.Location = new Point(29, 591);
            labelWorkSchedule.Name = "labelWorkSchedule";
            labelWorkSchedule.Size = new Size(118, 20);
            labelWorkSchedule.TabIndex = 5;
            labelWorkSchedule.Text = "График работы:";
            // 
            // labelEmploymentDate
            // 
            labelEmploymentDate.AutoSize = true;
            labelEmploymentDate.Location = new Point(54, 675);
            labelEmploymentDate.Name = "labelEmploymentDate";
            labelEmploymentDate.Size = new Size(93, 20);
            labelEmploymentDate.TabIndex = 6;
            labelEmploymentDate.Text = "Дата найма:";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(511, 407);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(55, 20);
            labelSearch.TabIndex = 7;
            labelSearch.Text = "Поиск:";
            labelSearch.Click += labelSearch_Click;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 750);
            Controls.Add(labelFirstName);
            Controls.Add(labelLastName);
            Controls.Add(labelMiddleName);
            Controls.Add(labelRole);
            Controls.Add(labelPhone);
            Controls.Add(labelWorkSchedule);
            Controls.Add(labelEmploymentDate);
            Controls.Add(labelSearch);
            Controls.Add(dataGridViewEmployees);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxMiddleName);
            Controls.Add(textBoxRole);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxWorkSchedule);
            Controls.Add(dateTimePickerHire);
            Controls.Add(buttonAddEmployee);
            Controls.Add(buttonUpdateEmployee);
            Controls.Add(buttonDeleteEmployee);
            Controls.Add(buttonClearFields);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonSearchEmployee);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeesForm";
            Text = "Сотрудники";
            Load += EmployeesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelFirstName;
        private Label labelLastName;
        private Label labelMiddleName;
        private Label labelRole;
        private Label labelPhone;
        private Label labelWorkSchedule;
        private Label labelEmploymentDate;
        private Label labelSearch;
    }
}