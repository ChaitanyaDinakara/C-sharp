namespace University23
{
    public class People
    {
        void display()
        {
            Console.WriteLine("Library details");
        }
    }
    public class student : People
    {

        public void studentdetails(int idno = 3263, string name = "Chaitanya",string attendance ="present")
        {
            Console.WriteLine("The student details are:{0},{1},{2}",idno,name,attendance);
            Console.WriteLine("Book taken");
            Console.WriteLine("student is present");

        }

        public class teacher : student
        {

            public void teacherdetails(string name ="Brunda")
            {
                Console.WriteLine(name);
                Console.WriteLine("Book taken");
                Console.WriteLine("present or absent");

            }
        }

        public class librarian : teacher
        {
            public void librariandetails(string name ="Suresh")
            {
                Console.WriteLine("Here's the book");
                Console.WriteLine("present or absent");
            }
        }


         static void Main(string[] args)
        {
            student s = new student();
            s.studentdetails();
            teacher t = new teacher();
            t.teacherdetails();
            librarian l = new librarian();
            l.librariandetails();
        }
    }
    }
