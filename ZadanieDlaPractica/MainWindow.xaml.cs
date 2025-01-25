using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Task;

namespace ZadanieDlaPractica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = sender as Button;
            switch(s.Name)
            {
                case "btTaskOne":TaskOneCalc(); break;
                case "btTaskTwo":TaskTwoCalc(); break;
                case "btTaskThree":TaskThreeCalc(); break;
                case "btTaskFour":TaskFourCalc(); break;
                case "btTaskInfo":MessageBox.Show("Made In Pasha"); break;
                case "btTaskExit":Close(); break;
            }
        }
        private void TaskOneCalc()
        {
            bool boolTaskOneThreeDigitNumber = int.TryParse(tbTaskOneThreeDigitNumber.Text, out int threeDigitNumber);
            if (boolTaskOneThreeDigitNumber && threeDigitNumber > 9 && threeDigitNumber < 1000)
            {
                TaskOne taskOne = new TaskOne(threeDigitNumber);
                bool boolTaskOneResult = taskOne.ResultTaskOne();
                if (boolTaskOneResult) MessageBox.Show("Сумма явдяется двухзначной");
                else MessageBox.Show("Сумма не является двухзначной");
            }
            else MessageBox.Show("Что-то не то");
        }
        private void TaskTwoCalc()
        {
            bool boolnumberOne = int.TryParse(tbTaskTwoNumberOne.Text, out int numberOne);
            bool boolnumberTwo = int.TryParse(tbTaskTwoNumberTwo.Text, out int numberTwo);
            bool boolnumberThree = int.TryParse(tbTaskTwoNumberThree.Text, out int numberThree);
            if (boolnumberOne && boolnumberTwo && boolnumberThree)
            {
                TaskTwo taskTwo = new TaskTwo(numberOne, numberTwo, numberThree);
                int MaxNumberResult = taskTwo.MaxNumber();
                tbTaskTwoResult.Text = Convert.ToString(MaxNumberResult);
            }
            else MessageBox.Show("Что-то не то");
        }
        private void TaskThreeCalc()
        {
            bool boolMaxMas = int.TryParse(tbTaskThreeMaxMas.Text, out int maxMas);
            bool boolMasRow = int.TryParse(tbTaskThreeMasRow.Text, out int masRow);
            if (boolMasRow && boolMaxMas)
            {
                TaskThree taskThree = new TaskThree(maxMas, masRow);
                int masResult = taskThree.AvgMasSum();
                tbTaskThreeResult.Text = Convert.ToString(masResult);
            }
            else MessageBox.Show("Что-то не то");
        }
        private void TaskFourCalc()
        {
            bool boolMatrixMax = int.TryParse(tbTaskFourMaxMatrix.Text, out int matrixMax);
            bool boolMatrixColumn = int.TryParse(tbTaskFourColumn.Text, out int matrixColumn);
            bool boolMatrixRow = int.TryParse(tbTaskFourRow.Text, out int matrixRow);
            if(boolMatrixColumn && boolMatrixMax && boolMatrixRow)
            {
                int[] mas;
                TaskFour taskFour = new TaskFour(matrixMax, matrixColumn, matrixRow);
                taskFour.MatrixRandomAndCalcPasitiveNumber(out mas);
                for (int i = 0; i < mas.Length; i++)
                {
                    lbMasResult.Items.Add(mas[i]);
                }
            }
            else MessageBox.Show("Что-то не то");
        }
    }
}