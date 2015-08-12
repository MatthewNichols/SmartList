using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SmartList.Controls;
using SmartList.Droid.CustomRenders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ExtendedLabel), typeof(ExtendedLabelRenderer))]

namespace SmartList.Droid.CustomRenders
{
    public class ExtendedLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            var view = (ExtendedLabel)Element;
            var control = Control;

            UpdateUi(view, control);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            var view = (ExtendedLabel)Element;

            if (e.PropertyName == ExtendedLabel.IsUnderlineProperty.PropertyName)
            {
                Control.PaintFlags = view.IsUnderline ? Control.PaintFlags | PaintFlags.UnderlineText : Control.PaintFlags &= ~PaintFlags.UnderlineText;
            }

            if (e.PropertyName == ExtendedLabel.IsStrikeThroughProperty.PropertyName)
            {
                Control.PaintFlags = view.IsStrikeThrough ? Control.PaintFlags | PaintFlags.StrikeThruText : Control.PaintFlags &= ~PaintFlags.StrikeThruText;
            }
        }

        static void UpdateUi(ExtendedLabel view, TextView control)
        {
            if (view.FontSize > 0)
            {
                control.TextSize = (float)view.FontSize;
            }

            if (view.IsUnderline)
            {
                control.PaintFlags = control.PaintFlags | PaintFlags.UnderlineText;
            }

            if (view.IsStrikeThrough)
            {
                control.PaintFlags = control.PaintFlags | PaintFlags.StrikeThruText;
            }
        }
    }
}