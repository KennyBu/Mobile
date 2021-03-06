﻿using System;
using Android.App;
using Android.Widget;
using Android.OS;
using CoursesLibrary;

namespace CoursesAndroid
{
    //[Activity(Label = "Courses", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button _buttonPrev;
        private Button _buttonNext;
        private CourseManager _courseManager;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            _buttonPrev = FindViewById<Button>(Resource.Id.buttonPrev);
            _buttonNext = FindViewById<Button>(Resource.Id.buttonNext);

            _buttonPrev.Click += ButtonPrevOnClick;
            _buttonNext.Click += ButtonNextOnClick;

            _courseManager = new CourseManager();
            _courseManager.MoveFirst();
            _courseManager.MoveNext();

            UpdateUi();
        }

        private void ButtonPrevOnClick(object sender, EventArgs eventArgs)
        {
            _courseManager.MovePrevious();
            UpdateUi();
        }

        private void ButtonNextOnClick(object sender, EventArgs eventArgs)
        {
            _courseManager.MoveNext();
            UpdateUi();
        }

        private void UpdateUi()
        {
            _buttonPrev.Enabled = _courseManager.CanMovePrev;
            _buttonNext.Enabled = _courseManager.CanMoveNext;
        }
    }
}

