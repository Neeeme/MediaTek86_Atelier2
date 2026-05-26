namespace MediaTek86.view
{
    partial class FrmMediaTek86
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
            this.btnAnnulPers = new System.Windows.Forms.Button();
            this.btnEnregPers = new System.Windows.Forms.Button();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDemandeAbsPers = new System.Windows.Forms.Button();
            this.btnDemandeSuppPers = new System.Windows.Forms.Button();
            this.btnDemandeModifPers = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.grbLePersonnel = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.grbLePersonnel.SuspendLayout();
            this.grbPersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnnulPers
            // 
            this.btnAnnulPers.Location = new System.Drawing.Point(122, 107);
            this.btnAnnulPers.Name = "btnAnnulPers";
            this.btnAnnulPers.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulPers.TabIndex = 10;
            this.btnAnnulPers.Text = "annuler";
            this.btnAnnulPers.UseVisualStyleBackColor = true;
            // 
            // btnEnregPers
            // 
            this.btnEnregPers.Location = new System.Drawing.Point(23, 107);
            this.btnEnregPers.Name = "btnEnregPers";
            this.btnEnregPers.Size = new System.Drawing.Size(75, 23);
            this.btnEnregPers.TabIndex = 2;
            this.btnEnregPers.Text = "enregistrer";
            this.btnEnregPers.UseVisualStyleBackColor = true;
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(312, 79);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(164, 21);
            this.cboService.TabIndex = 9;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(312, 50);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(164, 20);
            this.txtTel.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(312, 20);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(278, 20);
            this.txtMail.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(58, 47);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(216, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(58, 20);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(216, 20);
            this.txtNom.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom";
            // 
            // btnDemandeAbsPers
            // 
            this.btnDemandeAbsPers.Location = new System.Drawing.Point(218, 185);
            this.btnDemandeAbsPers.Name = "btnDemandeAbsPers";
            this.btnDemandeAbsPers.Size = new System.Drawing.Size(75, 23);
            this.btnDemandeAbsPers.TabIndex = 3;
            this.btnDemandeAbsPers.Text = "absences";
            this.btnDemandeAbsPers.UseVisualStyleBackColor = true;
            // 
            // btnDemandeSuppPers
            // 
            this.btnDemandeSuppPers.Location = new System.Drawing.Point(122, 186);
            this.btnDemandeSuppPers.Name = "btnDemandeSuppPers";
            this.btnDemandeSuppPers.Size = new System.Drawing.Size(75, 23);
            this.btnDemandeSuppPers.TabIndex = 2;
            this.btnDemandeSuppPers.Text = "supprimer";
            this.btnDemandeSuppPers.UseVisualStyleBackColor = true;
            // 
            // btnDemandeModifPers
            // 
            this.btnDemandeModifPers.Location = new System.Drawing.Point(23, 186);
            this.btnDemandeModifPers.Name = "btnDemandeModifPers";
            this.btnDemandeModifPers.Size = new System.Drawing.Size(75, 23);
            this.btnDemandeModifPers.TabIndex = 1;
            this.btnDemandeModifPers.Text = "modifier";
            this.btnDemandeModifPers.UseVisualStyleBackColor = true;
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(23, 20);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.Size = new System.Drawing.Size(567, 150);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // grbLePersonnel
            // 
            this.grbLePersonnel.Controls.Add(this.btnDemandeAbsPers);
            this.grbLePersonnel.Controls.Add(this.btnDemandeSuppPers);
            this.grbLePersonnel.Controls.Add(this.btnDemandeModifPers);
            this.grbLePersonnel.Controls.Add(this.dgvPersonnel);
            this.grbLePersonnel.Location = new System.Drawing.Point(18, 14);
            this.grbLePersonnel.Name = "grbLePersonnel";
            this.grbLePersonnel.Size = new System.Drawing.Size(614, 217);
            this.grbLePersonnel.TabIndex = 2;
            this.grbLePersonnel.TabStop = false;
            this.grbLePersonnel.Text = "liste du personnel";
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnAnnulPers);
            this.grbPersonnel.Controls.Add(this.btnEnregPers);
            this.grbPersonnel.Controls.Add(this.cboService);
            this.grbPersonnel.Controls.Add(this.txtTel);
            this.grbPersonnel.Controls.Add(this.txtMail);
            this.grbPersonnel.Controls.Add(this.txtPrenom);
            this.grbPersonnel.Controls.Add(this.txtNom);
            this.grbPersonnel.Controls.Add(this.label5);
            this.grbPersonnel.Controls.Add(this.label4);
            this.grbPersonnel.Controls.Add(this.label3);
            this.grbPersonnel.Controls.Add(this.label2);
            this.grbPersonnel.Controls.Add(this.label1);
            this.grbPersonnel.Location = new System.Drawing.Point(18, 259);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(614, 136);
            this.grbPersonnel.TabIndex = 3;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "ajouter un personnel";
            // 
            // FrmMediaTek86
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 408);
            this.Controls.Add(this.grbLePersonnel);
            this.Controls.Add(this.grbPersonnel);
            this.Name = "FrmMediaTek86";
            this.Text = "FrmMediaTek86";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.grbLePersonnel.ResumeLayout(false);
            this.grbPersonnel.ResumeLayout(false);
            this.grbPersonnel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnnulPers;
        private System.Windows.Forms.Button btnEnregPers;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDemandeAbsPers;
        private System.Windows.Forms.Button btnDemandeSuppPers;
        private System.Windows.Forms.Button btnDemandeModifPers;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.GroupBox grbLePersonnel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbPersonnel;
    }
}