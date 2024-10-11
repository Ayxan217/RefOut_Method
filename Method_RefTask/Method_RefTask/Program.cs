namespace Method_RefTask
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] arr = { 4, 8, 9, 0, 12, 5, 3 };

            Console.Write("elave olunacaq elemrntlerin sayı: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write(" elemntleri daxil edin: ");
                int newNumber = int.Parse(Console.ReadLine());

                CustomResize(ref arr, newNumber);
            }
            Console.WriteLine("yeni array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void CustomResize(ref int[] arr, int newElement)
        {

            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[newArr.Length - 1] = newElement;
            arr = newArr;
        }
    }
       
    
}

