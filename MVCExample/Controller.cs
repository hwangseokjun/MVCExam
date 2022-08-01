using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExample
{
    public class Controller
    {
        private IView view = null;

        private List<Employee> employees = new List<Employee>();

        public Controller(IView view) 
        {
            this.view = view;
        }

    }
}
