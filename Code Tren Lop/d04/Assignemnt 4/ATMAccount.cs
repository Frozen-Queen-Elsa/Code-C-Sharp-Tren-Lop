using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class ATMAccount
    {
        private string AccNo;
        private int Balance;
        public ATMAccount()
        {
            Input();
        }

        //Property pAccNo cho AccNo
        public string pAccNo
        {
            get
            {
                return AccNo;
            }
            set
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(value.Trim(),"^ACC-\\d{4}$") )
                {
                    AccNo = value.Trim();
                }
                else
                {
                    Console.WriteLine("Ma so Tai Khoan khong hop le");
                }
            }
        }//Ket thuc property

        //Write-only property pDeposit(Nap tien vo tai khoan)
        public int pDeposit
        {
            set
            {
                if (value >= 100)
                {
                    Balance += value;
                }
                else
                {
                    Console.WriteLine("So tien nap phai >=100 !");
                }
            }
        }//Ket thuc property

        //Write-only property pWithdraw(Rut tien khoi tai khoan)
        public int pWithdraw
        {
            set
            {
                if (value >= 100 && value <Balance)
                {
                    Balance -= value;
                }
                else
                {
                    Console.WriteLine("So tien nap phai >=100 va < so du hien tai {0} !",Balance);
                }
            }
        }//Ket thuc property

        //Read-only property pBalance ( Xem so du tai khoan )
        public int pBalance
        {
            get
            {
                return Balance;
            }
        }//ket thuc property pBalance

        //Ham nhap du lieu cho 1 tai khoan
        public void Input()
        {
            Console.WriteLine("Nhap thong tin chi tiet ");
            while (true)
            {
                Console.WriteLine("Nhap ma TK [ACC-xxxx]: ");
                pAccNo = Console.ReadLine().Trim();
                if (AccNo !=null) { break; }
            }

            while (true)
            {
                Console.Write("Nhap so du ban dau >100: ");
                pDeposit = int.Parse(Console.ReadLine());
                if (Balance > 100) { break; }
            }
        }//Ket thuc input

        public override string ToString()
        {
            return string.Format("Ma TK : {0} ,  So du : {1}", AccNo, Balance);
        }

    }

    
}
