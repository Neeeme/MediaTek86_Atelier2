using MediaTek86.dal;
using MediaTek86.model;
using System;

namespace MediaTek86.controller
{
    /// <summary>
    /// Contrôleur de FrmAuthentification
    /// </summary>
    internal class FrmAuthentificationController
    {
        /// <summary>
        /// récupère les opérations possibles sur Responsable
        /// </summary>
        private readonly ResponsableAccess responsableAccess;

        /// <summary>
        /// Récupère l'accès aux données
        /// </summary>
        public FrmAuthentificationController()
        {
            responsableAccess = new ResponsableAccess();
        }

        /// <summary>
        /// Permet de contrôler l'authentification
        /// </summary>
        /// <param name="responsable"></param>
        /// <returns></returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            return responsableAccess.ControleAuthentification(responsable);
        }
    }
}
