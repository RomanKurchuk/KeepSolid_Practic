
namespace VPN_Unlimited_Setup
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MenuFolderName = new System.Windows.Forms.Label();
            this.FolderName = new System.Windows.Forms.TextBox();
            this.CheckBoxFolder = new System.Windows.Forms.CheckBox();
            this.ShortcutCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.ShortcutCheckBox);
            this.panel1.Controls.Add(this.CheckBoxFolder);
            this.panel1.Controls.Add(this.FolderName);
            this.panel1.Controls.Add(this.MenuFolderName);
            this.panel1.Location = new System.Drawing.Point(-1, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 313);
            this.panel1.TabIndex = 0;
            // 
            // MenuLabel
            // 
            this.MenuLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuLabel.Location = new System.Drawing.Point(62, 13);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(300, 25);
            this.MenuLabel.TabIndex = 1;
            this.MenuLabel.Text = "Меню \"Пуск\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(461, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(447, 376);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(80, 25);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(354, 376);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(80, 25);
            this.ContinueButton.TabIndex = 4;
            this.ContinueButton.Text = "Продолжить";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(259, 376);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(80, 25);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MenuFolderName
            // 
            this.MenuFolderName.Location = new System.Drawing.Point(63, 18);
            this.MenuFolderName.Name = "MenuFolderName";
            this.MenuFolderName.Size = new System.Drawing.Size(400, 35);
            this.MenuFolderName.TabIndex = 0;
            this.MenuFolderName.Text = "Укажите имя папки в меню \"Пуск\"";
            // 
            // FolderName
            // 
            this.FolderName.Location = new System.Drawing.Point(66, 66);
            this.FolderName.Name = "FolderName";
            this.FolderName.Size = new System.Drawing.Size(300, 20);
            this.FolderName.TabIndex = 1;
            this.FolderName.Text = "VPN Unlimited";
            // 
            // CheckBoxFolder
            // 
            this.CheckBoxFolder.AutoSize = true;
            this.CheckBoxFolder.Location = new System.Drawing.Point(66, 259);
            this.CheckBoxFolder.Name = "CheckBoxFolder";
            this.CheckBoxFolder.Size = new System.Drawing.Size(206, 17);
            this.CheckBoxFolder.TabIndex = 2;
            this.CheckBoxFolder.Text = "Не создавать папку в меню \"Пуск\"";
            this.CheckBoxFolder.UseVisualStyleBackColor = true;
            this.CheckBoxFolder.CheckedChanged += new System.EventHandler(this.CheckBoxFolder_CheckedChanged);
            // 
            // ShortcutCheckBox
            // 
            this.ShortcutCheckBox.AutoSize = true;
            this.ShortcutCheckBox.Location = new System.Drawing.Point(66, 236);
            this.ShortcutCheckBox.Name = "ShortcutCheckBox";
            this.ShortcutCheckBox.Size = new System.Drawing.Size(196, 17);
            this.ShortcutCheckBox.TabIndex = 3;
            this.ShortcutCheckBox.Text = "Создать ярлык на рабочем столе";
            this.ShortcutCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPN Unlimited Setup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label MenuFolderName;
        private System.Windows.Forms.TextBox FolderName;
        private System.Windows.Forms.CheckBox CheckBoxFolder;
        private System.Windows.Forms.CheckBox ShortcutCheckBox;
    }
}