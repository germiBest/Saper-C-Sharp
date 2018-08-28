namespace Saper
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.choseSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choseSizeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(375, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // choseSizeToolStripMenuItem
            // 
            this.choseSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x10ToolStripMenuItem,
            this.x15ToolStripMenuItem,
            this.x5ToolStripMenuItem,
            this.customToolStripMenuItem});
            this.choseSizeToolStripMenuItem.Name = "choseSizeToolStripMenuItem";
            this.choseSizeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.choseSizeToolStripMenuItem.Text = "Chose size";
            // 
            // x10ToolStripMenuItem
            // 
            this.x10ToolStripMenuItem.Name = "x10ToolStripMenuItem";
            this.x10ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.x10ToolStripMenuItem.Text = "15x15";
            this.x10ToolStripMenuItem.Click += new System.EventHandler(this.x15ToolStripMenuItem_Click);
            // 
            // x15ToolStripMenuItem
            // 
            this.x15ToolStripMenuItem.Name = "x15ToolStripMenuItem";
            this.x15ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.x15ToolStripMenuItem.Text = "10x10";
            this.x15ToolStripMenuItem.Click += new System.EventHandler(this.x10ToolsStripMenuItem_Click);
            // 
            // x5ToolStripMenuItem
            // 
            this.x5ToolStripMenuItem.Name = "x5ToolStripMenuItem";
            this.x5ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.x5ToolStripMenuItem.Text = "5x5";
            this.x5ToolStripMenuItem.Click += new System.EventHandler(this.x5ToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customToolStripMenuItem.Text = "Custom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 363);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem choseSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x15ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
    }
}

