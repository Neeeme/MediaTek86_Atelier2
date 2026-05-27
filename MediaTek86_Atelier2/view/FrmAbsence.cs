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
        /// Permet de vérifier si une absence est en cours de modification
        /// </summary>
        private Boolean enCoursDeModifAbsence = false;
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

        /// <summary>
        /// Permet d'enregistrer une absence dans la base de données ou de modifier une absence déjà enregistrée en fonction du boolean enCoursDeModifAbsence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregAbs_Click(object sender, EventArgs e)
        {
            if (!dtpDebutAbs.Value.Equals("") && !dtpFinAbs.Text.Equals("") && cboMotif.SelectedIndex != -1)
            {
                if (dtpFinAbs.Value > dtpDebutAbs.Value)
                {
                    if (controller.CreneauLibre(personnelRecu.Idpersonnel, dtpDebutAbs.Value, dtpFinAbs.Value))
                    {
                        Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                        if (enCoursDeModifAbsence)
                        {
                            Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                            if (MessageBox.Show("Voulez-vous vraiment modifier l'absence du " + absence.date_de_debut + " jusqu'au " + absence.date_de_fin + " de " + personnelRecu.Nom + " " + personnelRecu.Prenom + "?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                absence.idpersonnel = personnelRecu;
                                absence.date_de_debut = dtpDebutAbs.Value;
                                absence.date_de_fin = dtpFinAbs.Value;
                                absence.motif = motif;
                                controller.UpdateAbsence(absence);
                            }
                        }
                        else
                        {
                            Absence absence = new Absence(personnelRecu, dtpDebutAbs.Value, dtpFinAbs.Value, motif);
                            controller.AddAbsence(absence);
                        }
                        RemplirListeAbsence();
                        EnCoursModifAbsence(false);
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

        /// <summary>
        /// Permet de changer le boolean enCoursDeModifAbsence pour pouvoir différencier une modification d'une création d'une absence et de changer le titre du group box en fonction de l'action en cours
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursModifAbsence(Boolean modif)
        {
            enCoursDeModifAbsence = modif;
            if (modif)
            {
                grbAbsence.Text = "modifier une absence";
            }
            else
            {
                grbAbsence.Text = "ajouter une absence";
                dtpDebutAbs.Value = DateTime.Now;
                dtpFinAbs.Value = DateTime.Now;
                cboMotif.SelectedIndex = 0;
            }
        }

        private void btnDemandeModifAbs_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                EnCoursModifAbsence(true);
                dtpDebutAbs.Value = absence.date_de_debut;
                dtpFinAbs.Value = absence.date_de_fin;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.motif.Libelle);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnDemandeSuppAbs_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer l'absence du " + absence.date_de_debut + " jusqu'au " + absence.date_de_fin + " de " + personnelRecu.Nom + " " + personnelRecu.Prenom + "?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    absence.idpersonnel = personnelRecu;
                    absence.date_de_debut = absence.date_de_debut;
                    absence.date_de_fin = absence.date_de_fin;
                    absence.motif = absence.motif;
                    controller.DelAbsence(absence);
                    RemplirListeAbsence();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne.", "Information");
            }
        }

        private void btnAnnulAbs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Souhaitez-vous vraiment annuler votre enregistrement/modification?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModifAbsence(false);
            }
        }
    }
}
