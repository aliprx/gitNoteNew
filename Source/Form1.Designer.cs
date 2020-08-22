namespace WindowsFormsApp38
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvShowTexts = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLiteDb = new System.Windows.Forms.CheckBox();
            this.cbSqLite = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddText = new System.Windows.Forms.ToolStripButton();
            this.btnEditText = new System.Windows.Forms.ToolStripButton();
            this.btnOpenText = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteText = new System.Windows.Forms.ToolStripButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTexts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvShowTexts);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "یاد داشت های اخیر";
            // 
            // dgvShowTexts
            // 
            this.dgvShowTexts.AllowUserToAddRows = false;
            this.dgvShowTexts.AllowUserToDeleteRows = false;
            this.dgvShowTexts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowTexts.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowTexts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowTexts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Text,
            this.Date});
            this.dgvShowTexts.Location = new System.Drawing.Point(6, 21);
            this.dgvShowTexts.Name = "dgvShowTexts";
            this.dgvShowTexts.ReadOnly = true;
            this.dgvShowTexts.RowHeadersVisible = false;
            this.dgvShowTexts.Size = new System.Drawing.Size(252, 231);
            this.dgvShowTexts.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ایدی";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "عنوان";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Text
            // 
            this.Text.DataPropertyName = "Text";
            this.Text.HeaderText = "متن";
            this.Text.Name = "Text";
            this.Text.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "تاریخ";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbLiteDb);
            this.groupBox2.Controls.Add(this.cbSqLite);
            this.groupBox2.Location = new System.Drawing.Point(3, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 94);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تنظیمات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "جهت تغییر فرمت یادداشت ابتدا میبایست\r\n یک یادداشت را باز کنید";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "فرمت :";
            // 
            // cbLiteDb
            // 
            this.cbLiteDb.AutoSize = true;
            this.cbLiteDb.Location = new System.Drawing.Point(100, 21);
            this.cbLiteDb.Name = "cbLiteDb";
            this.cbLiteDb.Size = new System.Drawing.Size(65, 18);
            this.cbLiteDb.TabIndex = 0;
            this.cbLiteDb.Text = "Lite Db";
            this.cbLiteDb.UseVisualStyleBackColor = true;
            // 
            // cbSqLite
            // 
            this.cbSqLite.AutoSize = true;
            this.cbSqLite.Location = new System.Drawing.Point(9, 21);
            this.cbSqLite.Name = "cbSqLite";
            this.cbSqLite.Size = new System.Drawing.Size(62, 18);
            this.cbSqLite.TabIndex = 0;
            this.cbSqLite.Text = "SQLite";
            this.cbSqLite.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtText);
            this.groupBox3.Controls.Add(this.txtTitle);
            this.groupBox3.Location = new System.Drawing.Point(273, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 358);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "یاد داشت ";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(6, 49);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(295, 303);
            this.txtText.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(6, 21);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(295, 22);
            this.txtTitle.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddText,
            this.btnEditText,
            this.btnOpenText,
            this.btnDeleteText});
            this.toolStrip1.Location = new System.Drawing.Point(0, 363);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(580, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddText
            // 
            this.btnAddText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddText.Image = ((System.Drawing.Image)(resources.GetObject("btnAddText.Image")));
            this.btnAddText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(41, 22);
            this.btnAddText.Text = "اضافه";
            this.btnAddText.Click += new System.EventHandler(this.BtnAddText_Click);
            // 
            // btnEditText
            // 
            this.btnEditText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditText.Image = ((System.Drawing.Image)(resources.GetObject("btnEditText.Image")));
            this.btnEditText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditText.Name = "btnEditText";
            this.btnEditText.Size = new System.Drawing.Size(47, 22);
            this.btnEditText.Text = "ویرایش";
            this.btnEditText.Click += new System.EventHandler(this.BtnEditText_Click);
            // 
            // btnOpenText
            // 
            this.btnOpenText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpenText.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenText.Image")));
            this.btnOpenText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenText.Name = "btnOpenText";
            this.btnOpenText.Size = new System.Drawing.Size(92, 22);
            this.btnOpenText.Text = "بازکردن یادداشت";
            this.btnOpenText.Click += new System.EventHandler(this.BtnOpenText_Click);
            // 
            // btnDeleteText
            // 
            this.btnDeleteText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteText.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteText.Image")));
            this.btnDeleteText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteText.Name = "btnDeleteText";
            this.btnDeleteText.Size = new System.Drawing.Size(36, 22);
            this.btnDeleteText.Text = "حذف";
            this.btnDeleteText.Click += new System.EventHandler(this.BtnDeleteText_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 374);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 14);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 388);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTexts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvShowTexts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbLiteDb;
        private System.Windows.Forms.CheckBox cbSqLite;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ToolStripButton btnAddText;
        private System.Windows.Forms.ToolStripButton btnEditText;
        private System.Windows.Forms.ToolStripButton btnOpenText;
        private System.Windows.Forms.ToolStripButton btnDeleteText;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}

