using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sortingAlgorithms;

namespace SortApp
{
    public partial class AppForm : Form
    {
        private string sortType;

        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            dataGridViewTimes.Rows.Add("", 44, 55, 11, 33);
        }
        private void checkBoxRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRandom.Checked)
            {
                labelArrSize.ForeColor = SystemColors.ControlText;
                textBoxArrSize.Enabled = true;
                buttonGenArr.Enabled = true;
            }
            else
            {
                labelArrSize.ForeColor = SystemColors.ControlDark;
                textBoxArrSize.Enabled = false;
                buttonGenArr.Enabled = false;
            }
        }

        private void buttonGenArr_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxArrSize.Text, out int arrSize) && arrSize > 0)
            {
                int[] array = GetRandomArray(arrSize);

                dataGridViewData.Rows.Clear();
                dataGridViewData.Rows.Add(count: arrSize);

                PopulateColumn(dataGridViewData, array, columnIndex: 0);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (sortType == "int") // if choice is int
            {
                Sort<int> sort = new Sort<int>();
                sorrt.arrayToSort = ReadColumnIntoArray<int>(columnIndex: 0);
                PerformSorting(sorrt);
            }
            //arrayToSort = ReadColumnIntoArray<int>(columnIndex: 0);

            //PerformSorting(array);

            MessageBox.Show("done");
        }

        private int[] GetRandomArray(int size)
        {
            int[] array = new int[size];
            var random = new Random();
            int maxValue = size * 10;

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, maxValue);
            }
            return array;
        }

        private void PopulateColumn<T>(DataGridView gridView, IList<T> list, int columnIndex)
        {
            for (int i = 0; i < list.Count; i++)
            {
                gridView[columnIndex, i].Value = list[i];
            }
        }

        private void PopulateColumn<T>(DataGridView gridView, T value, int columnIndex, int rowIndex)
        {
            gridView[columnIndex, rowIndex].Value = value;
        }

        private T[] ReadColumnIntoArray<T>(int columnIndex)
        {
            int size = dataGridViewData.Rows.Count - 1; // -1, as DGV creates empty row at bottom
            T[] array = new T[size];
            for (int i = 0; i < size; i++)
            {
                //if (int.TryParse(dataGridViewData[columnIndex, i].Value.ToString(), out int value))
                //{
                //    array[i] = value;
                //}
                //else
                //{
                //    MessageBox.Show($"Error occured when trying to read value in cell {i} in column {columnIndex}");
                //}

                array[i] = (T)dataGridViewData[columnIndex, i].Value;          
            }
            return array;
        }

        private (T[] bubbleSortedArray, long time) BubbleSort<T>(Sort<T> listObject)
        {
            var list = (IList<T>)listObject;
            T[] bubbleSortedArray = new T[list.Count];
            list.CopyTo(bubbleSortedArray, 0);

            var sw = new Stopwatch();
            sw.Start();
            bubbleSortedArray.BubbleSortAscending();
            sw.Stop();


            return (bubbleSortedArray, sw.ElapsedMilliseconds);
        }

        private (T[] insertionSortedArray, long time) InsertionSort<T>(object listObject)
        {
            var list = (IList<T>)listObject;
            T[] insertionSortedArray = new T[list.Count];
            list.CopyTo(insertionSortedArray, 0);

            var sw = new Stopwatch();
            sw.Start();
            insertionSortedArray.InsertionSortAscending();
            sw.Stop();

            return (insertionSortedArray, sw.ElapsedMilliseconds);
        }

        private (T[] selectionSortedArray, long time) SelectionSort<T>(IList<T> list)
        {
            T[] selectionSortedArray = new T[list.Count];
            list.CopyTo(selectionSortedArray, 0);

            var sw = new Stopwatch();
            sw.Start();
            selectionSortedArray.SelectionSortAscending();
            sw.Stop();

            return (selectionSortedArray, sw.ElapsedMilliseconds);
        }

        private (T[] mergeSortedArray, long time) MergeSort<T>(IList<T> array)
        {
            T[] mergeSortedArray = new T[array.Count];
            array.CopyTo(mergeSortedArray, 0);

            var sw = new Stopwatch();
            sw.Start();
            mergeSortedArray.MergeSort();
            sw.Stop();

            return (mergeSortedArray, sw.ElapsedMilliseconds);
        }

        private (T[] sortedArray, long time) ArraySort<T>(T[] array)
        {
            T[] sortedArray = new T[array.Length];
            array.CopyTo(sortedArray, 0);

            var sw = new Stopwatch();
            sw.Start();
            Array.Sort(sortedArray);
            sw.Stop();

            return (sortedArray, sw.ElapsedMilliseconds);
        }

        private void PerformSorting<T>(Sort<T> sort)
        {
            backgroundWorkerBubbleSort.RunWorkerAsync(sort);

            var insertionSort = InsertionSort(sort);
            PopulateColumn(dataGridViewData, insertionSort.insertionSortedArray, columnIndex: 2);
            PopulateColumn(dataGridViewTimes, insertionSort.time, columnIndex: 2, rowIndex: 0);

            var selectionSort = SelectionSort(sort);
            PopulateColumn(dataGridViewData, selectionSort.selectionSortedArray, columnIndex: 3);
            PopulateColumn(dataGridViewTimes, selectionSort.time, columnIndex: 3, rowIndex: 0);

            var mergeSort = MergeSort(sort);
            PopulateColumn(dataGridViewData, mergeSort.mergeSortedArray, columnIndex: 4);
            PopulateColumn(dataGridViewTimes, mergeSort.time, columnIndex: 4, rowIndex: 0);

            var builtInSort = ArraySort(sort.ToArray());
            // we do not populate dataGridViewData with standard sort result, only time
            PopulateColumn(dataGridViewTimes, builtInSort.time, columnIndex: 0, rowIndex: 0);         
        }

        private void backgroundWorkerBubbleSort_DoWork(object sender, DoWorkEventArgs e)
        {
            var bubbleSort = BubbleSort(sender, e.Argument);
            PopulateColumn(dataGridViewData, bubbleSort.bubbleSortedArray, columnIndex: 1);
            PopulateColumn(dataGridViewTimes, bubbleSort.time, columnIndex: 1, rowIndex: 0);
        }

        private void backgroundWorkerBubbleSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void backgroundWorkerInsertionSort_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorkerInsertionSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void backgroundWorkerSelectionSort_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void backgroundWorkerSelectionSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void backgroundWorkerMergeSort_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void backgroundWorkerMergeSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        private void backgroundWorkerBuiltInSort_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void backgroundWorkerBuiltInSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

    }
}
