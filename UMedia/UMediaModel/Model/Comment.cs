//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UMediaModel.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int Id { get; set; }
        public int VideoId { get; set; }
        public int ProfileId { get; set; }
        public string Comment1 { get; set; }
    
        public virtual Profile Profile { get; set; }
        public virtual Video Video { get; set; }
    }
}
