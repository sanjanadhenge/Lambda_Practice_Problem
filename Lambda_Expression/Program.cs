using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Student> Data = new List<Student>();

            Data.Add(new Student() { Name="Sanjana",Address="4161",PhoneNumber="65141455",Age=22,TotalMarks=98});
            Data.Add(new Student() { Name = "Saambhav", Address = "45261", PhoneNumber = "651495215", Age = 23,TotalMarks=98 });
            Data.Add(new Student() { Name = "Sudha", Address = "5161", PhoneNumber = "65141555", Age = 12,TotalMarks=88});
            Data.Add(new Student() { Name = "Siya", Address = "5161", PhoneNumber = "65851455", Age = 18,TotalMarks=100 });
            Display(Data);
            RetriveData(Data);
            Sort(Data);
            DisplayByAdress(Data, "1461");
        } 
        public static void Display(List<Student> Data)
        {
            foreach (Student s in Data)
            {
                Console.WriteLine(s.Name + "\t"+s.Address+"\t"+s.PhoneNumber+"\t"+s.Age);
            }
        } 
        public static void RetriveData(List<Student> Data)
        {
            var result = Data.FindAll(x=>x.Age >=12 &&  x.Age <=18).ToList();
            Display(result);
        }
        public static void Sort(List<Student> Data)
        {
            var result = Data.OrderByDescending(x=>x.TotalMarks).ToList();  
            Display(result);
        }
        public static void DisplayByAdress(List<Student> Data ,string Address)
        {
            var result = Data.Where(x=>x.Address.Equals(Address)).ToList();
            Display(result);
        }
    }
}

