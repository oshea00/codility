<Query Kind="Program" />

void Main()
{
	var p = new Solution();
	p.solution(new int[]{}, 3).Dump("answer");
}

// Define other methods and classes here
class Solution {
	public int[] solution(int[] A, int K) {
		if (A==null||A.Length==0)
			return new int[0];
		for (int i=0; i<K%A.Length ;i++)
		{
			int val = A[A.Length-1];
			for (int j=A.Length-1;j>0;j--)
			{
				A[j]=A[j-1];
			}
			A[0]=val;
		}
		return A;
	}
}