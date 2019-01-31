using SimpleXam.Fundamentals;
using SimpleXam.Fundamentals.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CircleView), typeof(CircleViewRenderer))]
namespace SimpleXam.Fundamentals.iOS
{
    public class CircleViewRenderer : BoxRenderer
    {
        private CircleView CustomElement => Element as CircleView;

        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);

            if (Element == null)
            {
                return;
            }

            Layer.MasksToBounds = true;
            Layer.CornerRadius = (float)CustomElement.Radius / 2.0f;
        }
    }
}
