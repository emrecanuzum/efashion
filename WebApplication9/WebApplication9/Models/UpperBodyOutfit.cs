//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication9.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UpperBodyOutfit
    {
        public UpperBodyOutfit()
        {
            this.Outfit = new HashSet<Outfit>();
            this.TechnicalDetail = new HashSet<TechnicalDetail>();
        }
    
        public int UpperBodyID { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Sex { get; set; }
    
        public virtual ICollection<Outfit> Outfit { get; set; }
        public virtual ICollection<TechnicalDetail> TechnicalDetail { get; set; }
    }
}
