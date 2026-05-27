namespace MediaTek86.view
{
    partial class FrmAbsence
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
            this.btnAnnulAbs = new System.Windows.Forms.Button();
            this.btnEnregAbs = new System.Windows.Forms.Button();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFinAbs = new System.Windows.Forms.DateTimePicker();
            this.dtpDebutAbs = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbAbsence = new System.Windows.Forms.GroupBox();
            this.prnLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.btnDemandeModifAbs = new System.Windows.Forms.Button();
            this.btnDemandeSuppAbs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grbAbsPersonnel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.grbAbsence.SuspendLayout();
            this.grbAbsPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnulAbs
            // 
            this.btnAnnulAbs.Location = new System.Drawing.Point(105, 99);
            this.btnAnnulAbs.Name = "btnAnnulAbs";
            this.btnAnnulAbs.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulAbs.TabIndex = 7;
            this.btnAnnulAbs.Text = "annuler";
            this.btnAnnulAbs.UseVisualStyleBackColor = true;
            // 
            // btnEnregAbs
            // 
            this.btnEnregAbs.Location = new System.Drawing.Point(10, 99);
            this.btnEnregAbs.Name = "btnEnregAbs";
            this.btnEnregAbs.Size = new System.Drawing.Size(75, 23);
            this.btnEnregAbs.TabIndex = 6;
            this.btnEnregAbs.Text = "enregistrer";
            this.btnEnregAbs.UseVisualStyleBackColor = true;
            this.btnEnregAbs.Click += new System.EventHandler(this.btnEnregAbs_Click);
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(341, 34);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(121, 21);
            this.cboMotif.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "motif :";
            // 
            // dtpFinAbs
            // 
            this.dtpFinAbs.Location = new System.Drawing.Point(91, 63);
            this.dtpFinAbs.Name = "dtpFinAbs";
            this.dtpFinAbs.Size = new System.Drawing.Size(200, 20);
            this.dtpFinAbs.TabIndex = 3;
            // 
            // dtpDebutAbs
            // 
            this.dtpDebutAbs.Location = new System.Drawing.Point(91, 37);
            this.dtpDebutAbs.Name = "dtpDebutAbs";
            this.dtpDebutAbs.Size = new System.Drawing.Size(200, 20);
            this.dtpDebutAbs.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "date de fin :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "date de début :";
            // 
            // grbAbsence
            // 
            this.grbAbsence.Controls.Add(this.btnAnnulAbs);
            this.grbAbsence.Controls.Add(this.btnEnregAbs);
            this.grbAbsence.Controls.Add(this.cboMotif);
            this.grbAbsence.Controls.Add(this.label5);
            this.grbAbsence.Controls.Add(this.dtpFinAbs);
            this.grbAbsence.Controls.Add(this.dtpDebutAbs);
            this.grbAbsence.Controls.Add(this.label4);
            this.grbAbsence.Controls.Add(this.label3);
            this.grbAbsence.Location = new System.Drawing.Point(21, 240);
            this.grbAbsence.Name = "grbAbsence";
            this.grbAbsence.Size = new System.Drawing.Size(468, 129);
            this.grbAbsence.TabIndex = 3;
            this.grbAbsence.TabStop = false;
            this.grbAbsence.Text = "ajouter une absence";
            // 
            // prnLabel
            // 
            this.prnLabel.AutoSize = true;
            this.prnLabel.Location = new System.Drawing.Point(195, 183);
            this.prnLabel.Name = "prnLabel";
            this.prnLabel.Size = new System.Drawing.Size(43, 13);
            this.prnLabel.TabIndex = 7;
            this.prnLabel.Text = "Antoine";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(52, 183);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(38, 13);
            this.nomLabel.TabIndex = 6;
            this.nomLabel.Text = "Garcia";
            // 
            // btnDemandeModifAbs
            // 
            this.btnDemandeModifAbs.Location = new System.Drawing.Point(269, 178);
            this.btnDemandeModifAbs.Name = "btnDemandeModifAbs";
            this.btnDemandeModifAbs.Size = new System.Drawing.Size(75, 23);
            this.btnDemandeModifAbs.TabIndex = 5;
            this.btnDemandeModifAbs.Text = "modifier";
            this.btnDemandeModifAbs.UseVisualStyleBackColor = true;
            this.btnDemandeModifAbs.Click += new System.EventHandler(this.btnDemandeModifAbs_Click);
            // 
            // btnDemandeSuppAbs
            // 
            this.btnDemandeSuppAbs.Location = new System.Drawing.Point(361, 178);
            this.btnDemandeSuppAbs.Name = "btnDemandeSuppAbs";
            this.btnDemandeSuppAbs.Size = new System.Drawing.Size(75, 23);
            this.btnDemandeSuppAbs.TabIndex = 4;
            this.btnDemandeSuppAbs.Text = "supprimer";
            this.btnDemandeSuppAbs.UseVisualStyleBackColor = true;
            this.btnDemandeSuppAbs.Click += new System.EventHandler(this.btnDemandeSuppAbs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "prénom :";
            // 
            // grbAbsPersonnel
            // 
            this.grbAbsPersonnel.Controls.Add(this.prnLabel);
            this.grbAbsPersonnel.Controls.Add(this.nomLabel);
            this.grbAbsPersonnel.Controls.Add(this.btnDemandeModifAbs);
            this.grbAbsPersonnel.Controls.Add(this.btnDemandeSuppAbs);
            this.grbAbsPersonnel.Controls.Add(this.label2);
            this.grbAbsPersonnel.Controls.Add(this.label1);
            this.grbAbsPersonnel.Controls.Add(this.dgvAbsences);
            this.grbAbsPersonnel.Location = new System.Drawing.Point(15, 14);
            this.grbAbsPersonnel.Name = "grbAbsPersonnel";
            this.grbAbsPersonnel.Size = new System.Drawing.Size(475, 215);
            this.grbAbsPersonnel.TabIndex = 2;
            this.grbAbsPersonnel.TabStop = false;
            this.grbAbsPersonnel.Text = "absence d\'un personnel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nom :";
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(15, 19);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.Size = new System.Drawing.Size(453, 147);
            this.dgvAbsences.TabIndex = 0;
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 383);
            this.Controls.Add(this.grbAbsence);
            this.Controls.Add(this.grbAbsPersonnel);
            this.Name = "FrmAbsence";
            this.Text = "Absence";
            this.Load += new System.EventHandler(this.FrmAbsence_Load);
            this.grbAbsence.ResumeLayout(false);
            this.grbAbsence.PerformLayout();
            this.grbAbsPersonnel.ResumeLayout(false);
            this.grbAbsPersonnel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnnulAbs;
        private System.Windows.Forms.Button btnEnregAbs;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFinAbs;
        private System.Windows.Forms.DateTimePicker dtpDebutAbs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbAbsence;
        private System.Windows.Forms.Label prnLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Button btnDemandeModifAbs;
        private System.Windows.Forms.Button btnDemandeSuppAbs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbAbsPersonnel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAbsences;
    }
}