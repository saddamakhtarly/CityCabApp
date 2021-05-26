using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DevTest.Droid.CustomRenderers;
using DevTest.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]
namespace DevTest.Droid.CustomRenderers
{
public    class BorderlessEntryRenderer : EntryRenderer
    {
        [Obsolete]
        public BorderlessEntryRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control == null || e.NewElement == null) return;

            if (e.NewElement is BorderlessEntry customEntry)
            {
                Control.Background = null;

            }
        }

    }
}