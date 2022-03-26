// using System;

// namespace C#
// {
//     class baitapcoban
//     {
//         static void tinhtong(){
//             int n;
//             long S = 0, S1 = 0;
//             float S2 = 0;
//             long S3 = 1;

//             Console.WriteLine("Nhap vao so n:");
//             n = int.Parse(Console.ReadLine());


//             //Tính tổng S(n) = 1+2+3+4+ … +n
//             for (int i = 1; i <= n; i++)
//             {
//                 S += i;
//             }
//             Console.WriteLine("Tong S({0}) la: {1}", n, S);

//             //Tính tổng S(n) = 1^2 + 2^2 + … + n^2
//             for (int i = 1; i <= n; i++)
//             {
//                 S1 += i * i;
//             }
//             Console.WriteLine("Tong S1({0}) la: {1}", n, S1);

//             //Tính tổng S(n) = 1/2 + 1/4 + 1/6 + 1/8 + 1/2n
//             for (int i = 0; i <= n; i++)
//             {
//                 S2 += 1 / (float)(2 * i + 2);
//             }
//             Console.WriteLine("Tong S2({0}) la: {1}", n, S2);

//             //Tính giai thừa số nguyên dương
//             for (int i = 1; i <= n; i++)
//             {
//                 S3 *= i;
//             }
//             Console.WriteLine(" {0}! = {1}", n, S3);

//         }
//         //Tìm ước số chung và bội số chung nhỏ nhất của 2 số a,b
//         static void UCBC(){
//             int a, b;

//             Console.WriteLine("Nhap vao so a:");
//             a = int.Parse(Console.ReadLine());
//             Console.WriteLine("Nhap vao so b:");
//             b = int.Parse(Console.ReadLine());

//             int USCLN(int a, int b)
//             {
//                 if (b == 0) return a;
//                 return USCLN(b, a % b);
//             }
//             Console.WriteLine("USCLN = {0}", USCLN(a, b));

//             int BSCNN(int a, int b)
//             {
//                 return (a * b) / USCLN(a, b);
//             }
//             Console.WriteLine("BSCNN = {0}", BSCNN(a, b));
            
//         }

//         static void SNT(){
//             uint k;

//             Console.WriteLine("Nhap vao so k:");
//             k = uint.Parse(Console.ReadLine());

//             //Kiểm tra số N có phải là số nguyên tố không?
//             bool isPrimeNumber(uint x)
//             {
//                 if (x < 2)
//                     return false;
//                 for (int i = 2; i <= x / 2; i++)
//                     if (x % i == 0)
//                         return false;
//                 return true;
//             }
//             if (isPrimeNumber(k) == true)
//                 Console.WriteLine("{0} la so nguyen to!", k);
//             else
//                 Console.WriteLine("{0} khong la so nguyen to!", k);

//             //Liệt kê các số nguyên tố nhỏ hơn N
//             Console.WriteLine("Tat ca cac so nguyen to nho hon {0} la:", k);
//             if (k >= 2)
//             {
//                 Console.Write("{0}\t", 2);
//             }
//             for (uint i = 3; i < k; i += 2)
//             {
//                 if (isPrimeNumber(i) == true)
//                 {
//                     Console.Write("{0}\t", i);
//                 }
//             }

//         }
//         static void Main(string[] argc)
//         {
//             Console.WriteLine("Chuong trinh tinh tong");
//             tinhtong();
//             Console.WriteLine("--------------------------------");
//             Console.WriteLine("Chuong trinh tinh USCLN, BSCNN");
//             UCBC();
//             Console.WriteLine("--------------------------------");
//             Console.WriteLine("Chuong trinh kiem tra so ngto");
//             SNT();
    
//         }
//     }
// }


