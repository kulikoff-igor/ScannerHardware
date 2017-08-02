namespace ScannerHardware
{
    partial class FormConfigDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigDB));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.конфигурацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьКонфигурациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКонфигурациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUrlBd = new System.Windows.Forms.TextBox();
            this.textBoxNameBd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserBd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPasswordBd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonTestBD = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.конфигурацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(316, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // конфигурацияToolStripMenuItem
            // 
            this.конфигурацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьКонфигурациюToolStripMenuItem,
            this.сохранитьКонфигурациюToolStripMenuItem});
            this.конфигурацияToolStripMenuItem.Name = "конфигурацияToolStripMenuItem";
            this.конфигурацияToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
            this.конфигурацияToolStripMenuItem.Text = "Конфигурация";
            // 
            // загрузитьКонфигурациюToolStripMenuItem
            // 
            this.загрузитьКонфигурациюToolStripMenuItem.Name = "загрузитьКонфигурациюToolStripMenuItem";
            this.загрузитьКонфигурациюToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.загрузитьКонфигурациюToolStripMenuItem.Text = "Загрузить конфигурацию";
            this.загрузитьКонфигурациюToolStripMenuItem.Click += new System.EventHandler(this.загрузитьКонфигурациюToolStripMenuItem_Click);
            // 
            // сохранитьКонфигурациюToolStripMenuItem
            // 
            this.сохранитьКонфигурациюToolStripMenuItem.Name = "сохранитьКонфигурациюToolStripMenuItem";
            this.сохранитьКонфигурациюToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.сохранитьКонфигурациюToolStripMenuItem.Text = "Сохранить конфигурацию";
            this.сохранитьКонфигурациюToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКонфигурациюToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL BD";
            // 
            // textBoxUrlBd
            // 
            this.textBoxUrlBd.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUrlBd.Location = new System.Drawing.Point(124, 50);
            this.textBoxUrlBd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUrlBd.Name = "textBoxUrlBd";
            this.textBoxUrlBd.Size = new System.Drawing.Size(156, 34);
            this.textBoxUrlBd.TabIndex = 2;
            // 
            // textBoxNameBd
            // 
            this.textBoxNameBd.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameBd.Location = new System.Drawing.Point(124, 94);
            this.textBoxNameBd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNameBd.Name = "textBoxNameBd";
            this.textBoxNameBd.Size = new System.Drawing.Size(156, 34);
            this.textBoxNameBd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name BD";
            // 
            // textBoxUserBd
            // 
            this.textBoxUserBd.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserBd.Location = new System.Drawing.Point(124, 142);
            this.textBoxUserBd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUserBd.Name = "textBoxUserBd";
            this.textBoxUserBd.Size = new System.Drawing.Size(156, 34);
            this.textBoxUserBd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "User";
            // 
            // textBoxPasswordBd
            // 
            this.textBoxPasswordBd.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPasswordBd.Location = new System.Drawing.Point(124, 189);
            this.textBoxPasswordBd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPasswordBd.Name = "textBoxPasswordBd";
            this.textBoxPasswordBd.Size = new System.Drawing.Size(156, 34);
            this.textBoxPasswordBd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // buttonTestBD
            // 
            this.buttonTestBD.Location = new System.Drawing.Point(36, 239);
            this.buttonTestBD.Name = "buttonTestBD";
            this.buttonTestBD.Size = new System.Drawing.Size(244, 37);
            this.buttonTestBD.TabIndex = 9;
            this.buttonTestBD.Text = "Тестировать подключение";
            this.buttonTestBD.UseVisualStyleBackColor = true;
            this.buttonTestBD.Click += new System.EventHandler(this.buttonTestBD_Click);
            // 
            // FormConfigDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 305);
            this.Controls.Add(this.buttonTestBD);
            this.Controls.Add(this.textBoxPasswordBd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUserBd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNameBd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUrlBd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormConfigDB";
            this.Text = "FormConfigDB";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem конфигурацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьКонфигурациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКонфигурациюToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUrlBd;
        private System.Windows.Forms.TextBox textBoxNameBd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserBd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPasswordBd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonTestBD;
    }
}