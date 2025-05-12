
using System.Diagnostics;

namespace shil_oop_lab1
{
    public partial class Form1 : Form
    {
        private SortContext<int> sorter = new();
        private List<int> data = new();
        private readonly Random random = new();
        public Form1()
        {
            InitializeComponent();
            comboBoxAlgorithm.Items.Add(new CocktailSort<int>());
            comboBoxAlgorithm.Items.Add(new InsertionSort<int>());
            comboBoxAlgorithm.Items.Add(new QwertS());
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            data = Enumerable.Range(0, 50).Select(_ => random.Next(100)).ToList();
            UpdateChart();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            var selectedAlgorithm = comboBoxAlgorithm.SelectedItem as ISortStrategy<int>;

           /* if (selectedAlgorithm == "Cocktail")
                strategy = new CocktailSort<int>();
            else if (selectedAlgorithm == "Insertion")
                strategy = new InsertionSort<int>();
            else if (selectedAlgorithm == "Radix")
                strategy = new RadixSort();
            else
                throw new InvalidOperationException();
           */
            sorter.SetStrategy(selectedAlgorithm);

            bool ascending = checkBox.Checked;

            data = sorter.Sort(data, ascending).ToList();

            UpdateChart();
        }

        private void UpdateChart()
        {
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.Add.Bars(data.Select((v, i) => (double)v).ToArray());
            formsPlot1.Refresh();
        }
    }
}
