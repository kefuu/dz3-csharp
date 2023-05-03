using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3_csharp
{
    public class Website
    {
        private string name;
        private string path;
        private string description;
        private string ipAddress;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetPath(string path)
        {
            this.path = path;
        }

        public string GetPath()
        {
            return path;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetIpAddress(string ipAddress)
        {
            this.ipAddress = ipAddress;
        }

        public string GetIpAddress()
        {
            return ipAddress;
        }

        public void InputData()
        {
            Console.Write("Введіть назву сайту: ");
            SetName(Console.ReadLine());

            Console.Write("Введіть шлях до сайту: ");
            SetPath(Console.ReadLine());

            Console.Write("Введіть опис сайту: ");
            SetDescription(Console.ReadLine());

            Console.Write("Введіть ip-адресу сайту: ");
            SetIpAddress(Console.ReadLine());
        }

        public void OutputData()
        {
            Console.WriteLine($"Назва сайту: {GetName()}");
            Console.WriteLine($"Шлях до сайту: {GetPath()}");
            Console.WriteLine($"Опис сайту: {GetDescription()}");
            Console.WriteLine($"IP-адреса сайту: {GetIpAddress()}");
        }
    }

}
