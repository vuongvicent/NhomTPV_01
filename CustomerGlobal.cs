using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaiTapSo3
{
    class CustomerGlobal : Person
    {
        //Tao thuoc tinh

        public string Nationality;
        public int Power;
        public float Bill;


        //Tao constructor khong tham so
        public CustomerGlobal() { }

        //Tao constructor co tham so
        public CustomerGlobal(string id, string fullName, DateTime day, string national, int power, float bill) : base(id, fullName, day)
        {
            Nationality = national;
            Power = power;
            Bill = bill;

        }

        public override double Money()
        {
            return this.Power * this.Bill;
        }
        public override void Input()
        {
            base.Input();//goi thuoc tinh cua lop Person
            //nhap them thuoc tinh xu ly cho lop 
            Console.WriteLine("Nationality :=");
            this.Nationality = Console.ReadLine();
            Console.WriteLine("Power (KW/H) :=");
            this.Power = int.Parse(Console.ReadLine());
            Console.WriteLine("Bill (VND) :=");
            this.Bill = float.Parse(Console.ReadLine());
            
        }

        //ham xuat mot
        public override void OutPut()
        {
            base.OutPut();//goi ham xuat cua lop Person
            Console.WriteLine("\nNationality: {3}\n Power: {4}\n Bill: {5}\n",
                  this.Nationality, this.Power, this.Bill);
            Console.WriteLine("Thanh tien: {0}", Money());
        }
    }
}
