using System;
using System.ComponentModel;
using SimpleXam.Fundamentals;
using SimpleXam.Fundamentals.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(StaticLabel), typeof(StaticLabelRenderer))]
namespace SimpleXam.Fundamentals.iOS
{
    public class StaticLabelRenderer : LabelRenderer
    {
        public StaticLabelRenderer() : base()
        {
        }
    }
}
