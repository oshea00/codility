<Query Kind="Program">
  <Namespace>System</Namespace>
</Query>

void Main()
{
	var p = new Solution();
	
}


class Solution
{
	public int solution(int[] A)
	{
		if (A==null || A.Length == 0 || (A.Length%2==0))
			return 0;
			
		var d = new Dictionary<int,int>();
		foreach (var i in A)
		{
			if (!d.ContainsKey(i))
				d.Add(i,1);
			else
				d[i] += 1;
		}
		foreach (var k in d.Keys)
		{
			if (d[k] % 2 == 1)
				return k;
		}
		return 0;
	}
}
// Define other methods and classes here
