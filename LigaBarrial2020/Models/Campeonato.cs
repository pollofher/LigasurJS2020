//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LigaBarrial2020.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Campeonato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Campeonato()
        {
            this.Campeonato_Equipo = new HashSet<Campeonato_Equipo>();
        }
    
        public int CampeonatoId { get; set; }
        public string nom_campeonato { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_fin { get; set; }
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Campeonato_Equipo> Campeonato_Equipo { get; set; }
    }
}