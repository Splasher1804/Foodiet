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
using System.Windows.Shapes;

namespace Foodiet.Pages
{
    /// <summary>
    /// Interaction logic for UserMeals.xaml
    /// </summary>
    public partial class UserMeals : Page
    {
        public UserMeals()
        {
            InitializeComponent();

            display_data();
        }

        private void button_add_meal_Click(object sender, RoutedEventArgs e)
        {
            MealDisplay meal1 = new MealDisplay();
            meal1.Name = "Breakfast";
            meal1.description = "low calorie breakfast";
            meal1.totalCalories = "340";
            meal1.mealImage = new BitmapImage(new Uri("/Images/Menu_meal_img.jpg", UriKind.Relative));
            MealDisplay meal2 = meal1;

            Grid Content = (Grid)this.FindName("content_meals");
            Content.Children.Add(meal1);

        }

        private void display_data()
        {
            Grid Content = (Grid)this.FindName("content_meals");
        }
    }
}
