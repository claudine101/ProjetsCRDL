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
    
    public partial class employe_association
    {
        public employe_association()
        {
            this.utilisateurs = new HashSet<utilisateur>();
        }
    
        public int ID_employe { get; set; }
        public string CNI { get; set; }
        public int ID_association { get; set; }
        public string NOM_employe { get; set; }
        public string PRENOM_employe { get; set; }
        public string TEL_employe { get; set; }
        public string EMAIL_employe { get; set; }
        public string Statut { get; set; }
    
        public virtual association association { get; set; }
        public virtual ICollection<utilisateur> utilisateurs { get; set; }
    }
}
