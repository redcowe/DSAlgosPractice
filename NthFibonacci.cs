using System;

public class Program {
	public static int GetNthFib(int n) {
		if (n == 1)
            return 0;
        if (n == 2)
            return 1;
       return GetNthFib(n - 1) + GetNthFib(n - 2);
	}
}
