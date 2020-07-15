using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortApp
{
    public partial class AppForm : Form
    {
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

                PopulateColumn(array, columnIndex: 0);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {

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

        private void PopulateColumn(int[] array, int columnIndex)
        {
            for (int i = 0; i < array.Length; i++)
            {
                dataGridViewData[columnIndex, i].Value = array[i];
            }
        }
    }
}
