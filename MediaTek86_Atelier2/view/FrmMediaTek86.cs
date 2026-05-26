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
    }
}
