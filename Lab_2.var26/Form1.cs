using AlgebraicProgressionLibrary;
using CheckTypeLibrary;
using System.Runtime.InteropServices.Swift;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

/******************************************************************************
 * Файл: Program.cs
 * Описание: Класс для вывода арифметической прогресии, ее суммы и визуализации с использование графического интерфейса
 * 
 * Автор: Титова Мария
 * Дата создания: 11.02.2026
 * 
 * История изменений:
 *  1.0 (11.02.2026) - Первоначальная версия
 *  1.1 (12.02.2026) - Добавлены функции для вывода суммы прогрессии и формулы 
 *  1.2 (13.02.2026) - Добавлены функции для визуализации прогресии 
 *
 * Использование: Класс предназначен для вывода арифметической прогресии, ее суммы и визуализации с использование графического интерфейса
 *****************************************************************************/

namespace Lab_2.var26
{

    public partial class ArithmeticSequence_form : Form
    {
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public ArithmeticSequence_form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Действие при нажатии кнопки для расчета прогрессии
        /// </summary>
        public void CalculateSequence_button_Click(object sender, EventArgs e)
        {

            Calculate();
        }

        /// <summary>
        /// Проверка правильности формата введенных значений
        /// </summary>
        public void Check_Valididy(object sender, KeyEventArgs e)
        {
            var tmp = (TextBox)sender;
            if ((tmp.Name == "MemberNumber_textBox" && !Regex.IsMatch(tmp.Text, "^(?:[1-9]\\d*|)$"))
             || (tmp.Name != "MemberNumber_textBox" && !Regex.IsMatch(tmp.Text, @"^[+-]?(?:\d+\,?\d*|\,\d+)?$")))
            {
                //Если введенное значение не соотвестствует регулярному выражению поле становится красным и кнопка блокируется
                tmp.BackColor = Color.Red;
                CalculateSequence_button.Enabled = false;
            }
            else
            {
                //Если все значения введены верно кнопка разблокируется
                tmp.BackColor = Color.White;
                if (Check_calculate_ability())
                {
                    CalculateSequence_button.Enabled = true;
                }

            }
        }

        /// <summary>
        /// Проверка правильности типа введенных значений
        /// </summary>
        ///<returns>
        ///True если все поля заполнены правильно
        ///False если хотя бы одно поле не заполнено
        ///</returns>
        public bool Check_calculate_ability()
        {
            return CheckTypeLibrary.Class1.CheckDouble(FirstMember_textBox.Text) &&
                   CheckTypeLibrary.Class1.CheckDouble(Difference_textBox.Text) &&
                   CheckTypeLibrary.Class1.CheckInt(MemberNumber_textBox.Text);

        }

