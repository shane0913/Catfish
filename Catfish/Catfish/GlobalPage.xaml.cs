using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
//added
using Windows.UI.Popups;
using Windows.Storage;
using Windows.Storage.Pickers;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace Catfish
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class GlobalPage : Page
    {
        Page rootPage = null;

        public GlobalPage()
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
            rootPage = e.Parameter as Page;
            rootFrame.Navigate(typeof(Index), this);
        }

        //appbar
        public void AppBar_Opened(object sender, object e)
        {
        }

        public void AppBar_Closed(object sender, object e)
        {
        }
        public void Index_Click(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(Index),this);
            rootFrame.Navigate(typeof(Index), this);
        }
        public void Message_Click(object sender, RoutedEventArgs e)
        {
            rootFrame.Navigate(typeof(MessageView));
        }
        public void Explore_Click(object sender, RoutedEventArgs e)
        {
            rootFrame.Navigate(typeof(ExploreView));
        }
        public void Me_Click(object sender, RoutedEventArgs e)
        {
            rootFrame.Navigate(typeof(MyPage));
        }
        public void Return_Click(object sender, RoutedEventArgs e)
        {
            rootFrame.Navigate(typeof(Login));
        }
      /*  private async void Upload_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement element = (FrameworkElement)sender;

            PopupMenu menu = new PopupMenu();
            menu.Commands.Add(new UICommand("摄像头",Camera_Click, "camera"));
            menu.Commands.Add(new UICommand("本地图片",Static_Image_Click,"static"));

            var clicked = await menu.ShowForSelectionAsync(Positioning.GetElementRect(element,0,-10),Placement.Above);
        }*/
        private void Upload_Click(object sender, RoutedEventArgs e)
        {
        }
        //private void menuFlyout_Opened(object sender, object e)
        //{
        //    MenuFlyout m = sender as MenuFlyout;
        //    if (m != null)
        //    {
        //        rootPage.NotifyUser("You opened a MenuFlyout", NotifyType.StatusMessage);
        //    }
        //}
        public void Camera_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CameraCapture));
        }
        public async void Local_Image_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".png");

            StorageFile file = await openPicker.PickSingleFileAsync();
            //string path = file.Path;

            if (file != null)
                this.Frame.Navigate(typeof(UploadPost));
        }
        public void Search_Id_Click(object sender, RoutedEventArgs e)
        {
            rootFrame.Navigate(typeof(SearchView));
        }

        
        
    }
}
