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
using Catfish.Models;
using System.Collections.ObjectModel;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace Catfish
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MessageView : Page
    {
        ObservableCollection<Message> messageList = new ObservableCollection<Message>();
        public MessageView()
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
            messageList.Add(new Message("Me", "like", "angelababy", "Images/man.jpg", "like", "2013-11-11", "Images/posts/2.jpg"));
            messageList.Add(new Message("Me", "like", "angelababy", "Images/man.jpg", "like", "2013-11-11", "Images/posts/2.jpg"));
            messageList.Add(new Message("Me", "like", "angelababy", "Images/man.jpg", "like", "2013-11-11", "Images/posts/2.jpg"));
            messageList.Add(new Message("Me", "like", "angelababy", "Images/man.jpg", "like", "2013-11-11", "Images/posts/2.jpg"));
            messageGrid.ItemsSource = messageList;
        }
    }
}
