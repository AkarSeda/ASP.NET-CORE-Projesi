//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace USERPAGE.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Questions
    {
        public int QuestionId { get; set; }
        public Nullable<int> QuestionNumber { get; set; }
        public string QuestionContent { get; set; }
        public Nullable<int> ExamId { get; set; }
    }
}
