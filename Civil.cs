using College;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    public class Civil : college
    {
        public class practical_labs
        { 
            public string name { get; set; }
            public int capacity { get; set; }   
        }
        public class practical_lab_list
        {
            List<practical_lab_list> practical_lab_lists { get; set; }

            public practical_lab_list()
            {
                practical_lab_lists= new List<practical_lab_list>();
            }
        }
        
    }
    }
        public class faculty :Civil
        {
            public string name { get; set; }
             public string Designation { get; set; }
        }
        public class faculty_list
        {
            List<faculty_list> faculty_Lists { get; set; }
            
                public faculty_list()
            {
                faculty_Lists = new List<faculty_list>();
            }
        }

    public class ug : Civil 
    {
            public int id { get; set; }
            public int number_of_students_per_year { get; set; }
            public double civil_ug_fees { get; set; }

    }

    public class civil_ug_second_year_subject 
    {
        public string name { get; set; } 
        public string Is_lab { get; set; }//take reveiew doubt
    }
    public class civil_ug_second_year_subject_list
    {
        List<civil_ug_second_year_subject> civil_ug_second_year_subject_lists { get; set; }

        public civil_ug_second_year_subject_list()
        {
            civil_ug_second_year_subject_lists = new List<civil_ug_second_year_subject>();
        }
    }


    public class civil_ug_third_year_subject 
    {
        public string name { get; set; }
        public string Is_lab { get; set;}
    }

    public class civil_ug_third_year_subject_list
    {
        List<civil_ug_third_year_subject> civil_third_year_subject_lists { get; set; }

        public civil_ug_third_year_subject_list()
        {
            civil_third_year_subject_lists = new List<civil_ug_third_year_subject>();
        }

    }
    public class civil_ug_final_year_subject :pg
    {
        public string name { get; set; }
        public string Is_lab { get; set;}
    }
    public class civil_ug_final_year_subject_list 
    {

        List<civil_ug_final_year_subject> civil_final_year_subject_lists { get; set; }

        public civil_ug_final_year_subject_list()
        {
            civil_final_year_subject_lists = new List<civil_ug_final_year_subject>();
        }

    }

    public class pg : Civil
    {
        public int id { get; set; }
        public int number_of_students_per_year { get; set; }
        public double civil_pg_fees { get; set; }
    }

    public class civil_pg_first_year_subject :pg
    {
        public string name { get; set; }
        public string Is_lab { get; set;}
    }
    public class civil_pg_first_year_subject_list
    {
        List<civil_pg_first_year_subject> civil_pg_first_year_subject_lists { get; set; }

        public civil_pg_first_year_subject_list()
        {
            civil_pg_first_year_subject_lists = new List<civil_pg_first_year_subject>();
        }
    }

    public class civil_pg_second_year_subject :pg
    {
        public string name { get; set; }
        public string Is_lab { get; set; }
    }
    public class civil_pg_second_year_subject_list
    {
        List<civil_pg_second_year_subject> civil_pg_second_year_subject_lists { get; set; }

        public civil_pg_second_year_subject_list()
        {
            civil_pg_second_year_subject_lists = new List<civil_pg_second_year_subject>();
        }
    }



