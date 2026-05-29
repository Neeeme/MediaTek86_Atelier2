using MediaTek86.bddmanager;
using System;

namespace MediaTek86.dal
{
    /// <summary>
    /// Singleton : permet davoir un accès à bddManager
    /// </summary>
    public class Access
    {
        /// <summary>
        /// Chaîne de connexion pour se connecter à la base de données
        /// </summary>
        private static readonly string connectionString = "server=localhost;user id=atelier;password=motdepasse;database=atelier;";
        /// <summary>
        /// Instance unique de la classe
        /// </summary>
        private static Access instance = null;

        /// <summary>
        /// Getter sur l'objet d'accès aux données
        /// </summary>
        public BddManager Manager { get; }


        /// <summary>
        /// Création unique de l'objet de type BddManager
        /// Le programme s'arrête subitement si l'accès à la base de données échoue
        /// </summary>
        private Access()
        {
            try
            {
                Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }


        /// <summary>
        /// Création d'une seule instance de la classe
        /// </summary>
        /// <returns></returns>
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }

    }
}
