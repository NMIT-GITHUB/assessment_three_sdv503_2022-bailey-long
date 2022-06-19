int[] newArray = { 0,0,0 };
void arrSort(int[][] arr)
{
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int largest = arr[i][0];
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                if (arr[i][j] > largest)
                {
                    largest = arr[i][j];
                    newArray[i] = largest;
                }
            }
        }
    Console.WriteLine(String.Join(",", newArray.Cast<int>()));
}
int[][] array = new int[2][];
array[0] = new int[] { 4, 2, 7, 1 };
array[1] = new int[] { 20, 70, 40, 90 };
array[2] = new int[] { 1, 2, 0 };
arrSort(array);
