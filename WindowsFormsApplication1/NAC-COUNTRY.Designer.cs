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
            this.btnsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.countryDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countryName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(1237, 77);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(175, 68);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country Description";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // countryDescription
            // 
            this.countryDescription.Location = new System.Drawing.Point(141, 116);
            this.countryDescription.Name = "countryDescription";
            this.countryDescription.Size = new System.Drawing.Size(1067, 19);
            this.countryDescription.TabIndex = 3;
            this.countryDescription.TextChanged += new System.EventHandler(this.CountryDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // countryName
            // 
            this.countryName.Location = new System.Drawing.Point(24, 116);
            this.countryName.Name = "countryName";
            this.countryName.Size = new System.Drawing.Size(71, 19);
            this.countryName.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1388, 437);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 643);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.countryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countryDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "NJDQEI App Content Management - Country";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox countryDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countryName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

