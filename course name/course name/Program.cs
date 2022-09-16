using System;


namespace StudentCourse
{
    class StudentCourse
    {
        static void Main(String[] args)
        {
            Course course = new Course();
            course=Course.get


        }

    }
    class Course
    {
        string course_name = "BSc. CSSE";
        string course_details = "3 years bachelors degree in Software Engineering.";
        int duration_year = 3;
        int no_of_semesters = 6;
        int total_credit_score = 360;
        Subjects[] subjects = new Subjects[6];
        public void printCourseDetails(Course course)
        {
            Console.WriteLine("Course Name"+course.course_name);
            Console.WriteLine("Course Details"+course.course_details);
            Console.WriteLine("Course Duration"+course.duration_year);
            Console.WriteLine("Number of Semesters"+course.no_of_semesters);
            Console.WriteLine("Total Credit Score"+course.total_ credit_ score.score);
            Console.WriteLine("Course Subjects");

        }
        public Course getCourseDetails()
        {
            Course course = new Course();
            for (int i = 0; i < 6; i++)
            {
                Subjects sub = new Subjects();
                Console.Writegi
                sub.subject_name = Console.ReadLine();
                sub.subject_code = Console.ReadLine();
                sub.credit_score = Convert.ToInt32(Console.ReadLine());
                sub.semester_number = Convert.ToInt32(Console.ReadLine());


            }

            return course;
        }

    }
    class Subjects
    {
        public string subject_name;
        public string subject_code;
        public int credit_score;
        public int semester_number;

    }
    class Semester
    {
        string sem_details;
        int semester_number;

    }
    class Student
    {
        string firstName;
        string middleName;
        string lastName;
        string gender;
        int age;
        string roll_no;
        string email;
        string university_id;
        string phone_number;
        Address[] address_details = new Address[2];
        Course student_affilited_course = new Course();



    }
    class Address
    {
        string tole;
        string mnc;
        string district;
        string city;
        string pradesh;
    }

}