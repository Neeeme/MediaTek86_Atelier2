using MediaTek86.controller;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.view
{
    public partial class FrmMediaTek86 : Form
    {
        /// <summary>
        /// Boolean pour savoir si on est en train de modifier un personnel
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;
        /// <summary>
        /// Objet pour pouvoir gérer la liste du personnel
        /// </summary>
        private BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// Objet pour pouvoir gérer la liste des services
        /// </summary>
        private BindingSource bdgServices = new BindingSource();
        /// <summary>
        /// Contrôleur de la fenêtre d'authentification
        /// </summary>
        private FrmMediaTek86Controller controller;

        public FrmMediaTek86()
        {
            InitializeComponent();
            Init();
        }

        private void FrmMediaTek86_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Création du controleur d'initialisation
        /// </summary>
        private void Init()
        {
            controller = new FrmMediaTek86Controller();
            RemplirListePersonnel();
            RemplirListeServices();
            EnCoursModifPersonnel(false);
        }

        /// <summary>
        /// Afficher la liste du personnel
        /// </summary>
        private void RemplirListePersonnel()
        {
            List<Personnel> lePersonnel = controller.GetLePersonnel();
            bdgPersonnel.DataSource = lePersonnel;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["Idpersonnel"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Permet de remplir la liste des services dans le combo box pour pouvoir les sélectionner lors de l'ajout ou la modification d'un personnel
        /// </summary>
        private void RemplirListeServices()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgServices.DataSource = lesServices;
            cboService.DataSource = bdgServices;
        }
        
        /// <summary>
        /// Permet d'enregistrer un nouveau personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregPers_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                Service service = (Service)bdgServices.List[bdgServices.Position];
                    if (enCoursDeModifPersonnel)
                    {
                        Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                        if (MessageBox.Show("Voulez-vous vraiment modifier les informations de " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                personnel.Nom = txtNom.Text;
                                personnel.Prenom = txtPrenom.Text;
                                personnel.Tel = txtTel.Text;
                                personnel.Mail = txtMail.Text;
                                personnel.Service = service;
                                controller.UpdatePersonnel(personnel);
                            }
                    }
                    else
                    {
                        Personnel personnel = new Personnel(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service);
                        controller.AddPersonnel(personnel);
                    }
                    RemplirListePersonnel();
                    EnCoursModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Permet de remplir les champs de la partie modification avec les informations du personnel sélectionner et de changer le boolean enCoursDeModifPersonnel pour différencier une modification d'une création d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemandeModifPers_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                EnCoursModifPersonnel(true);
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Affichage de la modification d'un personnel si jamais on le modifie, sinon affichage ajout d'un personnal
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursModifPersonnel(Boolean modif)
        {
            enCoursDeModifPersonnel = modif;
            grbLePersonnel.Enabled = !modif;
            if (modif)
            {
                grbPersonnel.Text = "modifier un personnel";
            }
            else
            {
                grbPersonnel.Text = "ajouter un personnel";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }

        /// <summary>
        /// Permet d'annuler la modification d'un personnel, ou l'ajout d'un personnel
        /// Vide les zones de saisies du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulPers_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Souhaitez-vous vraiment annuler votre enregistrement/modification?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModifPersonnel(false);
            }
        }

        /// <summary>
        /// Permet de supprimer un personnel de la base de données après confirmation de l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemandeSuppPers_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne.", "Information");
            }
        }

        private void btnDemandeAbsPers_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnelSelectionne = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                FrmAbsence frm = new FrmAbsence(personnelSelectionne);
                frm.ShowDialog();
            }

            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne.", "Information");
            }
        }

        private void dgvPersonnel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
