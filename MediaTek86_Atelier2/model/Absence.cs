using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    public class Absence
    {
        /// <summary>
        /// Mettre valeur dans propriétés de la classe absence
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        public Absence(Personnel idpersonnel, DateTime datedebut, DateTime datefin, Motif idmotif)
        {
            this.idpersonnel = idpersonnel;
            this.date_de_debut = datedebut;
            this.date_de_fin = datefin;
            this.motif = idmotif;
        }

        public Personnel idpersonnel { get; set; }
        public DateTime date_de_debut { get; set; }
        public DateTime date_de_fin { get; set; }
        public Motif motif { get; set; }
    }
}
