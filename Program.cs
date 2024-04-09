using System.ComponentModel.DataAnnotations.Schema;

class Program
{
public static void Main(string[] args)
{
    Console.WriteLine("Nhap cac phan tu cua mang");
    int[,] myArrays= new int[3,3];
    for (int row = 0; row < myArrays.GetLength(0); row++)
    {
        for (int colum = 0; colum < myArrays.GetLength(0); colum++)
        {
            myArrays[row,colum] = Convert.ToInt32(Console.ReadLine());
        }
    }
    for (int row = 0; row < myArrays.GetLength(0); row++)
    {
        Console.WriteLine("/n");
        for (int colum = 0; colum < myArrays.GetLength(1); colum++)
        {
       
            Console.Write(myArrays[row,colum] +",");
        }
    }
    //Qua trinh tinh gia tri lon nhat
    int maxValue = 0;
    int sum = 0;
    int sumline = 0;
    for (int row = 0; row < myArrays.GetLength(0); row++)
    {
        for(int colum = 0; colum < myArrays.GetLength(1); colum++)
        {
            sum += myArrays[row,colum];
            if(maxValue<myArrays[row,colum])
            {
                maxValue = myArrays[row,colum];
            }
            if(row==colum)
            {
                sumline = myArrays[row,colum];
            }
        }
    }
    Console.WriteLine($"gia tri lon nhat la {maxValue}");
    Console.WriteLine("gia tri tong la {sum}");
    Console.WriteLine($"gia tri tong cua duong cheo chinh la {maxValue}");
}
}

