//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication7.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class lending
    {
        public int Id { get; set; }
        public string starttime { get; set; }
        public string endtime { get; set; }
        public int memberId { get; set; }
        public int book_Id { get; set; }
    
        public virtual book book { get; set; }
        public virtual member member { get; set; }
    }
}
