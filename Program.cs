using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Store
    {
        private string storeName;
        private string address;
        private string profileDescription;
        private string contactPhone;
        private string contactEmail;

        public Store(string name, string addr, string description, string phone, string email)
        {
            storeName = name;
            address = addr;
            profileDescription = description;
            contactPhone = phone;
            contactEmail = email;
        }

        public string StoreName
        {
            get { return storeName; }
            set { storeName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string ProfileDescription
        {
            get { return profileDescription; }
            set { profileDescription = value; }
        }

        public string ContactPhone
        {
            get { return contactPhone; }
            set { contactPhone = value; }
        }

        public string ContactEmail
        {
            get { return contactEmail; }
            set { contactEmail = value; }
        }

        public void DisplayStoreInfo()
        {
            Console.WriteLine("Название магазина: " + StoreName);
            Console.WriteLine("Адрес: " + Address);
            Console.WriteLine("Описание профиля магазина: " + ProfileDescription);
            Console.WriteLine("Контактный телефон: " + ContactPhone);
            Console.WriteLine("Контактный e-mail: " + ContactEmail);
        }
    }
    class Website
    {
        private string siteName;
        private string sitePath;
        private string siteDescription;
        private string ipAddress;

        public Website(string name, string path, string description, string address)
        {
            siteName = name;
            sitePath = path;
            siteDescription = description;
            ipAddress = address;
        }
        public string SiteName
        {
            get { return siteName; }
            set { siteName = value; }
        }

        public string SitePath
        {
            get { return sitePath; }
            set { sitePath = value; }
        }

        public string SiteDescription
        {
            get { return siteDescription; }
            set { siteDescription = value; }
        }

        public string IPAddress
        {
            get { return ipAddress; }
            set { ipAddress = value; }
        }
    }
    class Journal
    {
        private string journalName;
        private int foundationYear;
        private string description;
        private string contactPhone;
        private string contactEmail;

        public string JournalName
        {
            get { return journalName; }
            set { journalName = value; }
        }

        public int FoundationYear
        {
            get { return foundationYear; }
            set { foundationYear = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string ContactPhone
        {
            get { return contactPhone; }
            set { contactPhone = value; }
        }

        public string ContactEmail
        {
            get { return contactEmail; }
            set { contactEmail = value; }
        }

        public Journal(string name, int year, string desc, string phone, string email)
        {
            JournalName = name;
            FoundationYear = year;
            Description = desc;
            ContactPhone = phone;
            ContactEmail = email;
        }
        public void DisplayJournalInfo()
        {
            Console.WriteLine("Название журнала: " + JournalName);
            Console.WriteLine("Год основания: " + FoundationYear);
            Console.WriteLine("Описание журнала: " + Description);
            Console.WriteLine("Контактный телефон: " + ContactPhone);
            Console.WriteLine("Контактный e-mail: " + ContactEmail);
        }
    }

    internal class Program
    {

        static void Q1()
        {
            int size;
            char symbol;
            Console.WriteLine("Введите длинну квадрата");
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Неверный формат. Введите целое число:");
            }
            Console.WriteLine("Введите символ заполнения");
            while (!char.TryParse(Console.ReadLine(), out symbol))
            {
                Console.WriteLine("Неверный формат. Введите символ:");
            }
            for(int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(' '+symbol);
                }
                Console.Write('\n');
            }
        }

        static void Q2()
        {
            int pal;

            Console.WriteLine("Введите число на проверку палиндрома:");
            while (!int.TryParse(Console.ReadLine(), out pal))
            {
                Console.WriteLine("Неверный формат. Введите число:");
            }
            string x=pal.ToString();


            for (int i=0,j= x.Length-1; i < x.Length-1; i++, j--)
            {
                if (x[i] != x[j])
                {
                    Console.WriteLine("Число не палиндром");
                    return;
                    //return false
                }

            }
            Console.WriteLine("Число палиндром");
            //return true
        }

        static int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            int[] result = new int[originalArray.Length];
            int resultIndex = 0;

            for (int i = 0; i < originalArray.Length; i++)
            {
                bool foundInFilter = false;
                for (int j = 0; j < filterArray.Length; j++)
                {
                    if (originalArray[i] == filterArray[j])
                    {
                        foundInFilter = true;
                        break;
                    }
                }

                if (!foundInFilter)
                {
                    result[resultIndex] = originalArray[i];
                    resultIndex++;
                }
            }


            int[] filteredResult = new int[resultIndex];
            Array.Copy(result, filteredResult, resultIndex);

            return filteredResult;

            //int[] result = originalArray.Where(item => !filterArray.Contains(item)).ToArray();
            //return result;
        }
        static void Q3()
        {
            int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filterArray = { 6, 88, 7 };

            int[] filteredResult = FilterArray(originalArray, filterArray);

            Console.WriteLine("Результат фильтрации:");
            foreach (int item in filteredResult)
            {
                Console.Write(item + " ");
            }

        }


        static void Main(string[] args)
        {

            //Q1();
            //Q2();
           //Q3();

        }
    }
}
