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
    
    public partial class Accessory
    {
        public Accessory()
        {
            this.Outfit = new HashSet<Outfit>();
            this.ShoeProperties = new HashSet<ShoeProperties>();
        }
    
        public Nullable<int> AccessoryID { get; set; }
        public int CombineID { get; set; }
        public string AccessoryName { get; set; }
        public string AccessoryType { get; set; }
        public string Color { get; set; }
        public string Sex { get; set; }
    
        public virtual ICollection<Outfit> Outfit { get; set; }
        public virtual ICollection<ShoeProperties> ShoeProperties { get; set; }
    }
}