using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Графика
{
    public partial class Form1 : Form
    {
        abstract class Filters
        {
            protected abstract Color calculateNewPixel(Bitmap sourceImage, int x, int y);

            public int Clamp(int value, int min, int max)
            {
                if (value < min) return min;
                if (value > max) return max;
                return value;
            }
            public Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
            {
                Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
                for (int i = 0; i < sourceImage.Width; i++)
                {
                    worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                    if (worker.CancellationPending)
                        return null;

                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        resultImage.SetPixel(i, j, calculateNewPixel(sourceImage, i, j));
                    }
                }
                return resultImage;
            }

        }

        class InvertFilter : Filters
        {
            protected override Color calculateNewPixel(Bitmap sourceImage, int x, int y)
            {
                Color sourceColor = sourceImage.GetPixel(x, y);
                Color resultColor = Color.FromArgb(255 - sourceColor.R, 255 - sourceColor.G, 255 - sourceColor.B);
                return resultColor;
            }
        }

        class GrayScaleFilter : Filters
        {
            protected override Color calculateNewPixel(Bitmap sourceImage, int x, int y)
            {
                Color sourceIntencity = sourceImage.GetPixel(x, y);
                int intencity = (int)((sourceIntencity.R * 0.36) + (sourceIntencity.G * 0.51) + (sourceIntencity.B * 0.11));
                Color resultIntencity = Color.FromArgb(intencity, intencity, intencity);
                return resultIntencity;
            }
        }

        class SepiaFilter : Filters
        {
            protected override Color calculateNewPixel(Bitmap sourceImage, int x, int y)
            {
                Color sourceIntencity = sourceImage.GetPixel(x, y);
                int intencity = (int)((sourceIntencity.R * 0.36) + (sourceIntencity.G * 0.51) + (sourceIntencity.B * 0.11));
                Color result = Color.FromArgb(Clamp(intencity + 2 * 20, 0, 255), Clamp(intencity + (int)0.5 * 20, 0, 255), Clamp((intencity - 1 * 20), 0, 255));
                return result;
            }
        }

        class Brightness : Filters
        {
            protected override Color calculateNewPixel(Bitmap sourceImage, int x, int y)
            {
                Color sourceIntencity = sourceImage.GetPixel(x, y);
                Color result = Color.FromArgb(Clamp(sourceIntencity.R + 30, 0, 225), Clamp(sourceIntencity.G + 30, 0, 255), Clamp(sourceIntencity.B + 30, 0, 255));
                return result;
            }
        }

        class MatrixFilter : Filters
        {
            protected float[,] kernel = null;
            protected MatrixFilter() { }
            public MatrixFilter(float[,] kernel)
            {
                this.kernel = kernel;
            }

            protected override Color calculateNewPixel(Bitmap sourceImage, int x, int y)
            {
                int radiusX = kernel.GetLength(0) / 2;
                int radiusY = kernel.GetLength(1) / 2;
                float resultR = 0;
                float resultG = 0;
                float resultB = 0;
                for (int l = -radiusY; l <= radiusY; l++)
                    for (int k = -radiusX; k <= radiusX; k++)
                    {
                        int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                        int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                        Color neighborColor = sourceImage.GetPixel(idX, idY);
                        resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
                        resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
                        resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
                    }
                return Color.FromArgb(
                    Clamp((int)resultR, 0, 255),
                    Clamp((int)resultG, 0, 255),
                    Clamp((int)resultB, 0, 255)
                    );
            }
        }

        class Sharpness : MatrixFilter
        {
            public Sharpness()
            {
                kernel = new float[,] {  {0, -1,  0 },
                                         {-1, 5, -1 },
                                         {0, -1,  0 } };

            }
        }

        class BlurFilter : MatrixFilter
        {
            public BlurFilter()
            {
                int sizeX = 3;
                int sizeY = 3;
                kernel = new float[sizeX, sizeY];
                for (int i = 0; i < sizeX; i++)
                    for (int j = 0; j < sizeY; j++)
                        kernel[i, j] = 1.0f / (float)(sizeX * sizeY);
            }
        }

        class GaussianFilter : MatrixFilter
        {
            public GaussianFilter()
            {
                createGaussianKernel(3, 10);
            }

            public void createGaussianKernel(int radius, float sigma)
            {
                int size = 2 * radius + 1;
                kernel = new float[size, size];
                float norm = 0;
                for (int i = -radius; i <= radius; i++)
                    for (int j = -radius; j <= radius; j++)
                    {
                        kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i + j * j) / (sigma * sigma)));
                        norm += kernel[i + radius, j + radius];
                    }

                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        kernel[i, j] /= norm;
            }
        }

        class DoubleMatrix : Filters
        {
            protected float[,] kernel1 = null;
            protected float[,] kernel2 = null;

            protected DoubleMatrix() { }

            public DoubleMatrix(float[,] kernel1, float[,] kernel2)
            {
                this.kernel1 = kernel1;
                this.kernel2 = kernel2;
            }

            protected override Color calculateNewPixel(Bitmap sourceImage, int x, int y)
            {
                int radiusX = kernel1.GetLength(0) / 2;
                int radiusY = kernel1.GetLength(1) / 2;

                float resultR1 = 0;
                float resultG1 = 0;
                float resultB1 = 0;

                for (int i = -radiusY; i <= radiusY; i++)
                {
                    for (int k = -radiusX; k <= radiusX; k++)
                    {
                        int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                        int idY = Clamp(y + i, 0, sourceImage.Height - 1);

                        Color neighbor = sourceImage.GetPixel(idX, idY);

                        resultR1 += neighbor.R * kernel1[k + radiusX, i + radiusY];
                        resultG1 += neighbor.G * kernel1[k + radiusX, i + radiusY];
                        resultB1 += neighbor.B * kernel1[k + radiusX, i + radiusY];
                    }
                }

                int radiusX2 = kernel2.GetLength(0) / 2;
                int radiusY2 = kernel2.GetLength(1) / 2;

                float resultR2 = 0;
                float resultG2 = 0;
                float resultB2 = 0;

                for (int i = -radiusY2; i <= radiusY2; i++)
                {
                    for (int k = -radiusX2; k <= radiusX2; k++)
                    {
                        int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                        int idY = Clamp(y + i, 0, sourceImage.Height - 1);

                        Color neighbor = sourceImage.GetPixel(idX, idY);

                        resultR2 += neighbor.R * kernel2[k + radiusX2, i + radiusY2];
                        resultG2 += neighbor.G * kernel2[k + radiusX2, i + radiusY2];
                        resultB2 += neighbor.B * kernel2[k + radiusX2, i + radiusY2];
                    }
                }

                return Color.FromArgb(
         Clamp((int)Math.Sqrt((resultR1 * resultR1 + resultR2 * resultR2)), 0, 255),
         Clamp((int)Math.Sqrt((resultG1 * resultG1 + resultG2 * resultG2)), 0, 255),
         Clamp((int)Math.Sqrt((resultB1 * resultB1 + resultB2 * resultB2)), 0, 255));
            }

        }

        class Sobel : DoubleMatrix
        {
            public Sobel()
            {
                kernel1 = new float[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
                kernel2 = new float[,] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
            }
        }

        Bitmap image;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *jpg; *.bmp | All files (*.*) | *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Refresh();
            }
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true) image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void фильтрГауссаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void оттенкиСерогоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void изменитьЯркостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Brightness();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void резкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Sharpness();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void собельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Sobel();
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}