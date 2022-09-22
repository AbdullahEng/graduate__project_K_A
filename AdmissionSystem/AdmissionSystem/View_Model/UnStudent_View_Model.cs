﻿using AdmissionSystem.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdmissionSystem.View_Model
{
    public class UnStudent_View_Model
    {
        public int id { get; set; }
        [Required]
        public string high_school_certificate { get; set; }//syrian or not syrian certificate.
        [Required(ErrorMessage = "First name is required")]
        [StringLength(20, ErrorMessage = "no more than 20 charecter")]
        public string First_Name_AR { get; set; }
        [Required(ErrorMessage = "Father name in is required")]
        [StringLength(20, ErrorMessage = "no more than 20 charecter")]
        public string Father_Name_AR { get; set; }
        [Required(ErrorMessage = "Grand father name is required")]
        [StringLength(20, ErrorMessage = "no more than 20 charecter")]
        public string Grandfather_Name_AR { get; set; }
        [Required(ErrorMessage = "Mother name is required")]
        [StringLength(20, ErrorMessage = "no more than 20 charecter")]
        public string Mother_Name_AR { get; set; }
        //[Required(ErrorMessage = "First name is required")]
        //[StringLength(20, ErrorMessage = "no more than 20 charecter")]
        public string First_Name_EN { get; set; }
        [Required(ErrorMessage = "Father name in is required")]
        [StringLength(20, ErrorMessage = "no more than 20 charecter")]
        public string Father_Name_EN { get; set; }
        [Required(ErrorMessage = "Grand father name is required")]
        [StringLength(20, ErrorMessage = "no more than 20 charecter")]
        public string Grandfather_Name_EN { get; set; }
        [Required(ErrorMessage = "Mother name is required")]
        [StringLength(20, ErrorMessage = "no more than 20 charecter")]
        public string Mother_Name_EN { get; set; }
        [Required(ErrorMessage = "Nick name is required")]
        [StringLength(20, ErrorMessage = "no more than 20 charecter")]
        public string Nick_Name { get; set; }
        //[Required(ErrorMessage = "Gender is required")]
        //[StringLength(20, ErrorMessage = "no more than 20 charecter")]
        public string gender { get; set; }
        [Required(ErrorMessage = "Nationality is required")]
        [StringLength(20, ErrorMessage = "no more than 20 charecter")]
        public string Nationality { get; set; }
        [Required(ErrorMessage = "Birth is required")]
        [DataType(DataType.Date)]
        public DateTime Birth { get; set; }
        [Required(ErrorMessage = "Marital status is required")]
        public string Marital_status { get; set; }
       
        public string Civil_Registriation_City { get; set; }
        
        public int Civil_Registrition_No { get; set; }
       
        public string Passport_No { get; set; }
        [Required(ErrorMessage = "Passport is required")]
        [RegularExpression(@"^[0-9]{9}([0-9]{2})?$",
        ErrorMessage = "Characters are not allowed and only 11 for identity and 9 fore.")]
        public string Identity_No { get; set; }
       
        public float The_Rate { get; set; }
        [Required(ErrorMessage = "Full Address is required")]
        [StringLength(150, ErrorMessage = "no more than 50 charecter")]
        public string Full_Address { get; set; }
        [Required(ErrorMessage = "Email is required")]
        //[EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Current Address is required")]
        [StringLength(50, ErrorMessage = "no more than 50 charecter")]
        public string Current_Address { get; set; }//address after the acciption
        [Required(ErrorMessage = "Mobile Phone is required")]
        [RegularExpression(@"^[0-9]{10}$",
        ErrorMessage = "Characters are not allowed and only 10 numbers.")]
        public string Mobile_Phone { get; set; }
        [RegularExpression(@"^[0-9]{10}$",
        ErrorMessage = "Characters are not allowed and only 10 numbers.")]
        public string Home_s_Phone { get; set; }
       
        [Required(ErrorMessage = "City of Certificate is required")]
        [StringLength(20, ErrorMessage = "no more than 20 charecter")]
        public string city_of_high_school_cirtificate { get; set; }
        [Required(ErrorMessage = "Date of Certificate is required")]
        [DataType(DataType.Date)]
        public DateTime date_of_high_school_cirtificate { get; set; }
        
        public string Addmition_eleigibilty { get; set; }

        public List<Type_of_high_school_Cirtificate> Type_Of_certificate_list { get; set; }
        [Required(ErrorMessage = "Type of your Certificate is required")]
        public int Type_Of_Certificat { get; set; }
        public int oldType_Of_Certificat { get; set; }
        public string Type_of_certificate_name { get; set; }
        /// for syrian student  <summary>
        /// for syrian student 
        /// </summary>



        public List<Country> CountryList { get; set; }
        [Required]
        public int country { get; set; }
        public string country_name { get; set; }


        public IFormFile Image_Of_Crtificat { get; set; }


        public IFormFile Identity_front_image { get; set; }
        public IFormFile Identity_back_image { get; set; }
        public IFormFile check_recipt_image { get; set; }

        public string Image_of_crtificat_URL { get; set; }
        public string Identity_front_image_URL { get; set; }
        public string Identity_back_image_URL { get; set; }
        public string Check_recipt_image_URL { get; set; }


        public List<Wishes> specializtions { get; set; }
        public int? wish_Department_Id1 { get; set; }
        public string wih1_name { get; set; }
        public int? wish_Department_Id2 { get; set; }
        public string wih2_name { get; set; }
        public int? wish_Department_Id3 { get; set; }
        public string wih3_name { get; set; }
        public int Conformation { get; set; }
    }
}