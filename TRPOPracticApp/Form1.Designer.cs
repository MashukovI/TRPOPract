namespace TRPOPracticApp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Vj_textBox = new TextBox();
            Pj_bol_textBox = new TextBox();
            pj_mal_textBox = new TextBox();
            Muj_textBox = new TextBox();
            dk_textBox = new TextBox();
            a_textBox = new TextBox();
            nf_textBox = new TextBox();
            dvh_textBox = new TextBox();
            np_textBox = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            labelOmegae = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            textBoxD = new TextBox();
            textBoxd0 = new TextBox();
            textBoxf = new TextBox();
            textBoxKf = new TextBox();
            textBoxNf = new TextBox();
            textBoxAf = new TextBox();
            textBoxR = new TextBox();
            textBoxH = new TextBox();
            textBoxNfreal = new TextBox();
            textBoxNfr = new TextBox();
            textBoxNfrreal = new TextBox();
            textBoxOmegae = new TextBox();
            textBoxVfreal = new TextBox();
            textBoxVf = new TextBox();
            pictureBox1 = new PictureBox();
            Raschet = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 15);
            label1.TabIndex = 0;
            label1.Text = "Общий расход воды на орошение Vж, м3/с:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 9);
            label2.Name = "label2";
            label2.Size = new Size(304, 15);
            label2.TabIndex = 1;
            label2.Text = "Избыточное давление воды перед форсункой Рж, Па:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 9);
            label3.Name = "label3";
            label3.Size = new Size(233, 15);
            label3.TabIndex = 2;
            label3.Text = "Плотность воды на орошение ρж, кг/м3:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 53);
            label4.Name = "label4";
            label4.Size = new Size(304, 15);
            label4.TabIndex = 3;
            label4.Text = "Коэффициент динамической вязкости воды µж, Па*с:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 54);
            label5.Name = "label5";
            label5.Size = new Size(254, 15);
            label5.TabIndex = 4;
            label5.Text = "Диаметр капель распыливаемой воды dк, м:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(578, 98);
            label6.Name = "label6";
            label6.Size = new Size(239, 15);
            label6.TabIndex = 5;
            label6.Text = "Угол раскрытия факела форсунки α, град:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 98);
            label7.Name = "label7";
            label7.Size = new Size(263, 15);
            label7.TabIndex = 6;
            label7.Text = "Число входных каналов вихревой камеры nф:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(281, 98);
            label8.Name = "label8";
            label8.Size = new Size(291, 15);
            label8.TabIndex = 7;
            label8.Text = "Диаметр входного канала вихревой камеры dвх, м:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(582, 54);
            label9.Name = "label9";
            label9.Size = new Size(155, 15);
            label9.TabIndex = 8;
            label9.Text = "Число рядов форсунок np:";
            // 
            // Vj_textBox
            // 
            Vj_textBox.Location = new Point(12, 27);
            Vj_textBox.Name = "Vj_textBox";
            Vj_textBox.Size = new Size(251, 23);
            Vj_textBox.TabIndex = 9;
            Vj_textBox.TextChanged += Vj_textBox_TextChanged;
            // 
            // Pj_bol_textBox
            // 
            Pj_bol_textBox.Location = new Point(269, 27);
            Pj_bol_textBox.Name = "Pj_bol_textBox";
            Pj_bol_textBox.Size = new Size(304, 23);
            Pj_bol_textBox.TabIndex = 10;
            // 
            // pj_mal_textBox
            // 
            pj_mal_textBox.Location = new Point(579, 27);
            pj_mal_textBox.Name = "pj_mal_textBox";
            pj_mal_textBox.Size = new Size(233, 23);
            pj_mal_textBox.TabIndex = 11;
            // 
            // Muj_textBox
            // 
            Muj_textBox.Location = new Point(12, 71);
            Muj_textBox.Name = "Muj_textBox";
            Muj_textBox.Size = new Size(304, 23);
            Muj_textBox.TabIndex = 12;
            // 
            // dk_textBox
            // 
            dk_textBox.Location = new Point(322, 72);
            dk_textBox.Name = "dk_textBox";
            dk_textBox.Size = new Size(254, 23);
            dk_textBox.TabIndex = 13;
            // 
            // a_textBox
            // 
            a_textBox.Location = new Point(578, 116);
            a_textBox.Name = "a_textBox";
            a_textBox.Size = new Size(234, 23);
            a_textBox.TabIndex = 14;
            // 
            // nf_textBox
            // 
            nf_textBox.Location = new Point(12, 116);
            nf_textBox.Name = "nf_textBox";
            nf_textBox.Size = new Size(263, 23);
            nf_textBox.TabIndex = 15;
            // 
            // dvh_textBox
            // 
            dvh_textBox.Location = new Point(281, 116);
            dvh_textBox.Name = "dvh_textBox";
            dvh_textBox.Size = new Size(291, 23);
            dvh_textBox.TabIndex = 16;
            // 
            // np_textBox
            // 
            np_textBox.Location = new Point(582, 71);
            np_textBox.Name = "np_textBox";
            np_textBox.Size = new Size(155, 23);
            np_textBox.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(381, 176);
            label10.Name = "label10";
            label10.Size = new Size(172, 15);
            label10.TabIndex = 38;
            label10.Text = "Высота камеры закручивания";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 440);
            label11.Name = "label11";
            label11.Size = new Size(226, 15);
            label11.TabIndex = 37;
            label11.Text = "Внутренний диаметр камеры форсунки";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 176);
            label12.Name = "label12";
            label12.Size = new Size(363, 15);
            label12.TabIndex = 36;
            label12.Text = "Эксцентриситет между входным патрубком и соплом форсунки";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 264);
            label13.Name = "label13";
            label13.Size = new Size(244, 15);
            label13.TabIndex = 35;
            label13.Text = "Геометрическая характеристика форсунки";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 352);
            label14.Name = "label14";
            label14.Size = new Size(188, 15);
            label14.TabIndex = 34;
            label14.Text = "Коэффициент заполнения сопла";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 396);
            label15.Name = "label15";
            label15.Size = new Size(169, 15);
            label15.TabIndex = 33;
            label15.Text = "Диаметр выходного отвестия";
            // 
            // labelOmegae
            // 
            labelOmegae.AutoSize = true;
            labelOmegae.Location = new Point(206, 352);
            labelOmegae.Name = "labelOmegae";
            labelOmegae.Size = new Size(218, 15);
            labelOmegae.TabIndex = 32;
            labelOmegae.Text = "Эквивалентная скорость воды в сопле";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(12, 308);
            label17.Name = "label17";
            label17.Size = new Size(291, 15);
            label17.TabIndex = 39;
            label17.Text = "Коэффициент расхода воды через сопло форсунки";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(187, 396);
            label18.Name = "label18";
            label18.Size = new Size(211, 15);
            label18.TabIndex = 51;
            label18.Text = "Уточненный расход воды на аппарат";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(262, 264);
            label19.Name = "label19";
            label19.Size = new Size(231, 15);
            label19.TabIndex = 50;
            label19.Text = "Уточненное число форсунок на аппарат";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(309, 308);
            label20.Name = "label20";
            label20.Size = new Size(189, 15);
            label20.TabIndex = 49;
            label20.Text = "Точное число форсунок на 1 ряд";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(312, 220);
            label21.Name = "label21";
            label21.Size = new Size(235, 15);
            label21.TabIndex = 48;
            label21.Text = "Число форсунок, приходящихся на 1 ряд";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(12, 220);
            label22.Name = "label22";
            label22.Size = new Size(294, 15);
            label22.TabIndex = 47;
            label22.Text = "Общее расчетное количество форсунок на аппарат";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(244, 440);
            label23.Name = "label23";
            label23.Size = new Size(158, 15);
            label23.TabIndex = 46;
            label23.Text = "Расход воды на 1 форсунку";
            // 
            // textBoxD
            // 
            textBoxD.Location = new Point(12, 458);
            textBoxD.Name = "textBoxD";
            textBoxD.ReadOnly = true;
            textBoxD.Size = new Size(226, 23);
            textBoxD.TabIndex = 52;
            // 
            // textBoxd0
            // 
            textBoxd0.Location = new Point(12, 414);
            textBoxd0.Name = "textBoxd0";
            textBoxd0.ReadOnly = true;
            textBoxd0.Size = new Size(169, 23);
            textBoxd0.TabIndex = 53;
            // 
            // textBoxf
            // 
            textBoxf.Location = new Point(12, 370);
            textBoxf.Name = "textBoxf";
            textBoxf.ReadOnly = true;
            textBoxf.Size = new Size(188, 23);
            textBoxf.TabIndex = 54;
            // 
            // textBoxKf
            // 
            textBoxKf.Location = new Point(12, 326);
            textBoxKf.Name = "textBoxKf";
            textBoxKf.ReadOnly = true;
            textBoxKf.Size = new Size(291, 23);
            textBoxKf.TabIndex = 55;
            // 
            // textBoxNf
            // 
            textBoxNf.Location = new Point(12, 238);
            textBoxNf.Name = "textBoxNf";
            textBoxNf.ReadOnly = true;
            textBoxNf.Size = new Size(294, 23);
            textBoxNf.TabIndex = 56;
            // 
            // textBoxAf
            // 
            textBoxAf.Location = new Point(12, 282);
            textBoxAf.Name = "textBoxAf";
            textBoxAf.ReadOnly = true;
            textBoxAf.Size = new Size(244, 23);
            textBoxAf.TabIndex = 57;
            // 
            // textBoxR
            // 
            textBoxR.Location = new Point(12, 194);
            textBoxR.Name = "textBoxR";
            textBoxR.ReadOnly = true;
            textBoxR.Size = new Size(363, 23);
            textBoxR.TabIndex = 58;
            // 
            // textBoxH
            // 
            textBoxH.Location = new Point(381, 194);
            textBoxH.Name = "textBoxH";
            textBoxH.ReadOnly = true;
            textBoxH.Size = new Size(172, 23);
            textBoxH.TabIndex = 59;
            // 
            // textBoxNfreal
            // 
            textBoxNfreal.Location = new Point(309, 326);
            textBoxNfreal.Name = "textBoxNfreal";
            textBoxNfreal.ReadOnly = true;
            textBoxNfreal.Size = new Size(189, 23);
            textBoxNfreal.TabIndex = 60;
            // 
            // textBoxNfr
            // 
            textBoxNfr.Location = new Point(312, 238);
            textBoxNfr.Name = "textBoxNfr";
            textBoxNfr.ReadOnly = true;
            textBoxNfr.Size = new Size(235, 23);
            textBoxNfr.TabIndex = 61;
            // 
            // textBoxNfrreal
            // 
            textBoxNfrreal.Location = new Point(262, 282);
            textBoxNfrreal.Name = "textBoxNfrreal";
            textBoxNfrreal.ReadOnly = true;
            textBoxNfrreal.Size = new Size(228, 23);
            textBoxNfrreal.TabIndex = 62;
            // 
            // textBoxOmegae
            // 
            textBoxOmegae.Location = new Point(206, 370);
            textBoxOmegae.Name = "textBoxOmegae";
            textBoxOmegae.ReadOnly = true;
            textBoxOmegae.Size = new Size(218, 23);
            textBoxOmegae.TabIndex = 63;
            // 
            // textBoxVfreal
            // 
            textBoxVfreal.Location = new Point(190, 414);
            textBoxVfreal.Name = "textBoxVfreal";
            textBoxVfreal.ReadOnly = true;
            textBoxVfreal.Size = new Size(208, 23);
            textBoxVfreal.TabIndex = 64;
            // 
            // textBoxVf
            // 
            textBoxVf.Location = new Point(244, 458);
            textBoxVf.Name = "textBoxVf";
            textBoxVf.ReadOnly = true;
            textBoxVf.Size = new Size(158, 23);
            textBoxVf.TabIndex = 65;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Farsunka;
            pictureBox1.Location = new Point(559, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 347);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Raschet
            // 
            Raschet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Raschet.Location = new Point(438, 355);
            Raschet.Name = "Raschet";
            Raschet.Size = new Size(115, 126);
            Raschet.TabIndex = 67;
            Raschet.Text = "Рассчитать";
            Raschet.UseVisualStyleBackColor = true;
            Raschet.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 498);
            Controls.Add(Raschet);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxVf);
            Controls.Add(textBoxVfreal);
            Controls.Add(textBoxOmegae);
            Controls.Add(textBoxNfrreal);
            Controls.Add(textBoxNfr);
            Controls.Add(textBoxNfreal);
            Controls.Add(textBoxH);
            Controls.Add(textBoxR);
            Controls.Add(textBoxAf);
            Controls.Add(textBoxNf);
            Controls.Add(textBoxKf);
            Controls.Add(textBoxf);
            Controls.Add(textBoxd0);
            Controls.Add(textBoxD);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label17);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(labelOmegae);
            Controls.Add(np_textBox);
            Controls.Add(dvh_textBox);
            Controls.Add(nf_textBox);
            Controls.Add(a_textBox);
            Controls.Add(dk_textBox);
            Controls.Add(Muj_textBox);
            Controls.Add(pj_mal_textBox);
            Controls.Add(Pj_bol_textBox);
            Controls.Add(Vj_textBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Расчет центробежной форсунки для аппаратов ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox Vj_textBox;
        private TextBox Pj_bol_textBox;
        private TextBox pj_mal_textBox;
        private TextBox Muj_textBox;
        private TextBox dk_textBox;
        private TextBox a_textBox;
        private TextBox nf_textBox;
        private TextBox dvh_textBox;
        private TextBox np_textBox;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label labelOmegae;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private TextBox textBoxD;
        private TextBox textBoxd0;
        private TextBox textBoxf;
        private TextBox textBoxKf;
        private TextBox textBoxNf;
        private TextBox textBoxAf;
        private TextBox textBoxR;
        private TextBox textBoxH;
        private TextBox textBoxNfreal;
        private TextBox textBoxNfr;
        private TextBox textBoxNfrreal;
        private TextBox textBoxOmegae;
        private TextBox textBoxVfreal;
        private TextBox textBoxVf;
        private PictureBox pictureBox1;
        private Button Raschet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}