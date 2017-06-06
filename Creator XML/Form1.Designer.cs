namespace Creator_XML
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
            this.lbx_article = new System.Windows.Forms.ListBox();
            this.lbx_quantity = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_selectFile = new System.Windows.Forms.Button();
            this.lbl_filePath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx_article
            // 
            this.lbx_article.FormattingEnabled = true;
            this.lbx_article.Location = new System.Drawing.Point(34, 84);
            this.lbx_article.Name = "lbx_article";
            this.lbx_article.Size = new System.Drawing.Size(90, 95);
            this.lbx_article.TabIndex = 2;
            // 
            // lbx_quantity
            // 
            this.lbx_quantity.FormattingEnabled = true;
            this.lbx_quantity.Location = new System.Drawing.Point(130, 84);
            this.lbx_quantity.Name = "lbx_quantity";
            this.lbx_quantity.Size = new System.Drawing.Size(90, 95);
            this.lbx_quantity.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(78, 199);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(103, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Salveaza Fisierul";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Articol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantitate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Copyright Alexandru Nita - All Rights Reserved";
            // 
            // btn_selectFile
            // 
            this.btn_selectFile.Location = new System.Drawing.Point(78, 12);
            this.btn_selectFile.Name = "btn_selectFile";
            this.btn_selectFile.Size = new System.Drawing.Size(108, 23);
            this.btn_selectFile.TabIndex = 11;
            this.btn_selectFile.Text = "Selecteaza Fisierul";
            this.btn_selectFile.UseVisualStyleBackColor = true;
            this.btn_selectFile.Click += new System.EventHandler(this.btn_selectFile_Click);
            // 
            // lbl_filePath
            // 
            this.lbl_filePath.AutoSize = true;
            this.lbl_filePath.Location = new System.Drawing.Point(75, 44);
            this.lbl_filePath.Name = "lbl_filePath";
            this.lbl_filePath.Size = new System.Drawing.Size(116, 13);
            this.lbl_filePath.TabIndex = 12;
            this.lbl_filePath.Text = "Nu este selectat fisierul";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 278);
            this.Controls.Add(this.lbl_filePath);
            this.Controls.Add(this.btn_selectFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbx_quantity);
            this.Controls.Add(this.lbx_article);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Creator XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_article;
        private System.Windows.Forms.ListBox lbx_quantity;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_selectFile;
        private System.Windows.Forms.Label lbl_filePath;
    }
}

