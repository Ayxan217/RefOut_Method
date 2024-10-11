namespace Method_RefTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 8, 9, 0, 12, 5, 3 };

            CustomResize(ref arr, 5, 9);

            Console.WriteLine("Yeni array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.Read(); // Console u açıq saxlamaq üçün

        }

        public static void CustomResize(ref int[] arr, params int[] newElements)
        {
            int newLength = arr.Length + newElements.Length; 
            int[] newArr = new int[newLength];


            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }


            for (int i = 0; i < newElements.Length; i++)
            {
                newArr[arr.Length + i] = newElements[i];
            }

            arr = newArr;
            
        }
    }
}
