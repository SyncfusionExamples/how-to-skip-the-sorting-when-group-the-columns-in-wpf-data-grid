using Syncfusion.UI.Xaml.TreeGrid;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace SfDataGrid_MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.dataGrid.Loaded += OnDataGrid_Loaded;
        }

        private void OnDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            this.dataGrid.View.CurrentChanged += OnView_CurrentChanged;
        }

        private void OnView_CurrentChanged(object sender, EventArgs e)
        {
            var groupColumn = dataGrid.View.SortDescriptions.FirstOrDefault(x => x.PropertyName == "ProductName");

            if (dataGrid.SortColumnDescriptions.FirstOrDefault(x => x.ColumnName == "ProductName") != null)
                dataGrid.View.SortDescriptions.Remove(groupColumn);
        }
    }
}
