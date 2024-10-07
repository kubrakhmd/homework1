#region murekkeb ededler
//int[] arr = { 3, 5, 12, 18 };
//for (int i = 0; i < arr.Length; i++)
//{
//   for (int j = 2; j < arr[i];j++)
//{
//   if (arr[i] % j == 0)
//        {
// Console.WriteLine(arr[i]);
// break;
//        }   
//}
//} 
#endregion
#region beraber olan elementlerin tapilmasi
//int[] nums = { 5, 10, 15, 30 };
//int[] arr = { 5, 6, 10, 12 };
//for (int i = 0; i < nums.Length; i++)
//{
//    for (int j = 0; j < arr.Length; j++)
//    {
//    if (nums[i] == arr[j])
//        {
//Console.WriteLine(nums[i]);
//        }
//    }
//} 
#endregion
//using System.Security.Cryptography;

//int[] arr = { 7, 9, 10, 15, 20 };
//int max = arr [0];
//int min = arr [0];
//int maxIndex=0;
//int minIndex=0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > max)
//    {
//        max = arr[i];
//        arr[i] = max;
//        maxIndex=i;
//    }
//    for (int j = 0; j < arr.Length; j++)
//    {
//        if (arr[j] < min)
//        {
//            min = arr[j];
//           minIndex=j;
//        }
//    }
//}
//Console.WriteLine("en boyuk indexli eded" + maxIndex );
#region ededin reqenmleri cemi
//byte num= 167;
//int vuruq= 1;
//int cem = 0;
//bool exit= false;
//while (!exit)
//{
//    int mod = num % (vuruq * 10);
//    int qaliq = mod /vuruq;
//    cem+= qaliq;
//    vuruq *= 10;
//    exit = (mod == num);
//}
//Console.WriteLine(cem);

#endregion

using System.Runtime.InteropServices;

///Console.WriteLine("en kicik indexli eded:" + minIndex);

Console.WriteLine("eksik olan eded");
int[] arr = { 2, 1, 3, 5, 4, 8, 7, 9, 6 };
int sum1 = 55;
int sum2 = 0;
for (int i = 0; i < arr.Length; i++)
{
    sum2+= arr[i];
}
int missingNum=sum1-sum2;
Console.WriteLine( missingNum );




























