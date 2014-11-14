using System;
using Android.Runtime;
using Android.Support.V4.App;
using CoursesLibrary;

namespace CoursesAndroid
{
    public class CoursePagerAdapter : FragmentStatePagerAdapter
    {
        private readonly CourseManager _courseManager;
        
        public CoursePagerAdapter(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public CoursePagerAdapter(FragmentManager fm, CourseManager courseManager)
            : base(fm)
        {
            _courseManager = courseManager;
        }

        public override int Count
        {
            get
            {
                return _courseManager.Length;
            }
        }

        public override Fragment GetItem(int position)
        {
            _courseManager.MoveTo(position);
            var courseFragment = new CourseFragment
                {
                    Course = _courseManager.Current
                };

            return courseFragment;
        }
    }
}