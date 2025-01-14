using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.IO;
using System.Xml;
//using KrnlAPI;
//using WeAreDevs_API;
//using EasyExploits;
using System.Threading;
//using Oxygen;


//   MADE BY SOULZAY#2182 

//   SKID IF YOU'RE A NOBODY THAT CANT CODE RAHHHHHHHHH
namespace atonixlol
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // EasyExploits.Module EZEXAPI = new EasyExploits.Module();
        //FluxAPI.API FLUXAPI = new FluxAPI.API();
       // KrnlApi KRNLAPI = new KrnlApi();
        //ExploitAPI WRDAPI = new ExploitAPI();

        public MainWindow()
        {
            InitializeComponent();
            texteditor.Text =
                "--                Welcome to\n" +
                "--                  FlameX\n" +
                "--            Multi API Executor! POGGGGG\n" +
                "--            Made by Soulzay#2182 And IDarkLord#2480 ";

            Stream xshd_stream = File.OpenRead(System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "/files" + "/robloxsyntax.xml");
            XmlTextReader xshd_reader = new XmlTextReader(xshd_stream);
            texteditor.SyntaxHighlighting = ICSharpCode.AvalonEdit.Highlighting.Xshd.HighlightingLoader.Load(xshd_reader, ICSharpCode.AvalonEdit.Highlighting.HighlightingManager.Instance);
            xshd_reader.Close();
            xshd_stream.Close();
        }

        private void dragwin(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void startanim(object sender, RoutedEventArgs e)
        {
            DoubleAnimation winanim = new DoubleAnimation();
            winanim.From = 0;
            winanim.To = 350;
            winanim.Duration = TimeSpan.FromSeconds(1);
            winanim.EasingFunction = new SineEase();
            mainwin.BeginAnimation(HeightProperty, winanim);

            DoubleAnimation textedanim = new DoubleAnimation();
            textedanim.From = 0;
            textedanim.To = 254;
            textedanim.Duration = TimeSpan.FromSeconds(1);
            textedanim.EasingFunction = new SineEase();
            DoubleAnimation textedanim2 = new DoubleAnimation();
            textedanim2.From = 0;
            textedanim2.To = 254;
            textedanim2.Duration = TimeSpan.FromSeconds(0.3);
            textedanim2.EasingFunction = new SineEase();
            texteditor.BeginAnimation(HeightProperty, textedanim2);
            apiselector.BeginAnimation(HeightProperty, textedanim);
        }

        private void exitapp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void injbut_Click(object sender, RoutedEventArgs e)
        {
            if (WRDSELECT == true)
            {
               // WRDAPI.LaunchExploit();
            }
            else if (KRNLSELECT == true)
            {
               // KRNLAPI.Inject();
            }
            else if (FLUXSELECT == true)
            {
                //FLUXAPI.Inject();
            } 
            else if (EZEXSELECT == true)
            {
                //EZEXAPI.LaunchExploit();
            }
            else if  (OXYSELECT == true)
            {
                
            }
        }

        private void exebut_Click(object sender, RoutedEventArgs e)
        {
            if (WRDSELECT == true)
            {
               // WRDAPI.SendLuaScript(texteditor.Text);
            }
            else if (KRNLSELECT == true)
            {
               // KRNLAPI.Execute(texteditor.Text);
            }
            else if (FLUXSELECT == true)
            {
               // FLUXAPI.Execute(texteditor.Text);
            }
            else if (EZEXSELECT == true)
            {
               // EZEXAPI.ExecuteScript(texteditor.Text);
            }
        }

        private void openfile(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog script = new Microsoft.Win32.OpenFileDialog();
            script.DefaultExt = ".txt|.lua";
            script.Filter = "Text documents (.txt)|*.txt|Lua Files (.lua)|*.lua";
            script.ShowDialog();

            texteditor.Text = File.ReadAllText(script.FileName);
        }

        private void cleartext(object sender, RoutedEventArgs e)
        {
            texteditor.Text = "";
        }

        public bool WRDSELECT;
        public bool FLUXSELECT;
        public bool KRNLSELECT;
        public bool OXYSELECT;
        public bool EZEXSELECT;
        private void WRDCLICK(object sender, RoutedEventArgs e)
        {
            WRDSELECT = true;
            FLUXSELECT = false;
            KRNLSELECT = false;
            EZEXSELECT = false;
            WRD.Header = "WeAreDevs API <==";
            FLUXUS.Header = "Fluxus API";
            KRNL.Header = "Krnl API";
            EZEX.Header = "EasyExploits API";
            
        }

        private void FLUXUSCLICK(object sender, RoutedEventArgs e)
        {
            WRDSELECT = false;
            FLUXSELECT = true;
            KRNLSELECT = false;
            EZEXSELECT = false;
            WRD.Header = "WeAreDevs API";
            FLUXUS.Header = "Fluxus API <==";
            KRNL.Header = "Krnl API";
            EZEX.Header = "EasyExploits API";
            
        }

        private void KRNLCLICK(object sender, RoutedEventArgs e)
        {
            WRDSELECT = false;
            FLUXSELECT = false;
            KRNLSELECT = true;
            EZEXSELECT = false;
            WRD.Header = "WeAreDevs API";
            FLUXUS.Header = "Fluxus API";
            KRNL.Header = "Krnl API <==";
            EZEX.Header = "EasyExploits API";
            
        }
        private void EZEXCLICK(object sender, RoutedEventArgs e)
        {
            WRDSELECT = false;
            FLUXSELECT = false;
            KRNLSELECT = false;
            EZEXSELECT = true;
            WRD.Header = "WeAreDevs API";
            FLUXUS.Header = "Fluxus API";
            KRNL.Header = "Krnl API";
            EZEX.Header = "EasyExploits API <==";
            
        }
        private void multiroblox(object sender, RoutedEventArgs e)
        {
            new Mutex(true, "ROBLOX_singletonMutex");
            MessageBox.Show("Turned on", "Success");
        }

        private void minimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void OGUCLICK(object sender, RoutedEventArgs e)
        {
            WRDSELECT = false;
            FLUXSELECT = false;
            KRNLSELECT = false;
            EZEXSELECT = false;
            OXYSELECT = true;
            WRD.Header = "WeAreDevs API";
            FLUXUS.Header = "Fluxus API";
            KRNL.Header = "Krnl API";
            EZEX.Header = "EasyExploits API ";
            
        }
    }

    class OXYGENAPI
    {
    }
}

//   MADE BY SOULZAY#2182 

//   SKID IF YOU'RE A NOBODY THAT CANT CODE RAHHHHHHHHH