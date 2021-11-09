using System;

namespace Session07_00
{
    /*
     Lab04.1: Tạo ứng dụng C# với các yêu cầu sau.
-	Lớp Account lưu thông tin về tài khoản (Balance – số tiền trong tài khoản). 
        Tạo 1 phương thức constructor với tham số đầu vào là initialize  (số tiền ban đầu). 
-	Tạo 2 phương thức cho lớp Account.
    o	Deposit(money): là phương thức gửi tiền cho ghi đè, money là số tiền cần gửi, hãy kiểm tra các thông tin cho phù hợp và xuất thông báo.
    o	WithDraw(money): là phương thức rút tiền cho ghi đè, money là số tiền rút, hãy kiểm tra các thông tin cho phù hợp và xuất thông báo.
    o	GetBalance(): là phương thức trả về số tiền trong tài khoản.

-	Lớp SavingAccount (gửi tiết kiệm) kế thừa từ lớp Account có thêm thông số rate(tỉ lệ lãi suất), tạo phương thức constructor với 2 tham số đầu vào, initialize (số tiền ban đầu), rate, kế thừa constructor của lớp Account. Tạo phương thức GetInterest() (lấy tiền lãi).
-	Lớp CheckAccount (vấn tin, gửi tiền, rút tiền) kế thừa từ lớp Account và có thêm biến FeeTransfer (phí giao dịch). Tạo phương thức constructor với 2 tham số đầu vào Balance, FeeTransfer, sau đó ghi đè 2 phương thức Deposit và WithDraw, GetBalance, mỗi khi gọi phương thức thành công thì số tiền trong tài khoản sẽ bị trừ đi 1 khoản bằng FeeTransfer.
-	Lớp Program để kiểm thử ứng dụng

     */

    /// <summary>
    /// Tạo lớp Account (Base class)
    /// </summary>
    /// 
    class Account
    {
        // properties
        public double Balance { get; set; }

        // Constructor
        public Account() { }
        public Account(double Balance)
        {
            this.Balance = Balance;
        }

        // Deposit(money):
        public virtual void Deposit(double money)
        {
            if (money > 0)
                this.Balance += money;
            else
                Console.WriteLine("Money >0?");
        }

        //WithDraw
        public virtual void WithDraw(double money)
        {
            if(this.Balance >= money)
            {
                this.Balance -= money;
            }
            else
            {
                Console.WriteLine("Khong du tien trong tai khoan");
            }
        }
        // GetBalance
        public double GetBalance()
        {
            return Balance;
        }
    }

    /// <summary>
    /// Lớp SavingAccount (gửi tiết kiệm) kế thừa từ lớp Account có thêm thông số rate(tỉ lệ lãi suất), 
    /// tạo phương thức constructor với 2 tham số đầu vào, initialize (số tiền ban đầu), rate, 
    /// kế thừa constructor của lớp Account. 
    /// Tạo phương thức GetInterest() (lấy tiền lãi).
    /// </summary>
    /// 
    class SavingAccount:Account
    {
        // properties
        public float rate { get; set; }
        //Constructor
        public SavingAccount() : base() { }
        public SavingAccount(double initialize, float rate) : base(initialize)
        {
            this.rate = rate;
        }

        // GetInterest
        public void GetInterest()
        {
            double TienLai = 0;
            TienLai = Balance * rate;

            Console.WriteLine("So tien trong tai khoan:" + Balance);
            Console.WriteLine("Tien lai:" + TienLai);


        }
    }

    /// <summary>
    /// CheckAccount:
    /// Lớp CheckAccount (vấn tin, gửi tiền, rút tiền) kế thừa từ lớp Account và có thêm biến FeeTransfer (phí giao dịch). 
    /// Tạo phương thức constructor với 2 tham số đầu vào Balance, FeeTransfer, 
    /// sau đó ghi đè 2 phương thức Deposit và WithDraw, GetBalance,
    /// mỗi khi gọi phương thức thành công thì số tiền trong tài khoản sẽ bị trừ đi 1 khoản bằng FeeTransfer.
    /// </summary>
    /// 
    class CheckAccount : Account
    {
        // properties
        public double FeeTransger { get; set; }

        // Constructor
        public CheckAccount() : base() { }
        public CheckAccount(double Balance, double FeeTransfer):base(Balance)
        {
            this.FeeTransger = FeeTransger;
        }

        public override void Deposit(double money)
        {
            base.Deposit(money);
            base.Balance -= FeeTransger;
            Console.WriteLine("So tien trong tai khoan:" + Balance);
        }

        public override void WithDraw(double money)
        {
            base.WithDraw(money);
            base.Balance -= FeeTransger;
            Console.WriteLine("So tien trong tai khoan:" + Balance);
        }

        public new void  GetBalance()
        {
            Console.WriteLine("So tien con lai:" + Balance);
        }

    }

    // Kiểm thử

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test!");

            Account acc = new Account(10000);
            Console.WriteLine("So tien con lai:" + acc.GetBalance());
            acc.Deposit(10000);
            Console.WriteLine("So tien con lai:" + acc.GetBalance());
            acc.WithDraw(5000);
            Console.WriteLine("So tien con lai:" + acc.GetBalance());

            SavingAccount sacc = new SavingAccount(10000, 0.125f);
            
            sacc.GetInterest();


            CheckAccount ca = new CheckAccount(10000, 1000);
            ca.GetBalance();
            ca.Deposit(1000);
            ca.GetBalance();
            ca.WithDraw(2000);
            ca.GetBalance();

        }
    }
}
