using Haley.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CompanyDashboard.Model
{
    class DashBoardModel
    {
        public ICommand AppShutdown => new DelegateCommand (app_shutdown);

        private void app_shutdown()
        {
            App.Current.Shutdown();
        }
    }
}
