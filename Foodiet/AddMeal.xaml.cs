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
            { Name = o.Description, Calories = o.Calories , foodID = o.FoodID}).ToList(); ;
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
            var nameCheck = _context.Meals.Where(o => o.Name == tb_name.Text).FirstOrDefault(); ;
            
            if (nameCheck == null &&(tb_name.Text != "" || tb_description.Text != ""))
            { 
            List<Food> foodList = new List<Food>();

            for (int i = 0; i < Content.Items.Count; i++)
            {
                DataGridRow row = (DataGridRow)Content.ItemContainerGenerator.ContainerFromIndex(i);
                CheckBox cellContent = Content.Columns[0].GetCellContent(row) as CheckBox;
                TextBlock cellContent2 = Content.Columns[3].GetCellContent(row) as TextBlock;
                
                if (cellContent.IsChecked == true)
                {
                    int id = Int32.Parse(cellContent2.Text);
                    foodList.Add(_context.Foods.Where(l => l.FoodID == id).FirstOrDefault());
                }
            }
                var meal_add = new Meal { Name = tb_name.Text, Description= tb_description.Text, Foods=foodList };
                _context.Meals.Add(meal_add);
                _context.SaveChanges();
                this.Close();

            }
            else if(tb_name.Text ==""||tb_description.Text=="")
            {
                MessageBox.Show("Please fill out all fields");
            }
            else { MessageBox.Show("A meal under that name already exists");  }
            
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
