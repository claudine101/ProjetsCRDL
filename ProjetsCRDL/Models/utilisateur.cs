//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetsCRDL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class utilisateur
    {
        public utilisateur()
        {
            this.historique_utilisateur = new HashSet<historique_utilisateur>();
        }
    
        public int ID_utilisateur { get; set; }
        public int ID_profile { get; set; }
        public Nullable<int> ID_employ { get; set; }
        public Nullable<int> ID_employe { get; set; }
        public string username { get; set; }
        public string passwords { get; set; }
    
        public virtual employe_association employe_association { get; set; }
        public virtual employe_station_lavage employe_station_lavage { get; set; }
        public virtual ICollection<historique_utilisateur> historique_utilisateur { get; set; }
        public virtual profile profile { get; set; }
    }
}
