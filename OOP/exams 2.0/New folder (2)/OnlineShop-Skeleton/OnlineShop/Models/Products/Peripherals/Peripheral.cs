using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Peripherals
{
    public abstract class Peripheral : Product, IPeripheral
    {
        public Peripheral(int id, string manufacturer, string model, decimal price, double overallPerformance, string connectionType) 
            : base(id, manufacturer, model, price, overallPerformance)
        {
            this.ConnectionType = connectionType;
        }

        public string ConnectionType { get; set; }

        public override string ToString()
        {
            return $"Overall Performance: {OverallPerformance}. Price: {Price} - {this.GetType()}: {Manufacturer} {Model} (Id: {Id}) Connection Type: {ConnectionType}";
        }

    }

}
