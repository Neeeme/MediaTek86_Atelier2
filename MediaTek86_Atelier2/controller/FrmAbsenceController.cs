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

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }

        /// <summary>
        /// Permet de vérifier si un créneau d'absence est libre pour un personnel donné
        /// </summary>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="datedebutavantmodif"></param>
        /// <returns></returns>
        public bool CreneauLibre(DateTime datedebut, DateTime datefin, DateTime? datedebutavantmodif)
        {
            List<Absence> absences = GetAbsence();

            foreach (Absence abs in absences)
            {
                if (datedebutavantmodif.HasValue && abs.date_de_debut == datedebutavantmodif.Value)
                {
                    continue;
                }

                if (datedebut <= abs.date_de_fin && datefin >= abs.date_de_debut)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
<<<<<<< HEAD
<<<<<<< HEAD
        /// <param name="date">date d'avant à garder</param>
        public void UpdateAbsence(Absence absence, DateTime? date)
=======
        public void UpdateAbsence(Absence absence, DateTime date)
>>>>>>> parent of 1de88e6 (Delete MediaTek86_Atelier2 directory)
=======
        public void UpdateAbsence(Absence absence, DateTime date)
>>>>>>> parent of 1de88e6 (Delete MediaTek86_Atelier2 directory)
        {
            absenceAccess.UpdateAbsence(absence, date);
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }
    }
}
