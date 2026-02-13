/******************************************************************************
 * Файл: Program.cs
 * Описание: Класс для проверки соответствия введенного значения определенному типу данных
 * 
 * Автор: Титова Мария
 * Дата создания: 11.02.2026
 * 
 * История изменений:
 *  1.0 (11.02.2026) - Первоначальная версия
 *  1.1 (12.02.2026) - Добавлена функция для типа Int
 *
 * Использование: Класс предназначен для вывода информации о соответствии введенного значения определенному типу данных
 *****************************************************************************/

namespace CheckTypeLibrary
{
    public class Class1
    {

        /// <summary>
        /// Проверка на соответствие типу Double
        /// </summary>
        /// <param name="num">Проверяемое значение</param>
        /// <returns>
        /// true если возможно перевести значение в тип Double, 
        /// false если нельзя
        /// </returns>
        /// <exception cref="FormatException">
        /// Возникает при несоответствии значения типу Double
        /// </exception>
        public static bool CheckDouble(string num)
        {
            try
            {
                Convert.ToDouble(num);
            }
            catch (FormatException)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Проверка на соответствие типу Int
        /// </summary>
        /// <param name="num">Проверяемое значение</param>
        /// <returns>
        /// true если возможно перевести значение в тип Int, 
        /// false если нельзя
        /// </returns>
        /// <exception cref="FormatException">
        /// Возникает при несоответствии значения типу Int
        /// </exception>
        public static bool CheckInt(string num)
        {
            try
            {
                Convert.ToInt32(num);
            }
            catch (FormatException)
            {
                return false;
            }
            return true;
        }
    }
}
