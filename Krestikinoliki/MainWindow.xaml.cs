using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace Krestikinoliki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int first;
        List<Button> enabled = new List<Button>();
        public MainWindow()
        {
            InitializeComponent();
            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn5.IsEnabled = false;
            btn6.IsEnabled = false;
            btn7.IsEnabled = false;
            btn8.IsEnabled = false;
            btn9.IsEnabled = false;
            start.IsEnabled = false;
            lazarev_love.IsEnabled = false;
            Player.Text = "";

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (first == 1)
            {
                (sender as Button).Content = "x";
                (sender as Button).IsEnabled = false;
                winner();
            }
            else if (first == 2)
            {
                (sender as Button).Content = "o";
                (sender as Button).IsEnabled = false;
                winner();
            }
            List<Button> allBtns = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            enabled = new List<Button>();
            foreach (var item in allBtns)
            {
                if (item.IsEnabled == true)
                {
                    enabled.Add(item);

                }
            }
            botslit();

        }
        private void botslit()
        {
            if (enabled.Count != 0)
            {
                Random random = new Random();
                int x = random.Next(0, enabled.Count - 1);
                Button btn = enabled[x];
                if (first == 1)
                {
                    first = 1;
                    btn.Content = "o";
                    btn.IsEnabled = false;
                    winner();
                }
                else 
                {
                    first = 2;
                    btn.Content = "x";
                    btn.IsEnabled = false;
                    winner();
                }
            }
        }

        private void lazarev_love_Click(object sender, RoutedEventArgs e)
        {
            lazarev_love.IsEnabled = false;
            if (lazarev_love.IsEnabled == false)
            {
                btn1.Content = "";
                btn2.Content = "";
                btn3.Content = "";
                btn4.Content = "";
                btn5.Content = "";
                btn6.Content = "";
                btn7.Content = "";
                btn8.Content = "";
                btn9.Content = "";
                start.IsEnabled = true;
                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
                Simka.IsEnabled = false;
                Shpulia.IsEnabled = false;
                Simka.IsEnabled = false;
                Player.Text = "";
                Shpulia.IsEnabled = false;
            }
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            start.IsEnabled = false;
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;
            lazarev_love.IsEnabled = true;
            Shpulia.IsEnabled = true;
            Simka.IsEnabled = true;

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Player.Text = "Ты играешь за " + (string)Simka.Content;
            first = 1;
            start.IsEnabled = true;
        }

        private void Shpulia_Checked(object sender, RoutedEventArgs e)
        {
            Player.Text = "Ты играешь за " + (string)Shpulia.Content;
            first = 2;
            start.IsEnabled = true;
            //botslit();
            
        }
        private void winner()
        {
            if (btn1.Content == "x" && btn2.Content == "x" && btn3.Content == "x" || btn4.Content == "x" && btn5.Content == "x" && btn6.Content == "x" ||
                btn7.Content == "x" && btn8.Content == "x" && btn9.Content == "x" || btn1.Content == "x" && btn4.Content == "x" && btn7.Content == "x" ||
                btn2.Content == "x" && btn5.Content == "x" && btn8.Content == "x" || btn3.Content == "x" && btn6.Content == "x" && btn9.Content == "x" ||
                btn1.Content == "x" && btn5.Content == "x" && btn9.Content == "x" || btn3.Content == "x" && btn5.Content == "x" && btn7.Content == "x")
            {
                MessageBox.Show("Симка победила");
                btn1.Content = "";
                btn2.Content = "";
                btn3.Content = "";
                btn4.Content = "";
                btn5.Content = "";
                btn6.Content = "";
                btn7.Content = "";
                btn8.Content = "";
                btn9.Content = "";
                start.IsEnabled = false;
                btn1.IsEnabled = true;
                btn2.IsEnabled = true;
                btn3.IsEnabled = true;
                btn4.IsEnabled = true;
                btn5.IsEnabled = true;
                btn6.IsEnabled = true;
                btn7.IsEnabled = true;
                btn8.IsEnabled = true;
                btn9.IsEnabled = true;
                lazarev_love.IsEnabled = true;
                if (first == 1)
                {
                    first = 2;
                }
                else if (first == 2)
                {
                    first = 1;
                }
            }
            else if (btn1.Content == "o" && btn2.Content == "o" && btn3.Content == "o" || btn4.Content == "o" && btn5.Content == "o" && btn6.Content == "o" ||
                btn7.Content == "o" && btn8.Content == "o" && btn9.Content == "o" || btn1.Content == "o" && btn4.Content == "o" && btn7.Content == "o" ||
                btn2.Content == "o" && btn5.Content == "o" && btn8.Content == "o" || btn3.Content == "o" && btn6.Content == "o" && btn9.Content == "o" ||
                btn1.Content == "o" && btn5.Content == "o" && btn9.Content == "o" || btn3.Content == "o" && btn5.Content == "o" && btn7.Content == "o")
            {
                MessageBox.Show("Шпуля победила");
                btn1.Content = "";
                btn2.Content = "";
                btn3.Content = "";
                btn4.Content = "";
                btn5.Content = "";
                btn6.Content = "";
                btn7.Content = "";
                btn8.Content = "";
                btn9.Content = "";
                start.IsEnabled = false;
                btn1.IsEnabled = true;
                btn2.IsEnabled = true;
                btn3.IsEnabled = true;
                btn4.IsEnabled = true;
                btn5.IsEnabled = true;
                btn6.IsEnabled = true;
                btn7.IsEnabled = true;
                btn8.IsEnabled = true;
                btn9.IsEnabled = true;
                lazarev_love.IsEnabled = true;
                if (first == 1)
                {
                    first = 2;
                }
                else if (first == 2)
                {
                    first = 1;
                }
            }
            else if(btn1.IsEnabled == false && btn2.IsEnabled == false && btn3.IsEnabled == false && btn4.IsEnabled == false && 
                btn5.IsEnabled == false && btn6.IsEnabled == false &&
                btn7.IsEnabled == false && btn8.IsEnabled == false && btn9.IsEnabled == false)
            {
                MessageBox.Show("Победил дедус");
                btn1.Content = "";
                btn2.Content = "";
                btn3.Content = "";
                btn4.Content = "";
                btn5.Content = "";
                btn6.Content = "";
                btn7.Content = "";
                btn8.Content = "";
                btn9.Content = "";
                start.IsEnabled = false;
                btn1.IsEnabled = true;
                btn2.IsEnabled = true;
                btn3.IsEnabled = true;
                btn4.IsEnabled = true;
                btn5.IsEnabled = true;
                btn6.IsEnabled = true;
                btn7.IsEnabled = true;
                btn8.IsEnabled = true;
                btn9.IsEnabled = true;
                lazarev_love.IsEnabled = true;
                if(first == 1)
                {
                    first = 2;
                }
                else if (first == 2)
                {
                    first = 1;
                }
            }
            return;
        }
    }
}
