using MediaTek86.dal;
using MediaTek86.model;
using System.Collections.Generic;

namespace MediaTek86.controller
{
    internal class FrmMediaTek86Controller
    {

        /// <summary>
        /// récupère les opérations possibles sur le personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;

        /// <summary>
        /// récupère les opérations possibles sur le service
        /// </summary>
        private readonly ServiceAccess serviceAccess;
        /// <summary>
        /// récupère les opérations possibles sur le service
        /// </summary>
        private readonly AbsenceAccess absenceAccess;


        /// <summary>
        /// Récupère les accès aux données
        /// </summary>
        public FrmMediaTek86Controller()
        {
            personnelAccess = new PersonnelAccess();
            serviceAccess = new ServiceAccess();
            absenceAccess = new AbsenceAccess();
        }

        /// <summary>
        /// Récupère et retourne l'intégralité du personnel
        /// </summary>
        /// <returns></returns>
        public List<Personnel> GetLePersonnel()
        {
            return personnelAccess.GetLePersonnel();
        }

        /// <summary>
        /// Récupère et retourne l'intégralité des services
        /// </summary>
        /// <returns></returns>
        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }


        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            personnelAccess.DelPersonnel(personnel);
        }

        /// <summary>
        /// Suppression de l'intégralité des absences d'un personnel lorsque celui ci est supprimé
        /// </summary>
        /// <param name="personnel">objet absence sur personnel à supprimer</param>
        public void DelLesAbsences(Personnel personnel)
        {
            absenceAccess.DelLesAbsences(personnel);
        }
    }
}
