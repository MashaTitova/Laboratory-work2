/******************************************************************************
 * Файл: AlgebraicProgression.cs
 * Описание: Класс для работы с арифметической прогрессией
 * 
 * Автор: Титова Мария
 * Дата создания: 12.02.2026
 * 
 * История изменений:
 *  1.0 (12.02.2026) - Первоначальная версия
 *  1.1 (13.02.2026) - Добавлены функции для нахожнения суммы прогрессии и вывода формулы 
 *
 * Использование: Класс предназначен для создания арифметической прогрессии, 
 * нахождения суммы прогрессии и вывода формулв нахождения суммы
 *****************************************************************************/
namespace AlgebraicProgressionLibrary
{
    public class Global
    {
        public static double[] numbers = new double[0];
    }
    public class AlgebraicProgression
    {
        /// <summary>
        /// Составляет арифметическую прогрессию
        /// </summary>
        /// <param name="next_num">Очередное значение последовательности (изначально первое)</param>
        /// <param name="dif">Разность между соседними членами последовательности</param>
        /// <param name="num">Количество членов последовательности</param>
        /// <returns>Арифметическая последовательность в текстовом виде</returns>
        public static string Sequence_generator(double next_num, double dif, int num)
        {
            double[] numbers = new double[num];
            numbers[0] = next_num;
            string result = Convert.ToString(next_num);
            for (int i = 1; i < num; i++) {
                next_num += dif;
                numbers[i] = next_num;
                if(next_num >= 0)
                {
                    result += " + " + Convert.ToString(next_num);
                }
                else
                {
                    result += " - " + Convert.ToString(-next_num);
                }
            }
            Global.numbers = numbers;
            return result;
        }
        /// <summary>
        /// Считает сумму членов арифметической прогрессии
        /// </summary>
        /// <param name="first_num">Первое значение последовательности</param>
        /// <param name="dif">Разность между соседними членами последовательности</param>
        /// <param name="num">Количество членов последовательности</param>
        /// <returns>Сумма членов арифметической прогресии прогрессии</returns>
        public static double Progression_Sum(double first_num, double dif, int num)
        {
            double sum = (num / 2) * (2 * first_num + (num - 1) * dif);
            return sum;
        }
        /// <summary>
        /// Составляет формулу суммы членов арифметической прогрессии для заданных переметров
        /// </summary>
        /// <param name="first_num">Первое значение последовательности</param>
        /// <param name="dif">Разность между соседними членами последовательности</param>
        /// <param name="num">Количество членов последовательности</param>
        /// <returns>Формула суммы членов арифметической прогрессии</returns>
        public static string Show_Formula(double first_num, double dif, int num)
        {
            string formula = ($"({num} / 2) * (2 * {first_num} + ({num} - 1) * {dif})");
            return formula;
        }

    }
}
