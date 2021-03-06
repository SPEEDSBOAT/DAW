//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIDAW.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Document
    {
        public int Id { get; set; }
        public Nullable<int> DocumentTypeId { get; set; }
        public Nullable<int> DocumentStatusId { get; set; }
        public Nullable<int> NextActionUserId { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> OwnerUserId { get; set; }
        public Nullable<int> SEQ { get; set; }
        public string Description { get; set; }
    
        public virtual DocumentStatus DocumentStatus { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual User User { get; set; }
    }
}
