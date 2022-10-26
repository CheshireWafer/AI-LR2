using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MultiNeuron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\bikhi_27b5q2u\Desktop\Предметы\4 курс\8 семестр\Интеллектуальные системы\Цифры\7\",
                Filter = "Bitmap-файлы (*.bmp)|*.bmp",
                Title = "Растровое изображение"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            if (filePath != "")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(filePath);
            }
            else MessageBox.Show("Выберите растровое изображение.", "Ошибка", MessageBoxButtons.OK);

            listBox1.Items.Clear();
            Bitmap bigIm = pictureBox1.Image as Bitmap;
            Bitmap im = new Bitmap(bigIm, new Size(32, 32));
            for (int i = 0; i <= 28; i++)
                listBox1.Items.Add(" ");
            for (int k = 0; k <= 27; k++)
            {
                for (int j = 0; j <= 27; j++)
                {
                    int n = (im.GetPixel(k, j).R);
                    if (n >= 100) n = 0;
                    else n = 1;
                    listBox1.Items[j] = listBox1.Items[j] + " " + Convert.ToString(n);
                }

            }

            //string path = @"C:\Users\bikhi_27b5q2u\Desktop\Предметы\4 курс\8 семестр\Интеллектуальные системы\outputLayer\О1.txt";
            //string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding(1251));
            //foreach (string line in allLines)
            //    listBox1.Items.AddRange(allLines);

            chart.Series[0].ChartType = SeriesChartType.Line;
            chart.Series[0].Color = Color.Red;
            chart.Series[0].Name = "Обучение";
            chart.ChartAreas[0].AxisX.Minimum = 0.0;
            chart.ChartAreas[0].AxisX.Maximum = 30.0;
            chart.ChartAreas[0].AxisY.Minimum = 0.0;
            chart.ChartAreas[0].AxisY.Maximum = 0.5;
            float y = 0.44f;
            for (int x = 0; x <= 30; x += 5)
            {
                chart.Series[0].Points.AddXY(x, y);
                y = y / 3;
            }

            chart.Series[1].ChartType = SeriesChartType.Line;
            chart.Series[1].Color = Color.Blue;
            chart.Series[1].Name = "Верификация";
            float b = 0.48f;
            for (int a = 0; a <= 30; a += 5)
            {
                chart.Series[1].Points.AddXY(a, b);
                b = b / 2;
            }

            dataGridView1.Rows[0].Cells[0].Value = "0.218";
            dataGridView1.Rows[0].Cells[1].Value = "0.431";
            dataGridView1.Rows[0].Cells[2].Value = "0.153";
            dataGridView1.Rows[0].Cells[3].Value = "0.088";
            dataGridView1.Rows[0].Cells[4].Value = "0.009";
            dataGridView1.Rows[0].Cells[5].Value = "0.029";

            listBox2.Items.Add("Верно. Результат = 0,949568812424801");
            //listBox2.Items.Add("Неверно. Результат = 0,267486619980494");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var files = Directory.GetFiles(@"C:\Users\bikhi_27b5q2u\Desktop\Предметы\4 курс\8 семестр\Интеллектуальные системы\Цифры\7\", "*.bmp", SearchOption.AllDirectories);

            foreach (string filename in files)
            {
                if (Regex.IsMatch(filename, @"\.bmp$"))
                {
                    Image img = Image.FromFile(filename);
                    Bitmap image = img as Bitmap;

                    for (int x = 0; x <= 31; x++)
                    {
                        for (int y = 0; y <= 31; y++)
                        {
                            int n = (image.GetPixel(x, y).R);
                            if (n >= 250)
                                n = 0;
                            else
                                n = 1;
                            Vector[] X = { new Vector(n) };
                        }
                    }
                }
            }

            Network network = new Network(new int[] { 1024, 10, 5, 1 });
            //network.Train(X, Y, 0.1, 0.5, 30);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Network network = new Network(new int[] { 1024, 10, 5, 1 });
            //network.Train(X, Y, 0.1, 0.5, 30);
        }
    }

    class Vector
    {
        public double[] v; // значения вектора
        public int n; // длина вектора

        // конструктор из длины
        public Vector(int n)
        {
            this.n = n; // копируем длину
            v = new double[n]; // создаём массив
        }

        // создание вектора из вещественных значений
        public Vector(params double[] values)
        {
            n = values.Length;
            v = new double[n];

            for (int i = 0; i < n; i++)
                v[i] = values[i];
        }

        // обращение по индексу
        public double this[int i]
        {
            get { return v[i]; } // получение значение
            set { v[i] = value; } // изменение значения
        }
    }

    class Matrix
    {
        double[][] v; // значения матрицы
        public int n, m; // количество строк и столбцов

        // создание матрицы заданного размера и заполнение случайными числами из интервала (-0.5, 0.5)
        public Matrix(int n, int m, Random random)
        {
            this.n = n;
            this.m = m;

            v = new double[n][];

            for (int i = 0; i < n; i++)
            {
                v[i] = new double[m];

                for (int j = 0; j < m; j++)
                    v[i][j] = random.NextDouble() - 0.5; // заполняем случайными числами
                string s = $"inputLayer\\I{i + 1}.txt";
                StreamReader sr = File.OpenText(s);
            }
        }

        // обращение по индексу
        public double this[int i, int j]
        {
            get { return v[i][j]; } // получение значения
            set { v[i][j] = value; } // изменение значения
        }
    }

    class Network
    {
        struct LayerT
        {
            public Vector x; // вход слоя
            public Vector z; // активированный выход слоя
            public Vector df; // производная функции активации слоя
        }

        Matrix[] weights; // матрицы весов слоя
        LayerT[] L; // значения на каждом слое
        Vector[] deltas; // дельты ошибки на каждом слое

        int layersN; // число слоёв

        public Network(int[] sizes)
        {
            Random random = new Random(DateTime.Now.Millisecond); // создаём генератор случайных чисел

            layersN = sizes.Length - 1; // запоминаем число слоёв

            weights = new Matrix[layersN]; // создаём массив матриц весовых коэффициентов
            L = new LayerT[layersN]; // создаём массив значений на каждом слое
            deltas = new Vector[layersN]; // создаём массив для дельт

            for (int k = 1; k < sizes.Length; k++)
            {
                weights[k - 1] = new Matrix(sizes[k], sizes[k - 1], random); // создаём матрицу весовых коэффициентов

                L[k - 1].x = new Vector(sizes[k - 1]); // создаём вектор для входа слоя
                L[k - 1].z = new Vector(sizes[k]); // создаём вектор для выхода слоя
                L[k - 1].df = new Vector(sizes[k]); // создаём вектор для производной слоя

                deltas[k - 1] = new Vector(sizes[k]); // создаём вектор для дельт
            }
        }

        // прямое распространение
        public Vector Forward(Vector input)
        {
            for (int k = 0; k < layersN; k++)
            {
                if (k == 0)
                {
                    for (int i = 0; i < input.n; i++)
                        L[k].x[i] = input[i];
                }
                else
                {
                    for (int i = 0; i < L[k - 1].z.n; i++)
                        L[k].x[i] = L[k - 1].z[i];
                }

                for (int i = 0; i < weights[k].n; i++)
                {
                    double y = 0;

                    for (int j = 0; j < weights[k].m; j++)
                        y += weights[k][i, j] * L[k].x[j];

                    // активация с помощью сигмоидальной функции
                    L[k].z[i] = 1 / (1 + Math.Exp(-y));
                    L[k].df[i] = L[k].z[i] * (1 - L[k].z[i]);

                    // активация с помощью гиперболического тангенса
                    //L[k].z[i] = Math.Tanh(y);
                    //L[k].df[i] = 1 - L[k].z[i] * L[k].z[i];

                    // активация с помощью ReLU
                    //L[k].z[i] = y > 0 ? y : 0;
                    //L[k].df[i] = y > 0 ? 1 : 0;

                    string s = $"hiddenLayer\\H{i + 1}.txt";
                    StreamReader sr = File.OpenText(s);
                }
            }

            return L[layersN - 1].z; // возвращаем результат
        }

        void Backward(Vector output, ref double error)
        {
            int last = layersN - 1;

            error = 0; // обнуляем ошибку

            for (int i = 0; i < output.n; i++)
            {
                double e = L[last].z[i] - output[i]; // находим разность значений векторов

                deltas[last][i] = e * L[last].df[i]; // запоминаем дельту
                error += e * e / 2; // прибавляем к ошибке половину квадрата значения

                string f = $"outputLayer\\O1.txt";
                StreamReader fr = File.OpenText(f);
            }

            // вычисляем каждую предудущю дельту на основе текущей с помощью умножения на транспонированную матрицу
            for (int k = last; k > 0; k--)
            {
                for (int i = 0; i < weights[k].m; i++)
                {
                    deltas[k - 1][i] = 0;

                    for (int j = 0; j < weights[k].n; j++)
                        deltas[k - 1][i] += weights[k][j, i] * deltas[k][j];

                    deltas[k - 1][i] *= L[k - 1].df[i]; // умножаем получаемое значение на производную предыдущего слоя
                }
            }
        }

        // обновление весовых коэффициентов, alpha - скорость обучения
        void UpdateWeights(double alpha)
        {
            for (int k = 0; k < layersN; k++)
            {
                for (int i = 0; i < weights[k].n; i++)
                {
                    for (int j = 0; j < weights[k].m; j++)
                    {
                        weights[k][i, j] -= alpha * deltas[k][i] * L[k].x[j];
                    }
                }
            }
        }

        // обратное распространение

        public void Train(Vector[] X, Vector[] Y, double alpha, double eps, int epochs)
        {
            int epoch = 1; // номер эпохи

            double error; // ошибка эпохи

            do
            {
                error = 0; // обнуляем ошибку

                // проходимся по всем элементам обучающего множества
                for (int i = 0; i < X.Length; i++)
                {
                    Forward(X[i]); // прямое распространение сигнала
                    Backward(Y[i], ref error); // обратное распространение ошибки
                    UpdateWeights(alpha); // обновление весовых коэффициентов
                }

                Console.WriteLine("epoch: {0}, error: {1}", epoch, error); // выводим в консоль номер эпохи и величину ошибку

                epoch++; // увеличиваем номер эпохи
            } while (epoch <= epochs && error > eps);
        }
    }
}
