namespace MyLibs;
public class MyMetods
{
   public static void GetRandomArrayDouble(double[,] array)
   {
      for (int i = 0; i < array.GetLength(0); i++)
      {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            array[i, j] = new Random().NextDouble() * 20 - 10;
         }
      }
   }

   public static void PrintArrayDouble(double[,] array)
   {
      for (int i = 0; i < array.GetLength(0); i++)
      {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            Console.Write($"{array[i, j]:f1} ");
         }
         Console.WriteLine();
      }
   }

   public static void GetRandomArrayInt(int[,] array)
   {
      for (int i = 0; i < array.GetLength(0); i++)
      {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            array[i, j] = new Random().Next(-10, 10);
         }
      }
   }

   public static void PrintArrayInt(int[,] array)
   {
      for (int i = 0; i < array.GetLength(0); i++)
      {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            Console.Write($"{array[i, j]} ");
         }
         Console.WriteLine();
      }
   }
}
