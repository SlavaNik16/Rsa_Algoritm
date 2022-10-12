namespace AlgoritmRSA
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qBox = new System.Windows.Forms.TextBox();
            this.MesBox = new System.Windows.Forms.TextBox();
            this.butEncrypt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PublicLabel = new System.Windows.Forms.Label();
            this.PrivateLabel = new System.Windows.Forms.Label();
            this.butNotEncrypt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nBox = new System.Windows.Forms.TextBox();
            this.dBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(81, 63);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(420, 20);
            this.pBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "p = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "q = ";
            // 
            // qBox
            // 
            this.qBox.Location = new System.Drawing.Point(81, 101);
            this.qBox.Name = "qBox";
            this.qBox.Size = new System.Drawing.Size(420, 20);
            this.qBox.TabIndex = 2;
            // 
            // MesBox
            // 
            this.MesBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MesBox.Location = new System.Drawing.Point(0, 142);
            this.MesBox.Multiline = true;
            this.MesBox.Name = "MesBox";
            this.MesBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MesBox.Size = new System.Drawing.Size(546, 173);
            this.MesBox.TabIndex = 5;
            // 
            // butEncrypt
            // 
            this.butEncrypt.BackColor = System.Drawing.Color.Yellow;
            this.butEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.butEncrypt.FlatAppearance.BorderSize = 0;
            this.butEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butEncrypt.Location = new System.Drawing.Point(97, 320);
            this.butEncrypt.Name = "butEncrypt";
            this.butEncrypt.Size = new System.Drawing.Size(338, 60);
            this.butEncrypt.TabIndex = 6;
            this.butEncrypt.Text = "Зашифровать";
            this.butEncrypt.UseVisualStyleBackColor = false;
            this.butEncrypt.Click += new System.EventHandler(this.butEncrypt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PublicLabel
            // 
            this.PublicLabel.AutoSize = true;
            this.PublicLabel.BackColor = System.Drawing.Color.DimGray;
            this.PublicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PublicLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PublicLabel.Location = new System.Drawing.Point(7, 396);
            this.PublicLabel.Name = "PublicLabel";
            this.PublicLabel.Size = new System.Drawing.Size(275, 31);
            this.PublicLabel.TabIndex = 7;
            this.PublicLabel.Text = "Открытый ключ(e,n):";
            // 
            // PrivateLabel
            // 
            this.PrivateLabel.AutoSize = true;
            this.PrivateLabel.BackColor = System.Drawing.Color.DimGray;
            this.PrivateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrivateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PrivateLabel.Location = new System.Drawing.Point(7, 447);
            this.PrivateLabel.Name = "PrivateLabel";
            this.PrivateLabel.Size = new System.Drawing.Size(288, 31);
            this.PrivateLabel.TabIndex = 8;
            this.PrivateLabel.Text = "Секретный ключ(d,n):";
            // 
            // butNotEncrypt
            // 
            this.butNotEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butNotEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.butNotEncrypt.FlatAppearance.BorderSize = 0;
            this.butNotEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butNotEncrypt.Location = new System.Drawing.Point(97, 508);
            this.butNotEncrypt.Name = "butNotEncrypt";
            this.butNotEncrypt.Size = new System.Drawing.Size(338, 60);
            this.butNotEncrypt.TabIndex = 9;
            this.butNotEncrypt.Text = "Расшифровать";
            this.butNotEncrypt.UseVisualStyleBackColor = false;
            this.butNotEncrypt.Click += new System.EventHandler(this.butNotEncrypt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 142);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(0, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 251);
            this.panel2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(515, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите два простых числа!";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Location = new System.Drawing.Point(0, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(546, 251);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.nBox);
            this.panel4.Controls.Add(this.dBox);
            this.panel4.Location = new System.Drawing.Point(0, 393);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(546, 96);
            this.panel4.TabIndex = 12;
            // 
            // nBox
            // 
            this.nBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nBox.Location = new System.Drawing.Point(437, 58);
            this.nBox.Multiline = true;
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(97, 29);
            this.nBox.TabIndex = 1;
            // 
            // dBox
            // 
            this.dBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dBox.Location = new System.Drawing.Point(301, 58);
            this.dBox.Multiline = true;
            this.dBox.Name = "dBox";
            this.dBox.Size = new System.Drawing.Size(97, 29);
            this.dBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(546, 586);
            this.Controls.Add(this.butNotEncrypt);
            this.Controls.Add(this.PrivateLabel);
            this.Controls.Add(this.PublicLabel);
            this.Controls.Add(this.butEncrypt);
            this.Controls.Add(this.MesBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox qBox;
        private System.Windows.Forms.TextBox MesBox;
        private System.Windows.Forms.Button butEncrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label PublicLabel;
        private System.Windows.Forms.Label PrivateLabel;
        private System.Windows.Forms.Button butNotEncrypt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.TextBox dBox;
    }
}

