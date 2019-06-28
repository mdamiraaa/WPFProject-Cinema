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
    public class Session
    {
        public string Film_name { get; internal set;}
        public string Film_format { get; internal set;}
        public string Time { get; internal set; }
        public int price_adult { get; internal set; }
        public int price_children { get; internal set; }
        public int price_student { get; internal set; }
        public Image image { get; internal set; }



    }
}