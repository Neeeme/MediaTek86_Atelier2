using MediaTek86.controller;
using MediaTek86.dal;
using MediaTek86.model;
using System;
using System.Windows.Forms;

namespace MediaTek86.view
{
    /// <summary>
    /// Fenêtre pour s'authentifier (Seulement le responsable peut accéder à l'application)
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre d'authentification
        /// </summary>
        private FrmAuthentificationController controller;

        /// <summary>
        /// Création des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Création du controleur d'initialisation
        /// </summary>
        private void Init()
        {
            controller = new FrmAuthentificationController();
        }

        private void FrmAuthentification_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Permet de se connecter à l'application en vérifiant les identifiants du responsable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;
            String pwd = txtPwd.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Erreur");
            }

            else
            {
                Responsable resp = new Responsable(login, pwd);
                if (controller.ControleAuthentification(resp))
                {
                    FrmMediaTek86 frm = new FrmMediaTek86();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Identifiants incorrects.", "Erreur");
                }

            }
        }
    }
}
