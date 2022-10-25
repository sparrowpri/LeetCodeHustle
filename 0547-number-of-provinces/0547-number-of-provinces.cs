public class Solution {
    public int FindCircleNum(int[][] isConnected) {
      var visited=new int[isConnected.Length+1]; 
      var ans=0;
      for(int i=0;i<isConnected.Length;i++)
      {
          if(visited[i]==0)
          {
              ans+=1;
              dfs(i,visited,isConnected);
          }
      }
        return ans;
    }
    public void dfs(int node,int[] visited,int[][] adjmatrix)
    {
        visited[node]=1;
        for(int i=0;i<adjmatrix[node].Length;i++)
        {
            if(adjmatrix[node][i]==1 && visited[i]==0 && i!=node )
            {
                dfs(i,visited,adjmatrix);
            }
            
        }
    }
}