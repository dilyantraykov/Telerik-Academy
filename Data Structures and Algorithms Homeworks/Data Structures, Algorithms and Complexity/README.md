## Data Structures, Algorithms and Complexity
### _Homework_

__Task 1.__ What is the expected running time of the following C# code? Explain why.
  - Assume the array's size is `n`.

~~~c#
long Compute(int[] arr)
{
    long count = 0;
    for (int i=0; i < arr.Length; i++)	// This would take n operations to run
    {
        int start = 0;
        int end = arr.Length-1;
        
        while (start < end) // This will perform n-1 operations
        {
            if (arr[start] < arr[end])
            { 
                start++;
                count++;
            }
            else
            {
                end--;
            }
        }
    }
    
    return count;
}
~~~

#### Answer
The complexity of the code is O(n<sup>2</sup>).

- - - -

__Task 2.__ What is the expected running time of the following C# code?
  - Explain why.
  - Assume the input matrix has size of n * m.

~~~c#
long CalcCount(int[,] matrix)
{
    long count = 0;
    for (int row=0; row<matrix.GetLength(0); row++) // This operation will be performed n times
    {
        if (matrix[row, 0] % 2 == 0)
        {
            for (int col=0; col<matrix.GetLength(1); col++) // This operation will be performed m times
            {
                if (matrix[row,col] > 0) // In the worst case scenario
                {
                    count++;
                }
            }
        }
    }
    
    return count;
}
~~~

#### Answer
The complexity of the code is O(n*m).

- - - -

__Task 3.*__ What is the expected running time of the following C# code?
  - Explain why.
  - Assume the input matrix has size of n * m.

~~~c#
long CalcSum(int[,] matrix, int row)
{
    long sum = 0;
    
    for (int col = 0; col < matrix.GetLength(0); col++) // This operation will be performed n times
    {
        sum += matrix[row, col];
    }
    
    if (row + 1 < matrix.GetLength(1)) // This operation will be performed m times
    {
        sum += CalcSum(matrix, row + 1); // In the worst case scenario
    }
    
    return sum;
}

Console.WriteLine(CalcSum(matrix, 0));
~~~

#### Answer to task 3
The complexity of the code is O(n*m).  
_Note: The code assumes that `n = m` and `row <= m-1` otherwise it throws an exception._