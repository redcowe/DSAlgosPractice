using System;

/*
Write a function that takes in a non-empty array of integers that are sorted in ascending order and returns
a new array of the same length with the squares of the original integers also sorted in ascending order.
*/
//Time: O(n log n) Space: O(N)
public class Program {

	public int[] SortedSquaredArray(int[] array) {
        int[] a = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                a[i] = array[i] * array[i];
            }
        Array.Sort(a);
		return a;
	}
}
