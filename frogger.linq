<Query Kind="Program" />

void Main()
{
	var p = new Solution();
	p.solution(10,85,30).Dump();
}

// Define other methods and classes here
class Solution
{
	public int solution(int X, int Y, int D)
	{
		
		if (X==Y || D==0)
			return 0; 
		return (int) System.Math.Ceiling((Y-X)/(D*1.0));
	}
}
