using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MediaTek86.bddmanager
{
    /// <summary>
    /// Singleton : permet la connexion à la base de données et l'exécution de requêtes SQL
    /// </summary>
    public class BddManager
    {
        /// <summary>
        /// Instance unique de la classse
        /// </summary>
        private static BddManager instance = null;
        /// <summary>
        /// Connexion à la base de données via une chaîne de connexion
        /// </summary>
        private readonly MySqlConnection connection;

        /// <summary>
        /// COnstructeur pour créer la connexion à la base de données et y accéder
        /// </summary>
        /// <param name="stringConnect"></param>
        private BddManager(string stringConnect)
        {
            connection = new MySqlConnection(stringConnect);
            connection.Open();
        }

        /// <summary>
        /// Création d'une seule instance de la classe pour éviter les problèmes de connexion à la base de données
        /// </summary>
        /// <param name="stringConnect"></param>
        /// <returns></returns>
        public static BddManager GetInstance(string stringConnect)
        {
            if (instance == null)
            {
                instance = new BddManager(stringConnect);
            }
            return instance;
        }

        /// <summary>
        /// Permet de modifier des données avec une requête de type UPDATE
        /// </summary>
        /// <param name="stringQuery">requête update</param>
        /// <param name="parameters">dictionnaire concernant les paramètres</param>
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            if (!(parameters is null))
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }
            command.Prepare();
            command.ExecuteNonQuery();
        }

        /// <summary>
        ///  Permet de sélectionner des données avec une requête de type SELECT
        /// </summary>
        /// <param name="stringQuery">requête select</param>
        /// <param name="parameters">dictionnaire avec les paramètres</param>
        /// <returns>tableau d'objets avec les valeurs de chaque colonne</returns>
        public List<Object[]> ReqSelect(string stringQuery, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            if (!(parameters is null))
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }
            command.Prepare();
            MySqlDataReader reader = command.ExecuteReader();
            int nbCols = reader.FieldCount;
            List<Object[]> records = new List<object[]>();
            while (reader.Read())
            {
                Object[] attributs = new Object[nbCols];
                reader.GetValues(attributs);
                records.Add(attributs);
            }
            reader.Close();
            return records;
        }

    }
}