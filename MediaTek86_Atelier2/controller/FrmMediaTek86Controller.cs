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
        /// Récupère les accès aux données
        /// </summary>
        public FrmMediaTek86Controller()
        {
            personnelAccess = new PersonnelAccess();
        }

        /// <summary>
        /// Récupère et retourne l'intégralité du personnel
        /// </summary>
        /// <returns></returns>
        public List<Personnel> GetLePersonnel()
        {
            return personnelAccess.GetLePersonnel();
        }

    }
}
