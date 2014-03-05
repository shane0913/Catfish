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

using Windows.Media.Capture;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace Catfish
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class CameraCapture : Page
    {
        MediaCapture captureMgr = new MediaCapture();

        public CameraCapture()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。Parameter
        /// 属性通常用于配置页。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            OnCapturePhoto();
        }

        private async void OnCapturePhoto()
        {
            await captureMgr.InitializeAsync();//
            capturePreview.Source = captureMgr;
            await captureMgr.StartPreviewAsync();
        }

        private void Photo_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UploadPost));
        }

        private void Video_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UploadPost));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GlobalPage));
        }
    }
}
