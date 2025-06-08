namespace HotelCRM.Forms
{
    partial class ServicesForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewServices;
        private TextBox textBoxServiceName;
        private NumericUpDown numericUpDownPrice;
        private TextBox textBoxDescription;
        private Button buttonAddService;
        private Button buttonUpdateService;
        private Button buttonDeleteService;
        private Button buttonClearFields;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewServices = new DataGridView();
            textBoxServiceName = new TextBox();
            numericUpDownPrice = new NumericUpDown();
            textBoxDescription = new TextBox();
            buttonAddService = new Button();
            buttonUpdateService = new Button();
            buttonDeleteService = new Button();
            buttonClearFields = new Button();
            labelServiceName = new Label();
            labelPrice = new Label();
            labelDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewServices
            // 
            dataGridViewServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServices.Location = new Point(12, 15);
            dataGridViewServices.Margin = new Padding(3, 4, 3, 4);
            dataGridViewServices.Name = "dataGridViewServices";
            dataGridViewServices.RowHeadersWidth = 51;
            dataGridViewServices.RowTemplate.Height = 24;
            dataGridViewServices.Size = new Size(760, 501);
            dataGridViewServices.TabIndex = 0;
            dataGridViewServices.CellClick += dataGridViewServices_CellClick;
            // 
            // textBoxServiceName
            // 
            textBoxServiceName.Location = new Point(95, 524);
            textBoxServiceName.Margin = new Padding(3, 4, 3, 4);
            textBoxServiceName.Name = "textBoxServiceName";
            textBoxServiceName.Size = new Size(200, 27);
            textBoxServiceName.TabIndex = 1;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownPrice.Location = new Point(95, 562);
            numericUpDownPrice.Margin = new Padding(3, 4, 3, 4);
            numericUpDownPrice.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(200, 27);
            numericUpDownPrice.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(95, 599);
            textBoxDescription.Margin = new Padding(3, 4, 3, 4);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(200, 74);
            textBoxDescription.TabIndex = 3;
            // 
            // buttonAddService
            // 
            buttonAddService.Location = new Point(354, 699);
            buttonAddService.Margin = new Padding(3, 4, 3, 4);
            buttonAddService.Name = "buttonAddService";
            buttonAddService.Size = new Size(100, 38);
            buttonAddService.TabIndex = 4;
            buttonAddService.Text = "Добавить";
            buttonAddService.UseVisualStyleBackColor = true;
            buttonAddService.Click += buttonAddService_Click;
            // 
            // buttonUpdateService
            // 
            buttonUpdateService.Location = new Point(460, 699);
            buttonUpdateService.Margin = new Padding(3, 4, 3, 4);
            buttonUpdateService.Name = "buttonUpdateService";
            buttonUpdateService.Size = new Size(100, 38);
            buttonUpdateService.TabIndex = 5;
            buttonUpdateService.Text = "Обновить";
            buttonUpdateService.UseVisualStyleBackColor = true;
            buttonUpdateService.Click += buttonUpdateService_Click;
            // 
            // buttonDeleteService
            // 
            buttonDeleteService.Location = new Point(566, 699);
            buttonDeleteService.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteService.Name = "buttonDeleteService";
            buttonDeleteService.Size = new Size(100, 38);
            buttonDeleteService.TabIndex = 6;
            buttonDeleteService.Text = "Удалить";
            buttonDeleteService.UseVisualStyleBackColor = true;
            buttonDeleteService.Click += buttonDeleteService_Click;
            // 
            // buttonClearFields
            // 
            buttonClearFields.Location = new Point(672, 699);
            buttonClearFields.Margin = new Padding(3, 4, 3, 4);
            buttonClearFields.Name = "buttonClearFields";
            buttonClearFields.Size = new Size(100, 38);
            buttonClearFields.TabIndex = 7;
            buttonClearFields.Text = "Очистить поля";
            buttonClearFields.UseVisualStyleBackColor = true;
            buttonClearFields.Click += buttonClearFields_Click;
            // 
            // labelServiceName
            // 
            labelServiceName.AutoSize = true;
            labelServiceName.Location = new Point(12, 528);
            labelServiceName.Name = "labelServiceName";
            labelServiceName.Size = new Size(80, 20);
            labelServiceName.TabIndex = 0;
            labelServiceName.Text = "Название:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(44, 565);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(48, 20);
            labelPrice.TabIndex = 1;
            labelPrice.Text = "Цена:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(10, 603);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(82, 20);
            labelDescription.TabIndex = 2;
            labelDescription.Text = "Описание:";
            // 
            // ServicesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 750);
            Controls.Add(labelServiceName);
            Controls.Add(labelPrice);
            Controls.Add(labelDescription);
            Controls.Add(dataGridViewServices);
            Controls.Add(textBoxServiceName);
            Controls.Add(numericUpDownPrice);
            Controls.Add(textBoxDescription);
            Controls.Add(buttonAddService);
            Controls.Add(buttonUpdateService);
            Controls.Add(buttonDeleteService);
            Controls.Add(buttonClearFields);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ServicesForm";
            Text = "Услуги";
            Load += ServicesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelServiceName;
        private Label labelPrice;
        private Label labelDescription;
    }
}