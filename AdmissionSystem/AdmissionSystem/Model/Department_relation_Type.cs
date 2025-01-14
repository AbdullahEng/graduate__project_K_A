﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionSystem.Model
{
    public class Department_relation_Type
    {
        public int id { get; set; }
        [Display(Name ="Department")]
        public int FK_DepartmentId { get; set; }//one_to_many relationship
        public Department FK_Department { get; set; }//one_to_many relationship
        [Display(Name = "Type of high school cirtificate")]
        public int FK_type_Of_High_School_CirtificateId { get; set; }//one_to_many relationship
        public Type_of_high_school_Cirtificate FK_type_Of_High_School_Cirtificate { get; set; }//one_to_many relationship
        [Display(Name = "Minemum rate")]
        public double Minemum_of_Rate  { get; set; }
        [Display(Name = "rate of chaire count")]
        public double Rate_of_chaire_count { get; set; } 

      ////  [ForeignKey("Admission_Eligibilty_Requist_For_UNsy_Certificate")]
      //  public int FK_Admission_Eligibilty_Requist_For_UNsy_Certificate1Id { get; set; }//one_to_one relationship
      //  public Admission_Eligibilty_Requist_For_UNsy_Certificate FK_Admission_Eligibilty_Requist_For_UNsy_Certificate1 { get; set; }//one_to_one relationship
      // // public ICollection<Admission_Eligibilty_Requist_For_UNsy_Certificate> a_d_E_R_UN_Sy_cert1 { get; set; }
      //  // [ForeignKey("Admission_Eligibilty_Requist_For_UNsy_Certificate")]

      //  public int FK_Admission_Eligibilty_Requist_For_UNsy_Certificate2Id { get; set; }//one_to_one relationship
      //  public Admission_Eligibilty_Requist_For_UNsy_Certificate FK_Admission_Eligibilty_Requist_For_UNsy_Certificate2 { get; set; }//one_to_one relationship
      // // public ICollection<Admission_Eligibilty_Requist_For_UNsy_Certificate> a_d_E_R_UN_Sy_cert2 { get; set; }


      //  //  [ForeignKey("Admission_Eligibilty_Requist_For_UNsy_Certificate")]

      //  public int FK_Admission_Eligibilty_Requist_For_UNsy_Certificate3Id { get; set; }//one_to_one relationship
      //  public Admission_Eligibilty_Requist_For_UNsy_Certificate FK_Admission_Eligibilty_Requist_For_UNsy_Certificate3 { get; set; }//one_to_one relationship
    
      //  public ICollection<Admission_Eligibilty_Requist_For_UNsy_Certificate> a_d_E_R_UN_Sy_cert3 { get; set; }


    }

}