        /// <summary>
        /// Рассчет прогрессии или переход на незаполненное поле при нажатии клавиши Enter
        /// </summary>
        private void Enter_Action(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Check_calculate_ability())
                {
                    Calculate();
                }
                else
                {
                    //Переход фокуса на незаполненное поле
                    if (FirstMember_textBox.Text == "")
                    {
                        FirstMember_textBox.Focus();
                    }
                    else
                    {
                        if (Difference_textBox.Text == "")
                        {
                            Difference_textBox.Focus();
                        }
                        else
                        {
                            if (MemberNumber_textBox.Text == "")
                            {
                                MemberNumber_textBox.Focus();
                            }

                        }

                    }

                }
            }
        }

        /// <summary>
        /// Вывод суммы арифметической прогрессии и формулы или очистка полей
        /// </summary>
        private void CulculateSum_button_Click(object sender, EventArgs e)
        {
            //Если прогрессия была посчитана, то выводим значения суммы и формулу
            //Кнопка меняет свой текст
            if (ArithmeticSequence_textBox.Text != "" && CulculateSum_button.Text == "Рассчитать")
            {

                MemberSum_textBox.Text = Convert.ToString(AlgebraicProgressionLibrary.Class1.Progression_Sum(
                    Convert.ToDouble(FirstMember_textBox.Text),
                    Convert.ToDouble(Difference_textBox.Text),
                    Convert.ToInt32(MemberNumber_textBox.Text)));
                SumFormula_textBox.Text = AlgebraicProgressionLibrary.Class1.Show_Formula(
                    Convert.ToDouble(FirstMember_textBox.Text),
                    Convert.ToDouble(Difference_textBox.Text),
                    Convert.ToInt32(MemberNumber_textBox.Text));
                CulculateSum_button.Text = "Очистить";
            }
            else
            {
                //Очистка полей
                //Кнопка меняет свой текст
                if (CulculateSum_button.Text == "Очистить")
                {
                    MemberSum_textBox.Clear();
                    SumFormula_textBox.Clear();
                    CulculateSum_button.Text = "Рассчитать";
                }
            }
        }

        /// <summary>
        /// Вывод арифметической прогрессии, смена поведения полей и кнопки
        /// </summary>
        public void Calculate()
        {
            if (CalculateSequence_button.Text == "Рассчитать")
            {
                //Выводится прогрессия, поля ввода заблокированы, кнопка сменила текст
                ArithmeticSequence_textBox.Text = AlgebraicProgressionLibrary.Class1.Sequence_generator(
                Convert.ToDouble(FirstMember_textBox.Text),
                Convert.ToDouble(Difference_textBox.Text),
                Convert.ToInt32(MemberNumber_textBox.Text));
                CalculateSequence_button.Text = "Очистить";
                FirstMember_textBox.ReadOnly = true;
                Difference_textBox.ReadOnly = true;
                MemberNumber_textBox.ReadOnly = true;

            }
            else
            {
                //Поля ввода очищены и разблокированы, кнопка сменила текст
                FirstMember_textBox.ReadOnly = false;
                Difference_textBox.ReadOnly = false;
                MemberNumber_textBox.ReadOnly = false;
                FirstMember_textBox.Clear();
                Difference_textBox.Clear();
                MemberNumber_textBox.Clear();
                ArithmeticSequence_textBox.Clear();
                CalculateSequence_button.Enabled = false;
                CalculateSequence_button.Text = "Рассчитать";

            }

        }

        /// <summary>
        /// Вывод арифметической прогрессии, смена поведения полей и кнопки
        /// </summary>
        private void ShowVisualizing_button_Click(object sender, EventArgs e)
        {
            // Создаем новый объект Random
            Random random = new Random();

            // Получаем массив чисел
            double[] progression_mass = AlgebraicProgressionLibrary.Global.numbers;

            // Создаем новый Bitmap для визуализации
            Bitmap bitmap = new Bitmap(ProgressionVisualizing_pictureBox.Width,
                                      ProgressionVisualizing_pictureBox.Height);
            Graphics g = Graphics.FromImage(bitmap);

            // Проверяем, что массив не пустой
            if (ArithmeticSequence_textBox.Text != "" && ShowVisualizing_button.Text == "Показать")
            {
                // Параметры отрисовки
                int x = 50;
                int y = ProgressionVisualizing_pictureBox.Height; // Начинаем снизу
                int maxHeight = (int)progression_mass.Max(); // Находим максимальное значение

                // Очищаем графическую поверхность
                g.Clear(Color.White);

                for (int i = 0; i < progression_mass.Length; i++)
                {
                    // Рассчитываем высоту прямоугольника относительно максимального значения
                    int height = (int)(Math.Abs(progression_mass[i]) / (double)maxHeight *
                                      (ProgressionVisualizing_pictureBox.Height - 10));
                    int width = ProgressionVisualizing_pictureBox.Height / 2 / progression_mass.Length;

                    // Создаем прямоугольник
                    Rectangle rect = new Rectangle(
                        x,
                        y - height, // Отрисовываем снизу вверх
                        width,
                        height
                    );

                    // Генерируем случайный цвет
                    Color randomColor = Color.FromArgb(
                        random.Next(256),
                        random.Next(256),
                        random.Next(256)
                    );
                    // Устанавливаем цвет заливки
                    SolidBrush Brush = new SolidBrush(randomColor);

                    // Рисуем прямоугольник
                    g.FillRectangle(Brush, rect);

                    // Рисуем стрелку
                    if (i != progression_mass.Length - 1)
                    {
                        using (Pen p = new Pen(Brushes.Black, 4f))
                        {
                            // Указать стиль заглушки для конца линии, так как рисуется стрелка, указывающая вправо  
                            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                            // Нарисовать стрелку  
                            g.DrawLine(p, x + width, y - height,
                                x + width + ProgressionVisualizing_pictureBox.Height / 2 / progression_mass.Length, y - height);
                        }
                    }
                    // Перемещаемся вправо
                    x += width + ProgressionVisualizing_pictureBox.Height / 2 / progression_mass.Length; ; // Добавляем отступ между столбцами
                }
                ProgressionVisualizing_pictureBox.Image = bitmap;
                ShowVisualizing_button.Text = "Очистить";
            }
            else
            {
                //Очищение поля
                if (ShowVisualizing_button.Text == "Очистить")
                {
                    g.Clear(Color.White);
                    ProgressionVisualizing_pictureBox.Image = bitmap;
                    ShowVisualizing_button.Text = "Показать";
                }
            }
        }

        /// <summary>
        /// Вызов действия кнопки при нажатии клавиши Enter для визуализации и суммы прогрессии
        /// </summary>
        private void KeyDown(object sender, KeyEventArgs e)
        {
            var tmp = (TabControl)sender;
            if (e.KeyCode == Keys.Enter)
            {
                if (tmp.SelectedTab.Name == "ProgressionSum_tabPage")
                {
                    CulculateSum_button_Click(tmp, e);
                }
                else
                {
                    ShowVisualizing_button_Click(tmp, e);
                }
            }
        }
    }
}

