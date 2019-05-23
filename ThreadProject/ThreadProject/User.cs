namespace ThreadProject
{
    class User
    {
        private int[] myVar = new int[5];

        public void SetInt(int index, int value)
        {
            myVar[index] = value;
        }
        public int[] GetInt()
        {
            return myVar;
        }
    }

    class UserIndexer
    {
        private int[] intArray;

        public UserIndexer(int length)
        {
            intArray = new int[length];
        }

        public int this[int i]
        {
            get { return intArray[i]; }

            set { intArray[i] = value; }
        }
    }
}
