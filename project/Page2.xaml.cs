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

namespace project
{


    public partial class Page2 : Page
    {
        public List<Session> listOfSessions { get; set; }
        public Page2()
        {
          
            InitializeComponent();

            listOfSessions = new List<Session>();

            Session session1 = new Session();
            session1.Film_name = "Бизнесмены";
            session1.Film_format = "-";
            session1.Time = "11:00";
            session1.price_adult = 1000;
            session1.price_children = 800;
            session1.price_student = 900;

            Session session2 = new Session();
            session2.Film_name = "Быть Астрид Линдгрен";
            session2.Film_format = "-";
            session2.Time = "13:00";
            session2.price_adult = 1000;
            session2.price_children = 800;
            session2.price_student = 900;

            Session session3 = new Session();
            session3.Film_name = "Преступления Грин-де-Вальда";
            session3.Film_format = "-";
            session3.Time = "16:00";
            session3.price_adult = 1000;
            session3.price_children = 800;
            session3.price_student = 900;
            


           listOfSessions.Add(session1);
           listOfSessions.Add(session2);
           listOfSessions.Add(session3);

            DataContext = this;
        }

  
        private void ButtonBuyTicket_Click(object sender, RoutedEventArgs e)
        {

            Page3 page3 = new Page3();
            NavigationService.Navigate(page3);

            Button b = sender as Button;
            Session session= b.CommandParameter as Session;
            page3.FilmName.Content = session.Film_name;
        //    MessageBox.Show(session.Film_name);

            //MainWindow main = new MainWindow();
            // Window1 win1 = new Window1();
            // win1.Show();
            // Application.Current.MainWindow.Opacity = 0.5;
            // main.MainPage.Content = new Page3();

        }
    }
}
