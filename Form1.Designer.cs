
namespace VPN_Unlimited_Setup
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
            this.Licension = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Please = new System.Windows.Forms.Label();
            this.UnacceptRButton = new System.Windows.Forms.RadioButton();
            this.AcceptRButton = new System.Windows.Forms.RadioButton();
            this.LicensionAccept = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Licension
            // 
            this.Licension.Location = new System.Drawing.Point(63, 56);
            this.Licension.Multiline = true;
            this.Licension.Name = "Licension";
            this.Licension.ReadOnly = true;
            this.Licension.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Licension.Size = new System.Drawing.Size(400, 190);
            this.Licension.TabIndex = 0;
            this.Licension.Text = resources.GetString("Licension.Text");
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(447, 376);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(80, 25);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(354, 376);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(80, 25);
            this.ContinueButton.TabIndex = 2;
            this.ContinueButton.Text = "Продолжить";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.Please);
            this.panel1.Controls.Add(this.UnacceptRButton);
            this.panel1.Controls.Add(this.AcceptRButton);
            this.panel1.Controls.Add(this.Licension);
            this.panel1.Location = new System.Drawing.Point(-1, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 313);
            this.panel1.TabIndex = 3;
            // 
            // Please
            // 
            this.Please.Location = new System.Drawing.Point(63, 18);
            this.Please.Name = "Please";
            this.Please.Size = new System.Drawing.Size(400, 35);
            this.Please.TabIndex = 2;
            this.Please.Text = "Пожалуйста, прочтите условия лицензионного соглашения. Вы должны принять условия " +
    "для продолжения установки\r\n";
            // 
            // UnacceptRButton
            // 
            this.UnacceptRButton.AutoSize = true;
            this.UnacceptRButton.Location = new System.Drawing.Point(63, 280);
            this.UnacceptRButton.Name = "UnacceptRButton";
            this.UnacceptRButton.Size = new System.Drawing.Size(94, 17);
            this.UnacceptRButton.TabIndex = 1;
            this.UnacceptRButton.TabStop = true;
            this.UnacceptRButton.Text = "Не принимаю";
            this.UnacceptRButton.UseVisualStyleBackColor = true;
            this.UnacceptRButton.CheckedChanged += new System.EventHandler(this.UnacceptRButton_CheckedChanged);
            // 
            // AcceptRButton
            // 
            this.AcceptRButton.AutoSize = true;
            this.AcceptRButton.Location = new System.Drawing.Point(63, 252);
            this.AcceptRButton.Name = "AcceptRButton";
            this.AcceptRButton.Size = new System.Drawing.Size(79, 17);
            this.AcceptRButton.TabIndex = 0;
            this.AcceptRButton.TabStop = true;
            this.AcceptRButton.Text = "Принимаю";
            this.AcceptRButton.UseVisualStyleBackColor = true;
            this.AcceptRButton.CheckedChanged += new System.EventHandler(this.AcceptRButton_CheckedChanged);
            // 
            // LicensionAccept
            // 
            this.LicensionAccept.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LicensionAccept.Location = new System.Drawing.Point(62, 13);
            this.LicensionAccept.Name = "LicensionAccept";
            this.LicensionAccept.Size = new System.Drawing.Size(300, 25);
            this.LicensionAccept.TabIndex = 4;
            this.LicensionAccept.Text = "Лицензионное соглашение";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(461, 1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(61, 50);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 5;
            this.Logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.LicensionAccept);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPN Unlimited Setup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Licension;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton UnacceptRButton;
        private System.Windows.Forms.RadioButton AcceptRButton;
        private System.Windows.Forms.Label Please;
        private System.Windows.Forms.Label LicensionAccept;
        private System.Windows.Forms.PictureBox Logo;
    }
}