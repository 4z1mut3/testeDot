//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VibeApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class APOLICE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APOLICE()
        {
            this.FINANCEIROAPOLICE = new HashSet<FINANCEIROAPOLICE>();
        }
    
        public int IDAPOLICE { get; set; }
        public int IDTIPOSEGURO { get; set; }
        public int IDSEGURADO { get; set; }
        public System.DateTime DTINIVIG { get; set; }
        public System.DateTime DTFIMVIG { get; set; }
        public int STATUSAPOLICE { get; set; }
    
        public virtual SEGURADO SEGURADO { get; set; }
        public virtual TIPOSEGURO TIPOSEGURO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FINANCEIROAPOLICE> FINANCEIROAPOLICE { get; set; }
    }
}
