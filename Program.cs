using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo3
{
    class Program
    {
        int sum;
        public static List<Person> personList = new List<Person>();
        public static List<CustomerGlobal> customerListGB = new List<CustomerGlobal>();
        public static List<CustomerVietNam> customerListVN = new List<CustomerVietNam>();
        static void Main(string[] args)
        {

            //lay so luong sinh vien do nguoi dung nhap
            //ctrl + k + c: comment
            //ctrl + k + u: uncomment
            //ctrl + k + d: lam dep code, format code
            
            int numOfCustomer;
            do
            {
                Console.Write("Enter Number of Customer: ");
            } while (!int.TryParse(Console.ReadLine(), out numOfCustomer));

            Console.WriteLine("Nhap Danh sach khach hang: ");
            InputCustomerList(numOfCustomer);
            Console.WriteLine("Xuat Danh sach khach hang: ");
            OutputCustomerList(personList);
            //Xuat danh sach khach hang thang 9/2019
            Console.WriteLine("Danh sach khach hang thang 9/2019: ");
            OutputCustomerMontList();
            //Xuat danh sach khach hang VN su dung vuot dinh muc
            Console.WriteLine("Danh sach khach hang Viet Nam su dung vuot dinh muc: {0}");
            OutputCustomerVNList();
            ////nhap ID khach hang can xuat
            ///Tra ve ID va xuat hoa don thanh tien cua khach hang 
            Console.WriteLine("TONG SO TIEN CUA KHACH HANG VUA NHAP");
            SearchIDShowID();
            //Tam ngung man hinh de xem ket qua
            Console.ReadKey();
        }
        //Ham nhap danh sach khach hang tuong ung
        private static void InputCustomerList(int numOfCustomer)
        {
            //tao mang danh sach sinh viEN
            for (int i = 0; i < numOfCustomer; i++)
            {
                int choose;
                do
                {
                    Console.WriteLine("Chon nhap CustomerVN {1}: ; Chon nhap CustomerGB {2}:");
                    choose = int.Parse(Console.ReadLine());
                } while (choose != 1 && choose != 2);

                //xuat danh sach khach hang VN neu chon chuc nang 1
                if (choose == 1)
                {
                    CustomerVietNam VN = new CustomerVietNam();
                    VN.Input();
                    personList.Add(VN);
                    
                    Console.WriteLine();
                }
                else if (choose == 2)
                {
                    CustomerGlobal GB = new CustomerGlobal();
                    GB.Input();
                    personList.Add(GB);
                    Console.WriteLine();
                }
            }
        }

    //Ham xuat danh sach khach hang tuong ung
        public static void OutputCustomerList(List<Person> personList)
        {
            foreach (Person person in personList)
            {
                if (person is CustomerVietNam)
                {
                    Console.WriteLine("Danh sach cua khach hang VN:");
                    ((CustomerVietNam)person).OutPut();
                    Console.WriteLine();
                }

                if (person is CustomerGlobal)
                {
                    Console.WriteLine("Danh sach cua khach hang Quoc te:");
                    ((CustomerGlobal)person).OutPut();
                    Console.WriteLine();
                }
            }
        }
    //Ham Xuat DS khach hang theo thang 09/2019
        private static void OutputCustomerMontList()
        {
            List<Person> Show = personList.Where(p => p.Day.Month == 09 && p.Day.Year == 2019).ToList();
            if (Show.Count() > 0)
            {
                OutputCustomerList(Show);
            }
            else
            {
                Console.WriteLine("Khong tim thay thong tin!");
            }
        }
    //ham tim kiem khach hang va xuat hoa don khach hang da tim kiem
    //danh sach khach hang viet nam
    //xuat ra khach hang su dung vuot dinh muc nho ham if
    //bien nationality dung de truy xuat quoc tich khach hang vn
        private static void OutputCustomerVNList()
        {
        }

    //Ham nhap 1 ID va tra ve gia tri tuong ung
        private static void SearchIDShowID()
        {
            string IDshow;
            Console.WriteLine("Nhap ID ban muon tim:");
            IDshow = Console.ReadLine();
            List<Person> OutputIDShow = personList.Where(p => p.ID == IDshow).ToList();
            if (OutputIDShow.Count() > 0)
            {
                OutputCustomerList(OutputIDShow);
            }
            else
            {
                Console.WriteLine("Khong tim thay ID tuong ung!");
            }
        }
    }
}





