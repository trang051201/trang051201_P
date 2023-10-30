﻿using System.Collections;
using NewApp.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList studentList = new ArrayList();
        int n;
        do
        {
            try
            {
                System.Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                n = 0;
            }
        } while (n < 1);

        // Them n phan tu vao list

        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine($"[{i}]");
            Student std = new Student();
            std.EnterData();
            studentList.Add(std);
        }

        // Cach 2:Hien thi danh sach
        foreach(Student std in studentList)
        {
            std.Display();
        }
        // Sua thong tin trong phan tu cua list

        string fullname = null;
        System.Console.WriteLine($"Nhap ten hoc sinh can thay doi: {fullname}");
        fullname = Console.ReadLine()
        for(int i = 0; i < studentList.Count; i++)
        {   
            Student std = (Student) studentList[i];

            if ( std.FullName == fullname){

                std.EnterData();
                break;

            }else
            {
                System.Console.WriteLine("Khong co hoc sinh nay!");
                break;
            }
        }

        foreach(Student std in studentList)
        {
            std.Display();
        }

        // Xoa 1 phan tu trong list

        System.Console.WriteLine("Nhap ten hoc sinh can xoa: ");
        fullname = Console.ReadLine();
        
        for(int i=0; i < studentList.Count; i++ )
        {
            Student std = (Student) studentList[i];
            if(std.FullName == fullname)
            {
                studentList.RemoveAt(i);
                System.Console.WriteLine($"da xoa hoc sinh co ten la: {fullname}");
                break;
            }
        }
        // hien thi danh sach list

         foreach(Student std in studentList)
        {
            // goi toi phuong thuc hien thi
            std.Display();
        }

    }
}//Quách Kiều Trang - 2021050654