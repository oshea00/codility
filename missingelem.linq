<Query Kind="Program" />

void Main()
{
	(new Solution()).solution(new int[] {3,1,2,4,3}).Dump();
}

class Solution
{
	public int solution(int[] A)
	{
		if (A == null || A.Length==0)
		    return 0;
		long minDiff=long.MaxValue;
		var lsums = new long[A.Length-1];
		lsums[0] = A[0];
		var rsums = new long[A.Length-1];
		rsums[rsums.Length-1]=A[A.Length-1];
		for (int i=1;i<A.Length-1;i++) {
			lsums[i]=lsums[i-1]+A[i];
			rsums[rsums.Length-i-1]=A[A.Length-i-1]+rsums[rsums.Length-i];
		}
		for (int i=0;i<lsums.Length;i++) {
			minDiff = Math.Min(minDiff,Math.Abs(lsums[i]-rsums[i]));
		}
		return (int) minDiff;
	}
}