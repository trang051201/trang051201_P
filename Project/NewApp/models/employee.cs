using System.Runtime.Intrinsics.Arm;
using NewApp.Models;

namespace NewApp.Models
{
    public class Employee
    {
        public int EmployeeID {get; set;}
        public string FullName {get; set; }
        public string Address {get; set; }
       

     
       
// Quach Kieu Trang - 2021050564
    
       public void EnterData()
        {
           
          
           
            System.Console.Write("FullName = "); 
            FullName = Console.ReadLine();
            System.Console.Write("Address = ");
            Address = Console.ReadLine();
            System.Console.Write("EmpoyeeID =");
         

            try{
                EmployeeID = Convert.ToInt32(Console.ReadLine());
          
                
            }catch(Exception e)
            {
                EmployeeID = 0;
       
            }


        }

        public void Display()
        {
           
           System.Console.WriteLine("Ma nhan vien: {0} - Ten nhan vien {1} - Dia Chi {2}", EmployeeID,FullName,Address); 
        }
}
}