
namespace VPN_Unlimited_Setup
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReadyToInstall = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SetupButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ReadyLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.ReadyLabel);
            this.panel1.Location = new System.Drawing.Point(-1, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 313);
            this.panel1.TabIndex = 0;
            // 
            // ReadyToInstall
            // 
            this.ReadyToInstall.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadyToInstall.Location = new System.Drawing.Point(62, 13);
            this.ReadyToInstall.Name = "ReadyToInstall";
            this.ReadyToInstall.Size = new System.Drawing.Size(300, 25);
            this.ReadyToInstall.TabIndex = 1;
            this.ReadyToInstall.Text = "Готово к установке";
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
            // SetupButton
            // 
            this.SetupButton.Location = new System.Drawing.Point(354, 377);
            this.SetupButton.Name = "SetupButton";
            this.SetupButton.Size = new System.Drawing.Size(80, 25);
            this.SetupButton.TabIndex = 4;
            this.SetupButton.Text = "Установить";
            this.SetupButton.UseVisualStyleBackColor = true;
            this.SetupButton.Click += new System.EventHandler(this.SetupButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(259, 377);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(80, 25);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ReadyLabel
            // 
            this.ReadyLabel.Location = new System.Drawing.Point(67, 44);
            this.ReadyLabel.Name = "ReadyLabel";
            this.ReadyLabel.Size = new System.Drawing.Size(400, 35);
            this.ReadyLabel.TabIndex = 0;
            this.ReadyLabel.Text = "Программа готова к установке. Нажмите \"Установить\" для начала установки или \"Наза" +
    "д\" для коректировки настроек";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SetupButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ReadyToInstall);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPN Unlimited Setup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ReadyToInstall;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SetupButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label ReadyLabel;
    }
}