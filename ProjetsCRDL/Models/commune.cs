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
    
    public partial class commune
    {
        public commune()
        {
            this.zones = new HashSet<zone>();
        }
    
        public int ID_commune { get; set; }
        public string NOM_commune { get; set; }
        public Nullable<int> ID_province { get; set; }
        public double LATITUDE_commune { get; set; }
        public double LONGITUDE_commune { get; set; }
    
        public virtual province province { get; set; }
        public virtual ICollection<zone> zones { get; set; }
    }
}
