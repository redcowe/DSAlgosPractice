using System;
using System.Collections.Generic;

public class Program {
	public static bool IsValidSubsequence(List<int> array, List<int> sequence) {
		// O(n) time, O(1) space
        int sequenceIndex = 0;
       foreach (var val in array)
       {
           if (sequenceIndex == sequence.Count)
               break;
           if (sequence[sequenceIndex] == val)
               sequenceIndex++;
       }
        return  sequenceIndex == sequence.Count;
    }
}
