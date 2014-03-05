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
// added
using System.Collections.ObjectModel;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace Catfish
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ExploreView : Page
    {
        ObservableCollection<Image> postsList = new ObservableCollection<Image>();

        public ExploreView()
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
            postsList.Add(new Image("Am i cute~?", "Images/posts/1.jpg", "boy", "2013-11-11", 1, 1));
            postsList.Add(new Image("new collections", "Images/posts/2.jpg", "gem", "2013-11-11", 100, 100));
            postsList.Add(new Image("OMG", "Images/posts/3.jpg", "honey", "2013-11-11", 15, 1));
            postsList.Add(new Image("catch up!", "Images/posts/4.jpg", "cocorocha", "2013-11-11", 240, 100));
            postsList.Add(new Image("got a haircut", "Images/posts/5.jpg", "Angelababy", "2013-11-11", 2000, 1230));
            postsGrid.ItemsSource = postsList;
        }
    }
}
