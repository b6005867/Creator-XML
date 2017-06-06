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
            this.tbx_article = new System.Windows.Forms.TextBox();
            this.nud_quantity = new System.Windows.Forms.NumericUpDown();
            this.lbx_article = new System.Windows.Forms.ListBox();
            this.lbx_quantity = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_article
            // 
            this.tbx_article.Location = new System.Drawing.Point(90, 20);
            this.tbx_article.Name = "tbx_article";
            this.tbx_article.Size = new System.Drawing.Size(100, 20);
            this.tbx_article.TabIndex = 0;
            // 
            // nud_quantity
            // 
            this.nud_quantity.Location = new System.Drawing.Point(90, 43);
            this.nud_quantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_quantity.Name = "nud_quantity";
            this.nud_quantity.Size = new System.Drawing.Size(69, 20);
            this.nud_quantity.TabIndex = 1;
            // 
            // lbx_article
            // 
            this.lbx_article.FormattingEnabled = true;
            this.lbx_article.Location = new System.Drawing.Point(35, 125);
            this.lbx_article.Name = "lbx_article";
            this.lbx_article.Size = new System.Drawing.Size(90, 95);
            this.lbx_article.TabIndex = 2;
            // 
            // lbx_quantity
            // 
            this.lbx_quantity.FormattingEnabled = true;
            this.lbx_quantity.Location = new System.Drawing.Point(131, 125);
            this.lbx_quantity.Name = "lbx_quantity";
            this.lbx_quantity.Size = new System.Drawing.Size(90, 95);
            this.lbx_quantity.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(64, 69);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(117, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Adauga In Lista";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(78, 226);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(103, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Salveaza Fisierul";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Articol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantitate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Articol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantitate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alexandru Nita 2017";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 278);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbx_quantity);
            this.Controls.Add(this.lbx_article);
            this.Controls.Add(this.nud_quantity);
            this.Controls.Add(this.tbx_article);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Creator XML";
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_article;
        private System.Windows.Forms.NumericUpDown nud_quantity;
        private System.Windows.Forms.ListBox lbx_article;
        private System.Windows.Forms.ListBox lbx_quantity;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

