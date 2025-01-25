namespace Task
{
    public struct TaskOne
    {
        private int threeDigitNumber;
        private int ThreeDigitNumber
        {
            get
            {
                return threeDigitNumber;
            }
            set
            {
                if (value > 99 || value < 1000)
                {
                    threeDigitNumber = value;
                }
            }
        }
        public TaskOne(int threeDigitNumber)
        {
            ThreeDigitNumber = threeDigitNumber;
        }
        public bool ResultTaskOne()
        {
            int numberOne = threeDigitNumber % 10;
            int numberTwo = (threeDigitNumber % 100) / 10;
            int numberThree = threeDigitNumber / 100;
            int numberResult = numberOne + numberTwo + numberThree;
            if (numberResult > 10 && numberResult < 99)
            {
                return true; 
            }
            return false;
        }
    }
    public struct TaskTwo
    {
        private int NumberOne { get; set; }
        private int NumberTwo { get; set; }
        private int NumberThree { get; set; }
        public TaskTwo(int numberOne, int numberTwo, int numberThree)
        {
            NumberOne = numberOne;
            NumberTwo = numberTwo;
            NumberThree = numberThree;
        }
        public int MaxNumber()
        {
            if ((NumberOne < NumberTwo) && (NumberOne < NumberThree))
            {
                return NumberTwo + NumberThree;
            }
            if ((NumberTwo < NumberOne) && (NumberTwo < NumberThree))
            {
                return NumberOne + NumberThree;
            }
            if ((NumberThree < NumberOne) && (NumberThree < NumberTwo))
            {
                return NumberOne + NumberTwo;
            }
            else return 0;
        }
    }
    public struct TaskThree
    {
        public int MasRow { get; set; }
        public int MasMax { get; set; }
        public int[] mas;
        public TaskThree(int masMax, int masRow)
        {
            MasRow = masRow;
            MasMax = masMax;
        }
        public void MasRandom()
        {
            Random rnd = new Random();
            mas = new int[MasRow];
            for (int i = 0; i < MasRow; i++)
            {
                mas[i] = rnd.Next(MasMax);
            }
        }
        public int AvgMasSum()
        {
            MasRandom();
            int masSum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                masSum += mas[i];
            }
            int masAvgSum = masSum / mas.Length;
            int minIndex = -1;
            double minValue = double.MaxValue;
            for (int i = 0; i < mas.Length; i++)
            {
                double difference = Math.Abs(mas[i] - masAvgSum);

                if (difference < minValue)
                {
                    minValue = difference;
                    minIndex = i;
                }
            }
            return minIndex;
        }
    }
    public struct TaskFour
    {
        int[,] matrix;
        private int MatrixMax { get; set; }
        private int MatrixRow { get; set; }
        private int MatrixColumn { get; set; }
        public TaskFour(int matrixMax, int matrixColumn, int matrixRow)
        {
            MatrixColumn = matrixColumn;
            MatrixMax = matrixMax;
            MatrixRow = matrixRow;
        }
        public void MatrixRandomAndCalcPasitiveNumber(out int[] masResult)
        {
            List<int> result = new List<int>();
            Random rnd = new Random();
            matrix = new int[MatrixRow, MatrixColumn];
            for (int i = 0; i < MatrixRow; i++)
            {
                for (int j = 0; j < MatrixColumn; j++)
                {
                    matrix[i, j] = rnd.Next(-10, MatrixMax);
                }
            }
            for (int i = 0; i < matrix.GetLength(0);i++)
            {
                for (int j = 0;j < matrix.GetLength(0);j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        result.Add(matrix[i, j]);
                    }
                }
            }
            masResult = new int[result.Count];
            for (int i = 0;i < result.Count;i++)
            {
                masResult[i] = result[i];
            }
        }
    }
}