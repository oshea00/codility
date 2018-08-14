<Query Kind="Program" />

void Main()
{
	(new Solution()).solution(
		new int[] {1}).Dump();
}

// Define other methods and classes here
class Solution
{
	Dictionary<long,long> items = new Dictionary<long, long>();	
	public int solution(int[] A)
	{
		long sum = 0L ;
		if (A==null || A.Length == 0)
		    return 0;
		long n = A.Length;
		foreach (long item in A) {
			if (item <= 0 || item > A.Length)
				return 0;
			if (items.ContainsKey(item))
			    return 0;
			else 
				items.Add(item,1L);
			sum+=item;
		}
		
		if ((n*n+n)/2 == sum)
		    return 1;
		else
		    return 0;
	}
}