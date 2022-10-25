public class Solution {
    public int NumIslands(char[][] grid) {
       
    int rows=grid.Length;
    int columns=grid[0].Length;
    var islands=0;
        
    for(int i=0;i<rows;i++)
    {
        for(int j=0;j<columns;j++)
        {
            if(grid[i][j]=='1' )
            {
                
                bfs(i,j,grid,rows,columns);
                islands+=1;
            }
        }
    }
        return islands;
    }
    public void bfs(int i,int j,char[][] grid,int rows,int columns)
    {
        
       
        var queue=new Queue<int[]>();
        queue.Enqueue(new int[2]{i,j});
        while(queue.Count>0)
        {
            var curr=queue.Dequeue();
            var directions=new int[4][]{
                new int[2]{1,0},
                new int[2]{-1,0},
                new int[2]{0,1},
                new int[2]{0,-1}};
            foreach(var item in directions)
            {
                var currrow=item[0]+curr[0];
                var currcolumn=item[1]+curr[1];
                if(currrow<rows && currrow>=0 && currcolumn<columns && currcolumn>=0 && grid[currrow][currcolumn]=='1')
                {
                    queue.Enqueue(new int[2]{currrow,currcolumn});
                    grid[currrow][currcolumn]='0';
                }
            }
        }
        
    }
}