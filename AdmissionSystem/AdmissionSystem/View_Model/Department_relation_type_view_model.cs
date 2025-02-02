﻿using AdmissionSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionSystem.View_Model
{
    public class Department_relation_type_view_model
    {
        public int id { get; set; }
        // public int FK_DepartmentId { get; set; }//one_to_many relationship
        [Display(Name="Department")]
        public int Department_id { get; set; }
        public List< Department> FK_Department { get; set; }//one_to_many relationship
        [Display(Name= "Type of high school cirtificate")]
        public int Type_of_high_school_cirtificate_id { get; set; }                                         // public int FK_type_Of_High_School_CirtificateId { get; set; }//one_to_many relationship
        public List<Type_of_high_school_Cirtificate> FK_type_Of_High_School_Cirtificate { get; set; }//one_to_many relationship
        [Display(Name= "Minemum of Rate")]
        [Required]
        [Range(0,100)]
        public double Minemum_of_Rate { get; set; }
        [Required]
        [Range(0, 100)]
        [Display(Name= "Rate of chaire count")]
        public double Rate_of_chaire_count { get; set; }
    }
}
