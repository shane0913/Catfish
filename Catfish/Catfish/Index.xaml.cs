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
//tile and toast
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;


// “分组项页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234231 上提供

namespace Catfish
{
    /// <summary>
    /// 显示分组的项集合的页。
    /// </summary>
    public sealed partial class Index : Page
    {
        ObservableCollection<Image> postsList = new ObservableCollection<Image>();
        Page rootPage = null;

        public Index()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            rootPage = (Page)e.Parameter;

            setPostsList();
            postsGrid.ItemsSource = postsList;
            showTile();
            showToast();
        }

        /// <summary>
        /// 从后台获取最新的好友动态
        /// </summary>
        private void setPostsList()
        {
            /// 先用静态数据
            /// ...
            postsList.Add(new Image("Am i cute~?", "Images/posts/1.jpg", "boy", "2013-11-11", 1, 1));
            postsList.Add(new Image("new collections", "Images/posts/2.jpg", "gem", "2013-11-11", 100, 100));
            postsList.Add(new Image("OMG", "Images/posts/3.jpg", "honey", "2013-11-11", 15, 1));
            postsList.Add(new Image("catch up!", "Images/posts/4.jpg", "cocorocha", "2013-11-11", 240, 100));
            postsList.Add(new Image("got a haircut", "Images/posts/5.jpg", "Angelababy", "2013-11-11", 2000, 1230));
        }

        private void Comment_Add_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Comment_Send_Click(object sender, RoutedEventArgs e)
        {
        }

        // Tile
        public void showTile()
        {
            XmlDocument smallTileData = TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquare150x150PeekImageAndText02);
            XmlNodeList smallTextData = smallTileData.GetElementsByTagName("text");
            XmlNodeList smallImageData = smallTileData.GetElementsByTagName("image");

            smallTextData[0].InnerText = postsList.ElementAt(0).brief;
            smallTextData[1].InnerText = postsList.ElementAt(0).date; 
            ((XmlElement)smallImageData[0]).SetAttribute("src", "ms-appx:///"+postsList.ElementAt(0).imageUrl);
//            ((XmlElement)smallImageData[0]).SetAttribute("src", "ms-appx:///Assets/Logo.jpg");
            ((XmlElement)smallImageData[0]).SetAttribute("alt", "red graphic");

            //宽版
//            XmlDocument wideTileData = TileUpdateManager.GetTemplateContent(TileTemplateType.TileWide310x150BlockAndText01);
//            XmlNodeList wideTextData = smallTileData.GetElementsByTagName("text");
//            XmlNodeList wideImageData = smallTileData.GetElementsByTagName("image"); 
//            wideTextData[0].InnerText = postsList.ElementAt(0).brief;
//            wideTextData[1].InnerText = postsList.ElementAt(0).date;
//            ((XmlElement)wideImageData[0]).SetAttribute("src", "ms-appx:///" + postsList.ElementAt(0).imageUrl);
////            ((XmlElement)wideImageData[0]).SetAttribute("src", "ms-appx:///Assets/Wide310x150Logo.scale-100.jpg");
//            ((XmlElement)wideImageData[0]).SetAttribute("alt", "red graphic");
//            IXmlNode newNode = wideTileData.ImportNode(smallTileData.GetElementsByTagName("binding").Item(0), true);
            
            // 计划通知
            Int16 dueTimeInSeconds = 3;
            DateTime dueTime = DateTime.Now.AddSeconds(dueTimeInSeconds);
            ScheduledTileNotification scheduledTile = new ScheduledTileNotification(smallTileData, dueTime);
            scheduledTile.Id = "Future_Tile";
            //TileUpdateManager.CreateTileUpdaterForApplication().AddToSchedule(scheduledTile);


            TileNotification notification = new TileNotification(smallTileData);
            //TileNotification notification = new TileNotification(wideTileData);
            //notification.ExpirationTime = DateTimeOffset.UtcNow.AddSeconds(10);
           // TileUpdateManager.CreateTileUpdaterForApplication().Update(notification);
            //定期通知
            string polledUrl = "http://appdev.sysu.edu.cn/~mad/Tools/Test/sample.xml";
            PeriodicUpdateRecurrence recurrence = PeriodicUpdateRecurrence.HalfHour;
            System.Uri url = new System.Uri(polledUrl);

           // TileUpdateManager.CreateTileUpdaterForApplication().StartPeriodicUpdate(url, recurrence);
        }

        public void showToast()
        {
            XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(
                                             ToastTemplateType.ToastImageAndText01);

            //text
            XmlNodeList stringElements = toastXml.GetElementsByTagName("text");
            stringElements[0].AppendChild(toastXml.CreateTextNode("You have a message"));

            //image
            string imagePath = "ms-appx:///Assets/Logo.png";
            XmlNodeList imageElements = toastXml.GetElementsByTagName("image");
            ((XmlElement)imageElements[0]).SetAttribute("src", imagePath);
            ((XmlElement)imageElements[0]).SetAttribute("alt", "red graphic");

            //audio
            IXmlNode toastNode = toastXml.SelectSingleNode("/toast");
            XmlElement audio = toastXml.CreateElement("audio");
            //messenger mode
            audio.SetAttribute("src", "ms-winsoundevent:Notification.IM");
            toastNode.AppendChild(audio);
            //
            ((XmlElement)toastNode).SetAttribute("launch", 
                        "{\"type\":\"toast\",\"param1\":\"12345\",\"param2\":\"67890\"}");

            // 计划通知
            Int16 dueTimeInSeconds = 3;
            DateTime dueTime = DateTime.Now.AddSeconds(dueTimeInSeconds);
            ScheduledToastNotification scheduledToast = new ScheduledToastNotification(toastXml, dueTime);
            scheduledToast.Id = "Future_Toast";

            //create and send toast
            ToastNotification toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
            ToastNotificationManager.CreateToastNotifier().AddToSchedule(scheduledToast);

            
        }
    }
}
