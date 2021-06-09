using Component = OnlineShop.Models.Products.Components.Component;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;
using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop.Core
{
    class Controller : IController
    {
        private List<Component> components;
        private List<Computer> computers;
        private List<Peripheral> peripherals;

        public Controller()
        {
            components = new List<Component>();
            computers = new List<Computer>();
            peripherals = new List<Peripheral>();
        }
        public string AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price, double overallPerformance, int generation)
        {
            Component component = null;
            if (componentType == "CentralProcessingUnit")
            {
                if (components.FirstOrDefault(x => x.Id == computerId) == null)
                {
                    component = new CentralProcessingUnit(id, manufacturer, model, price, overallPerformance, generation);
                    components.Add(component);
                    return $"Component {componentType} with id {component.Id} added successfully in computer with id {computerId}.";
                }
                else
                {
                    throw new ArgumentException("Component type is invalid.");
                }

            }
            if (componentType == "Motherboard")
            {
                if (components.FirstOrDefault(x => x.Id == computerId) == null)
                {
                    component = new Motherboard(id, manufacturer, model, price, overallPerformance, generation);
                    components.Add(component);
                    return $"Component {componentType} with id {component.Id} added successfully in computer with id {computerId}.";
                }
                else
                {
                    throw new ArgumentException("Component type is invalid.");
                }
            }
            if (componentType == "PowerSupply")
            {
                if (components.FirstOrDefault(x => x.Id == computerId) == null)
                {
                    component = new PowerSupply(id, manufacturer, model, price, overallPerformance, generation);
                    components.Add(component);
                    return $"Component {componentType} with id {component.Id} added successfully in computer with id {computerId}.";
                }
                else
                {
                    throw new ArgumentException("Component type is invalid.");
                }
            }
            if (componentType == "RandomAccessMemory")
            {
                if (components.FirstOrDefault(x => x.Id == computerId) == null)
                {
                    component = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance, generation);
                    components.Add(component);
                    return $"Component {componentType} with id {component.Id} added successfully in computer with id {computerId}.";
                }
                else
                {
                    throw new ArgumentException("Component type is invalid.");
                }
            }
            if (componentType == "SolidStateDrive")
            {
                if (components.FirstOrDefault(x => x.Id == computerId) == null)
                {
                    component = new SolidStateDrive(id, manufacturer, model, price, overallPerformance, generation);
                    components.Add(component);
                    return $"Component {componentType} with id {component.Id} added successfully in computer with id {computerId}.";
                }
                else
                {
                    throw new ArgumentException("Component type is invalid.");
                }
            }
            if (componentType == "VideoCard")
            {
                if (components.FirstOrDefault(x => x.Id == computerId) == null)
                {
                    component = new VideoCard(id, manufacturer, model, price, overallPerformance, generation);
                    components.Add(component);
                    return $"Component {componentType} with id {component.Id} added successfully in computer with id {computerId}.";
                }
                else
                {
                    throw new ArgumentException("Component type is invalid.");
                }

            }
            else
            {
                throw new ArgumentException($"Component type is invalid.");
            }
        }

        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {
            Computer computer = null;
            if (computerType == "DesktopComputer")
            {
                if (computers.FirstOrDefault(x => x.Id == id) == null)
                {
                    computer = new DesktopComputer(id, manufacturer, model, price);
                    computers.Add(computer);
                    return $"Computer with id {id} added successfully.";
                }
                else
                {
                    throw new ArgumentException("Computer with this id already exists.");
                }
            }
            if (computerType == "Laptop")
            {
                if (computers.FirstOrDefault(x => x.Id == id) == null)
                {
                    computer = new Laptop(id, manufacturer, model, price);
                    computers.Add(computer);
                    return $"Computer with id {id} added successfully.";
                }
                else
                {
                    throw new ArgumentException("Computer with this id already exists.");
                }
            }
            else
            {
                throw new ArgumentException("Computer type is invalid.");
            }
        }

        public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
        {

            Peripheral peripheral = null;
            if (peripheralType == "Headset")
            {
                if (peripherals.FirstOrDefault(x => x.Id == id) == null)
                {
                    peripheral = new Headset(id, manufacturer, model, price, overallPerformance, connectionType);
                    peripherals.Add(peripheral);
                    return $"Peripheral {peripheralType} with id {id} added successfully in computer with id {computerId}.";
                }
                
                else
                {
                    throw new ArgumentException("Peripheral  with this id already exists.");
                }
            }
            if (peripheralType == "Keyboard")
            {
                if (peripherals.FirstOrDefault(x => x.Id == id) == null)
                {
                    peripheral = new Keyboard(id, manufacturer, model, price, overallPerformance, connectionType);
                    peripherals.Add(peripheral);
                    return $"Peripheral {peripheralType} with id {id} added successfully in computer with id {computerId}.";
                }
                else
                {
                    throw new ArgumentException("Peripheral  with this id already exists.");
                }
            }
            if (peripheralType == "Monitor")
            {
                if (peripherals.FirstOrDefault(x => x.Id == id) == null)
                {
                    peripheral = new Monitor(id, manufacturer, model, price, overallPerformance, connectionType);
                    peripherals.Add(peripheral);
                    return $"Peripheral {peripheralType} with id {id} added successfully in computer with id {computerId}.";
                }
                else
                {
                    throw new ArgumentException("Peripheral  with this id already exists.");
                }
            }
            if (peripheralType == "Mouse")
            {
                if (peripherals.FirstOrDefault(x => x.Id == id) == null)
                {
                    peripheral = new Mouse(id, manufacturer, model, price, overallPerformance, connectionType);
                    peripherals.Add(peripheral);
                    return $"Peripheral {peripheralType} with id {id} added successfully in computer with id {computerId}.";
                }
                else
                {
                    throw new ArgumentException("Peripheral  with this id already exists.");
                }
            }
            else
            {
                throw new ArgumentException("Peripheral type is invalid.");
            }
        }

        public string BuyBest(decimal budget)
        {
            computers.OrderByDescending(x => x.OverallPerformance);
            var itemToSell = computers[0];
            if (itemToSell.Price <= budget)
            {
                return computers.ToString();
            }
            else
            {
                throw new ArgumentException($"Can't buy a computer with a budget of ${budget}.");
            }
        }

        public string BuyComputer(int id)
        {
            if (computers.FirstOrDefault(x => x.Id == id) != null);
            {
                computers.Remove(computers.FirstOrDefault(x => x.Id == id));
                return computers.ToString();
            }
        }

        public string GetComputerData(int id)
        {
            var curr = computers.FirstOrDefault(x => x.Id == id);
            return curr.ToString();

        }

        public string RemoveComponent(string componentType, int computerId)
        {
            foreach (var item in components)
            {
                if (item.GetType().ToString() == componentType)
                {
                    if (item.Id == computerId)
                    {
                        components.Remove(item);
                        return $"Successfully removed {componentType} with id {computerId}.";
                    }
                }
            }

            throw new ArgumentException();


        }
        public string RemovePeripheral(string peripheralType, int computerId)
        {
            foreach (var item in peripherals)
            {
                if (item.GetType().ToString() == peripheralType)
                {
                    if (item.Id == computerId)
                    {
                        peripherals.Remove(item);
                        return $"Successfully removed {peripheralType} with id {computerId}.";
                    }
                }
            }
            return null;
        }
    }

   

}
