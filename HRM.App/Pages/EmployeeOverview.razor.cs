using HRM.App.Models;
using HRM.Shared;

namespace HRM.App.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = default!;


        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;
        }


    }
}
