using System.Collections.Generic;
using System;


public class Program {

	public bool ClassPhotos(List<int> redShirtHeights, List<int> blueShirtHeights) {
        redShirtHeights.Sort();  //2, 4, 5, 6, 9
        blueShirtHeights.Sort(); //1, 3, 4, 5, 8

        var backRow = redShirtHeights;
        var frontRow = blueShirtHeights;
        var backPointer = 0;
        
        if (redShirtHeights[redShirtHeights.Count - 1] < blueShirtHeights[blueShirtHeights.Count - 1])
        {
             frontRow = redShirtHeights;
             backRow = blueShirtHeights;
        }
   
        foreach (var val in frontRow)
        {
            if (backRow[backPointer] > val)
                backPointer++;
        }     
		return backPointer == backRow.Count;
	}
}
