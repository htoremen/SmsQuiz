//------------------------------------------------------------------------------ 
// <auto-generated> 
// This code was generated by a tool. 
// Runtime Version:2.0.50727.42 
// 
// Changes to this file may cause incorrect behavior and will be lost if 
// the code is regenerated. 
// </auto-generated> 
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace BB.SmsQuiz.Repository.EF.Models
{
    public partial class EntrantData
    {
        public System.Guid ID { get; set; }
        public System.Guid CompetitionID { get; set; }
        public int AnswerKey { get; set; }
        public int Source { get; set; }
        public int ContactType { get; set; }
        public string ContactDetail { get; set; }
        public System.DateTime EntryDate { get; set; }
        public virtual CompetitionData Competition { get; set; }
    }
}