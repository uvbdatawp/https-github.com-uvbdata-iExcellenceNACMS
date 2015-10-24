namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AppTab = new System.Windows.Forms.TabControl();
            this.tabPageCountry = new System.Windows.Forms.TabPage();
            this.btnRefreshCountry = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStripItemDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.countryDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveCountry = new System.Windows.Forms.Button();
            this.countryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageHotline = new System.Windows.Forms.TabPage();
            this.btnRefreshHotline = new System.Windows.Forms.Button();
            this.btnSaveHotline = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.hotlineEmail = new System.Windows.Forms.TextBox();
            this.hotlinePhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.languageComboBoxHotline = new System.Windows.Forms.ComboBox();
            this.tabPageBrand = new System.Windows.Forms.TabPage();
            this.BrandBtnSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.branddescription = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.brandImage = new System.Windows.Forms.PictureBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.brandSortRank = new System.Windows.Forms.TextBox();
            this.brandname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BrandComboBoxHotline = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusBackend = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarBackend = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPageType = new System.Windows.Forms.TabPage();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.tabPageDealer = new System.Windows.Forms.TabPage();
            this.tabPageECommerce = new System.Windows.Forms.TabPage();
            this.tabPageNews = new System.Windows.Forms.TabPage();
            this.tabPageVideo = new System.Windows.Forms.TabPage();
            this.tabPageTeaser = new System.Windows.Forms.TabPage();
            this.AppTab.SuspendLayout();
            this.tabPageCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStripItemDelete.SuspendLayout();
            this.tabPageHotline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppTab
            // 
            this.AppTab.Controls.Add(this.tabPageCountry);
            this.AppTab.Controls.Add(this.tabPageHotline);
            this.AppTab.Controls.Add(this.tabPageBrand);
            this.AppTab.Controls.Add(this.tabPageType);
            this.AppTab.Controls.Add(this.tabPageProduct);
            this.AppTab.Controls.Add(this.tabPageDealer);
            this.AppTab.Controls.Add(this.tabPageECommerce);
            this.AppTab.Controls.Add(this.tabPageNews);
            this.AppTab.Controls.Add(this.tabPageVideo);
            this.AppTab.Controls.Add(this.tabPageTeaser);
            this.AppTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTab.Location = new System.Drawing.Point(12, 121);
            this.AppTab.Name = "AppTab";
            this.AppTab.SelectedIndex = 0;
            this.AppTab.Size = new System.Drawing.Size(1372, 766);
            this.AppTab.TabIndex = 7;
            this.AppTab.SelectedIndexChanged += new System.EventHandler(this.Form1_Reload);
            // 
            // tabPageCountry
            // 
            this.tabPageCountry.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPageCountry.Controls.Add(this.btnRefreshCountry);
            this.tabPageCountry.Controls.Add(this.label8);
            this.tabPageCountry.Controls.Add(this.dataGridView1);
            this.tabPageCountry.Controls.Add(this.countryDescription);
            this.tabPageCountry.Controls.Add(this.label1);
            this.tabPageCountry.Controls.Add(this.btnSaveCountry);
            this.tabPageCountry.Controls.Add(this.countryName);
            this.tabPageCountry.Controls.Add(this.label2);
            this.tabPageCountry.Location = new System.Drawing.Point(4, 29);
            this.tabPageCountry.Name = "tabPageCountry";
            this.tabPageCountry.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCountry.Size = new System.Drawing.Size(1364, 733);
            this.tabPageCountry.TabIndex = 0;
            this.tabPageCountry.Text = "Country";
            this.tabPageCountry.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnRefreshCountry
            // 
            this.btnRefreshCountry.Location = new System.Drawing.Point(1027, 161);
            this.btnRefreshCountry.Name = "btnRefreshCountry";
            this.btnRefreshCountry.Size = new System.Drawing.Size(151, 52);
            this.btnRefreshCountry.TabIndex = 13;
            this.btnRefreshCountry.Text = "Refresh";
            this.btnRefreshCountry.UseVisualStyleBackColor = true;
            this.btnRefreshCountry.Click += new System.EventHandler(this.btnRefreshCountry_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 42);
            this.label8.TabIndex = 12;
            this.label8.Text = "Country";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStripItemDelete;
            this.dataGridView1.Location = new System.Drawing.Point(6, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1355, 501);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStripItemDelete
            // 
            this.contextMenuStripItemDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDelete});
            this.contextMenuStripItemDelete.Name = "contextMenuStripItemDelete";
            this.contextMenuStripItemDelete.Size = new System.Drawing.Size(108, 26);
            this.contextMenuStripItemDelete.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripItemDelete_Opening);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemDelete.Text = "Delete";
            // 
            // countryDescription
            // 
            this.countryDescription.Location = new System.Drawing.Point(217, 129);
            this.countryDescription.Name = "countryDescription";
            this.countryDescription.Size = new System.Drawing.Size(1133, 26);
            this.countryDescription.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Country Description";
            // 
            // btnSaveCountry
            // 
            this.btnSaveCountry.Location = new System.Drawing.Point(1199, 161);
            this.btnSaveCountry.Name = "btnSaveCountry";
            this.btnSaveCountry.Size = new System.Drawing.Size(151, 52);
            this.btnSaveCountry.TabIndex = 8;
            this.btnSaveCountry.Text = "Save";
            this.btnSaveCountry.UseVisualStyleBackColor = true;
            this.btnSaveCountry.Click += new System.EventHandler(this.btnSaveCountry_Click);
            // 
            // countryName
            // 
            this.countryName.Location = new System.Drawing.Point(26, 129);
            this.countryName.Name = "countryName";
            this.countryName.Size = new System.Drawing.Size(185, 26);
            this.countryName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Countrycode";
            // 
            // tabPageHotline
            // 
            this.tabPageHotline.BackColor = System.Drawing.Color.LightCoral;
            this.tabPageHotline.Controls.Add(this.btnRefreshHotline);
            this.tabPageHotline.Controls.Add(this.btnSaveHotline);
            this.tabPageHotline.Controls.Add(this.dataGridView2);
            this.tabPageHotline.Controls.Add(this.label6);
            this.tabPageHotline.Controls.Add(this.hotlineEmail);
            this.tabPageHotline.Controls.Add(this.hotlinePhone);
            this.tabPageHotline.Controls.Add(this.label5);
            this.tabPageHotline.Controls.Add(this.label4);
            this.tabPageHotline.Controls.Add(this.label3);
            this.tabPageHotline.Controls.Add(this.languageComboBoxHotline);
            this.tabPageHotline.Location = new System.Drawing.Point(4, 29);
            this.tabPageHotline.Name = "tabPageHotline";
            this.tabPageHotline.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHotline.Size = new System.Drawing.Size(1364, 733);
            this.tabPageHotline.TabIndex = 1;
            this.tabPageHotline.Text = "Hotline";
            // 
            // btnRefreshHotline
            // 
            this.btnRefreshHotline.Location = new System.Drawing.Point(1067, 267);
            this.btnRefreshHotline.Name = "btnRefreshHotline";
            this.btnRefreshHotline.Size = new System.Drawing.Size(132, 50);
            this.btnRefreshHotline.TabIndex = 12;
            this.btnRefreshHotline.Text = "Refresh";
            this.btnRefreshHotline.UseVisualStyleBackColor = true;
            this.btnRefreshHotline.Click += new System.EventHandler(this.btnRefreshHotline_Click_1);
            // 
            // btnSaveHotline
            // 
            this.btnSaveHotline.Location = new System.Drawing.Point(1205, 267);
            this.btnSaveHotline.Name = "btnSaveHotline";
            this.btnSaveHotline.Size = new System.Drawing.Size(134, 50);
            this.btnSaveHotline.TabIndex = 11;
            this.btnSaveHotline.Text = "Save";
            this.btnSaveHotline.UseVisualStyleBackColor = true;
            this.btnSaveHotline.Click += new System.EventHandler(this.btnSaveHotline_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 337);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1355, 390);
            this.dataGridView2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "eMail";
            // 
            // hotlineEmail
            // 
            this.hotlineEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotlineEmail.Location = new System.Drawing.Point(487, 172);
            this.hotlineEmail.Name = "hotlineEmail";
            this.hotlineEmail.Size = new System.Drawing.Size(852, 26);
            this.hotlineEmail.TabIndex = 6;
            // 
            // hotlinePhone
            // 
            this.hotlinePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotlinePhone.Location = new System.Drawing.Point(487, 128);
            this.hotlinePhone.Name = "hotlinePhone";
            this.hotlinePhone.Size = new System.Drawing.Size(852, 26);
            this.hotlinePhone.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phonenumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Countrycode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hotline";
            // 
            // languageComboBoxHotline
            // 
            this.languageComboBoxHotline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageComboBoxHotline.FormattingEnabled = true;
            this.languageComboBoxHotline.Location = new System.Drawing.Point(29, 128);
            this.languageComboBoxHotline.Name = "languageComboBoxHotline";
            this.languageComboBoxHotline.Size = new System.Drawing.Size(288, 28);
            this.languageComboBoxHotline.TabIndex = 1;
            // 
            // tabPageBrand
            // 
            this.tabPageBrand.BackColor = System.Drawing.Color.Moccasin;
            this.tabPageBrand.Controls.Add(this.BrandBtnSave);
            this.tabPageBrand.Controls.Add(this.label13);
            this.tabPageBrand.Controls.Add(this.branddescription);
            this.tabPageBrand.Controls.Add(this.label12);
            this.tabPageBrand.Controls.Add(this.brandImage);
            this.tabPageBrand.Controls.Add(this.dataGridView3);
            this.tabPageBrand.Controls.Add(this.label10);
            this.tabPageBrand.Controls.Add(this.brandSortRank);
            this.tabPageBrand.Controls.Add(this.brandname);
            this.tabPageBrand.Controls.Add(this.label11);
            this.tabPageBrand.Controls.Add(this.label7);
            this.tabPageBrand.Controls.Add(this.label9);
            this.tabPageBrand.Controls.Add(this.BrandComboBoxHotline);
            this.tabPageBrand.Location = new System.Drawing.Point(4, 29);
            this.tabPageBrand.Name = "tabPageBrand";
            this.tabPageBrand.Size = new System.Drawing.Size(1364, 733);
            this.tabPageBrand.TabIndex = 2;
            this.tabPageBrand.Text = "Brand";
            this.tabPageBrand.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // BrandBtnSave
            // 
            this.BrandBtnSave.Location = new System.Drawing.Point(1191, 635);
            this.BrandBtnSave.Name = "BrandBtnSave";
            this.BrandBtnSave.Size = new System.Drawing.Size(148, 40);
            this.BrandBtnSave.TabIndex = 20;
            this.BrandBtnSave.Text = "Save";
            this.BrandBtnSave.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(339, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Description";
            // 
            // branddescription
            // 
            this.branddescription.Location = new System.Drawing.Point(333, 178);
            this.branddescription.Multiline = true;
            this.branddescription.Name = "branddescription";
            this.branddescription.Size = new System.Drawing.Size(1006, 92);
            this.branddescription.TabIndex = 18;
            this.branddescription.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Image";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // brandImage
            // 
            this.brandImage.Location = new System.Drawing.Point(26, 178);
            this.brandImage.Name = "brandImage";
            this.brandImage.Size = new System.Drawing.Size(288, 92);
            this.brandImage.TabIndex = 16;
            this.brandImage.TabStop = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(26, 276);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1313, 353);
            this.dataGridView3.TabIndex = 15;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1196, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Sort Rank";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // brandSortRank
            // 
            this.brandSortRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandSortRank.Location = new System.Drawing.Point(1191, 119);
            this.brandSortRank.Name = "brandSortRank";
            this.brandSortRank.Size = new System.Drawing.Size(148, 26);
            this.brandSortRank.TabIndex = 13;
            this.brandSortRank.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // brandname
            // 
            this.brandname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandname.Location = new System.Drawing.Point(333, 119);
            this.brandname.Name = "brandname";
            this.brandname.Size = new System.Drawing.Size(852, 26);
            this.brandname.TabIndex = 12;
            this.brandname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(339, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Brandname";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Countrycode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 42);
            this.label9.TabIndex = 5;
            this.label9.Text = "Brand";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // BrandComboBoxHotline
            // 
            this.BrandComboBoxHotline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandComboBoxHotline.FormattingEnabled = true;
            this.BrandComboBoxHotline.Location = new System.Drawing.Point(26, 117);
            this.BrandComboBoxHotline.Name = "BrandComboBoxHotline";
            this.BrandComboBoxHotline.Size = new System.Drawing.Size(288, 28);
            this.BrandComboBoxHotline.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1405, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionInfoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // versionInfoToolStripMenuItem
            // 
            this.versionInfoToolStripMenuItem.Name = "versionInfoToolStripMenuItem";
            this.versionInfoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.versionInfoToolStripMenuItem.Text = "Version Info";
            this.versionInfoToolStripMenuItem.Click += new System.EventHandler(this.versionInfoToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusBackend,
            this.toolStripProgressBarBackend,
            this.toolStripStatusLabel2,
            this.toolStripStatusDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 841);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1405, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusBackend
            // 
            this.toolStripStatusBackend.Name = "toolStripStatusBackend";
            this.toolStripStatusBackend.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusBackend.Text = "Backend Ready";
            // 
            // toolStripProgressBarBackend
            // 
            this.toolStripProgressBarBackend.Name = "toolStripProgressBarBackend";
            this.toolStripProgressBarBackend.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(200, 17);
            this.toolStripStatusLabel2.Text = "Please Login with your User Account";
            // 
            // toolStripStatusDateTime
            // 
            this.toolStripStatusDateTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusDateTime.Name = "toolStripStatusDateTime";
            this.toolStripStatusDateTime.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusDateTime.Text = "Date and Time";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPageType
            // 
            this.tabPageType.Location = new System.Drawing.Point(4, 29);
            this.tabPageType.Name = "tabPageType";
            this.tabPageType.Size = new System.Drawing.Size(1364, 733);
            this.tabPageType.TabIndex = 3;
            this.tabPageType.Text = "Type";
            this.tabPageType.UseVisualStyleBackColor = true;
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Location = new System.Drawing.Point(4, 29);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Size = new System.Drawing.Size(1364, 733);
            this.tabPageProduct.TabIndex = 4;
            this.tabPageProduct.Text = "Product";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // tabPageDealer
            // 
            this.tabPageDealer.Location = new System.Drawing.Point(4, 29);
            this.tabPageDealer.Name = "tabPageDealer";
            this.tabPageDealer.Size = new System.Drawing.Size(1364, 733);
            this.tabPageDealer.TabIndex = 5;
            this.tabPageDealer.Text = "Dealer";
            this.tabPageDealer.UseVisualStyleBackColor = true;
            // 
            // tabPageECommerce
            // 
            this.tabPageECommerce.Location = new System.Drawing.Point(4, 29);
            this.tabPageECommerce.Name = "tabPageECommerce";
            this.tabPageECommerce.Size = new System.Drawing.Size(1364, 733);
            this.tabPageECommerce.TabIndex = 6;
            this.tabPageECommerce.Text = "eCommerce";
            this.tabPageECommerce.UseVisualStyleBackColor = true;
            // 
            // tabPageNews
            // 
            this.tabPageNews.Location = new System.Drawing.Point(4, 29);
            this.tabPageNews.Name = "tabPageNews";
            this.tabPageNews.Size = new System.Drawing.Size(1364, 733);
            this.tabPageNews.TabIndex = 7;
            this.tabPageNews.Text = "News";
            this.tabPageNews.UseVisualStyleBackColor = true;
            // 
            // tabPageVideo
            // 
            this.tabPageVideo.Location = new System.Drawing.Point(4, 29);
            this.tabPageVideo.Name = "tabPageVideo";
            this.tabPageVideo.Size = new System.Drawing.Size(1364, 733);
            this.tabPageVideo.TabIndex = 8;
            this.tabPageVideo.Text = "Video";
            this.tabPageVideo.UseVisualStyleBackColor = true;
            // 
            // tabPageTeaser
            // 
            this.tabPageTeaser.Location = new System.Drawing.Point(4, 29);
            this.tabPageTeaser.Name = "tabPageTeaser";
            this.tabPageTeaser.Size = new System.Drawing.Size(1364, 733);
            this.tabPageTeaser.TabIndex = 9;
            this.tabPageTeaser.Text = "Teaser";
            this.tabPageTeaser.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 863);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.AppTab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NACMS - NJDQEI App Content Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AppTab.ResumeLayout(false);
            this.tabPageCountry.ResumeLayout(false);
            this.tabPageCountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStripItemDelete.ResumeLayout(false);
            this.tabPageHotline.ResumeLayout(false);
            this.tabPageHotline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageBrand.ResumeLayout(false);
            this.tabPageBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl AppTab;
        private System.Windows.Forms.TabPage tabPageCountry;
        private System.Windows.Forms.TabPage tabPageHotline;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox countryDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveCountry;
        private System.Windows.Forms.TextBox countryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox languageComboBoxHotline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hotlineEmail;
        private System.Windows.Forms.TextBox hotlinePhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRefreshHotline;
        private System.Windows.Forms.Button btnSaveHotline;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRefreshCountry;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionInfoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusBackend;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarBackend;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDateTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripItemDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.TabPage tabPageBrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox BrandComboBoxHotline;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox brandSortRank;
        private System.Windows.Forms.TextBox brandname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox brandImage;
        private System.Windows.Forms.TextBox branddescription;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BrandBtnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPageType;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.TabPage tabPageDealer;
        private System.Windows.Forms.TabPage tabPageECommerce;
        private System.Windows.Forms.TabPage tabPageNews;
        private System.Windows.Forms.TabPage tabPageVideo;
        private System.Windows.Forms.TabPage tabPageTeaser;
    }
}

