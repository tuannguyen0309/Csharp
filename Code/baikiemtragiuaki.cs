// using System;

// class baikiemtragiuaki
// {
//     static void Main(string[] args)
//     {
//         double[] arr = new double[100];
//         for (int i = 45; i < 55; i++)
//         {
//             Console.Write("Nhap arr[{0}]: ", i);
//             arr[i] = double.Parse(Console.ReadLine());
//         }
//         Console.WriteLine("cac phan tu chia het cho 3");
//         for (int i = 45; i < 55; i++)
//         {
//             if ((int)arr[i] % 3 == 0)
//             {
//                 Console.Write(arr[i] + " ");
//             }
//         }
//         Console.WriteLine("\n");
//         Console.WriteLine("Nhap x: ");
//         double x;
//         x = double.Parse(Console.ReadLine());
//         int count = 0;
//         for (int i = 45; i < 55; i++)
//         {
//             if (arr[i] == x)
//             {
//                  count++;
//             }
//         }
//         if (count != 0)
//             Console.Write("{0}  co trong mang", x);
//         else Console.Write("{0}  khong co trong mang", x);
//         Console.WriteLine("\n");
//         Console.WriteLine("Nhap y: ");
//         double y;
//         y = double.Parse(Console.ReadLine());
//         int dem = 0;

//         for (int i = 45; i < 55; i++)
//         {
//             if (arr[i] == y)
//             {
//                 dem++;
//             }
//         }
//         Console.Write("{0} xuat hien {1} lan  trong mang", y, dem);
//     }
// }
