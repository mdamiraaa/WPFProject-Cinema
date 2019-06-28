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
using System.Diagnostics;


namespace project
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        List<Button> buts;
        Button b;
        Button b1;
        public Page3()
        {

            InitializeComponent();

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
                for (int j = 0; j < 10; j++)
                {
                gridForSeats.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(30) });
                }

                for (int j = 0; j < 10; j++)
                {
                gridForSeats.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(50) });
                }

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Button b = new Button
                        {
                            Name = "Button"+i+"_"+j,
                            Content = i+1,
                            Width = 50
                            
                        };
                        b.Click += BtnClick;
                        gridForSeats.Children.Add(b);
                        Grid.SetRow(b, j);
                        Grid.SetColumn(b, i);
                    }
                }
            }


        private void BtnClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int row = int.Parse(b.Name.Substring(6,1))+1;
            int column = int.Parse(b.Name.Substring(8, 1))+1;

            LabelForSeat.Content = "Место: "+row+" Ряд: "+column;
            if (b.Background == Brushes.Red)
            {
                b.Background = Brushes.White;

            }
            else
            {
                b.Background = Brushes.Red;

            }
           
            

        }

        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            Page4 page4 = new Page4();
            NavigationService.Navigate(page4);
        }
    }
    }
