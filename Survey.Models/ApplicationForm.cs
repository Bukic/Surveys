//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Survey.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ApplicationForm
    {
        public ApplicationForm()
        {
            this.Roles = new HashSet<Role>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    
        public virtual ICollection<Role> Roles { get; set; }
    }
}
