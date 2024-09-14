namespace _2_mnozetely
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int arraySize = 10; 
            int[] numbers = GenerateRandomArray(arraySize);
            int x = GenerateRandomNumber(1, 100); 
            string output = "Массив: ";
            foreach (int num in numbers)
            {
                output += num + " ";
            }
            output += "\nЧисло x: " + x;
            MessageBox.Show(output);
            bool foundPair = FindPair(numbers, x);
            if (foundPair)
            {
                MessageBox.Show("Найдена пара чисел в массиве, произведение которых равно x.");
            }
            else
            {
                MessageBox.Show("В массиве нет пары чисел, произведение которых равно x.");
            }
        }
        private int[] GenerateRandomArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 100); 
            }
            return array;
        }
        private int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }
        private bool FindPair(int[] numbers, int x)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] * numbers[j] == x)
                    {
                        return true; 
                    }
                }
            }
            return false; 
        }
    }
}