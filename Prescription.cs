//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VVUHMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prescription
    {
        public int ID { get; set; }
        public string PatientID { get; set; }
        public string StaffID { get; set; }
        public string Medicine { get; set; }
        public System.DateTime Date { get; set; }
        public int VitalID { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual PatientVital PatientVital { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
