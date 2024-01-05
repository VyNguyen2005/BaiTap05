using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap5
{
    class CD
    {
        private int maCD;
        private string tuaCD;
        private string caSy;
        private int soBaihat;
        private double giaThanh;

        public CD()
        {

        }
        public CD(int maCD, string tuaCD, string caSy, int soBaihat, double giaThanh)
        {
            this.maCD = maCD;
            this.caSy = caSy;
            this.soBaihat = soBaihat;
            this.giaThanh = giaThanh;
        }
        public int MaCD
        {
            set { maCD = value; }
            get { return maCD; }
        }
        public string TuaCD
        {
            set { tuaCD = value; }
            get { return tuaCD; }
        }
        public string CaSy
        {
            set { caSy = value; }
            get { return caSy; }
        }
        public int SoBaiHat
        {
            set { soBaihat = value; }
            get { return soBaihat; }
        }
        public double GiaThanh
        {
            set { giaThanh = value; }
            get { return giaThanh; }
        }
        public string toString()
        {
            return string.Format($"{maCD,-20} {tuaCD,-15} {caSy,-5} {soBaihat,5} {giaThanh,10:#,##0}");
        }

    }
}
