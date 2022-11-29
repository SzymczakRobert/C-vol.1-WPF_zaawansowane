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
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        InkEditingModes editingModes = new InkEditingModes();


        public MainWindow()
        {
            InitializeComponent();

            inkCanvas.DataContext = editingModes;
        }

        private void Drawing_Click(object sender, RoutedEventArgs e)
        {
            editingModes.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void Selection_Click(object sender, RoutedEventArgs e)
        {
            editingModes.EditingMode = InkCanvasEditingMode.Select;
        }
        // to dotyczy banału 
        /****************************
         *                          *
         *     Uwaga Ważne !!!!!!   *
         *                          *
         ****************************
         */
    }
}
