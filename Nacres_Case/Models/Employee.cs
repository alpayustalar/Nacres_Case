//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nacres_Case.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Nullable<long> id_number { get; set; }
        public Nullable<int> company_id { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
