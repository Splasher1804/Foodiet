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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Foodiet;Integrated Security=True");

        private void button_login_Click(object sender, RoutedEventArgs e)
        {
            String username, password;

            username = tb_username.Text;
            password = tb_password.Text;

            try
            {
                String query = "SELECT * FROM login WHERE username = '" + tb_username.Text + "' AND password = '" + tb_password.Text+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if(dataTable.Rows.Count > 0)
                {
                    username = tb_username.Text;
                    password = tb_password.Text;

                    HomeWindow home = new HomeWindow();
                    home.Show();
                    this.Close();
                }
                else
                {
                    tb_username.Clear();
                    tb_password.Clear();
                    MessageBox.Show("Account not found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }


        private void button_signup_Click(object sender, RoutedEventArgs e)
        {
            SignupWindow signup = new SignupWindow();
            signup.Show();
            this.Close();
        }


    }

}
