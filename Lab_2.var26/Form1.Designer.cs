namespace Lab_2.var26
{
    partial class ArithmeticSequence_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArithmeticSequence_form));
            ArithmeticSequence_tabControl = new TabControl();
            Generator_tabPage = new TabPage();
            GeneratorInf_button = new Button();
            MemberNumber_textBox = new TextBox();
            CalculateSequence_button = new Button();
            ArithmeticSequence_textBox = new TextBox();
            Difference_textBox = new TextBox();
            FirstMember_textBox = new TextBox();
            ArithmeticSequence_label = new Label();
            MemberNumber_label = new Label();
            Difference_label = new Label();
            FirstMember_label = new Label();
            ProgressionVisualizing_tabPage = new TabPage();
            VisualizeInf_button = new Button();
            ShowY_button = new Button();
            ShowX_button = new Button();
            ShowVisualizing_button = new Button();
            ProgressionVisualizing_pictureBox = new PictureBox();
            ProgressionVisualizing_label = new Label();
            ProgressionSum_tabPage = new TabPage();
            SumInf_button = new Button();
            CulculateSum_button = new Button();
            MemberSum_textBox = new TextBox();
            SumFormula_textBox = new TextBox();
            MemberSum_label = new Label();
            SumFormula_label = new Label();
            ArithmeticSequence_tabControl.SuspendLayout();
            Generator_tabPage.SuspendLayout();
            ProgressionVisualizing_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProgressionVisualizing_pictureBox).BeginInit();
            ProgressionSum_tabPage.SuspendLayout();
            SuspendLayout();
            // 
            // ArithmeticSequence_tabControl
            // 
            ArithmeticSequence_tabControl.Controls.Add(Generator_tabPage);
            ArithmeticSequence_tabControl.Controls.Add(ProgressionVisualizing_tabPage);
            ArithmeticSequence_tabControl.Controls.Add(ProgressionSum_tabPage);
            ArithmeticSequence_tabControl.Location = new Point(0, 0);
            ArithmeticSequence_tabControl.Name = "ArithmeticSequence_tabControl";
            ArithmeticSequence_tabControl.SelectedIndex = 0;
            ArithmeticSequence_tabControl.ShowToolTips = true;
            ArithmeticSequence_tabControl.Size = new Size(1109, 644);
            ArithmeticSequence_tabControl.TabIndex = 0;
            ArithmeticSequence_tabControl.KeyUp += KeyDown;
            // 
            // Generator_tabPage
            // 
            Generator_tabPage.Controls.Add(GeneratorInf_button);
            Generator_tabPage.Controls.Add(MemberNumber_textBox);
            Generator_tabPage.Controls.Add(CalculateSequence_button);
            Generator_tabPage.Controls.Add(ArithmeticSequence_textBox);
            Generator_tabPage.Controls.Add(Difference_textBox);
            Generator_tabPage.Controls.Add(FirstMember_textBox);
            Generator_tabPage.Controls.Add(ArithmeticSequence_label);
            Generator_tabPage.Controls.Add(MemberNumber_label);
            Generator_tabPage.Controls.Add(Difference_label);
            Generator_tabPage.Controls.Add(FirstMember_label);
            Generator_tabPage.Location = new Point(8, 46);
            Generator_tabPage.Name = "Generator_tabPage";
            Generator_tabPage.Padding = new Padding(3);
            Generator_tabPage.Size = new Size(1093, 590);
            Generator_tabPage.TabIndex = 0;
            Generator_tabPage.Text = "Генератор прогрессии";
            Generator_tabPage.UseVisualStyleBackColor = true;
            // 
            // GeneratorInf_button
            // 
            GeneratorInf_button.Location = new Point(901, 15);
            GeneratorInf_button.Name = "GeneratorInf_button";
            GeneratorInf_button.Size = new Size(182, 78);
            GeneratorInf_button.TabIndex = 19;
            GeneratorInf_button.Text = "Информация";
            GeneratorInf_button.UseVisualStyleBackColor = true;
            GeneratorInf_button.Click += Information;
            // 
            // MemberNumber_textBox
            // 
            MemberNumber_textBox.BorderStyle = BorderStyle.FixedSingle;
            MemberNumber_textBox.Location = new Point(803, 288);
            MemberNumber_textBox.Name = "MemberNumber_textBox";
            MemberNumber_textBox.Size = new Size(200, 39);
            MemberNumber_textBox.TabIndex = 1;
            MemberNumber_textBox.KeyDown += Enter_Action;
            MemberNumber_textBox.KeyUp += Check_Valididy;
            // 
            // CalculateSequence_button
            // 
            CalculateSequence_button.Enabled = false;
            CalculateSequence_button.Location = new Point(71, 460);
            CalculateSequence_button.Name = "CalculateSequence_button";
            CalculateSequence_button.Size = new Size(220, 77);
            CalculateSequence_button.TabIndex = 9;
            CalculateSequence_button.Text = "Рассчитать";
            CalculateSequence_button.UseVisualStyleBackColor = true;
            CalculateSequence_button.Click += CalculateSequence_button_Click;
            // 
            // ArithmeticSequence_textBox
            // 
            ArithmeticSequence_textBox.BorderStyle = BorderStyle.FixedSingle;
            ArithmeticSequence_textBox.Location = new Point(442, 376);
            ArithmeticSequence_textBox.Multiline = true;
            ArithmeticSequence_textBox.Name = "ArithmeticSequence_textBox";
            ArithmeticSequence_textBox.ReadOnly = true;
            ArithmeticSequence_textBox.Size = new Size(561, 189);
            ArithmeticSequence_textBox.TabIndex = 8;
            // 
            // Difference_textBox
            // 
            Difference_textBox.BorderStyle = BorderStyle.FixedSingle;
            Difference_textBox.Location = new Point(803, 207);
            Difference_textBox.Name = "Difference_textBox";
            Difference_textBox.Size = new Size(200, 39);
            Difference_textBox.TabIndex = 6;
            Difference_textBox.KeyDown += Enter_Action;
            Difference_textBox.KeyUp += Check_Valididy;
            // 
            // FirstMember_textBox
            // 
            FirstMember_textBox.BackColor = SystemColors.Window;
            FirstMember_textBox.BorderStyle = BorderStyle.FixedSingle;
            FirstMember_textBox.ForeColor = SystemColors.WindowText;
            FirstMember_textBox.Location = new Point(803, 123);
            FirstMember_textBox.Name = "FirstMember_textBox";
            FirstMember_textBox.Size = new Size(200, 39);
            FirstMember_textBox.TabIndex = 5;
            FirstMember_textBox.KeyDown += Enter_Action;
            FirstMember_textBox.KeyUp += Check_Valididy;
            // 
            // ArithmeticSequence_label
            // 
            ArithmeticSequence_label.AllowDrop = true;
            ArithmeticSequence_label.AutoSize = true;
            ArithmeticSequence_label.BackColor = Color.WhiteSmoke;
            ArithmeticSequence_label.BorderStyle = BorderStyle.FixedSingle;
            ArithmeticSequence_label.Location = new Point(35, 376);
            ArithmeticSequence_label.Name = "ArithmeticSequence_label";
            ArithmeticSequence_label.Size = new Size(336, 34);
            ArithmeticSequence_label.TabIndex = 4;
            ArithmeticSequence_label.Text = "Арифметическая прогрессия";
            // 
            // MemberNumber_label
            // 
            MemberNumber_label.AllowDrop = true;
            MemberNumber_label.AutoSize = true;
            MemberNumber_label.BackColor = Color.WhiteSmoke;
            MemberNumber_label.BorderStyle = BorderStyle.FixedSingle;
            MemberNumber_label.Location = new Point(35, 293);
            MemberNumber_label.Name = "MemberNumber_label";
            MemberNumber_label.Size = new Size(659, 34);
            MemberNumber_label.TabIndex = 3;
            MemberNumber_label.Text = "Введите количество членов арифметической прогрессии";
            // 
            // Difference_label
            // 
            Difference_label.AllowDrop = true;
            Difference_label.AutoSize = true;
            Difference_label.BackColor = Color.WhiteSmoke;
            Difference_label.BorderStyle = BorderStyle.FixedSingle;
            Difference_label.Location = new Point(35, 212);
            Difference_label.Name = "Difference_label";
            Difference_label.Size = new Size(737, 34);
            Difference_label.TabIndex = 2;
            Difference_label.Text = "Введите разность соседних членов арифметической прогрессии";
            // 
            // FirstMember_label
            // 
            FirstMember_label.AllowDrop = true;
            FirstMember_label.AutoSize = true;
            FirstMember_label.BackColor = Color.WhiteSmoke;
            FirstMember_label.BorderStyle = BorderStyle.FixedSingle;
            FirstMember_label.Location = new Point(35, 128);
            FirstMember_label.Name = "FirstMember_label";
            FirstMember_label.Size = new Size(589, 34);
            FirstMember_label.TabIndex = 1;
            FirstMember_label.Text = "Введите первый член арифметической прогрессии";
            // 
            // ProgressionVisualizing_tabPage
            // 
            ProgressionVisualizing_tabPage.BackColor = Color.WhiteSmoke;
            ProgressionVisualizing_tabPage.Controls.Add(VisualizeInf_button);
            ProgressionVisualizing_tabPage.Controls.Add(ShowY_button);
            ProgressionVisualizing_tabPage.Controls.Add(ShowX_button);
            ProgressionVisualizing_tabPage.Controls.Add(ShowVisualizing_button);
            ProgressionVisualizing_tabPage.Controls.Add(ProgressionVisualizing_pictureBox);
            ProgressionVisualizing_tabPage.Controls.Add(ProgressionVisualizing_label);
            ProgressionVisualizing_tabPage.Location = new Point(8, 46);
            ProgressionVisualizing_tabPage.Name = "ProgressionVisualizing_tabPage";
            ProgressionVisualizing_tabPage.Padding = new Padding(3);
            ProgressionVisualizing_tabPage.Size = new Size(1093, 590);
            ProgressionVisualizing_tabPage.TabIndex = 2;
            ProgressionVisualizing_tabPage.Text = "Визуализатор прогрессии";
            // 
            // VisualizeInf_button
            // 
            VisualizeInf_button.Location = new Point(885, 6);
            VisualizeInf_button.Name = "VisualizeInf_button";
            VisualizeInf_button.Size = new Size(182, 78);
            VisualizeInf_button.TabIndex = 18;
            VisualizeInf_button.Text = "Информация";
            VisualizeInf_button.UseVisualStyleBackColor = true;
            VisualizeInf_button.Click += Information;
            // 
            // ShowY_button
            // 
            ShowY_button.Location = new Point(361, 240);
            ShowY_button.Name = "ShowY_button";
            ShowY_button.Size = new Size(78, 78);
            ShowY_button.TabIndex = 17;
            ShowY_button.Text = "y";
            ShowY_button.UseVisualStyleBackColor = true;
            ShowY_button.Click += Information;
            // 
            // ShowX_button
            // 
            ShowX_button.Location = new Point(699, 480);
            ShowX_button.Name = "ShowX_button";
            ShowX_button.Size = new Size(77, 78);
            ShowX_button.TabIndex = 16;
            ShowX_button.Text = "x";
            ShowX_button.UseVisualStyleBackColor = true;
            ShowX_button.Click += Information;
            // 
            // ShowVisualizing_button
            // 
            ShowVisualizing_button.Location = new Point(51, 240);
            ShowVisualizing_button.Name = "ShowVisualizing_button";
            ShowVisualizing_button.Size = new Size(220, 77);
            ShowVisualizing_button.TabIndex = 15;
            ShowVisualizing_button.Text = "Показать";
            ShowVisualizing_button.UseVisualStyleBackColor = true;
            ShowVisualizing_button.Click += ShowVisualizing_button_Click;
            // 
            // ProgressionVisualizing_pictureBox
            // 
            ProgressionVisualizing_pictureBox.BackColor = Color.WhiteSmoke;
            ProgressionVisualizing_pictureBox.Location = new Point(445, 106);
            ProgressionVisualizing_pictureBox.Name = "ProgressionVisualizing_pictureBox";
            ProgressionVisualizing_pictureBox.Size = new Size(569, 368);
            ProgressionVisualizing_pictureBox.TabIndex = 6;
            ProgressionVisualizing_pictureBox.TabStop = false;
            // 
            // ProgressionVisualizing_label
            // 
            ProgressionVisualizing_label.AllowDrop = true;
            ProgressionVisualizing_label.AutoSize = true;
            ProgressionVisualizing_label.BackColor = Color.WhiteSmoke;
            ProgressionVisualizing_label.BorderStyle = BorderStyle.FixedSingle;
            ProgressionVisualizing_label.Location = new Point(51, 106);
            ProgressionVisualizing_label.Name = "ProgressionVisualizing_label";
            ProgressionVisualizing_label.Size = new Size(304, 34);
            ProgressionVisualizing_label.TabIndex = 5;
            ProgressionVisualizing_label.Text = "Визуализация прогрессии";
            // 
            // ProgressionSum_tabPage
            // 
            ProgressionSum_tabPage.Controls.Add(SumInf_button);
            ProgressionSum_tabPage.Controls.Add(CulculateSum_button);
            ProgressionSum_tabPage.Controls.Add(MemberSum_textBox);
            ProgressionSum_tabPage.Controls.Add(SumFormula_textBox);
            ProgressionSum_tabPage.Controls.Add(MemberSum_label);
            ProgressionSum_tabPage.Controls.Add(SumFormula_label);
            ProgressionSum_tabPage.Location = new Point(8, 46);
            ProgressionSum_tabPage.Name = "ProgressionSum_tabPage";
            ProgressionSum_tabPage.Padding = new Padding(3);
            ProgressionSum_tabPage.Size = new Size(1093, 590);
            ProgressionSum_tabPage.TabIndex = 1;
            ProgressionSum_tabPage.Text = "Сумма элементов прогресии";
            ProgressionSum_tabPage.UseVisualStyleBackColor = true;
            // 
            // SumInf_button
            // 
            SumInf_button.Location = new Point(890, 18);
            SumInf_button.Name = "SumInf_button";
            SumInf_button.Size = new Size(182, 78);
            SumInf_button.TabIndex = 19;
            SumInf_button.Text = "Информация";
            SumInf_button.UseVisualStyleBackColor = true;
            SumInf_button.Click += Information;
            // 
            // CulculateSum_button
            // 
            CulculateSum_button.Location = new Point(171, 365);
            CulculateSum_button.Name = "CulculateSum_button";
            CulculateSum_button.Size = new Size(220, 77);
            CulculateSum_button.TabIndex = 14;
            CulculateSum_button.Text = "Рассчитать";
            CulculateSum_button.UseVisualStyleBackColor = true;
            CulculateSum_button.Click += CulculateSum_button_Click;
            // 
            // MemberSum_textBox
            // 
            MemberSum_textBox.BorderStyle = BorderStyle.FixedSingle;
            MemberSum_textBox.Location = new Point(771, 161);
            MemberSum_textBox.Name = "MemberSum_textBox";
            MemberSum_textBox.ReadOnly = true;
            MemberSum_textBox.Size = new Size(241, 39);
            MemberSum_textBox.TabIndex = 13;
            // 
            // SumFormula_textBox
            // 
            SumFormula_textBox.BorderStyle = BorderStyle.FixedSingle;
            SumFormula_textBox.Location = new Point(561, 365);
            SumFormula_textBox.Multiline = true;
            SumFormula_textBox.Name = "SumFormula_textBox";
            SumFormula_textBox.ReadOnly = true;
            SumFormula_textBox.Size = new Size(451, 135);
            SumFormula_textBox.TabIndex = 12;
            // 
            // MemberSum_label
            // 
            MemberSum_label.AllowDrop = true;
            MemberSum_label.AutoSize = true;
            MemberSum_label.BackColor = Color.WhiteSmoke;
            MemberSum_label.BorderStyle = BorderStyle.FixedSingle;
            MemberSum_label.Location = new Point(39, 166);
            MemberSum_label.Name = "MemberSum_label";
            MemberSum_label.Size = new Size(544, 34);
            MemberSum_label.TabIndex = 11;
            MemberSum_label.Text = "Сумма элементов арифметической прогрессии";
            // 
            // SumFormula_label
            // 
            SumFormula_label.AllowDrop = true;
            SumFormula_label.AutoSize = true;
            SumFormula_label.BackColor = Color.WhiteSmoke;
            SumFormula_label.BorderStyle = BorderStyle.FixedSingle;
            SumFormula_label.Location = new Point(39, 263);
            SumFormula_label.Name = "SumFormula_label";
            SumFormula_label.Size = new Size(651, 34);
            SumFormula_label.TabIndex = 9;
            SumFormula_label.Text = "Формула суммы элементов арифметической прогрессии";
            // 
            // ArithmeticSequence_form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1103, 638);
            Controls.Add(ArithmeticSequence_tabControl);
            Name = "ArithmeticSequence_form";
            StartPosition = FormStartPosition.Manual;
            Text = "Arithmetic Sequence";
            ArithmeticSequence_tabControl.ResumeLayout(false);
            Generator_tabPage.ResumeLayout(false);
            Generator_tabPage.PerformLayout();
            ProgressionVisualizing_tabPage.ResumeLayout(false);
            ProgressionVisualizing_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProgressionVisualizing_pictureBox).EndInit();
            ProgressionSum_tabPage.ResumeLayout(false);
            ProgressionSum_tabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl ArithmeticSequence_tabControl;
        private TabPage Generator_tabPage;
        private TabPage ProgressionSum_tabPage;
        private TabPage ProgressionVisualizing_tabPage;
        private Label Difference_label;
        private Label FirstMember_label;
        private Label MemberNumber_label;
        private Label ArithmeticSequence_label;
        private TextBox ArithmeticSequence_textBox;
        private TextBox Difference_textBox;
        private TextBox FirstMember_textBox;
        private Label SumFormula_label;
        private Label MemberSum_label;
        private TextBox MemberSum_textBox;
        private TextBox SumFormula_textBox;
        private PictureBox ProgressionVisualizing_pictureBox;
        private Label ProgressionVisualizing_label;
        private Button CalculateSequence_button;
        private Button CulculateSum_button;
        private TextBox MemberNumber_textBox;
        private Button ShowVisualizing_button;
        private Button ShowY_button;
        private Button ShowX_button;
        private Button VisualizeInf_button;
        private Button GeneratorInf_button;
        private Button SumInf_button;
    }
}
