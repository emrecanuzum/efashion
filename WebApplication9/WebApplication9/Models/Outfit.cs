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
    
    public partial class Outfit
    {
        public int CombineID { get; set; }
        public int UpperBodyID { get; set; }
        public int LowerBodyID { get; set; }
    
        public virtual Accessory Accessory { get; set; }
        public virtual LowerBodyOutfit LowerBodyOutfit { get; set; }
        public virtual UpperBodyOutfit UpperBodyOutfit { get; set; }
    }
}