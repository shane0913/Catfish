using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Catfish
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SearchView : Page
    {
        ObservableCollection<User> search_list = new ObservableCollection<User>();
        public SearchView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            search_grid.ItemsSource = search_list;
        }

        /// <summary>
        /// Find user by username in database. Result is stored in this.search_list
        /// </summary>
        /// <param name='username'>username used for searching</param>
        private void findUserByUsername(String username)
        { 
            /// 先用静态数据
            /// ...

            search_list.Add(new User("angelababyct", "123456", "angelababy", "female", "hi:)", "2010-01-01", "Images/man.jpg"));
        }
    }
}
