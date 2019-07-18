namespace P03._Database
{
    public class Courses
    {


        public void PrintAll(Data database)
        {
            var courses = database.CourseNames();

            //print courses
        }

        public void PrintIds(Data database)
        {
            var courseIds = database.CourseIds();

            //print course ids
        }

        public void PrintById(int id, Data database)
        {
            var course = database.GetCourseById(id);

            // print course
        }

        public void Search(string substring, Data database)
        {
            var courses = database.Search(substring);

            // print courses
        }
    }
}
