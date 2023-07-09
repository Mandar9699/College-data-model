using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    public class CSE : college
    {


        public string name { get; set; } 
        public int number_of_students_per_year { get; set; }
        public int practical_lab_capacity { get; set; }
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
                fees_description_details = new List<fees>();
            }
        }

    }

    public class faculty 
    {
        public string name { get; set; }
        public string designation { get; set; }
    }

       public class faculty_member_list 
    { 
        List <faculty> faculty_member_lists   { get; set; }

        public faculty_member_list()
        {
             faculty_member_lists= new List<faculty>();
        }

    }

   
        public class second_year_subject : CSE
        {
           public string name { get; set; }
           public string Is_lab { get; set; }
        }
        public class second_year_subject_list
         {
        List<second_year_subject> second_year_subject_lists{ get; set; }

        public second_year_subject_list()
        {
              second_year_subject_lists= new List<second_year_subject>(); 
        }
         }

        public class third_year_subject : CSE
        {
            public string name { get; set; }
            public string Is_lab { get; set; }
        }

        public class third_year_subject_list 
        {           
                List<third_year_subject> third_year_subject_lists { get; set; }
            
            public third_year_subject_list()
        {   
                third_year_subject_lists= new List<third_year_subject>();
        }

        }

    public class final_year_subject : CSE
    {
        public string name { get; set; }
        public string Is_lab { get; set; }
    }
      public class final_year_subject_list
    {

         List<final_year_subject> final_year_subject_lists { get; set; }

        public final_year_subject_list() 
        {
            final_year_subject_lists=new List<final_year_subject>();
        }
       
    }

        
    }
