using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // multipleObject();
            //takingInput();
            //StudentManagementSystem();
            //challenge1();
            challenge2();
        }
        static void multipleObject()
        {
            //first object
            student s1 = new student();
            s1.name = "M Soban Akram";
            s1.rollNo = 173;
            s1.cgpa = 3.5F;
            Console.WriteLine("Name: {0} Roll no: {1} CGPA: {2}", s1.name, s1.rollNo, s1.cgpa);

            //second object
            student s2 = new student();
            s2.name = "M Bilal";
            s2.rollNo = 196;
            s2.cgpa = 3.6F;
            Console.WriteLine("Name: {0} Roll no: {1} CGPA: {2}", s2.name, s2.rollNo, s2.cgpa);
            Console.ReadKey();
        }
        static void takingInput()
        {
            student s3 = new student();
            Console.WriteLine("Enter your name:");
            s3.name=Console.ReadLine();
            Console.WriteLine("Enter your roll no:");
            s3.rollNo =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter your CGPA:");
            s3.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0} Roll no: {1} CGPA: {2}", s3.name, s3.rollNo, s3.cgpa);
            Console.ReadKey();

        }
        static void StudentManagementSystem()
        {
            Students[] s = new Students[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    s[count] = addStudent();
                    count = count + 1;

                }
                else if (option == '2')
                {
                    Console.WriteLine("fjak");
                  
                    viewsStudent(s, count);
                    Console.ReadKey();
                }
                else if (option == '3')
                {
                    topStudent(s, count);
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice");

                }
            }
            while (option != '4');
            
                Console.WriteLine("Press Enter to exit");
                Console.Read();
            
            
        }
        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("1. Add a student:");
            Console.WriteLine("2. View a student:");
            Console.WriteLine("3. Top Three student:");
            Console.WriteLine("4. To exit:");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static Students addStudent()
        {
            Console.Clear();
            Students s1 = new Students();
            Console.WriteLine("Enter Name:");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter Roll No:");
            s1.rollNo =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter CGPA:");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter department:");
            s1.department = Console.ReadLine();
            Console.WriteLine("Are you hostelide(y || n):");
            s1.isHostelide =char.Parse( Console.ReadLine());
            return s1;
            
        }
        static void viewsStudent(Students[] s,int count)
        {
            Console.Clear();
            for (int i=0;i<count;i++)
            {
                Console.WriteLine("Name: {0}", s[i].name);
                Console.WriteLine("Roll No: {0}", s[i].rollNo);
                Console.WriteLine("CGPA: {0}", s[i].cgpa);
                Console.WriteLine("Department: {0}", s[i].department);
                Console.WriteLine("Hostelide: {0}", s[i].isHostelide);
            }
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();
        }
        static void topStudent(Students[] s,int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("NO record present");

            }
            else if (count == 1)
            {
                viewsStudent(s, 1);
            }
            else if (count == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    int index = largest(s, i, count);
                    Students temp = s[index];
                    s[index] = s[i];
                    s[i] = temp;
                }
                viewsStudent(s, 2);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    int index = largest(s, i, count);
                    Students temp = s[index];
                    s[index] = s[i];
                    s[i] = temp;
                }
                viewsStudent(s, 3);
            }

        }
        static int largest(Students[] s,int start ,int end)
        {
            int index = start;
            float large = s[start].cgpa;
            for (int i=start;i<end;i++)
            {
                if(large<s[i].cgpa)
                {
                    large = s[i].cgpa;
                    index = i;
                }
            }
            return index;
        }
        static void challenge1()
        {
            products[] p = new products[100];
            int count = 0;
            char option;
            do
            {
                option = productMenu();
                if (option == '1')
                {
                    p[count] = addProducts();
                    count = count + 1;
                }
                else if (option == '2')
                {
                    showProducts(p, count);
                }
                else if(option=='3')
                {
                    Console.Clear();
                    float price = totalWorth(p, count);
                    Console.WriteLine("Total Store Worth is: {0}", price);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid Choice!");
                    Console.ReadKey();
                }
            }
            while (option != '4');
            Console.WriteLine("Press Enter to exit");
            Console.Read();
        }
        static char productMenu()
        {
            Console.Clear();
            char option;
            Console.WriteLine("1. Add products:");
            Console.WriteLine("2. Show products:");
            Console.WriteLine("3. Total Store Worth:");
            Console.WriteLine("4. Exit");
                option = char.Parse(Console.ReadLine());
            return option;
        }
        static products addProducts()
        {
            Console.Clear();
            products p1 = new products();
            Console.WriteLine("Enter the product ID:");
            p1.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of the product:");
            p1.name = Console.ReadLine();
            Console.WriteLine("Enter the price of the product:");
            p1.price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the category of the product:");
            p1.category = Console.ReadLine();
            Console.WriteLine("Enter the Brand Name:");
            p1.brandName = Console.ReadLine();
            Console.WriteLine("Enter the name of the country:");
            p1.country = Console.ReadLine();
            return p1;
        }
        static void showProducts(products[] p,int count)
        {
            Console.Clear();
            for (int i=0;i<count;i++)
            {
                Console.WriteLine("Product ID: {0}", p[i].id);
                Console.WriteLine("Product Name: {0}", p[i].name);
                Console.WriteLine("Product Price: {0}", p[i].price);
                Console.WriteLine("Product Category: {0}", p[i].category);
                Console.WriteLine("Brand Name: {0}", p[i].brandName);
                Console.WriteLine("Country Name: {0}", p[i].country);
            }
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();
        }
        static float totalWorth(products[] p,int count)
        {
            float totalPrice=0.0F;
            for (int i=0;i<count;i++)
            {
                totalPrice = totalPrice + p[i].price;
            }
            return totalPrice;
        }
        static void challenge2()
        {
            char option;
            userDetail[] s = new userDetail[100];
            int count = 0;
                readFromFile(ref s,ref count);
            
            
            do
            {
                option = applicationMenu();
                if (option == '1')
                {
                    signIn(s, count);
                }
                else if(option=='2')
                {
                    s[count]=signUp();
                    count++;
                    storeInFile(s, count);
                    Console.WriteLine("Signed-Up successfully");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    
                }
                else if (option!='3')
                {
                    Console.WriteLine("Invalid Choice!");
                    Console.ReadKey();
                }    
            }
            while (option != '3');
            Console.WriteLine("Press Enter to exit");
            Console.Read();

        }
        static char applicationMenu()
        {
            Console.Clear();
            char option;
            Console.WriteLine("1. Sign-In");
            Console.WriteLine("2. Sign-Up");
            Console.WriteLine("3. Exit");
            option = char.Parse(Console.ReadLine());
            return option;
        }
        static userDetail signUp()
        {
            Console.Clear();
            userDetail s = new userDetail();
            Console.WriteLine("Enter your name:");
            s.name = Console.ReadLine();
            Console.WriteLine("Enter password:");
            s.password = Console.ReadLine();
            return s;
        }
        static void signIn(userDetail[] s,int count)
        {
            Console.Clear();
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            bool checker = signInChecker(s, name, password, count);
            if (checker==true)
            {
                Console.WriteLine("Sign In successfully");
            }
            else
            {
                Console.WriteLine("Invalid credentials");
            }
            Console.WriteLine("Press Enter Key to continue");
            Console.ReadKey();
            
        }
        static bool signInChecker(userDetail[] s, string name1, string password1, int count)
        {
            bool flag = false ;
            for (int i=0;i<count;i++)
            {
                if (s[i].name==name1 && s[i].password==password1)
                {
                    flag = true;
                }
            }
            return flag;
        }
        static void storeInFile(userDetail[] s,int count)
        {
            string path = "D:\\OOP\\lab2\\userDetail.txt";
            StreamWriter fileVariable = new StreamWriter(path,false);
            for (int i=0;i<count;i++)
            {
                fileVariable.WriteLine("{0},{1}", s[i].name, s[i].password);                   
            }
            fileVariable.Flush();
            fileVariable.Close();
        }
        static void readFromFile(ref userDetail[] s,ref int count)
        {
            
            string path= "D:\\OOP\\lab2\\userDetail.txt";
            StreamReader fileVariable = new StreamReader(path);
            string record;   
            while((record=fileVariable.ReadLine())!=null)
                {
                s[count] = new userDetail();
                    s[count].name = parseData(record, 1);
                    s[count].password = parseData(record, 2);
                count++;
            }
            fileVariable.Close();
            
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }

       

    }
}
