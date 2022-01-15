namespace cursach
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новийФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиВибраніЯкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Operations = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.друкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокФІОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вибраніПрофіліToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допомогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfEntrance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EducationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.Filter_button = new System.Windows.Forms.Button();
            this.resetFiltersButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.openedFileName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Close_button = new System.Windows.Forms.Button();
            this.Search_question = new System.Windows.Forms.PictureBox();
            this.Filter_question = new System.Windows.Forms.PictureBox();
            this.Group_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Speciality_label = new System.Windows.Forms.Label();
            this.PaymentType_comboBox = new System.Windows.Forms.ComboBox();
            this.EducationType_comboBox = new System.Windows.Forms.ComboBox();
            this.PaymentType_label = new System.Windows.Forms.Label();
            this.EducationType_label = new System.Windows.Forms.Label();
            this.openedFileName_question = new System.Windows.Forms.PictureBox();
            this.Group_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.YearOfEntrance_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Speciality_button = new System.Windows.Forms.Button();
            this.YearOfEntrance_button = new System.Windows.Forms.Button();
            this.Group_button = new System.Windows.Forms.Button();
            this.EducationType_button = new System.Windows.Forms.Button();
            this.PaymentType_button = new System.Windows.Forms.Button();
            this.Speciality_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainFormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search_question)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filter_question)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openedFileName_question)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.Operations,
            this.друкToolStripMenuItem,
            this.допомогаToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(64, 38);
            this.Menu.MaximumSize = new System.Drawing.Size(700, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(331, 31);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новийФайлToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.зберегтиВибраніЯкToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новийФайлToolStripMenuItem
            // 
            this.новийФайлToolStripMenuItem.Image = global::cursach.Properties.Resources._new;
            this.новийФайлToolStripMenuItem.Name = "новийФайлToolStripMenuItem";
            this.новийФайлToolStripMenuItem.Size = new System.Drawing.Size(254, 28);
            this.новийФайлToolStripMenuItem.Text = "Новий файл";
            this.новийФайлToolStripMenuItem.Click += new System.EventHandler(this.новийФайлToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = global::cursach.Properties.Resources.open;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(254, 28);
            this.открытьToolStripMenuItem.Text = "Відкрити";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = global::cursach.Properties.Resources.pngwing_com__1_;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(254, 28);
            this.сохранитьToolStripMenuItem.Text = "Зберегти";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(254, 28);
            this.сохранитьКакToolStripMenuItem.Text = "Зберегти як";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // зберегтиВибраніЯкToolStripMenuItem
            // 
            this.зберегтиВибраніЯкToolStripMenuItem.Image = global::cursach.Properties.Resources.save_all;
            this.зберегтиВибраніЯкToolStripMenuItem.Name = "зберегтиВибраніЯкToolStripMenuItem";
            this.зберегтиВибраніЯкToolStripMenuItem.Size = new System.Drawing.Size(254, 28);
            this.зберегтиВибраніЯкToolStripMenuItem.Text = "Зберегти вибрані як";
            this.зберегтиВибраніЯкToolStripMenuItem.Click += new System.EventHandler(this.зберегтиВибраніЯкToolStripMenuItem_Click);
            // 
            // Operations
            // 
            this.Operations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.видалитиToolStripMenuItem});
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(93, 27);
            this.Operations.Text = "Операції";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::cursach.Properties.Resources.add;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.addToolStripMenuItem.Text = "Створити";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::cursach.Properties.Resources.edit;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.editToolStripMenuItem.Text = "Змінити";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Image = global::cursach.Properties.Resources.delete;
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
            // 
            // друкToolStripMenuItem
            // 
            this.друкToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокФІОToolStripMenuItem,
            this.вибраніПрофіліToolStripMenuItem});
            this.друкToolStripMenuItem.Name = "друкToolStripMenuItem";
            this.друкToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.друкToolStripMenuItem.Text = "Друк";
            // 
            // списокФІОToolStripMenuItem
            // 
            this.списокФІОToolStripMenuItem.Image = global::cursach.Properties.Resources.printer;
            this.списокФІОToolStripMenuItem.Name = "списокФІОToolStripMenuItem";
            this.списокФІОToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.списокФІОToolStripMenuItem.Text = "Список ПІБ";
            this.списокФІОToolStripMenuItem.Click += new System.EventHandler(this.списокФІОToolStripMenuItem_Click);
            // 
            // вибраніПрофіліToolStripMenuItem
            // 
            this.вибраніПрофіліToolStripMenuItem.Image = global::cursach.Properties.Resources.printer_filled_tool_for_print_button;
            this.вибраніПрофіліToolStripMenuItem.Name = "вибраніПрофіліToolStripMenuItem";
            this.вибраніПрофіліToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.вибраніПрофіліToolStripMenuItem.Text = "Список профілей";
            this.вибраніПрофіліToolStripMenuItem.Click += new System.EventHandler(this.вибраніПрофіліToolStripMenuItem_Click);
            // 
            // допомогаToolStripMenuItem
            // 
            this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(104, 27);
            this.допомогаToolStripMenuItem.Text = "Допомога";
            this.допомогаToolStripMenuItem.Click += new System.EventHandler(this.допомогаToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SecondName,
            this.FirstName,
            this.LastName,
            this.Sex,
            this.Birthdate,
            this.Address,
            this.PhoneNumber,
            this.Passport,
            this.Parent,
            this.Speciality,
            this.YearOfEntrance,
            this.Group,
            this.EducationType,
            this.PaymentType});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(64, 150);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(573, 416);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.TabStop = false;
            // 
            // SecondName
            // 
            this.SecondName.DataPropertyName = "LastName";
            this.SecondName.HeaderText = "Прізвище";
            this.SecondName.MinimumWidth = 6;
            this.SecondName.Name = "SecondName";
            this.SecondName.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Ім\'я";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "SecondName";
            this.LastName.HeaderText = "Побатькові";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "Стать";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.Width = 125;
            // 
            // Birthdate
            // 
            this.Birthdate.DataPropertyName = "Birthdate";
            this.Birthdate.HeaderText = "Дата народження";
            this.Birthdate.MinimumWidth = 6;
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Width = 125;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Адреса";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Телефонний номер";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 125;
            // 
            // Passport
            // 
            this.Passport.DataPropertyName = "Passport";
            this.Passport.HeaderText = "Паспорт серія №";
            this.Passport.MinimumWidth = 6;
            this.Passport.Name = "Passport";
            this.Passport.Width = 125;
            // 
            // Parent
            // 
            this.Parent.DataPropertyName = "Parent";
            this.Parent.HeaderText = "Родич/опікун";
            this.Parent.MinimumWidth = 6;
            this.Parent.Name = "Parent";
            this.Parent.Width = 125;
            // 
            // Speciality
            // 
            this.Speciality.DataPropertyName = "Speciality";
            this.Speciality.HeaderText = "Спеціальність";
            this.Speciality.MinimumWidth = 6;
            this.Speciality.Name = "Speciality";
            this.Speciality.Width = 125;
            // 
            // YearOfEntrance
            // 
            this.YearOfEntrance.DataPropertyName = "YearOfEntrance";
            this.YearOfEntrance.HeaderText = "Рік вступу";
            this.YearOfEntrance.MinimumWidth = 6;
            this.YearOfEntrance.Name = "YearOfEntrance";
            this.YearOfEntrance.Width = 125;
            // 
            // Group
            // 
            this.Group.DataPropertyName = "Group";
            this.Group.HeaderText = "Група";
            this.Group.MinimumWidth = 6;
            this.Group.Name = "Group";
            this.Group.Width = 125;
            // 
            // EducationType
            // 
            this.EducationType.DataPropertyName = "EducationType";
            this.EducationType.HeaderText = "Форма навчання";
            this.EducationType.MinimumWidth = 6;
            this.EducationType.Name = "EducationType";
            this.EducationType.Width = 125;
            // 
            // PaymentType
            // 
            this.PaymentType.DataPropertyName = "PaymentType";
            this.PaymentType.HeaderText = "Форма оплати";
            this.PaymentType.MinimumWidth = 6;
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.Width = 125;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(803, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фільтри";
            // 
            // Filter_button
            // 
            this.Filter_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Filter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filter_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Filter_button.Location = new System.Drawing.Point(766, 513);
            this.Filter_button.Name = "Filter_button";
            this.Filter_button.Size = new System.Drawing.Size(168, 48);
            this.Filter_button.TabIndex = 7;
            this.Filter_button.TabStop = false;
            this.Filter_button.Text = "Фільтрувати";
            this.Filter_button.UseVisualStyleBackColor = false;
            this.Filter_button.Click += new System.EventHandler(this.ФільтруватиButton_Click);
            // 
            // resetFiltersButton
            // 
            this.resetFiltersButton.Location = new System.Drawing.Point(766, 579);
            this.resetFiltersButton.Name = "resetFiltersButton";
            this.resetFiltersButton.Size = new System.Drawing.Size(168, 33);
            this.resetFiltersButton.TabIndex = 30;
            this.resetFiltersButton.TabStop = false;
            this.resetFiltersButton.Text = "Скинути фільтри";
            this.resetFiltersButton.UseVisualStyleBackColor = true;
            this.resetFiltersButton.Click += new System.EventHandler(this.resetFiltersButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(64, 83);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(446, 26);
            this.searchTextBox.TabIndex = 31;
            this.searchTextBox.TabStop = false;
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_button.Location = new System.Drawing.Point(508, 80);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(129, 33);
            this.Search_button.TabIndex = 32;
            this.Search_button.TabStop = false;
            this.Search_button.Text = "Пошук";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // openedFileName
            // 
            this.openedFileName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.openedFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openedFileName.Location = new System.Drawing.Point(64, 120);
            this.openedFileName.Name = "openedFileName";
            this.openedFileName.ReadOnly = true;
            this.openedFileName.Size = new System.Drawing.Size(573, 26);
            this.openedFileName.TabIndex = 33;
            this.openedFileName.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Close_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 35);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Облік студентів";
            // 
            // Close_button
            // 
            this.Close_button.Image = global::cursach.Properties.Resources.изображение_2020_12_17_230528;
            this.Close_button.Location = new System.Drawing.Point(1028, 3);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(28, 29);
            this.Close_button.TabIndex = 0;
            this.Close_button.TabStop = false;
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Search_question
            // 
            this.Search_question.Image = global::cursach.Properties.Resources.pngwing_com__2_;
            this.Search_question.Location = new System.Drawing.Point(643, 80);
            this.Search_question.Name = "Search_question";
            this.Search_question.Size = new System.Drawing.Size(30, 29);
            this.Search_question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Search_question.TabIndex = 35;
            this.Search_question.TabStop = false;
            this.Search_question.Click += new System.EventHandler(this.Search_question_Click);
            // 
            // Filter_question
            // 
            this.Filter_question.Image = global::cursach.Properties.Resources.pngwing_com__2_;
            this.Filter_question.Location = new System.Drawing.Point(940, 522);
            this.Filter_question.Name = "Filter_question";
            this.Filter_question.Size = new System.Drawing.Size(30, 29);
            this.Filter_question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Filter_question.TabIndex = 36;
            this.Filter_question.TabStop = false;
            this.Filter_question.Click += new System.EventHandler(this.Filter_question_Click);
            // 
            // Group_label
            // 
            this.Group_label.AutoSize = true;
            this.Group_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Group_label.Location = new System.Drawing.Point(752, 287);
            this.Group_label.Name = "Group_label";
            this.Group_label.Size = new System.Drawing.Size(57, 20);
            this.Group_label.TabIndex = 42;
            this.Group_label.Text = "Група";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(716, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "Рік вступу";
            // 
            // Speciality_label
            // 
            this.Speciality_label.AutoSize = true;
            this.Speciality_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Speciality_label.Location = new System.Drawing.Point(681, 180);
            this.Speciality_label.Name = "Speciality_label";
            this.Speciality_label.Size = new System.Drawing.Size(128, 20);
            this.Speciality_label.TabIndex = 48;
            this.Speciality_label.Text = "Спеціальність";
            // 
            // PaymentType_comboBox
            // 
            this.PaymentType_comboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PaymentType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentType_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentType_comboBox.FormattingEnabled = true;
            this.PaymentType_comboBox.Items.AddRange(new object[] {
            "Контракт",
            "Бюджет",
            "Стипендія",
            "Підвищена стипендія"});
            this.PaymentType_comboBox.Location = new System.Drawing.Point(833, 423);
            this.PaymentType_comboBox.MaxLength = 30;
            this.PaymentType_comboBox.Name = "PaymentType_comboBox";
            this.PaymentType_comboBox.Size = new System.Drawing.Size(159, 33);
            this.PaymentType_comboBox.TabIndex = 50;
            this.PaymentType_comboBox.TabStop = false;
            // 
            // EducationType_comboBox
            // 
            this.EducationType_comboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EducationType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EducationType_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EducationType_comboBox.FormattingEnabled = true;
            this.EducationType_comboBox.Items.AddRange(new object[] {
            "Очна",
            "Заочна",
            "Прискорена"});
            this.EducationType_comboBox.Location = new System.Drawing.Point(833, 368);
            this.EducationType_comboBox.MaxLength = 30;
            this.EducationType_comboBox.Name = "EducationType_comboBox";
            this.EducationType_comboBox.Size = new System.Drawing.Size(159, 33);
            this.EducationType_comboBox.TabIndex = 49;
            this.EducationType_comboBox.TabStop = false;
            // 
            // PaymentType_label
            // 
            this.PaymentType_label.AutoSize = true;
            this.PaymentType_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentType_label.Location = new System.Drawing.Point(677, 430);
            this.PaymentType_label.Name = "PaymentType_label";
            this.PaymentType_label.Size = new System.Drawing.Size(132, 20);
            this.PaymentType_label.TabIndex = 52;
            this.PaymentType_label.Text = "Форма оплати";
            // 
            // EducationType_label
            // 
            this.EducationType_label.AutoSize = true;
            this.EducationType_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EducationType_label.Location = new System.Drawing.Point(659, 375);
            this.EducationType_label.Name = "EducationType_label";
            this.EducationType_label.Size = new System.Drawing.Size(152, 20);
            this.EducationType_label.TabIndex = 51;
            this.EducationType_label.Text = "Форма навчання";
            // 
            // openedFileName_question
            // 
            this.openedFileName_question.Image = global::cursach.Properties.Resources.pngwing_com__2_;
            this.openedFileName_question.Location = new System.Drawing.Point(643, 117);
            this.openedFileName_question.Name = "openedFileName_question";
            this.openedFileName_question.Size = new System.Drawing.Size(30, 29);
            this.openedFileName_question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.openedFileName_question.TabIndex = 54;
            this.openedFileName_question.TabStop = false;
            this.openedFileName_question.Click += new System.EventHandler(this.openedFileName_question_Click);
            // 
            // Group_maskedTextBox
            // 
            this.Group_maskedTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Group_maskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Group_maskedTextBox.Location = new System.Drawing.Point(833, 280);
            this.Group_maskedTextBox.Mask = "09";
            this.Group_maskedTextBox.Name = "Group_maskedTextBox";
            this.Group_maskedTextBox.Size = new System.Drawing.Size(159, 30);
            this.Group_maskedTextBox.TabIndex = 56;
            this.Group_maskedTextBox.TabStop = false;
            this.Group_maskedTextBox.ValidatingType = typeof(int);
            // 
            // YearOfEntrance_maskedTextBox
            // 
            this.YearOfEntrance_maskedTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.YearOfEntrance_maskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearOfEntrance_maskedTextBox.Location = new System.Drawing.Point(833, 227);
            this.YearOfEntrance_maskedTextBox.Mask = "0000";
            this.YearOfEntrance_maskedTextBox.Name = "YearOfEntrance_maskedTextBox";
            this.YearOfEntrance_maskedTextBox.Size = new System.Drawing.Size(159, 30);
            this.YearOfEntrance_maskedTextBox.TabIndex = 57;
            this.YearOfEntrance_maskedTextBox.TabStop = false;
            this.YearOfEntrance_maskedTextBox.ValidatingType = typeof(int);
            // 
            // Speciality_button
            // 
            this.Speciality_button.BackgroundImage = global::cursach.Properties.Resources.clear;
            this.Speciality_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Speciality_button.Location = new System.Drawing.Point(998, 173);
            this.Speciality_button.Name = "Speciality_button";
            this.Speciality_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Speciality_button.Size = new System.Drawing.Size(29, 30);
            this.Speciality_button.TabIndex = 58;
            this.Speciality_button.TabStop = false;
            this.Speciality_button.UseVisualStyleBackColor = true;
            this.Speciality_button.Click += new System.EventHandler(this.Speciality_button_Click);
            // 
            // YearOfEntrance_button
            // 
            this.YearOfEntrance_button.BackgroundImage = global::cursach.Properties.Resources.clear;
            this.YearOfEntrance_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.YearOfEntrance_button.Location = new System.Drawing.Point(998, 227);
            this.YearOfEntrance_button.Name = "YearOfEntrance_button";
            this.YearOfEntrance_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.YearOfEntrance_button.Size = new System.Drawing.Size(29, 30);
            this.YearOfEntrance_button.TabIndex = 59;
            this.YearOfEntrance_button.TabStop = false;
            this.YearOfEntrance_button.UseVisualStyleBackColor = true;
            this.YearOfEntrance_button.Click += new System.EventHandler(this.YearOfEntrance_button_Click);
            // 
            // Group_button
            // 
            this.Group_button.BackgroundImage = global::cursach.Properties.Resources.clear;
            this.Group_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Group_button.Location = new System.Drawing.Point(998, 280);
            this.Group_button.Name = "Group_button";
            this.Group_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Group_button.Size = new System.Drawing.Size(29, 30);
            this.Group_button.TabIndex = 60;
            this.Group_button.TabStop = false;
            this.Group_button.UseVisualStyleBackColor = true;
            this.Group_button.Click += new System.EventHandler(this.Grroup_button_Click);
            // 
            // EducationType_button
            // 
            this.EducationType_button.BackgroundImage = global::cursach.Properties.Resources.clear;
            this.EducationType_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EducationType_button.Location = new System.Drawing.Point(998, 368);
            this.EducationType_button.Name = "EducationType_button";
            this.EducationType_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EducationType_button.Size = new System.Drawing.Size(29, 30);
            this.EducationType_button.TabIndex = 61;
            this.EducationType_button.TabStop = false;
            this.EducationType_button.UseVisualStyleBackColor = true;
            this.EducationType_button.Click += new System.EventHandler(this.EducationType_button_Click);
            // 
            // PaymentType_button
            // 
            this.PaymentType_button.BackgroundImage = global::cursach.Properties.Resources.clear;
            this.PaymentType_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PaymentType_button.Location = new System.Drawing.Point(998, 423);
            this.PaymentType_button.Name = "PaymentType_button";
            this.PaymentType_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PaymentType_button.Size = new System.Drawing.Size(29, 30);
            this.PaymentType_button.TabIndex = 62;
            this.PaymentType_button.TabStop = false;
            this.PaymentType_button.UseVisualStyleBackColor = true;
            this.PaymentType_button.Click += new System.EventHandler(this.PaymentType_button_Click);
            // 
            // Speciality_maskedTextBox
            // 
            this.Speciality_maskedTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Speciality_maskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Speciality_maskedTextBox.Location = new System.Drawing.Point(833, 173);
            this.Speciality_maskedTextBox.Mask = "LL????????";
            this.Speciality_maskedTextBox.Name = "Speciality_maskedTextBox";
            this.Speciality_maskedTextBox.Size = new System.Drawing.Size(159, 30);
            this.Speciality_maskedTextBox.TabIndex = 63;
            this.Speciality_maskedTextBox.TabStop = false;
            this.Speciality_maskedTextBox.ValidatingType = typeof(int);
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(64, 563);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(190, 57);
            this.Add_button.TabIndex = 64;
            this.Add_button.TabStop = false;
            this.Add_button.Text = "Створити";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_button.Location = new System.Drawing.Point(250, 563);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(190, 57);
            this.Edit_button.TabIndex = 65;
            this.Edit_button.TabStop = false;
            this.Edit_button.Text = "Змінити";
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(436, 563);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(190, 57);
            this.Delete_button.TabIndex = 66;
            this.Delete_button.TabStop = false;
            this.Delete_button.Text = "Видалити";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(cursach.MainForm);
            // 
            // mainFormBindingSource1
            // 
            this.mainFormBindingSource1.DataSource = typeof(cursach.MainForm);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1068, 652);
            this.ControlBox = false;
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Speciality_maskedTextBox);
            this.Controls.Add(this.PaymentType_button);
            this.Controls.Add(this.EducationType_button);
            this.Controls.Add(this.Group_button);
            this.Controls.Add(this.YearOfEntrance_button);
            this.Controls.Add(this.Speciality_button);
            this.Controls.Add(this.YearOfEntrance_maskedTextBox);
            this.Controls.Add(this.Group_maskedTextBox);
            this.Controls.Add(this.openedFileName_question);
            this.Controls.Add(this.PaymentType_comboBox);
            this.Controls.Add(this.EducationType_comboBox);
            this.Controls.Add(this.PaymentType_label);
            this.Controls.Add(this.EducationType_label);
            this.Controls.Add(this.Speciality_label);
            this.Controls.Add(this.Group_label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Filter_question);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Search_question);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.openedFileName);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.resetFiltersButton);
            this.Controls.Add(this.Filter_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Довідник командира";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search_question)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filter_question)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openedFileName_question)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Operations;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mainFormBindingSource;
        private System.Windows.Forms.BindingSource mainFormBindingSource1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Filter_button;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.Button resetFiltersButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.ToolStripMenuItem новийФайлToolStripMenuItem;
        private System.Windows.Forms.TextBox openedFileName;
        private System.Windows.Forms.ToolStripMenuItem зберегтиВибраніЯкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem друкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокФІОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вибраніПрофіліToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.PictureBox Search_question;
        private System.Windows.Forms.PictureBox Filter_question;
        private System.Windows.Forms.Label Group_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Speciality_label;
        private System.Windows.Forms.ComboBox PaymentType_comboBox;
        private System.Windows.Forms.ComboBox EducationType_comboBox;
        private System.Windows.Forms.Label PaymentType_label;
        private System.Windows.Forms.Label EducationType_label;
        private System.Windows.Forms.PictureBox openedFileName_question;
        private System.Windows.Forms.MaskedTextBox Group_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox YearOfEntrance_maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Speciality_button;
        private System.Windows.Forms.Button YearOfEntrance_button;
        private System.Windows.Forms.Button Group_button;
        private System.Windows.Forms.Button EducationType_button;
        private System.Windows.Forms.Button PaymentType_button;
        private System.Windows.Forms.MaskedTextBox Speciality_maskedTextBox;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfEntrance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn EducationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
        private System.Windows.Forms.ToolStripMenuItem допомогаToolStripMenuItem;
    }
}

