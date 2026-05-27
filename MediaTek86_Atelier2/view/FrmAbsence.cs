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
        /// Objet pour pouvoir gérer la liste des motifs
        /// </summary>
        private BindingSource bdgMotifs = new BindingSource();
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
            RemplirListeMotif();
            RemplirNomPrenom();

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


        /// <summary>
        /// Permet de remplir la liste motifs absences dans le combo box pour pouvoir les sélectionner lors de l'ajout ou la modification d'un personnel
        /// </summary>
        private void RemplirListeMotif()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cboMotif.DataSource = bdgMotifs;
        }

        /// <summary>
        /// Permet de remplir la liste des prénoms et noms du personnel sélectionner pour pouvoir les afficher dans la fenêtre d'absence
        /// </summary>
        private void RemplirNomPrenom()
        {
            nomLabel.Text = personnelRecu.Nom;
            prnLabel.Text = personnelRecu.Prenom;
        }

        private void btnEnregAbs_Click(object sender, EventArgs e)
        {
            if (!dtpDebutAbs.Value.Equals("") && !dtpFinAbs.Text.Equals("") && cboMotif.SelectedIndex != -1)
            {
                if (dtpFinAbs.Value > dtpDebutAbs.Value)
                {
                    if (controller.CreneauLibre(personnelRecu.Idpersonnel, dtpDebutAbs.Value, dtpFinAbs.Value))
                    {
                        Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                        Absence absence = new Absence(personnelRecu, dtpDebutAbs.Value, dtpFinAbs.Value, motif);
                        controller.AddAbsence(absence);
                        RemplirListeAbsence();
                    }
                    else
                    {
                        MessageBox.Show("Il existe déjà une absence pour ce créneau.", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("La date de fin doit être antérieure à la date de début.", "Information");
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}
