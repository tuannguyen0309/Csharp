// using System;

// namespace tuan2
// {
//     internal class NewBaseType
//     {
//         static void Main2(string[] args)
//         {
//             //Giai PT BAC NHAT ax + b = 0
//             Console.Write("Nhap vao so a:");
//             float a = float.Parse(Console.ReadLine());
//             Console.Write("Nhap vao so b:");
//             float b = float.Parse(Console.ReadLine());

//             if (a != 0)
//             {
//                 Console.WriteLine("Phuong trinh co nghiem x=-b/a= " + (-b / a));
//             }
//             if (a == 0)
//             {
//                 if (b == 0)
//                 {
//                     Console.WriteLine("Phuong trinh co vo so nghiem !");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Phuong trinh vo nghiem !");
//                 }
//             }
//             Console.ReadKey();
//         }
//     }

//     class Bai2 : NewBaseType
//     {
//     }
// }