using Android.App;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.View;
using CoursesLibrary;

namespace CoursesAndroid
{
    [Activity(Label = "Courses", MainLauncher = true, Icon = "@drawable/icon")]
    public class CourseActivity : FragmentActivity
    {
        private CourseManager _courseManager;
        private CoursePagerAdapter _coursePagerAdapter;
        private ViewPager _viewPager;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.CourseActivity);

            _courseManager = new CourseManager();
            _courseManager.MoveFirst();
            _coursePagerAdapter = new CoursePagerAdapter(SupportFragmentManager, _courseManager);

            _viewPager = FindViewById<ViewPager>(Resource.Id.coursePager);
            _viewPager.Adapter = _coursePagerAdapter;

        }
    }
}