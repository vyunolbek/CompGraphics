namespace Графика
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            фильтрыToolStripMenuItem = new ToolStripMenuItem();
            точечныеToolStripMenuItem = new ToolStripMenuItem();
            инверсияToolStripMenuItem = new ToolStripMenuItem();
            оттенкиСерогоToolStripMenuItem = new ToolStripMenuItem();
            сепияToolStripMenuItem = new ToolStripMenuItem();
            изменитьЯркостьToolStripMenuItem = new ToolStripMenuItem();
            матричныеToolStripMenuItem = new ToolStripMenuItem();
            размытиеToolStripMenuItem = new ToolStripMenuItem();
            фильтрГауссаToolStripMenuItem = new ToolStripMenuItem();
            резкостьToolStripMenuItem = new ToolStripMenuItem();
            соебльToolStripMenuItem = new ToolStripMenuItem();
            резкостьToolStripMenuItem1 = new ToolStripMenuItem();
            операторПрюитаToolStripMenuItem = new ToolStripMenuItem();
            операторШартцаToolStripMenuItem = new ToolStripMenuItem();
            матМорфологияToolStripMenuItem = new ToolStripMenuItem();
            расширениеToolStripMenuItem = new ToolStripMenuItem();
            эрозияToolStripMenuItem = new ToolStripMenuItem();
            открытиеToolStripMenuItem = new ToolStripMenuItem();
            закрытиеToolStripMenuItem = new ToolStripMenuItem();
            градиентToolStripMenuItem = new ToolStripMenuItem();
            глобальныеToolStripMenuItem = new ToolStripMenuItem();
            серыйМирToolStripMenuItem = new ToolStripMenuItem();
            линейноеРастяжениеToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, фильтрыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1003, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(121, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // фильтрыToolStripMenuItem
            // 
            фильтрыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { точечныеToolStripMenuItem, матричныеToolStripMenuItem, матМорфологияToolStripMenuItem, глобальныеToolStripMenuItem });
            фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            фильтрыToolStripMenuItem.Size = new Size(69, 20);
            фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            точечныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { инверсияToolStripMenuItem, оттенкиСерогоToolStripMenuItem, сепияToolStripMenuItem, изменитьЯркостьToolStripMenuItem });
            точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            точечныеToolStripMenuItem.Size = new Size(180, 22);
            точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            инверсияToolStripMenuItem.Size = new Size(174, 22);
            инверсияToolStripMenuItem.Text = "Инверсия";
            инверсияToolStripMenuItem.Click += инверсияToolStripMenuItem_Click;
            // 
            // оттенкиСерогоToolStripMenuItem
            // 
            оттенкиСерогоToolStripMenuItem.Name = "оттенкиСерогоToolStripMenuItem";
            оттенкиСерогоToolStripMenuItem.Size = new Size(174, 22);
            оттенкиСерогоToolStripMenuItem.Text = "Оттенки серого";
            оттенкиСерогоToolStripMenuItem.Click += оттенкиСерогоToolStripMenuItem_Click;
            // 
            // сепияToolStripMenuItem
            // 
            сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            сепияToolStripMenuItem.Size = new Size(174, 22);
            сепияToolStripMenuItem.Text = "Сепия";
            сепияToolStripMenuItem.Click += сепияToolStripMenuItem_Click;
            // 
            // изменитьЯркостьToolStripMenuItem
            // 
            изменитьЯркостьToolStripMenuItem.Name = "изменитьЯркостьToolStripMenuItem";
            изменитьЯркостьToolStripMenuItem.Size = new Size(174, 22);
            изменитьЯркостьToolStripMenuItem.Text = "Изменить яркость";
            изменитьЯркостьToolStripMenuItem.Click += изменитьЯркостьToolStripMenuItem_Click;
            // 
            // матричныеToolStripMenuItem
            // 
            матричныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { размытиеToolStripMenuItem, фильтрГауссаToolStripMenuItem, резкостьToolStripMenuItem, соебльToolStripMenuItem, резкостьToolStripMenuItem1, операторПрюитаToolStripMenuItem, операторШартцаToolStripMenuItem });
            матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            матричныеToolStripMenuItem.Size = new Size(180, 22);
            матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            размытиеToolStripMenuItem.Size = new Size(180, 22);
            размытиеToolStripMenuItem.Text = "Размытие";
            размытиеToolStripMenuItem.Click += размытиеToolStripMenuItem_Click;
            // 
            // фильтрГауссаToolStripMenuItem
            // 
            фильтрГауссаToolStripMenuItem.Name = "фильтрГауссаToolStripMenuItem";
            фильтрГауссаToolStripMenuItem.Size = new Size(180, 22);
            фильтрГауссаToolStripMenuItem.Text = "Фильтр Гаусса";
            фильтрГауссаToolStripMenuItem.Click += фильтрГауссаToolStripMenuItem_Click;
            // 
            // резкостьToolStripMenuItem
            // 
            резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            резкостьToolStripMenuItem.Size = new Size(180, 22);
            резкостьToolStripMenuItem.Text = "Резкость";
            резкостьToolStripMenuItem.Click += резкостьToolStripMenuItem_Click;
            // 
            // соебльToolStripMenuItem
            // 
            соебльToolStripMenuItem.Name = "соебльToolStripMenuItem";
            соебльToolStripMenuItem.Size = new Size(180, 22);
            соебльToolStripMenuItem.Text = "Собель";
            соебльToolStripMenuItem.Click += собельToolStripMenuItem_Click;
            // 
            // резкостьToolStripMenuItem1
            // 
            резкостьToolStripMenuItem1.Name = "резкостьToolStripMenuItem1";
            резкостьToolStripMenuItem1.Size = new Size(180, 22);
            резкостьToolStripMenuItem1.Text = "Резкость";
            резкостьToolStripMenuItem1.Click += резкостьToolStripMenuItem1_Click;
            // 
            // операторПрюитаToolStripMenuItem
            // 
            операторПрюитаToolStripMenuItem.Name = "операторПрюитаToolStripMenuItem";
            операторПрюитаToolStripMenuItem.Size = new Size(180, 22);
            операторПрюитаToolStripMenuItem.Text = "Оператор Прюитта";
            операторПрюитаToolStripMenuItem.Click += операторПрюитаToolStripMenuItem_Click;
            // 
            // операторШартцаToolStripMenuItem
            // 
            операторШартцаToolStripMenuItem.Name = "операторШартцаToolStripMenuItem";
            операторШартцаToolStripMenuItem.Size = new Size(180, 22);
            операторШартцаToolStripMenuItem.Text = "Оператор Шарра";
            операторШартцаToolStripMenuItem.Click += операторШартцаToolStripMenuItem_Click;
            // 
            // матМорфологияToolStripMenuItem
            // 
            матМорфологияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { расширениеToolStripMenuItem, эрозияToolStripMenuItem, открытиеToolStripMenuItem, закрытиеToolStripMenuItem, градиентToolStripMenuItem });
            матМорфологияToolStripMenuItem.Name = "матМорфологияToolStripMenuItem";
            матМорфологияToolStripMenuItem.Size = new Size(180, 22);
            матМорфологияToolStripMenuItem.Text = "Мат. морфология";
            // 
            // расширениеToolStripMenuItem
            // 
            расширениеToolStripMenuItem.Name = "расширениеToolStripMenuItem";
            расширениеToolStripMenuItem.Size = new Size(144, 22);
            расширениеToolStripMenuItem.Text = "Расширение";
            расширениеToolStripMenuItem.Click += расширениеToolStripMenuItem_Click;
            // 
            // эрозияToolStripMenuItem
            // 
            эрозияToolStripMenuItem.Name = "эрозияToolStripMenuItem";
            эрозияToolStripMenuItem.Size = new Size(144, 22);
            эрозияToolStripMenuItem.Text = "Эрозия";
            эрозияToolStripMenuItem.Click += эрозияToolStripMenuItem_Click;
            // 
            // открытиеToolStripMenuItem
            // 
            открытиеToolStripMenuItem.Name = "открытиеToolStripMenuItem";
            открытиеToolStripMenuItem.Size = new Size(144, 22);
            открытиеToolStripMenuItem.Text = "Открытие";
            открытиеToolStripMenuItem.Click += открытиеToolStripMenuItem_Click;
            // 
            // закрытиеToolStripMenuItem
            // 
            закрытиеToolStripMenuItem.Name = "закрытиеToolStripMenuItem";
            закрытиеToolStripMenuItem.Size = new Size(144, 22);
            закрытиеToolStripMenuItem.Text = "Закрытие";
            закрытиеToolStripMenuItem.Click += закрытиеToolStripMenuItem_Click;
            // 
            // градиентToolStripMenuItem
            // 
            градиентToolStripMenuItem.Name = "градиентToolStripMenuItem";
            градиентToolStripMenuItem.Size = new Size(144, 22);
            градиентToolStripMenuItem.Text = "Градиент";
            градиентToolStripMenuItem.Click += градиентToolStripMenuItem_Click;
            // 
            // глобальныеToolStripMenuItem
            // 
            глобальныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { серыйМирToolStripMenuItem, линейноеРастяжениеToolStripMenuItem });
            глобальныеToolStripMenuItem.Name = "глобальныеToolStripMenuItem";
            глобальныеToolStripMenuItem.Size = new Size(180, 22);
            глобальныеToolStripMenuItem.Text = "Глобальные";
            // 
            // серыйМирToolStripMenuItem
            // 
            серыйМирToolStripMenuItem.Name = "серыйМирToolStripMenuItem";
            серыйМирToolStripMenuItem.Size = new Size(197, 22);
            серыйМирToolStripMenuItem.Text = "Серый мир";
            серыйМирToolStripMenuItem.Click += серыйМирToolStripMenuItem_Click;
            // 
            // линейноеРастяжениеToolStripMenuItem
            // 
            линейноеРастяжениеToolStripMenuItem.Name = "линейноеРастяжениеToolStripMenuItem";
            линейноеРастяжениеToolStripMenuItem.Size = new Size(197, 22);
            линейноеРастяжениеToolStripMenuItem.Text = "Линейное растяжение";
            линейноеРастяжениеToolStripMenuItem.Click += линейноеРастяжениеToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(188, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(584, 411);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(283, 643);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(404, 27);
            progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(697, 643);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 3;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 786);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem фильтрыToolStripMenuItem;
        private ToolStripMenuItem точечныеToolStripMenuItem;
        private ToolStripMenuItem инверсияToolStripMenuItem;
        private ToolStripMenuItem матричныеToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ProgressBar progressBar1;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private ToolStripMenuItem размытиеToolStripMenuItem;
        private ToolStripMenuItem фильтрГауссаToolStripMenuItem;
        private ToolStripMenuItem оттенкиСерогоToolStripMenuItem;
        private ToolStripMenuItem сепияToolStripMenuItem;
        private ToolStripMenuItem изменитьЯркостьToolStripMenuItem;
        private ToolStripMenuItem резкостьToolStripMenuItem;
        private ToolStripMenuItem соебльToolStripMenuItem;
        private ToolStripMenuItem резкостьToolStripMenuItem1;
        private ToolStripMenuItem операторПрюитаToolStripMenuItem;
        private ToolStripMenuItem операторШартцаToolStripMenuItem;
        private ToolStripMenuItem матМорфологияToolStripMenuItem;
        private ToolStripMenuItem расширениеToolStripMenuItem;
        private ToolStripMenuItem эрозияToolStripMenuItem;
        private ToolStripMenuItem открытиеToolStripMenuItem;
        private ToolStripMenuItem закрытиеToolStripMenuItem;
        private ToolStripMenuItem градиентToolStripMenuItem;
        private ToolStripMenuItem глобальныеToolStripMenuItem;
        private ToolStripMenuItem серыйМирToolStripMenuItem;
        private ToolStripMenuItem линейноеРастяжениеToolStripMenuItem;
    }
}