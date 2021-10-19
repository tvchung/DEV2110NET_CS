using System;

namespace Session03_06
{
    /// <summary>
    /// Mảng 1 chiều
    /// 
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {

            // 1. Khai báo
            //  <datatype>[] varArr;
            int[] varNums; // Khai báo mảng số nguyên
            float[] varNumFloat = new float[100]; // khai báo và khởi tạo số phần tử trong mảng
            int[] x = new int[] { 10, 20, 30, 40 };
            int[] y = { 12, 23, 34, 45, 56 };

            // 2. truy xuất (gán/lấy giá trị)
            varNumFloat[0] = 123.45f;
            Console.WriteLine("{0} = {1}",0,varNumFloat[0]);

            // 3. Duyệt mảng
            Console.WriteLine("Danh sách cac phan tu trong mang");
            foreach (int item in x)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Danh sách cac phan tu trong mang");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            // 4. Thao tác cơ bản: tìm kiếm, sắp xếp, chèn, xóa, trích đoạn,...
            // tìm những phần tử trong mảng y mà chia hết cho 2
            foreach (int item in y)
            {
                if (item % 2 == 0)
                    Console.WriteLine(item);
            }
        }
    }
}
/*
Bài tập:
1.	Tính S = 13 +23 + 33 + ……+ N3 
2.	Tính S = 12 +22 + 32 + ……+ N2 
3.	Tính S = 1 + 1/2  + 1/3 + …. + 1/n 
4.	Tính S = 1/(1x2) + 1/(2x3) + 1/(3x4) + ….. + 1/(n x (n+1)) 
5.	Tính S = 1 + 1.2 + 1.2.3 + …. + 1.2.3….n 
6.	Tính S = 1 + x + x2 + ….. + xn 
7.	Tính S = 1! + 2! + 3! +….. + n! 
8.	Tìm số nguyên dương n nhỏ nhất sao cho 1 + 2 + 3 + …… + n > 1000 
9.	Tìm và in lên màn hình tất cả các số nguyên trong phạm vi từ 10 đến 99 sao cho tích của 2 chữ số bằng 2 lần tổng của 2 chữ số đó. 
10.	Tìm các ước số chung nhỏ nhất của 2 số nguyên dƣơng  
11.	Kiểm tra 1 số có phải là số nguyên tố hay không. 
12.	In ra tất cả các số nguyên tố nhỏ hơn số n đƣợc nhập vào từ bàn phím

=========================
viết một chương trình nhập vào thu nhập hàng tháng của người dùng và in ra tổng thuế thu nhập trong tháng và chi tiết số tiền phải đóng ở mỗi mức thuế
Biểu thuế thu nhập lũy tiến từng phần được áp dụng như sau:
Bậc Thuế	Phần thu nhập tính thuế/năm (triệu đồng)	Phần thu nhập tính thuế/tháng (triệu đồng)	Thuế suất (%)
1	Đến 60	            Đến 5	            5
2	Trên 60 đến 120	    Trên 5 đến 10	    10
3	Trên 120 đến 216	Trên 10 đến 18	    15
4	Trên 216 đến 384	Trên 18 đến 32	    20
5	Trên 384 đến 624	Trên 32 đến 52	    25
6	Trên 624 đến 960	Trên 52 đến 80	    30
7	Trên 960	        Trên 80	            35

Flow chương trình được thực hiện dưới dạng như sau:
Welcome to PIT calculation
Please enter your income in the month:
Personal Income Tax are as below: 
Level 1 tax rate	:		dong
Level 2 tax rate	:		dong
Level 3 tax rate	:		dong
Level 4 tax rate	:		dong
Level 5 tax rate	:		dong
Level 6 tax rate	:		dong
Level 7 tax rate 	:		dong
---------------
Total		:		dong

=====================================
DHL is a company which transport good. The company need to calculate free of transporting, the fee is calculated as the following:
-	The customer must be pay $50 for each good package.
-	The fee must be pay by distance:
o	 < 20km: free
o	From 20km to 30km: include $25 for each good package.
o	From 30km to 40km: include $30 for each good package.
o	From 40km to 50km: include $35 for each good package.
o	Greater than 50m: include $40 for each good package.
-	Time of transporting: If time of transporting in day (6h-18h): Include 10% of total fee.
Write application to input information of transporting and print report of fee that customer must be pay.
=========== TRANSPORT FEE ==========
Enter number of package: 10
Enter the distance to transport (km) : 30
Enter the time to transport (0h-24h): 22
The customer must pay: $880

Exercise 2 (6 mark)
TienPhong Bank is the bank of FPT. With number of customer continuous increase, the bank need to develop an application to supply the services : register bank account and process transactions. The main menu of application as the following:
1.	Open a Bank account
2.	Perform transactions for an account
3.	Exit the application
Command	Process	Description
1	Open an account	Register an account
2	Perform transactions on an account	Process transaction
3	Exit the application	Exit

Choose menu 1, enter name, age, address and starting balance of account. Preview information’s for confirmation.
Choose menu 2, show the following menu:
1.	Deposit money in his account
2.	Withdraw money from his account
3.	Display the number of transactions and the balance
4.	Exit from the application
=============================
        Welcome to Tien phong bank ATM System:
        1. Open a Bank account
        2. Perform transactions for an account
        3. Exit the application
        Choose service: 1

        Open an account
        Enter your name: nguyen duy hoang
        Enter your age: 21
        Enter your address: ha noi
        Enter your balance: 2000

        Welcome new account, your information:
        Name: nguyen duy hoang
        Age: 21
        Address: ha noi
        Balance: $2000

        Welcome to Tien phong bank ATM System:
        1. Open a Bank account
        2. Perform transactions for an account
        3. Exit the application
        Choose service: 2

        Please choose the service:
        1. Deposit money in his account
        2. Withdraw money from his account
        3. Display the number of transactions and losing balance
        4. Exit from the application
        Choose service: 1
        Enter amount to deposit: 100
        You have deposit:  100 $
        Your balance is: 2100 $

        Please choose the service:
        1. Deposit money in his account
        2. Withdraw money from his account
        3. Display the number of transactions and losing balance
        4. Exit from the application
        Choose service: 2
        Enter amount to deposit: 300
        You have withdrawn:  300 $
        Your balance is: 1800 $

        Please choose the service:
        1. Deposit money in his account
        2. Withdraw money from his account
        3. Display the number of transactions and losing balance
        4. Exit from the application
        Choose service: 3

        You have perform 2 transaction(s)
        Your balance is: 1800 $

        Please choose the service:
        1. Deposit money in his account
        2. Withdraw money from his account
        3. Display the number of transactions and losing balance
        4. Exit from the application
        Choose service: 
==============================================
Mảng 1 chiều
Viết chương trình lựa chọn thực hiện các chức năng sau
==============Menu==================
1. Nhập mảng số nguyên
2. In ra mảng số nguyên

3. In ra dãy tuyến tính tăng dài nhất trong mảng
    30 10 30 50 15 12 27 => 10 30 50

4. Sắp xếp mảng theo thứ tự tăng dần

5. Tìm các số chính phương và tính tổng

6. Thoát

*/