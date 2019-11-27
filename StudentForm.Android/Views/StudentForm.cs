using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Views;
using StudentForm.Core.ViewModels;

namespace StudentForm.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class StudentFormView : MvxActivity<StudentFormViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.StudenFormPage);

        }
    }
}