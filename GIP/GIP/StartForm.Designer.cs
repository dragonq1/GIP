﻿namespace GIP
{
    partial class StartForm
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
            this.lblWelkom = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelkom
            // 
            this.lblWelkom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelkom.AutoSize = true;
            this.lblWelkom.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelkom.Location = new System.Drawing.Point(631, 270);
            this.lblWelkom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelkom.Name = "lblWelkom";
            this.lblWelkom.Size = new System.Drawing.Size(376, 57);
            this.lblWelkom.TabIndex = 0;
            this.lblWelkom.Text = "Welkom bij NetPay";
            this.lblWelkom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNaam
            // 
            this.txtNaam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaam.Location = new System.Drawing.Point(701, 378);
            this.txtNaam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(236, 34);
            this.txtNaam.TabIndex = 1;
            this.txtNaam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWachtwoord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWachtwoord.Location = new System.Drawing.Point(701, 421);
            this.txtWachtwoord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.PasswordChar = '*';
            this.txtWachtwoord.Size = new System.Drawing.Size(236, 34);
            this.txtWachtwoord.TabIndex = 2;
            this.txtWachtwoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnInloggen
            // 
            this.btnInloggen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInloggen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInloggen.Location = new System.Drawing.Point(701, 465);
            this.btnInloggen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(238, 46);
            this.btnInloggen.TabIndex = 3;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click);
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAfsluiten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfsluiten.Location = new System.Drawing.Point(701, 519);
            this.btnAfsluiten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(238, 46);
            this.btnAfsluiten.TabIndex = 4;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Red;
            this.lblLogin.Location = new System.Drawing.Point(660, 569);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(313, 23);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Gebruikersnaam of wachtwoord onjuist!";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.Visible = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1641, 846);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.btnInloggen);
            this.Controls.Add(this.txtWachtwoord);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblWelkom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StartForm";
            this.Padding = new System.Windows.Forms.Padding(25, 75, 25, 25);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelkom;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.Button btnInloggen;
        private System.Windows.Forms.Button btnAfsluiten;
        private System.Windows.Forms.Label lblLogin;
    }
}

