﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {

        public delegate void GradeAddedDelegate(object sender, EventArgs e);

        public abstract event GradeAddedDelegate GradeAdded;

        public string Surname { get; private set; }
        public string Name { get; private set; }



        public EmployeeBase(string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public abstract void AddGrade(long grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(decimal grade);

        public abstract void AddGrade(double grade);


        public abstract void AddGrade(float grade);
        
        public abstract void AddGrade(string grade);

        public abstract void AddGrade(char grade);


        public abstract Statistics GetStatistics();
        
    }
}
