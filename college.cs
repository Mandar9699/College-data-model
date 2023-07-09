using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static College.college.admission_section;

namespace College
{
    public class college
    {
        public string name { get; set; }

        public string address { get; set; }
        public string university_name { get; set; }

        public int studyroom_capacity { get; set; }
        public class fees
        {
            public double amount { get; set; }
            public string description { get; set; }
        }
        public class fees_description
        {
            List<fees> fees_description_details { get; set; }

            public fees_description()
            {
                fees_description_details= new List<fees>();
            }
        }

        public class faculty
        {
            public string name { get; set; }
            public string Designation { get; set; }
        }
        public class faculty_list
        {
            List<faculty> faculty_Lists { get; set; }

            public faculty_list()
            {
                faculty_Lists = new List<faculty>();
            }
        }


        public class first_year_subject 
        {
            public string name { get; set; }
            public string  Is_lab { get; set; }
        }
        public class first_year_subject_list
        {
            List<first_year_subject> first_year_subject_lists { get; set; }

            public first_year_subject_list()
            {
                first_year_subject_lists = new List<first_year_subject>();
            }
        }

        public class admission_section
        {
            public class student_details
            {
                public int PRN { get; set; }
                public string name { get; set; }
                public string age { get; set; }
                public string branch { get; set; }
            }
        }

        public class student_list
        {
            List<student_details> student_lists { get; set; }

            public student_list()
            {
                student_lists = new List<student_details>();
            }
        }

        
    }
}
