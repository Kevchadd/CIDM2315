class Program
{
    public static void Main(string[] args)
    {
       int [] int_array = {11,23,31,42,53};
       ArraySum(int_array);


       int [,] array_2d = {
        {1,2,3},
        {4,5,6},
        {7,8,9}
       };
    

    PrintAllOddNumber(array_2d);
    Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");
    int [ , ] Q2_3 = DoubleArray(array_2d);
    Console.WriteLine("The new 2d array: ");
    foreach (int num in Q2_3){
        Console.Write(num + " ");
    }
 
    
}

public static void ArraySum(int [] int_array){
int Sum =0;

    foreach (int x in int_array){
        Sum+=x;}
        Console.WriteLine($"The Sum of int_array is: {Sum}");
        }
public static void PrintAllOddNumber(int [ , ]array_2d){
    foreach(int val in array_2d){
        if(val%2==1){Console.Write(val+" ");}
        }}


public static int ElementSum(int[ , ] array_2d){
    int Sum1=0;
foreach (int x in array_2d){
        Sum1+=x;}
        return Sum1;
        }


 public static int[ , ] DoubleArray (int [ , ] array_2d){
    int [ , ] double_int_array = new int [3,3];
    for (int row = 0; row < 3; row++) {
            for (int col = 0; col < 3; col++) {
                double_int_array[row,col] = array_2d[row, col] * 2; 
    }
    }
    
        return double_int_array;
      
 }
 }


