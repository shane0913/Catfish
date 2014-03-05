using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
//added
using Windows.UI.Popups;

namespace Catfish
{
    // 返回FrameworkElement的rect
    public static class Positioning
    {
        public static Rect GetElementRect(this FrameworkElement element, int hOffset, int vOffset)
        {
            Rect rect = Positioning.GetElementRect(element);
            rect.Y += vOffset;
            rect.X += hOffset;
            return rect;
        }
        public static Rect GetElementRect(this FrameworkElement element)
            { 
                GeneralTransform buttonTransform = element.TransformToVisual(null);
                Point point = buttonTransform.TransformPoint(new Point());
                return new Rect(point, new Size(element.ActualWidth,element.ActualHeight));
            }
    }
}
