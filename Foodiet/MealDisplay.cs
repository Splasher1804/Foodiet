using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Foodiet
{

    public class MealDisplay : ButtonBase
    {
        static MealDisplay()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MealDisplay), new FrameworkPropertyMetadata(typeof(MealDisplay)));
        }



        public int mealID
        {
            get { return (int)GetValue(mealIDProperty); }
            set { SetValue(mealIDProperty, value); }
        }

        // Using a DependencyProperty as the backing store for mealID.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty mealIDProperty =
            DependencyProperty.Register("mealID", typeof(int), typeof(MealDisplay), new PropertyMetadata(0));



        public ImageSource mealImage
        {
            get { return (ImageSource)GetValue(mealImageProperty); }
            set { SetValue(mealImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for mealImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty mealImageProperty =
        DependencyProperty.Register("mealImage", typeof(ImageSource), typeof(MealDisplay), new PropertyMetadata(null));

        public String nameOfMeal
        {
            get { return (String)GetValue(nameOfMealProperty); }
            set { SetValue(nameOfMealProperty, value); }
        }

        // Using a DependencyProperty as the backing store for nameOfMeal.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty nameOfMealProperty =
        DependencyProperty.Register("nameOfMeal", typeof(String), typeof(MealDisplay), new PropertyMetadata(null));

        public String description
        {
            get { return (String)GetValue(descriptionProperty); }
            set { SetValue(descriptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Description.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty descriptionProperty =
        DependencyProperty.Register("description", typeof(String), typeof(MealDisplay), new PropertyMetadata(null));



        public String totalCalories
        {
            get { return (String)GetValue(totalCaloriesProperty); }
            set { SetValue(totalCaloriesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for totalCalories.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty totalCaloriesProperty =
            DependencyProperty.Register("totalCalories", typeof(String), typeof(MealDisplay), new PropertyMetadata(null));


        public ListBox listOfFoodItems
        {
            get { return (ListBox)GetValue(listOfFoodItemsProperty); }
            set { SetValue(listOfFoodItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for listOfFoodItems.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty listOfFoodItemsProperty =
        DependencyProperty.Register("listOfFoodItems", typeof(ListBox), typeof(MealDisplay), new PropertyMetadata(null));


        public String strokeThickness
        {
            get { return (String)GetValue(strokeThicknessProperty); }
            set { SetValue(strokeThicknessProperty, value); }
        }
        // Using a DependencyProperty as the backing store for strokeThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty strokeThicknessProperty =
            DependencyProperty.Register("strokeThickness", typeof(String), typeof(MealDisplay), new PropertyMetadata("0"));



    }
}
