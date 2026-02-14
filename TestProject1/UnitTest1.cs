using Lab_2.var26;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Windows.Forms;

namespace TestArithmeticSequence
{
    [TestClass]
    public class ArithmeticSequenceTests
    {
        private ArithmeticSequence_form form;

        [TestInitialize]
        public void Initialize()
        {
            form = new ArithmeticSequence_form();
            // Инициализация тестовых данных
            form.FirstMember_textBox.Text = "1";
            form.Difference_textBox.Text = "2";
            form.MemberNumber_textBox.Text = "5";
        }

        [TestMethod]
        public void TestCheck_calculate_ability_ValidInput()
        {
            Assert.IsTrue(form.Check_calculate_ability());
        }

        [TestMethod]
        public void TestCheck_calculate_ability_InvalidInput()
        {
            form.FirstMember_textBox.Text = "abc";
            Assert.IsFalse(form.Check_calculate_ability());

            form.FirstMember_textBox.Text = "1";
            form.Difference_textBox.Text = "";
            Assert.IsFalse(form.Check_calculate_ability());
        }

        [TestMethod]
        public void TestCalculate_ValidInput()
        {
            form.Calculate();
            Assert.IsTrue(form.ArithmeticSequence_textBox.Text.Contains("1"));
            Assert.IsTrue(form.ArithmeticSequence_textBox.Text.Contains("3"));
            Assert.IsTrue(form.ArithmeticSequence_textBox.Text.Contains("5"));
            Assert.IsTrue(form.ArithmeticSequence_textBox.Text.Contains("7"));
            Assert.IsTrue(form.ArithmeticSequence_textBox.Text.Contains("9"));
        }

        [TestMethod]
        public void TestCalculateSum_ValidInput()
        {
            form.CulculateSum_button_Click(null, null);
            double expectedSum = 25; // Сумма прогрессии 1, 3, 5, 7, 9
            double actualSum = Convert.ToDouble(form.MemberSum_textBox.Text);
            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        public void TestVisualization_ValidInput()
        {
            // Проверяем, что визуализация не вызывает исключений
            form.ShowVisualizing_button_Click(null, null);
            Assert.IsNotNull(form.ProgressionVisualizing_pictureBox.Image);
        }

        [TestMethod]
        public void TestEnter_Action_ValidInput()
        {
            KeyEventArgs e = new KeyEventArgs(Keys.Enter);
            form.Enter_Action(form.FirstMember_textBox, e);
            Assert.IsTrue(form.CalculateSequence_button.Enabled);
        }

        [TestMethod]
        public void TestEnter_Action_InvalidInput()
        {
            form.FirstMember_textBox.Text = "";
            KeyEventArgs e = new KeyEventArgs(Keys.Enter);
            form.Enter_Action(form.FirstMember_textBox, e);
            Assert.IsFalse(form.CalculateSequence_button.Enabled);
        }

        [TestMethod]
        public void TestCheck_Valididy_ValidInput()
        {
            KeyPressEventArgs e = new KeyPressEventArgs('1');
            form.Check_Valididy(form.FirstMember_textBox, e);
            Assert.AreEqual(Color.White, form.FirstMember_textBox.BackColor);
        }

        [TestMethod]
        public void TestCheck_Valididy_InvalidInput()
        {
            KeyPressEventArgs e = new KeyPressEventArgs('a');
            form.Check_Valididy(form.FirstMember_textBox, e);
            Assert.AreEqual(Color.Red, form.FirstMember_textBox.BackColor);
        }
    }
}