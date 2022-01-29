
namespace VPN_Unlimited_Setup
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ContinueButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DirectoryWriteLabel = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.DirectoryLabel = new System.Windows.Forms.Label();
            this.SetupDirectory = new System.Windows.Forms.TextBox();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.Directory = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(354, 376);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(80, 25);
            this.ContinueButton.TabIndex = 0;
            this.ContinueButton.Text = "Продолжить";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(259, 376);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(80, 25);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(447, 376);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(80, 25);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.DirectoryButton);
            this.panel1.Controls.Add(this.SetupDirectory);
            this.panel1.Controls.Add(this.DirectoryWriteLabel);
            this.panel1.Location = new System.Drawing.Point(-1, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 313);
            this.panel1.TabIndex = 3;
            // 
            // DirectoryWriteLabel
            // 
            this.DirectoryWriteLabel.Location = new System.Drawing.Point(63, 18);
            this.DirectoryWriteLabel.Name = "DirectoryWriteLabel";
            this.DirectoryWriteLabel.Size = new System.Drawing.Size(400, 35);
            this.DirectoryWriteLabel.TabIndex = 0;
            this.DirectoryWriteLabel.Text = "Укажите путь для установки программы\r\n";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(461, 1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(61, 50);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 4;
            this.Logo.TabStop = false;
            // 
            // DirectoryLabel
            // 
            this.DirectoryLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryLabel.Location = new System.Drawing.Point(62, 13);
            this.DirectoryLabel.Name = "DirectoryLabel";
            this.DirectoryLabel.Size = new System.Drawing.Size(300, 25);
            this.DirectoryLabel.TabIndex = 5;
            this.DirectoryLabel.Text = "Путь установки";
            // 
            // SetupDirectory
            // 
            this.SetupDirectory.Location = new System.Drawing.Point(66, 66);
            this.SetupDirectory.Name = "SetupDirectory";
            this.SetupDirectory.Size = new System.Drawing.Size(450, 20);
            this.SetupDirectory.TabIndex = 1;
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Location = new System.Drawing.Point(66, 111);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(80, 25);
            this.DirectoryButton.TabIndex = 2;
            this.DirectoryButton.Text = "Обзор";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.DirectoryLabel);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPN Unlimited Setup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label DirectoryLabel;
        private System.Windows.Forms.Label DirectoryWriteLabel;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.TextBox SetupDirectory;
        private System.Windows.Forms.FolderBrowserDialog Directory;
    }
}