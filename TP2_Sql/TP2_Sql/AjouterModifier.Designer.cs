﻿namespace TP2_Sql
{
    partial class AjouterModifier
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
            this.components = new System.ComponentModel.Container();
            this.btn_Enregistrer = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NumEmp = new System.Windows.Forms.TextBox();
            this.tb_Echelon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Prenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Salaire = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Dep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Adresse = new System.Windows.Forms.TextBox();
            this.TP_NumEmp = new System.Windows.Forms.ToolTip(this.components);
            this.TP_Echelon = new System.Windows.Forms.ToolTip(this.components);
            this.TP_Dep = new System.Windows.Forms.ToolTip(this.components);
            this.TP_Salaire = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_Enregistrer
            // 
            this.btn_Enregistrer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Enregistrer.Location = new System.Drawing.Point(60, 258);
            this.btn_Enregistrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Enregistrer.Name = "btn_Enregistrer";
            this.btn_Enregistrer.Size = new System.Drawing.Size(93, 33);
            this.btn_Enregistrer.TabIndex = 0;
            this.btn_Enregistrer.Text = "Enregistrer";
            this.btn_Enregistrer.UseVisualStyleBackColor = true;
            this.btn_Enregistrer.Click += new System.EventHandler(this.btn_Enregistrer_Click);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Annuler.Location = new System.Drawing.Point(160, 258);
            this.btn_Annuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(93, 33);
            this.btn_Annuler.TabIndex = 1;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero Employé";
            // 
            // tb_NumEmp
            // 
            this.tb_NumEmp.Location = new System.Drawing.Point(160, 22);
            this.tb_NumEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_NumEmp.Name = "tb_NumEmp";
            this.tb_NumEmp.Size = new System.Drawing.Size(100, 22);
            this.tb_NumEmp.TabIndex = 1;
            this.tb_NumEmp.TextChanged += new System.EventHandler(this.TB_Adresse_TextChanged_1);
            // 
            // tb_Echelon
            // 
            this.tb_Echelon.Location = new System.Drawing.Point(160, 148);
            this.tb_Echelon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Echelon.Name = "tb_Echelon";
            this.tb_Echelon.Size = new System.Drawing.Size(100, 22);
            this.tb_Echelon.TabIndex = 5;
            this.tb_Echelon.TextChanged += new System.EventHandler(this.TB_Adresse_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Échelon";
            // 
            // tb_Nom
            // 
            this.tb_Nom.Location = new System.Drawing.Point(160, 53);
            this.tb_Nom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Nom.Name = "tb_Nom";
            this.tb_Nom.Size = new System.Drawing.Size(100, 22);
            this.tb_Nom.TabIndex = 2;
            this.tb_Nom.TextChanged += new System.EventHandler(this.TB_Adresse_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom";
            // 
            // tb_Prenom
            // 
            this.tb_Prenom.Location = new System.Drawing.Point(160, 84);
            this.tb_Prenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Prenom.Name = "tb_Prenom";
            this.tb_Prenom.Size = new System.Drawing.Size(100, 22);
            this.tb_Prenom.TabIndex = 3;
            this.tb_Prenom.TextChanged += new System.EventHandler(this.TB_Adresse_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prénom";
            // 
            // tb_Salaire
            // 
            this.tb_Salaire.Location = new System.Drawing.Point(160, 116);
            this.tb_Salaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Salaire.MaxLength = 6;
            this.tb_Salaire.Name = "tb_Salaire";
            this.tb_Salaire.Size = new System.Drawing.Size(100, 22);
            this.tb_Salaire.TabIndex = 4;
            this.tb_Salaire.Text = "25000";
            this.tb_Salaire.TextChanged += new System.EventHandler(this.TB_Adresse_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salaire";
            // 
            // tb_Dep
            // 
            this.tb_Dep.Location = new System.Drawing.Point(160, 178);
            this.tb_Dep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Dep.Name = "tb_Dep";
            this.tb_Dep.Size = new System.Drawing.Size(100, 22);
            this.tb_Dep.TabIndex = 6;
            this.tb_Dep.TextChanged += new System.EventHandler(this.TB_Adresse_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Département";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Adresse";
            // 
            // TB_Adresse
            // 
            this.TB_Adresse.Location = new System.Drawing.Point(160, 209);
            this.TB_Adresse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_Adresse.Name = "TB_Adresse";
            this.TB_Adresse.Size = new System.Drawing.Size(100, 22);
            this.TB_Adresse.TabIndex = 14;
            this.TB_Adresse.TextChanged += new System.EventHandler(this.TB_Adresse_TextChanged_1);
            // 
            // TP_NumEmp
            // 
            this.TP_NumEmp.AutomaticDelay = 1;
            this.TP_NumEmp.AutoPopDelay = 5000;
            this.TP_NumEmp.InitialDelay = 1;
            this.TP_NumEmp.ReshowDelay = 5;
            // 
            // TP_Echelon
            // 
            this.TP_Echelon.AutomaticDelay = 1;
            this.TP_Echelon.AutoPopDelay = 5000;
            this.TP_Echelon.InitialDelay = 1;
            this.TP_Echelon.ReshowDelay = 5;
            // 
            // TP_Dep
            // 
            this.TP_Dep.AutomaticDelay = 1;
            this.TP_Dep.AutoPopDelay = 5000;
            this.TP_Dep.InitialDelay = 1;
            this.TP_Dep.ReshowDelay = 5;
            // 
            // TP_Salaire
            // 
            this.TP_Salaire.AutomaticDelay = 1;
            this.TP_Salaire.AutoPopDelay = 5000;
            this.TP_Salaire.InitialDelay = 1;
            this.TP_Salaire.ReshowDelay = 5;
            // 
            // AjouterModifier
            // 
            this.AcceptButton = this.btn_Enregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(137)))));
            this.CancelButton = this.btn_Annuler;
            this.ClientSize = new System.Drawing.Size(315, 316);
            this.Controls.Add(this.TB_Adresse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Dep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Salaire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Prenom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Nom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Echelon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_NumEmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.btn_Enregistrer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AjouterModifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterModifier";
            this.Load += new System.EventHandler(this.AjouterModifier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Enregistrer;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_NumEmp;
        private System.Windows.Forms.TextBox tb_Echelon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Prenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Salaire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Dep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Adresse;
        private System.Windows.Forms.ToolTip TP_NumEmp;
        private System.Windows.Forms.ToolTip TP_Echelon;
        private System.Windows.Forms.ToolTip TP_Dep;
        private System.Windows.Forms.ToolTip TP_Salaire;
    }
}