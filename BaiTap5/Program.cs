using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap5
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanliCD quanli = new QuanliCD();
            int chon = 0;
            do
            {
                Console.WriteLine("********Quan li CD*********");
                Console.WriteLine("1. Them CD");
                Console.WriteLine("2. Tinh gia thanh trung binh");
                Console.WriteLine("3. Sap xep giam gia thanh");
                Console.WriteLine("4. Sap xep tang tua CD");
                Console.WriteLine("5. Xuat toan bo CD");
                Console.WriteLine("6. Thoat");

                Console.WriteLine("---------------------");
                Console.Write("Ban chon: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        CD cd = new CD();
                        Console.Write("Nhap ma CD:");
                        cd.MaCD = int.Parse(Console.ReadLine());
                        Console.Write("Nhap tua CD:");
                        cd.TuaCD = Console.ReadLine();
                        Console.Write("Nhap ca si:");
                        cd.CaSy = Console.ReadLine();
                        Console.Write("Nhap so bai hat: ");
                        cd.SoBaiHat = int.Parse(Console.ReadLine());
                        Console.Write("Nhap gia thanh:");
                        cd.GiaThanh = double.Parse(Console.ReadLine());
                        quanli.ThemCD(cd);
                        break;
                    case 2:
                        double kq = quanli.TinhTB();
                        Console.WriteLine("Gia thanh trung binh: {0:#,##0.00}", kq);
                        break;
                    case 3:
                        quanli.SapxepGiamGiaThanh();
                        Console.WriteLine("Da sap xep theo gia thanh giam dan");
                        break;
                    case 4:
                        quanli.SapxepTangtuaCD();
                        Console.WriteLine("Da sap xep tang dan theo tua CD");
                        break;
                    case 5:
                        quanli.Xuat();
                        break;
                }
            } while (chon != 0);
            Console.ReadLine();
        }
    }
}
