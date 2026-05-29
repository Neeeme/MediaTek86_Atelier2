namespace MediaTek86.model
{
    public class Service
    {
        public int Idservice { get; }
        public string Nom { get; }

        /// <summary>
        /// Mettre valeur dans propriétés de la classe service
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du service</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
