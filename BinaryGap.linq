<Query Kind="Program" />


void Main()
{
	var p = new Solution();
	var cases = new List<Tuple<int, int>> {
	  new Tuple<int,int>(0,0),
	  new Tuple<int,int>(1,0),
	  new Tuple<int,int>(255,0),
	  new Tuple<int,int>(32,0),
	  new Tuple<int,int>(529,4),
	  new Tuple<int,int>(9, 2),
	  new Tuple<int,int>(20, 1),
	  new Tuple<int,int>(22, 1),
	  new Tuple<int,int>(2147483647, 0),
	  };
	  
	foreach (var i in cases)
	{
		Console.WriteLine($"{i.Item1} {Convert.ToString(i.Item1, 2)} {p.solution(i.Item1)} pass? {p.solution(i.Item1)==i.Item2}");
	}
}

int Log2(int n)
{
	return (int) (Math.Log10(n)/Math.Log10(2));
}

// Define other methods and classes here
class Solution
{
	public int solution(int N)
	{
		bool firstOne = false;
	    int ones = 0;
		int zeroCount = 0;
		int max = 0;
		int test = N;
		if ((test == 0) || (test == 1))
		{
			return 0;
		}
			
		while (test > 0)
		{
			if ((test & 1) == 1)
			{
				firstOne = true;
				ones++;
				if (zeroCount > 0)
				{
					max = Math.Max(max,zeroCount);
					zeroCount = 0;
				}
			}
			else {
				if (firstOne)
					zeroCount++;
			}
			test >>= 1;
		}
		if (ones > 1)
		    return max;
		else
		    return 0;
	}
}