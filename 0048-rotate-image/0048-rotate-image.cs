public class Solution {
    public void Rotate(int[][] matrix) {
      Array.Reverse(matrix);
    for(int i=0;i<matrix.Length;i++)
    {for(int j=i+1;j<matrix[0].Length;j++)
    {
        var temp=matrix[j][i];
        matrix[j][i]=matrix[i][j];
            matrix[i][j]=temp;
    }
     
     
     
     }
    }
}