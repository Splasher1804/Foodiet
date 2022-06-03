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
using System.Windows.Navigation;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Shapes;
using Foodiet.Models;
using System.Diagnostics;

namespace Foodiet.Pages
{
    /// <summary>
    /// Interaction logic for UserMeals.xaml
    /// </summary>
    public partial class UserMeals : Page
    {
        private MealDisplay selectedMeal;
        private FoodContext _context;
        public UserMeals()
        {
            _context = new FoodContext();
            InitializeComponent();
            display_data();

        }


        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Foodiet.Models.FoodContext;Integrated Security=True");


        private void Grid2_click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("i am ");
            MealDisplay ClickedButton = e.OriginalSource as MealDisplay;
            Debug.WriteLine(e.OriginalSource.ToString());
            if (ClickedButton != null)
            {
                ClickedButton.strokeThickness = "0";
                if(selectedMeal!=null)
                selectedMeal.strokeThickness = "1";
                selectedMeal = ClickedButton;
            }
        }

        int Index = 0;
        private void button_add_meal_Click(object sender, RoutedEventArgs e)
        {
            AddMeal addMeal = new AddMeal();
            addMeal.Show();
        }

        private void display_data()
        {
            Grid Content = (Grid)this.FindName("content_meals");
            Content.Children.Clear();
            Content.RowDefinitions.Clear();
            Index = 0;

            try
            {
                var Meals = _context.Meals;

                foreach (var row in _context.Meals)
                {
                    MealDisplay meal1 = new MealDisplay();
                    meal1.mealID = row.MealID;
                    meal1.nameOfMeal = row.Name;
                    meal1.description = row.Description;
                    float calories = 0;
                    foreach (var row2 in row.Foods)
                    {
                        calories += row2.Calories;
                    }
                    meal1.totalCalories = calories.ToString();
                    meal1.mealImage = new BitmapImage(new Uri("/Images/Menu_meal_img.jpg", UriKind.Relative));
                    meal1.strokeThickness = "0";

                    Content.Children.Add(meal1);
                    var rowDefinition = new RowDefinition();
                    rowDefinition.Height = GridLength.Auto;
                    Content.RowDefinitions.Add(rowDefinition);
                    Grid.SetRow(meal1, Index);
                    Index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

        }

        private void button_remove_meal_Click(object sender, RoutedEventArgs e)
        {
            if (selectedMeal != null)
                foreach (var row in _context.Meals)
                {
                    if (row.MealID == selectedMeal.mealID)
                        _context.Meals.Remove(row);
                }
            _context.SaveChanges();
            display_data();
        }
    }
    
}
