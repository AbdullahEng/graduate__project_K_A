﻿using AdmissionSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionSystem.Model.Repository
{
    public class Student_Repo : CRUD_Operation_Interface<Student>
    {
        ApplicationDbContext DB;
        public Student_Repo(ApplicationDbContext _DB)
        {
            DB = _DB;
        }
        public void Add(Student entity)
        {
            DB.Student.Add(entity);
            DB.SaveChanges();
        }

        public void Delete(int id)
        {
            var studen_f = Find(id);
            DB.Student.Remove(studen_f);
            DB.SaveChanges();
        }

        public Student Find(int id)
        {
            var Student_f = DB.Student.Include(a => a.FK_Admission_Eligibilty_Requist_For_UNsy_Certificate).Include(a=>a.Cirtificate_city).Include(a=>a.Statues_Of_Admission_Eligibilty).SingleOrDefault(a => a.Id == id);
            return Student_f;

        }

        public IList<Student> List()
        {
            return DB.Student.Include(a => a.FK_Admission_Eligibilty_Requist_For_UNsy_Certificate).ThenInclude(a=>a.FK_Type_of_high_school_Cirtificate).Include(a => a.Statues_Of_Admission_Eligibilty).Include(c=>c.Cirtificate_city).ToList();
        }

        public void Update(int id, Student entity)
        {

            DB.Student.Update(entity);
            DB.SaveChanges();
        }
    }
}
