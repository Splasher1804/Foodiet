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
using System.Data.SqlClient;
using System.Data;

namespace Foodiet
{
    /// <summary>
    /// Interaction logic for SignupWindow.xaml
    /// </summary>
    public partial class SignupWindow : Window
    {
        public SignupWindow()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Foodiet.Models.FoodContext;Integrated Security=True");
        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            this.Close();
        }

        private void button_create_account_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
                String query2 = "SELECT * FROM Login WHERE username = '" + tb_signup_username.Text + "'";
                SqlDataAdapter adapter2 = new SqlDataAdapter(query2, conn);

                DataTable dataTable2 = new DataTable();
                adapter2.Fill(dataTable2);


                if (dataTable2.Rows.Count > 0)
                {

                    signup_info.Content = "Account already exists";
                }
                else
                {
                    String query = "INSERT INTO Login (username,password) VALUES('" + tb_signup_username.Text + "', '" + tb_signup_password.Text + "')";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    signup_info.Content = "Account has been succesfully created";
                    //Task.Delay(2000).ContinueWith(_ =>
                    //{
                        
                    //}
                    //);
                    LoginWindow login = new LoginWindow();
                    login.Show();
                    this.Close();

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
    }
}
