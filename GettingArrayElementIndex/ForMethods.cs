namespace GettingArrayElementIndex
{
    public static class ForMethods
    {
        public static int GetIndexOf(this uint[] arrayToSearch, uint value)
        {
            // TODO #1. Analyze the implementation of "GetLastIndexOf(uint[], uint)" method to see how "for" loop works, and implement the method using the "for" loop statement.
            throw new NotImplementedException();
        }

        public static int GetIndexOf(this uint[] arrayToSearch, uint value, int startIndex, int count)
        {
            // TODO #2. Analyze the implementation of "GetLastIndexOf(uint[], uint, int, int)" method to see how "for" loop works, and implement the method using the "for" loop statement.
            throw new NotImplementedException();
        }

        public static int GetLastIndexOf(this uint[] arrayToSearch, uint value)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            for (int i = arrayToSearch.Length - 1; i >= 0; i--)
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int GetLastIndexOf(this uint[] arrayToSearch, uint value, int startIndex, int count)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater than arrayToSearch.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            if (startIndex + count > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > arrayToSearch.Length");
            }

            for (int i = startIndex + count - 1; i >= startIndex; i--)
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
