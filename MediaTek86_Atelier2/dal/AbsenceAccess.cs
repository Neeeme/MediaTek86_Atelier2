using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    internal class AbsenceAccess
    {

        /// <summary>
        /// Instance unique pour l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les absences d'un personnel par son id
        /// </summary>
        /// <returns>liste des absences d'un personnel par son id</returns>
        public List<Absence> GetAbsence(int idPersonnel)
        {
            List<Absence> Absence = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "SELECT a.idpersonnel, a.datedebut, a.datefin, a.idmotif, ";
                req += "p.nom, p.prenom, p.tel, p.mail, s.idservice, s.nom, m.libelle ";
                req += "FROM absence a ";
                req += "JOIN personnel p ON a.idpersonnel = p.idpersonnel ";
                req += "JOIN service s ON p.idservice = s.idservice ";
                req += "JOIN motif m ON a.idmotif = m.idmotif ";
                req += "WHERE a.idpersonnel = " + idPersonnel + " ";
                req += "ORDER BY a.datedebut DESC, a.datefin DESC;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service idservice = new Service((int)record[8], (string)record[9]);
                            Personnel idpersonnel = new Personnel((int)record[0], (string)record[4], (string)record[5], (string)record[6], (string)record[7], idservice);
                            Motif idmotif = new Motif((int)record[3], (string)record[10]);
                            Absence absence = new Absence(idpersonnel, (DateTime)record[1], (DateTime)record[2], idmotif);
                            Absence.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return Absence;
        }

        /// <summary>
        /// Demande d'ajout d'une absence sur un personnel
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "insert into absence(idpersonnel, datedebut, datefin, idmotif) ";
                req += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.idpersonnel.Idpersonnel);
                parameters.Add("@datedebut", absence.date_de_debut);
                parameters.Add("@datefin", absence.date_de_fin);
                parameters.Add("@idmotif", absence.motif.Idmotif);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Demande de modification d'une absence sur un personnel
        /// </summary>
        /// <param name="personnel">objet absence à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "update absence set datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif ";
                req += "where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idPersonnel", absence.idpersonnel.Idpersonnel);
                parameters.Add("@datedebut", absence.date_de_debut);
                parameters.Add("@datefin", absence.date_de_fin);
                parameters.Add("@idmotif", absence.motif.Idmotif);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
