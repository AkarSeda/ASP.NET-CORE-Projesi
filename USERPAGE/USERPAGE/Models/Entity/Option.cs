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
    
    public partial class Option
    {
        public int OptionId { get; set; }
        public string OptionName { get; set; }
        public string OptionContent { get; set; }
        public Nullable<int> CorrectOption { get; set; }
        public Nullable<int> QuestionId { get; set; }
    }
}
