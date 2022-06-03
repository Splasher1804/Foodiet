using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Shapes;
using Foodiet.Models;
using System.Diagnostics;
using System.Linq;
using System.Windows.Controls.Primitives;

namespace Foodiet
{
    /// <summary>
    /// Interaction logic for AddMeal.xaml
    /// </summary>
    public partial class AddMeal : Window
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Foodiet.Models.FoodContext;Integrated Security=True");
        private FoodContext _context;

        public AddMeal()
        {
            InitializeComponent();

            _context = new FoodContext();
            var foods = _context.Foods.Select(o => new
            { Column1 = o.Description, Column2 = o.Calories }).ToList(); ;
            DataGrid Content = (DataGrid)this.FindName("dataGrid");
            Content.ItemsSource = foods;
            DataGridCheckBoxColumn Column3 = new DataGridCheckBoxColumn();
            Column3.Header = "Selected";
            Column3.Binding = new Binding("Selected");
            dataGrid.Columns.Add(Column3);
        }

        private void button_save_Click(object sender, RoutedEventArgs e)
        {
            DataGrid Content = (DataGrid)this.FindName("dataGrid");

            for (int i = 0; i < Content.Items.Count; i++)
            {
                DataGridColumn row = (DataGridColumn)Content.ItemContainerGenerator
                                                           .ContainerFromIndex(0);

                MessageBox.Show(row.GetCellContent(i).ToString());
            }


        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
