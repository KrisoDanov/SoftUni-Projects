using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private readonly List<IComponent> components;
        private readonly List<IPeripheral> peripherals;
        public Computer(int id, string manufacturer, string model, decimal price, double overallPerformance)
            : base(id, manufacturer, model, price, overallPerformance)
        {
            components = new List<IComponent>();
            peripherals = new List<IPeripheral>();
        }

        public IReadOnlyCollection<IComponent> Components => this.components;

        public IReadOnlyCollection<IPeripheral> Peripherals => this.peripherals;

        public void AddComponent(IComponent component)
        {
            if (components.Any(x => x.GetType() == component))
            {
                throw new ArgumentException($"Component {component} already exists in {this.GetType().Name} with Id {Id}.");
            }
            else
            {
                components.Add(component);
            }
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (peripherals.Any(x => x.GetType() == peripheral))
            {
                throw new ArgumentException($"Peripheral {peripheral} already exists in {this.GetType().Name} with Id {Id}.");
            }
            else
            {
                peripherals.Add(peripheral);
            }
        }

        public IComponent RemoveComponent(string componentType)
        {
            if (components.Any(x => x.Model == componentType))
            {
                IComponent thingToRemove = components.FirstOrDefault(x => x.Model == componentType);
                components.Remove(components.Find(x => x.Model == componentType));
                return thingToRemove;
            }
            else
            {
                throw new ArgumentException($"Peripheral {componentType} already exists in {this.GetType().Name} with Id {Id}.");
            }
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            if (peripherals.Any(x => x.Model == peripheralType))
            {
                var thingToRemove = peripherals.FirstOrDefault(x => x.Model == Model);
                peripherals.Remove(peripherals.FirstOrDefault(x => x.Model == peripheralType));
                return thingToRemove;
            }
            else
            {
                throw new ArgumentException($"Peripheral {peripheralType} does not exist in {this.GetType().Name} with Id {Id}.");
            }
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();


            sb.AppendLine($"Overall Performance: {OverallPerformance}. Price: {Price} - {this.GetType().Name}: {Manufacturer} {Model} (Id: {Id})");
            sb.AppendLine($" Components ({components.Count}):");
            if (components.Count > 0)
            {
                foreach (var component in components)
                {
                    sb.AppendLine($"  {component}");
                }
            }

            sb.AppendLine($" Peripherals ({peripherals.Count}); Average Overall Performance ({OverallPerformance}):");
            if (peripherals.Count > 0)
            {
                foreach (var peripheral in peripherals)
                {
                    sb.AppendLine($"  {peripheral}");
                }
            }
            return sb.ToString();
        }
    }
}
