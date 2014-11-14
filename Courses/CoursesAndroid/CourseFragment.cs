using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using CoursesLibrary;

namespace CoursesAndroid
{
    public class CourseFragment : Fragment
    {
        private TextView _textTitle;
        private ImageView _imageCourse;
        private TextView _textDescription;
        
        public Course Course { get; set; }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var rootView = inflater.Inflate(Resource.Layout.CourseFragment, container, false);

            _textTitle = rootView.FindViewById<TextView>(Resource.Id.textTitle);
            _imageCourse = rootView.FindViewById<ImageView>(Resource.Id.imageView1);
            _textDescription = rootView.FindViewById<TextView>(Resource.Id.textDescription);

            _textTitle.Text = Course.Title;
            _textDescription.Text = Course.Description;
            _imageCourse.SetImageResource(ResourceHelper.TranslateDrawableWithReflection(Course.Image));   

            return rootView;
        }
    }
}