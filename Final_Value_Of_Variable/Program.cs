Solution solution = new Solution();
string[] operations = new string[] { "X++", "++X", "--X"};
Console.WriteLine(solution.FinalValueAfterOperations(operations));


public class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        int value = 0;

        foreach (var operation in operations)
        {
            switch (operation)
            {
                case "X++":
                case "++X":
                    value++;
                    break;

                case "X--":
                case "--X":
                    value--;
                    break;
            }
        }

        return value;
    }
}