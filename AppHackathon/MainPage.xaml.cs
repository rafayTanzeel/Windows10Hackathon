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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AppHackathon
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private DispatcherTimer t;
        private int timerVal;
        private int breakLimit;
        private int breakMax;

        public MainPage()
        {
            this.InitializeComponent();
            t = new DispatcherTimer();
            t.Tick += T_Tick;
            t.Interval = new TimeSpan(0, 0, 1);
            timerVal = 0;

            breakMax = 5;
            breakLimit = breakMax;
        }

        
        private void AddTime_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddTime_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                this.Frame.Navigate(typeof(MainPage));
            }
        }

        private void HistoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                this.Frame.Navigate(typeof(Page2));
            }
        }

        private void NotesButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                this.Frame.Navigate(typeof(Page3));
            }
        }

        private void StartTimer()
        {
            if (((string)toggleTimer.Content).CompareTo("START") == 0)
            {
                t.Stop();
                
            }
            else
            {
                t.Start();
            }
            return;
        }

        private void T_Tick(object sender, object e)
        {
            
            timerVal += 1;
            breakLimit--;
            if ( breakLimit == 0)
            {
                t.Stop();
                toggleTimer.Content = "START";
               // breakLimit = breakMax;

            }
            Timer.Text = TimeSpan.FromSeconds(timerVal).ToString();
            BreakTimer.Text = TimeSpan.FromSeconds(breakLimit).ToString();
            

        }

        private void dispatcherTick(object sender, EventArgs e)
        {
            throw new NotImplementedException();


        }


        private void toggleTimer_Click_1(object sender, RoutedEventArgs e)
        {
            string name = (string)toggleTimer.Content;
            if (name.CompareTo("START") == 0)
            {
                toggleTimer.Content = "PAUSE";
                if (breakLimit == 0)
                {
                    breakLimit = timerVal;
                }
                StartTimer();
            }
            else {
                toggleTimer.Content = "START";
                t.Stop();
            }


        }
    }
}
