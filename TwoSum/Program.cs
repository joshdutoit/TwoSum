PrintTwoSumResult();

void PrintTwoSumResult()
{
    int[] result = TwoSum(new int[] {2, 7, 11, 15}, 9);
    Console.WriteLine(string.Join(" ", result));
};

static int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> result = new();

    if(nums == null && nums.Length < 2)
        return Array.Empty<int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int firstNum = nums[i];
        int secondNum = target - firstNum;

        if(result.TryGetValue(secondNum, out int index))
        {
            return new[]
            {
                index,
                i
            };
        }

        result[firstNum] = i;
    }

    return Array.Empty<int>();
}