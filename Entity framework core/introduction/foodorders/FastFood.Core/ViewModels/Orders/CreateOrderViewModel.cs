namespace FastFood.Core.ViewModels.Orders
{
    using System.Collections.Generic;

    public class CreateOrderViewModel
    {
        public List<CreateOrderItemViewModel> Items { get; set; }

        public List<CreateEmployeeViewModel> Employees { get; set; }
    }
}
