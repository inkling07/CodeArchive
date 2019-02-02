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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// Il modello di elemento Pagina vuota è documentato all'indirizzo https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x410

namespace CodeArchive
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static int x = 0;
        private DispatcherTimer time1;

        public MainPage()
        {
            this.InitializeComponent();
            Progress.IsIndeterminate = true;
            Progress.IsEnabled = false;
            
        }

        private void login(object sender, RoutedEventArgs e)
        {
            if (mail.Text == "pass")
                if (pass.Password == "password")
            {
                    time1 = new DispatcherTimer();
                    time1.Start();
                    time1.Interval = new TimeSpan(0, 0, 0, 0, 50);
                    time1.Tick += timestart;
                    Progress.IsEnabled = true;
                this.Frame.Navigate(typeof(Home), null, new EntranceNavigationTransitionInfo());

                }
        }

        private void timestart(object sender, object e)
        {
            x += 1;

            if (x >= Progress.Maximum) ;
             //   this.Frame.Navigate(typeof(Home), null, new EntranceNavigationTransitionInfo());
        }
        }
    }

