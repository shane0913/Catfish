//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using Windows.Foundation;
//using Windows.Foundation.Collections;
//using Windows.UI.Xaml;
//using Windows.UI.Xaml.Controls;
//using Windows.UI.Xaml.Controls.Primitives;
//using Windows.UI.Xaml.Data;
//using Windows.UI.Xaml.Input;
//using Windows.UI.Xaml.Media;
//using Windows.UI.Xaml.Navigation;
//// added
//using System.Collections.ObjectModel;

//// “分组项页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234231 上提供

//namespace Catfish
//{
//    /// <summary>
//    /// 显示分组的项集合的页。
//    /// </summary>
//    public sealed partial class Index : Catfish.Common.LayoutAwarePage
//    {
//        ObservableCollection<Image> postsList = new ObservableCollection<Image>();
//        Page rootPage = null;

//        public Index()
//        {
//            this.InitializeComponent();
//        }

//        protected override void OnNavigatedTo(NavigationEventArgs e)
//        {
//            rootPage = (Page)e.Parameter;

//            postsList.Add(new Image("Am i cute~?", "Images/posts/1.jpg", "boy", "2013-11-11", 1, 1));
//            postsList.Add(new Image("new collections", "Images/posts/2.jpg", "gem", "2013-11-11", 100, 100));
//            postsList.Add(new Image("OMG", "Images/posts/3.jpg", "honey", "2013-11-11", 15, 1));
//            postsList.Add(new Image("catch up!", "Images/posts/4.jpg", "cocorocha", "2013-11-11", 240, 100));
//            postsList.Add(new Image("got a haircut", "Images/posts/5.jpg", "Angelababy", "2013-11-11", 2000, 1230));
//            postsGrid.ItemsSource = postsList;
//        }

//        private void Comment_Add_Click(object sender, RoutedEventArgs e)
//        {
//        }

//        private void Comment_Send_Click(object sender, RoutedEventArgs e)
//        {
//        }
//    }
//}
