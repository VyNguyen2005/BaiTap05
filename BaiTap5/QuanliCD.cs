using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap5
{
    class QuanliCD
    {
        private CD[] ds;
        private int n;
        public QuanliCD()
        {
            ds = new CD[100];
            n = 0;
        }
        public QuanliCD(int sophantu)
        {
            ds = new CD[sophantu];
            n = 0;
        }
        private bool KiemtratrungCD(int macd)
        {
            for(int i = 0; i<n; i++)
            {
                if(ds[i].MaCD == macd)
                {
                    return true;
                }
            }
            return false;
        }
        public void ThemCD(CD cd)
        {
            if (n >= ds.Length)
                Console.WriteLine("Danh sach da day");
            else
            {
                if (!KiemtratrungCD(cd.MaCD))
                    ds[n++] = cd;
                else
                    Console.WriteLine("Trung CD");
            }
        }
        public double TinhTB()
        {
            double S = 0;
            double avg;
            for(int i = 0; i<n; i++)
            {
                S = S + ds[i].GiaThanh;
            }
            avg = S / n;
            return avg;
        }
        public void Xuat()
        {
            Console.WriteLine($"{"MaCD",-20} {"Tua CD",-15} {"Ca Si",-5} {"So bai hat:",5} {"Gia thanh",10}");
            for(int i =0; i<n; i++)
            {
                Console.WriteLine(ds[i].toString());
            }
        }
        public void SapxepGiamGiaThanh()
        {
            CD sxgiam;
            for(int i =0; i<n-1; i++)
            {
                for(int j = i+1; j<n; j++)
                {
                    if(ds[i].GiaThanh < ds[j].GiaThanh)
                    {
                        sxgiam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = sxgiam;
                    }
                }
            }
        }
        public void SapxepTangtuaCD()
        {
            CD sxtang;
            for(int i = 0; i<n-1; i++)
            {
                for(int j = i+ 1; j<n; j++)
                {
                    if(ds[i].TuaCD.CompareTo(ds[j].TuaCD)>0)
                    {
                        sxtang = ds[i];
                        ds[i] = ds[j];
                        ds[j] = sxtang;
                    }
                }
            }
        }

    }
}
