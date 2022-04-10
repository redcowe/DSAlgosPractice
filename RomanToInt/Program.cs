
bool compareRight(int left, int right)
{
    if (right > left)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int RomanToInt(string s)
{

    s = s.ToUpper();

    //initialize result
    int result = 0;

    //initiallize roman num dict

    Dictionary<char, int> romanNumerals = new Dictionary<char, int>();
    // fill dict
    romanNumerals.Add('I', 1);
    romanNumerals.Add('V', 5);
    romanNumerals.Add('X', 10);
    romanNumerals.Add('L', 50);
    romanNumerals.Add('C', 100);
    romanNumerals.Add('D', 500);
    romanNumerals.Add('M', 1000);

    //breaking string into letters
    char[] splitInput = new char[s.Length];

    for (int i = 0; i < s.Length; i++)
    {
        splitInput[i] = s[i];
    }
    //compare each letter to the letter directly to it's left


    for (int i = 0; i < splitInput.Length; i++)
    {
        if (i == 0 && s.Length > 2)
        {
            if (romanNumerals[splitInput[0]] < romanNumerals[splitInput[1]])
            {
                result = result + (romanNumerals[splitInput[1]] - romanNumerals[splitInput[0]]);
                i++;
            }
            else
            {
                result = result + romanNumerals[splitInput[0]];
            }
        }
        else if (i == splitInput.Length - 1)
        {
            result = result + romanNumerals[splitInput[splitInput.Length - 1]];
        }
        else
        {
            if (i != splitInput.Length - 1)
            {
                if (compareRight(romanNumerals[splitInput[i]], romanNumerals[splitInput[i + 1]]))
                {
                    result = result + (romanNumerals[splitInput[i + 1]] - romanNumerals[splitInput[i]]);
                    i++;
                }
                else
                {
                    result = result + romanNumerals[splitInput[i]];
                }
            }
        }
    }


    return result;


}

Console.WriteLine(RomanToInt("CMLII"));


