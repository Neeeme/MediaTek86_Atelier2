using MediaTek86.dal;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.controller
{
    internal class FrmAbsenceController
    {


        /// <summary>
        /// récupère les opérations possibles sur les absences
        /// </summary>
        private readonly AbsenceAccess absenceAccess;

        /// <summary>
        /// récupère les opérations possibles sur les motifs
        /// </summary>
        private readonly MotifAccess motifAccess;

        /// <summary>
        /// Création d'une valeur idPersonnel pour stocker l'id du personnel dont on veut récupérer les absences
        /// </summary>
        public int idPersonnel { get; set; }


        /// <summary>
        /// Permet de initialiser les accès aux données d'absence et de motif
        /// </summary>
        public FrmAbsenceController()
        {
            absenceAccess = new AbsenceAccess();
            motifAccess = new MotifAccess();
        }

        /// <summary>
        /// Récupère et retourne les absences d'un personnel à partir de son id
        /// </summary>
        /// <returns></returns>
        public List<Absence> GetAbsence()
        {
            return absenceAccess.GetAbsence(this.idPersonnel);
        }

        /// <summary>
        /// Récupère et retourne l'intégralité des motifs
        /// </summary>
        /// <returns></returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }
    }
}
