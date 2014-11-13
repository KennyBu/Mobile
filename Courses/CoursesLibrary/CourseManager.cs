namespace CoursesLibrary
{
    public class CourseManager
    {
        private readonly Course[] _courses;
        private int _currentIndex;

        public CourseManager()
        {
            _courses = InitCourses();
        }

        private Course[] InitCourses()
        {
            var initCourses = new[]
                {
                   new Course
                       {
                           Description = "An intro course.",
                           Title = "Course 1",
                           Image = "jimwilson"
                       },
                       new Course
                       {
                           Description = "Another course.",
                           Title = "Course 2",
                           Image = "johnpapa"
                       },
                       new Course
                       {
                           Description = "A third course.",
                           Title = "Course 3",
                           Image = "johnsonmez"
                       },
                };

            return initCourses;
        }

        public void MoveFirst()
        {
            _currentIndex = 0;
        }

        public void MovePrevious()
        {
            if (_currentIndex > 0)
            {
                _currentIndex--;    
            }
            
        }

        public void MoveNext()
        {
            if (_currentIndex < _courses.Length -1)
            {
                _currentIndex++;
            }
        }

        public Course Current
        {
            get { return _courses[_currentIndex]; }
        }

        public bool CanMovePrev
        {
            get { return _currentIndex > 0; }
        }

        public bool CanMoveNext
        {
            get { return _currentIndex < _courses.Length - 1; }
        }


    }
}