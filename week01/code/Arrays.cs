public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // 1. Create an array of doubles with the size of 'length'.
        // 2. Use a for loop to iterate from 0 to length - 1.
        // 3. In each iteration, calculate the multiple of 'number' by multiplying it with the current index + 1.
        // 4. Store the result in the corresponding index of the array.
        // 5. Return the array after the loop completes.

        //step 1: Create an array of doubles with the size of 'length'.
        double[] multiples = new double[length];

        //step 2: Use a for loop to iterate from 0 to length - 1.

        for (int i = 0; i < length; i++)
        {
            //step 3: In each iteration, calculate the multiple of 'number' by multiplying it with the current index + 1.
            //step 4: Store the result in the corresponding index of the array.
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // step 1: get the count of the list (data.Count)
        int count = data.Count;
        // step 2: Use GetRange  to copy the last 'amount' element of the list
        List<int> lastElements = data.GetRange(count - amount, amount);
        // step 3: Use RemoveRange to remove the last 'amount' elements from the list
        data.RemoveRange(count - amount, amount);
        // step 4: insert the saved elements at t he geginning of the list using InsertRange
        data.InsertRange(0, lastElements);
        // step 5: return the list now rotated
        // Note: The list is modified in place, so no return statement is needed.
    }
}
