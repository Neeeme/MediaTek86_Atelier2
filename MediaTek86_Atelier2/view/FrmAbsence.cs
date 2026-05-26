using MediaTek86.controller;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.view
{
    public partial class FrmAbsence : Form
    {

        /// <summary>
        /// Variable pour pouvoir stocker le personnel sélectionner
        /// </summary>
        private Personnel personnelRecu;
        /// <summary>
        /// Objet pour pouvoir gérer la liste des absences
        /// </summary>
        private BindingSource bdgAbsence = new BindingSource();
        /// <summary>
        /// Contrôleur de la fenêtre d'absence
        /// </summary>
        private FrmAbsenceController controller;

        public FrmAbsence(Personnel personnelRecu)
        {
            InitializeComponent();
            this.personnelRecu = personnelRecu;
            Init();
        }

        private void FrmAbsence_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Création du controleur d'initialisation
        /// </summary>
        private void Init()
        {
            controller = new FrmAbsenceController();
            RemplirListeAbsence();

        }

        /// <summary>
        /// Afficher la liste des absences du personnel sélectionner
        /// </summary>
        public void RemplirListeAbsence()
        {
            controller.idPersonnel = personnelRecu.Idpersonnel;
            List<Absence> Absences = controller.GetAbsence();
            bdgAbsence.DataSource = Absences;
            dgvAbsences.DataSource = bdgAbsence;
            dgvAbsences.Columns["Idpersonnel"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
