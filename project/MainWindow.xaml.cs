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
using System.Windows.Navigation;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;   


namespace project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button btn;
        private object SessionList;

        public List<Session> listOfSessions { get; set; }
        public MainWindow()
        {
           
            InitializeComponent();

            MongoClient client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("some");
            var collection = database.GetCollection<BsonDocument>("aaa");

              using (IAsyncCursor<BsonDocument> cursor = collection.FindSync(new BsonDocument()))
                  {
                    while (cursor.MoveNext())
                    {
                      IEnumerable<BsonDocument> batch = cursor.Current;
                      foreach (BsonDocument document in batch)
                      {
                      // lbl1.Content += document["_id"].ToString()+"    "+document["text"].ToString()+"\n";

                      }
                    }
                  }

       //     using (IAsyncCursor<BsonDocument> cursor = await collection.FindSync(new BsonDocument())) //Синхронды түрде оқу
        //    {
        //        while (cursor.MoveNext()) //Бар болса келесі курсорға өту
        //        {
        //            IEnumerable<BsonDocument> batch = cursor.Current; //Курсордың бөліктерін алады, Бұл жағдайда барлық құжат бір бөлік болады
          //          foreach (BsonDocument document in batch) //Әр бөліктегі құжаттарды алады
            //        {
              //          lbl1.Content += document["_id"].ToString() + "\n";
                       // docs.Add(document);
                //    }
                //}
               // MessageBox.Show(docs.Count.ToString());
        //    }


        }

        private void BtnFirst(object sender, RoutedEventArgs e)
        {
            MainPage.Content = new Page1();
        }

        private void BtnSecond(object sender, RoutedEventArgs e)
        {
          //  String cinema = Cinemas.SelectedItem.ToString();
           // Page2 p2 = new Page2();
            MainPage.Content = new Page2();
        }


        private void ComboBox_Selected(object sender, SelectionChangedEventArgs e)
        {

            Page2 p2 = new Page2();
            String cinema = Cinemas.SelectedItem.ToString();
           // p2.ForCinemaName.Content = cinema;
      
             ComboBox comboBox = (ComboBox)sender;
           try { 
             ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
                p2.ForCinemaName.Content = selectedItem.ToString();
              MessageBox.Show(selectedItem.ToString());
            }
            catch
            {
                MessageBox.Show("Something wrong");
            }
       
        }
    }
}
