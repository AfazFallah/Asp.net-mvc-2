using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.net_mvc_2.Models
{
    public class Students
    {
        #region Prop
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentFamily { get; set; }
        public int StudentAge { get; set; } 
        #endregion

        public Students(){}
        public Students(int Id , string Name , string Family , int Age)
        { 
            StudentId = Id;
            StudentName = Name; 
            StudentFamily = Family;
            StudentAge = Age;
        }
    }
}