using PageRankWork;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PageRankForm
{
    public partial class Form1 : Form
    {
        public double dampingFactor;
        public double tolerance;
        public int maxIterations;
        public int[,] webGraph;

        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(button2, "Если будет введен размер матрицы, то\r\nматрица, указанная слева\r\nиспользована не будет." +
                "\r\nВместо нее будет сгенерирована новая");
        }

        private int[,] GenerateMatix(int size)
        {
            int[,] data = new int[size, size];

            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    data[i, j] = random.Next(0, 2);
                }
            }
            return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox2 == null)
                {
                    dampingFactor = 0.85;
                }
                if (richTextBox3 == null)
                {
                    tolerance = 0.001;
                }
                if (richTextBox4 == null)
                {
                    maxIterations = 100;
                }
                if ((richTextBox5 == null) && (richTextBox1 == null))
                {
                    Error("Введите матрицу или укажите размер");
                }
                if ((richTextBox5 == null) && (richTextBox1 != null))
                {

                }
                if (richTextBox5 != null)
                {
                    webGraph = GenerateMatix(Convert.ToInt32(richTextBox5.Text));
                }

                PageRank pagerank = new(webGraph, dampingFactor, tolerance, maxIterations);
                double[] result = pagerank.CalculatePageRank();
                for (int i = 0; i < result.Length; i++)
                {
                    richTextBox6.Text+=$"Page {i + 1}: {result[i]} \r\n";
                }
            }
            catch (Exception)
            {
                Error("unknows error");
            }
        }
        private static void Error(string text)
        {
            MessageBox.Show(
                text,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }
    }
}
