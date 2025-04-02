
using System.Diagnostics;

namespace shil_oop_lab1
{
    public partial class Form1 : Form
    {
        private SortContext<int> _sorter = new();
        private List<int> _data = new();
        private readonly Random _random = new();
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            _data = Enumerable.Range(0, 50).Select(_ => _random.Next(100)).ToList();
            UpdateChart();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string? selectedAlgorithm = comboBoxAlgorithm.SelectedItem?.ToString();

            ISortStrategy<int> strategy;

            if (selectedAlgorithm == "Cocktail")
                strategy = new CocktailSort<int>();
            else if (selectedAlgorithm == "Insertion")
                strategy = new InsertionSort<int>();
            else if (selectedAlgorithm == "Radix")
                strategy = new RadixSort();
            else
                throw new InvalidOperationException("Неизвестный алгоритм сортировки");

            _sorter.SetStrategy(strategy);
            bool ascending = radioButtonAscending.Checked;

            var stopwatch = Stopwatch.StartNew();
            _data = _sorter.Sort(_data, ascending).ToList();
            stopwatch.Stop();

            labelTime.Text = $"Time: {stopwatch.ElapsedMilliseconds} ms";
            UpdateChart();
        }

        private void UpdateChart()
        {
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.Add.Bars(_data.Select((v, i) => (double)v).ToArray());
            formsPlot1.Refresh();
        }
    }
}
