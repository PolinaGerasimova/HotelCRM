namespace HotelCRM.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem logoutMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem dataMenuItem;
        private ToolStripMenuItem guestsMenuItem;
        private ToolStripMenuItem roomsMenuItem;
        private ToolStripMenuItem bookingsMenuItem;
        private ToolStripMenuItem reportsMenuItem;
        private ToolStripMenuItem adminMenuItem;
        private ToolStripMenuItem tariffsMenuItem;
        private ToolStripMenuItem employeesMenuItem;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel toolStripStatusLabelUser;
        private ToolStripStatusLabel toolStripStatusLabelRole;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStripMain = new MenuStrip();
            fileMenuItem = new ToolStripMenuItem();
            logoutMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            dataMenuItem = new ToolStripMenuItem();
            guestsMenuItem = new ToolStripMenuItem();
            roomsMenuItem = new ToolStripMenuItem();
            bookingsMenuItem = new ToolStripMenuItem();
            adminMenuItem = new ToolStripMenuItem();
            tariffsMenuItem = new ToolStripMenuItem();
            employeesMenuItem = new ToolStripMenuItem();
            reportsMenuItem = new ToolStripMenuItem();
            statusStripMain = new StatusStrip();
            toolStripStatusLabelUser = new ToolStripStatusLabel();
            toolStripStatusLabelRole = new ToolStripStatusLabel();
            menuStripMain.SuspendLayout();
            statusStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(20, 20);
            menuStripMain.Items.AddRange(new ToolStripItem[] { fileMenuItem, dataMenuItem, adminMenuItem, reportsMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(800, 28);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutMenuItem, exitMenuItem });
            fileMenuItem.Name = "fileMenuItem";
            fileMenuItem.Size = new Size(59, 24);
            fileMenuItem.Text = "Файл";
            // 
            // logoutMenuItem
            // 
            logoutMenuItem.Name = "logoutMenuItem";
            logoutMenuItem.Size = new Size(224, 26);
            logoutMenuItem.Text = "Выйти";
            logoutMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(224, 26);
            exitMenuItem.Text = "Выход";
            exitMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // dataMenuItem
            // 
            dataMenuItem.DropDownItems.AddRange(new ToolStripItem[] { guestsMenuItem, roomsMenuItem, bookingsMenuItem });
            dataMenuItem.Name = "dataMenuItem";
            dataMenuItem.Size = new Size(78, 24);
            dataMenuItem.Text = "Данные";
            // 
            // guestsMenuItem
            // 
            guestsMenuItem.Name = "guestsMenuItem";
            guestsMenuItem.Size = new Size(224, 26);
            guestsMenuItem.Text = "Гости";
            guestsMenuItem.Click += guestsToolStripMenuItem_Click;
            // 
            // roomsMenuItem
            // 
            roomsMenuItem.Name = "roomsMenuItem";
            roomsMenuItem.Size = new Size(224, 26);
            roomsMenuItem.Text = "Номера";
            roomsMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // bookingsMenuItem
            // 
            bookingsMenuItem.Name = "bookingsMenuItem";
            bookingsMenuItem.Size = new Size(224, 26);
            bookingsMenuItem.Text = "Бронирования";
            bookingsMenuItem.Click += bookingsToolStripMenuItem_Click;
            // 
            // adminMenuItem
            // 
            adminMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tariffsMenuItem, employeesMenuItem });
            adminMenuItem.Name = "adminMenuItem";
            adminMenuItem.Size = new Size(170, 24);
            adminMenuItem.Text = "Администрирование";
            // 
            // tariffsMenuItem
            // 
            tariffsMenuItem.Name = "tariffsMenuItem";
            tariffsMenuItem.Size = new Size(224, 26);
            tariffsMenuItem.Text = "Тарифы";
            tariffsMenuItem.Visible = false;
            // 
            // employeesMenuItem
            // 
            employeesMenuItem.Name = "employeesMenuItem";
            employeesMenuItem.Size = new Size(224, 26);
            employeesMenuItem.Text = "Сотрудники";
            employeesMenuItem.Visible = false;
            // 
            // reportsMenuItem
            // 
            reportsMenuItem.Name = "reportsMenuItem";
            reportsMenuItem.Size = new Size(73, 24);
            reportsMenuItem.Text = "Отчеты";
            reportsMenuItem.Click += reportsToolStripMenuItem_Click;
            // 
            // statusStripMain
            // 
            statusStripMain.ImageScalingSize = new Size(20, 20);
            statusStripMain.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelUser, toolStripStatusLabelRole });
            statusStripMain.Location = new Point(0, 545);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Padding = new Padding(1, 0, 19, 0);
            statusStripMain.Size = new Size(800, 26);
            statusStripMain.TabIndex = 1;
            statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUser
            // 
            toolStripStatusLabelUser.Name = "toolStripStatusLabelUser";
            toolStripStatusLabelUser.Size = new Size(114, 20);
            toolStripStatusLabelUser.Text = "Пользователь: ";
            // 
            // toolStripStatusLabelRole
            // 
            toolStripStatusLabelRole.Name = "toolStripStatusLabelRole";
            toolStripStatusLabelRole.Padding = new Padding(20, 0, 0, 0);
            toolStripStatusLabelRole.Size = new Size(69, 20);
            toolStripStatusLabelRole.Text = "Роль: ";
            toolStripStatusLabelRole.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 571);
            Controls.Add(statusStripMain);
            Controls.Add(menuStripMain);
            IsMdiContainer = true;
            MainMenuStrip = menuStripMain;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "CRM Отель - Главное меню";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}