
int input = Convert.ToInt32(Console.ReadLine());
Solution sol = new Solution();
int[] result = sol.EvenOddBit(input);
Console.WriteLine("Even: " + result[0] + " Odd: " + result[1]);

public class Solution
{
    public int[] EvenOddBit(int n)
    {
        // turing string into binary
        string binary = Convert.ToString(n, 2);

        // array to hold even and odd
        int[] evenAndOdd = new int[2];

        // into array
        int[] binaryArr = binary.Select(c => Convert.ToInt32(c.ToString())).ToArray();
        
        // reverse the array becasue when dealing with binary its revesed
        Array.Reverse(binaryArr);

        // creating for loop
        for (int i = 0; i < binary.Length; i++)
        {
            //if bit index is 0 then continue
            if (binaryArr[i] == 0)
            {
                continue;
            }

            //if bit index is an even and hold 1 then add to evenAndOdd[0]
            if(i % 2 == 0 && binaryArr[i] == 1)
            {
                evenAndOdd[0]++;
            }
            //if bit index is an odd and hold 1 then add to evenAndOdd[1]
            else if(i % 2 != 0 && binaryArr[i] == 1)
            {
                evenAndOdd[1]++;
            }
        }

        // return the array
        return evenAndOdd;
    }
}