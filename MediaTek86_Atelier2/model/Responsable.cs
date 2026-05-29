using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier interne pour pouvoir mémoriser les informations de connexions
    /// </summary>
    internal class Responsable
    {
        public string Login { get; }
        public string Pwd { get; }

        /// <summary>
        /// Mettre valeur dans propriétés de la classe responsable
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }
    }
}
