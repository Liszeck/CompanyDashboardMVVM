using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Haley;
using Haley.Abstractions;
using Haley.Enums;
using Haley.Events;
using Haley.Models;
using Haley.MVVM;
using Haley.Utils;
using System.Windows.Input;
using System.Data.Sql;

namespace CompanyDashboard.ViewModel
{
    public class DashboardViewModel : BaseVM
    {
       
        private double _profit;
        public double Profit { get { return _profit; } set { SetProp(ref _profit, value); } }

        private double _sales;
        public double Sales { get { return _sales; } set { SetProp(ref _sales, value); } }

        private int _employeeCount;
        public int EmployeeCount { get { return _employeeCount; } set { SetProp(ref _employeeCount, value); } }

        private int _id;
        public int Id { get { return _id; } set { SetProp(ref _id, value); } }

        public DashboardViewModel() 
        {
             
            Profit = 10000;
            Sales = 1200;
            EmployeeCount = 12;
            Id = 1;

        }
        
    }
}
