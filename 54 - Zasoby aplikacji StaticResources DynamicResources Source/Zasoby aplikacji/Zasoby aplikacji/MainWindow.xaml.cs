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

namespace DataContext_INotifyPr
{
    //   teraz musimy dać w komentarz EditingModes gdyż tworzymy go w zakresie xamla 
    // można się do niej odwoływać THIS gdyż jest ona w drzewie MainWindow


    public partial class MainWindow : Window
    {
        //InkEditingModes editingModes = new InkEditingModes();


        public MainWindow()
        {
            InitializeComponent();

            //inkCanvas.DataContext = editingModes;
        }

        private void Drawing_Click(object sender, RoutedEventArgs e)
        {
            // editingModes.EditingMode = InkCanvasEditingMode.Ink;
            (Application.Current.Resources["editingModes"] as InkEditingModes).EditingMode = InkCanvasEditingMode.Ink;

            // jeśli chcemy się odnosić do dany statyczny w APP.Xaml to musimy dodać "Application.Current.Resources"  jak powyżej
        }

        private void Selection_Click(object sender, RoutedEventArgs e)
        {
            // editingModes.EditingMode = InkCanvasEditingMode.Select;
            (Application.Current.Resources["editingModes"] as InkEditingModes).EditingMode = InkCanvasEditingMode.Select;
        }        
    }
}
