﻿namespace TP2_Sql
{
    partial class FormPrincipale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Rechercher = new System.Windows.Forms.Button();
            this.TB_ModSup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Connection = new System.Windows.Forms.Label();
            this.BTN_Suivant = new System.Windows.Forms.Button();
            this.BTN_Precedant = new System.Windows.Forms.Button();
            this.GB_Employe = new System.Windows.Forms.GroupBox();
            this.LB_Adresse = new System.Windows.Forms.Label();
            this.LB_Dep = new System.Windows.Forms.Label();
            this.LB_Salaire = new System.Windows.Forms.Label();
            this.LB_Echelon = new System.Windows.Forms.Label();
            this.LB_Nom = new System.Windows.Forms.Label();
            this.LB_Prenom = new System.Windows.Forms.Label();
            this.LB_Numemp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_Departement = new System.Windows.Forms.DataGridView();
            this.CodeDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbrEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GB_Employe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Departement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(65, 190);
            this.btn_Ajouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(155, 33);
            this.btn_Ajouter.TabIndex = 3;
            this.btn_Ajouter.Text = "Ajouter un employé";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(165, 276);
            this.btn_Supprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(99, 33);
            this.btn_Supprimer.TabIndex = 4;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(165, 238);
            this.btn_Modifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(99, 33);
            this.btn_Modifier.TabIndex = 5;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Rechercher
            // 
            this.btn_Rechercher.Location = new System.Drawing.Point(426, 150);
            this.btn_Rechercher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Rechercher.Name = "btn_Rechercher";
            this.btn_Rechercher.Size = new System.Drawing.Size(99, 33);
            this.btn_Rechercher.TabIndex = 6;
            this.btn_Rechercher.Text = "Rechercher";
            this.btn_Rechercher.UseVisualStyleBackColor = true;
            this.btn_Rechercher.Click += new System.EventHandler(this.btn_Rechercher_Click);
            // 
            // TB_ModSup
            // 
            this.TB_ModSup.Location = new System.Drawing.Point(42, 275);
            this.TB_ModSup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_ModSup.MaxLength = 6;
            this.TB_ModSup.Name = "TB_ModSup";
            this.TB_ModSup.Size = new System.Drawing.Size(100, 22);
            this.TB_ModSup.TabIndex = 8;
            this.TB_ModSup.TextChanged += new System.EventHandler(this.TB_ModSup_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero d\'Employé";
            // 
            // LB_Connection
            // 
            this.LB_Connection.AutoSize = true;
            this.LB_Connection.Location = new System.Drawing.Point(71, 26);
            this.LB_Connection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Connection.Name = "LB_Connection";
            this.LB_Connection.Size = new System.Drawing.Size(51, 17);
            this.LB_Connection.TabIndex = 10;
            this.LB_Connection.Text = "Closed";
            // 
            // BTN_Suivant
            // 
            this.BTN_Suivant.Location = new System.Drawing.Point(479, 402);
            this.BTN_Suivant.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Suivant.Name = "BTN_Suivant";
            this.BTN_Suivant.Size = new System.Drawing.Size(100, 28);
            this.BTN_Suivant.TabIndex = 12;
            this.BTN_Suivant.Text = "Suivant";
            this.BTN_Suivant.UseVisualStyleBackColor = true;
            this.BTN_Suivant.Click += new System.EventHandler(this.BTN_Suivant_Click);
            // 
            // BTN_Precedant
            // 
            this.BTN_Precedant.Location = new System.Drawing.Point(371, 402);
            this.BTN_Precedant.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Precedant.Name = "BTN_Precedant";
            this.BTN_Precedant.Size = new System.Drawing.Size(100, 28);
            this.BTN_Precedant.TabIndex = 11;
            this.BTN_Precedant.Text = "Précédant";
            this.BTN_Precedant.UseVisualStyleBackColor = true;
            this.BTN_Precedant.Click += new System.EventHandler(this.BTN_Precedant_Click);
            // 
            // GB_Employe
            // 
            this.GB_Employe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(137)))));
            this.GB_Employe.Controls.Add(this.LB_Adresse);
            this.GB_Employe.Controls.Add(this.LB_Dep);
            this.GB_Employe.Controls.Add(this.LB_Salaire);
            this.GB_Employe.Controls.Add(this.LB_Echelon);
            this.GB_Employe.Controls.Add(this.LB_Nom);
            this.GB_Employe.Controls.Add(this.LB_Prenom);
            this.GB_Employe.Controls.Add(this.LB_Numemp);
            this.GB_Employe.Controls.Add(this.label8);
            this.GB_Employe.Controls.Add(this.label7);
            this.GB_Employe.Controls.Add(this.label6);
            this.GB_Employe.Controls.Add(this.label5);
            this.GB_Employe.Controls.Add(this.label4);
            this.GB_Employe.Controls.Add(this.label3);
            this.GB_Employe.Controls.Add(this.label2);
            this.GB_Employe.Location = new System.Drawing.Point(302, 190);
            this.GB_Employe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_Employe.Name = "GB_Employe";
            this.GB_Employe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_Employe.Size = new System.Drawing.Size(334, 206);
            this.GB_Employe.TabIndex = 13;
            this.GB_Employe.TabStop = false;
            this.GB_Employe.Text = " Employé (X résultats)";
            // 
            // LB_Adresse
            // 
            this.LB_Adresse.AutoSize = true;
            this.LB_Adresse.Location = new System.Drawing.Point(121, 174);
            this.LB_Adresse.Name = "LB_Adresse";
            this.LB_Adresse.Size = new System.Drawing.Size(149, 17);
            this.LB_Adresse.TabIndex = 13;
            this.LB_Adresse.Text = "105 Inconnu, Montreal";
            // 
            // LB_Dep
            // 
            this.LB_Dep.AutoSize = true;
            this.LB_Dep.Location = new System.Drawing.Point(121, 151);
            this.LB_Dep.Name = "LB_Dep";
            this.LB_Dep.Size = new System.Drawing.Size(150, 17);
            this.LB_Dep.TabIndex = 12;
            this.LB_Dep.Text = "Ressources Humaines";
            // 
            // LB_Salaire
            // 
            this.LB_Salaire.AutoSize = true;
            this.LB_Salaire.Location = new System.Drawing.Point(121, 130);
            this.LB_Salaire.Name = "LB_Salaire";
            this.LB_Salaire.Size = new System.Drawing.Size(48, 17);
            this.LB_Salaire.TabIndex = 11;
            this.LB_Salaire.Text = "25000";
            // 
            // LB_Echelon
            // 
            this.LB_Echelon.AutoSize = true;
            this.LB_Echelon.Location = new System.Drawing.Point(121, 107);
            this.LB_Echelon.Name = "LB_Echelon";
            this.LB_Echelon.Size = new System.Drawing.Size(16, 17);
            this.LB_Echelon.TabIndex = 10;
            this.LB_Echelon.Text = "0";
            // 
            // LB_Nom
            // 
            this.LB_Nom.AutoSize = true;
            this.LB_Nom.Location = new System.Drawing.Point(121, 85);
            this.LB_Nom.Name = "LB_Nom";
            this.LB_Nom.Size = new System.Drawing.Size(34, 17);
            this.LB_Nom.TabIndex = 9;
            this.LB_Nom.Text = "Doe";
            // 
            // LB_Prenom
            // 
            this.LB_Prenom.AutoSize = true;
            this.LB_Prenom.Location = new System.Drawing.Point(121, 63);
            this.LB_Prenom.Name = "LB_Prenom";
            this.LB_Prenom.Size = new System.Drawing.Size(39, 17);
            this.LB_Prenom.TabIndex = 8;
            this.LB_Prenom.Text = "Jane";
            // 
            // LB_Numemp
            // 
            this.LB_Numemp.AutoSize = true;
            this.LB_Numemp.Location = new System.Drawing.Point(121, 39);
            this.LB_Numemp.Name = "LB_Numemp";
            this.LB_Numemp.Size = new System.Drawing.Size(24, 17);
            this.LB_Numemp.TabIndex = 7;
            this.LB_Numemp.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Adresse :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Departement :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Salaire :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Echelon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prenom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "NumEmp :";
            // 
            // DGV_Departement
            // 
            this.DGV_Departement.AllowUserToAddRows = false;
            this.DGV_Departement.AllowUserToDeleteRows = false;
            this.DGV_Departement.AllowUserToResizeColumns = false;
            this.DGV_Departement.AllowUserToResizeRows = false;
            this.DGV_Departement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(100)))));
            this.DGV_Departement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Departement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeDep,
            this.NomDep,
            this.NbrEmp});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Departement.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Departement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(125)))));
            this.DGV_Departement.Location = new System.Drawing.Point(302, 20);
            this.DGV_Departement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_Departement.MultiSelect = false;
            this.DGV_Departement.Name = "DGV_Departement";
            this.DGV_Departement.ReadOnly = true;
            this.DGV_Departement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGV_Departement.RowHeadersVisible = false;
            this.DGV_Departement.RowTemplate.Height = 24;
            this.DGV_Departement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Departement.Size = new System.Drawing.Size(334, 112);
            this.DGV_Departement.TabIndex = 14;
            // 
            // CodeDep
            // 
            this.CodeDep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CodeDep.HeaderText = "Code";
            this.CodeDep.MaxInputLength = 4;
            this.CodeDep.Name = "CodeDep";
            this.CodeDep.ReadOnly = true;
            this.CodeDep.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodeDep.Width = 70;
            // 
            // NomDep
            // 
            this.NomDep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NomDep.HeaderText = "Nom Dép";
            this.NomDep.MaxInputLength = 50;
            this.NomDep.Name = "NomDep";
            this.NomDep.ReadOnly = true;
            this.NomDep.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomDep.Width = 170;
            // 
            // NbrEmp
            // 
            this.NbrEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NbrEmp.HeaderText = "NbEmp";
            this.NbrEmp.MaxInputLength = 3;
            this.NbrEmp.Name = "NbrEmp";
            this.NbrEmp.ReadOnly = true;
            this.NbrEmp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NbrEmp.Width = 70;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TP2_Sql.Properties.Resources.Deconnecter;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(653, 453);
            this.Controls.Add(this.DGV_Departement);
            this.Controls.Add(this.GB_Employe);
            this.Controls.Add(this.BTN_Precedant);
            this.Controls.Add(this.BTN_Suivant);
            this.Controls.Add(this.LB_Connection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_ModSup);
            this.Controls.Add(this.btn_Rechercher);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipale_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.GB_Employe.ResumeLayout(false);
            this.GB_Employe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Departement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Rechercher;
        private System.Windows.Forms.TextBox TB_ModSup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Connection;
        private System.Windows.Forms.Button BTN_Suivant;
        private System.Windows.Forms.Button BTN_Precedant;
        private System.Windows.Forms.GroupBox GB_Employe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_Departement;
        private System.Windows.Forms.Label LB_Prenom;
        private System.Windows.Forms.Label LB_Numemp;
        private System.Windows.Forms.Label LB_Adresse;
        private System.Windows.Forms.Label LB_Dep;
        private System.Windows.Forms.Label LB_Salaire;
        private System.Windows.Forms.Label LB_Echelon;
        private System.Windows.Forms.Label LB_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbrEmp;
    }
}