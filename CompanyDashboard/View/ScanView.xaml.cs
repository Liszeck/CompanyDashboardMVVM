using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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

namespace CompanyDashboard.View
{
    /// <summary>
    /// Interaction logic for ScanView.xaml
    /// </summary>
    public partial class ScanView : UserControl
    {
        public ScanView()
        {
            InitializeComponent();
        }

        private void PlainTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PlainTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void PlainTextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=sdt_Company;Integrated Security=True");
            string InsertQuery = "insert into CompanyDB(ID,Profit,EmployeeCount,Sales)Values('" + TextBox4.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(InsertQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void PlainTextBox_TextChanged4(object sender, TextChangedEventArgs e)
        {

        }
    }
}
