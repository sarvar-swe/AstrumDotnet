namespace Arrays;

public partial class Solution
{
    /// <summary>
    /// Given a two-dimensional array, find the maximum element.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns>Maximum element in arr.</returns>
    public int FindMaxElement(int[][] arr)
    {
        int max = int.MinValue;

        // for(int i = 0; i < arr.Length; i++)
        // {
        //     for(int j = 0; j < arr[i].Length; j++)
        //     {
        //         if(max < arr[i][j])
        //         {
        //             max = arr[i][j];
        //         }
        //     }
        // }

        for(int i = 0; i < arr.Length; i++)
        {
            max = Math.Max(max, arr[i].Max());
        }

        return max;
    }

    /// <summary>
    /// Given a matrix, calculate its transpose. The transpose of a matrix flips the matrix over its main diagonal, switching the row and column indices.
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public int[][] CalculateTranspose(int[][] matrix)
    {
        if(matrix.Length == 0)
        {
            return matrix;
        }

        int[][] transpose = new int[matrix[0].Length][];

        for(int i = 0; i < matrix[0].Length; i++)
        {
            transpose[i] = new int[matrix.Length];
        }

        for(int i = 0; i < matrix[0].Length; i++)
        {
            for(int j = 0; j < matrix.Length; j++)
            {
                transpose[i][j] = matrix[j][i];
            }
        }

        return transpose;
    }

    /// <summary>
    /// Given a jagged array, sort its elements in ascending order.
    /// </summary>
    /// <param name="arr"></param>
    public void SortJaggedArray(int[][] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            Array.Sort(arr[i]);
        }
    }

    /// <summary>
    /// Given a jagged array, calculate the sum of all elements.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int CalculateSumOfElements(int[][] arr)
    {
        int sum = 0;

        for(int i = 0; i < arr.Length; i++)
            sum += arr[i].Sum();
        
        return sum;
    }


    /// <summary>
    /// Given a jagged array, sort its rows in ascending order based on the sum of their elements.
    /// </summary>
    /// <param name="arr"></param>
    public void SortRowsBySum(int[][] arr)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given a multi-dimensional array, convert it into a jagged array.
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public int[][] ConvertToJaggedArray(int[,] array)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given a multi-dimensional array, reshape it into a new shape without changing its data.
    /// </summary>
    /// <param name="array"></param>
    /// <param name="rows"></param>
    /// <param name="columns"></param>
    /// <returns></returns>
    public int[,] ReshapeArray(int[,] array, int rows, int columns)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given an integer N, generate a spiral matrix of size N x N.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[,] GenerateSpiralMatrix(int n)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given a jagged array and a target element, search for the element and return its indices if found, otherwise return [-1, -1].
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="target"></param>
    /// <param name="rowIndex"></param>
    /// <param name="columnIndex"></param>
    public void SearchElement(int[][] arr, int target, out int rowIndex, out int columnIndex)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given a chain of matrices, calculate the minimum number of scalar multiplications required to multiply them.
    /// </summary>
    /// <param name="chain"></param>
    /// <returns></returns>
    public int CalculateMinScalarMultiplications(int[] chain)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given a one-dimensional array, find the maximum sum of a subarray.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int FindMaxSubarraySum(int[] arr)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Find the maximum value in a 2D array of integers, considering only the elements that form a square or rectangle. The square/rectangle can have any size and must be aligned with the rows and columns.
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public int FindMaxValueInRectangle(int[,] array)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given a jagged array of integers, sort the array in ascending order based on the sum of each row. If two rows have the same sum, maintain their relative order.
    /// </summary>
    /// <param name="arr"></param>
    /// /// <returns></returns>
    public void SortJaggedArrayByRowSum(int[][] arr)
    {
        throw new NotImplementedException();
    }


    /// <summary>
    /// Given a 2D array of integers, find the subarray with the maximum sum. The subarray should have a rectangular shape.
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public int[,] FindMaxSumSubarray(int[,] array)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given a square 2D array of integers, rotate it 90 degrees clockwise in place, without using additional space.
    /// </summary>
    /// <param name="array"></param>
    public void RotateSquareArrayClockwise(int[,] array)
    {
        throw new NotImplementedException();
    }


    /// <summary>
    /// Given a jagged array of integers, find the row with the highest sum of elements. If multiple rows have the same sum, return the index of the first occurrence.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int FindRowWithHighestSum(int[][] arr)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given a 2D array of characters, count the number of occurrences of a specific character in the array.
    /// </summary>
    /// <param name="array"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int CountOccurrencesIn2DArray(char[,] array, char target)
    {
        throw new NotImplementedException();
    }
}