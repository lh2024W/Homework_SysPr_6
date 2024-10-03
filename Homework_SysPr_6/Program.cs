namespace Homework_SysPr_6
{
    public class Program
    {
        static void Main()
        {
           Task task = new Task(CallMathod);
            task.Start();
            task.Wait();
            Console.WriteLine("Main end");
            Console.ReadLine();
        }

        static async void CallMathod ()
        {
            string filePath = @"C:\Users\user\Desktop\Test.txt";
            Task<int> task = ReadFile(filePath);
            int length = await task;
            Console.WriteLine("Total length: " + length);
        }

        static async Task<int> ReadFile(string file)
        {
            int length = 0;
            Console.WriteLine("File reading is stating");
            using (StreamReader reader = new StreamReader(file))
            {
                string s = await reader.ReadToEndAsync();
                length = s.Length;
            }
            Console.WriteLine("File reading is completed");
            return length;
        }
    }
}
