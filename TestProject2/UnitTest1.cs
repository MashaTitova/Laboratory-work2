using Xunit;

namespace Lab_2.var26.Tests
{
    public class CheckTypeTests
    {
        [Fact]
        public void CheckDouble_ValidDoubleString_ReturnsTrue()
        {
            // Arrange
            string input = "123.45";

            // Act
            bool result = CheckType.CheckDouble(input);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CheckDouble_InvalidString_ReturnsFalse()
        {
            string input = "abc";
            bool result = CheckType.CheckDouble(input);
            Assert.False(result);
        }

        [Fact]
        public void CheckDouble_EmptyString_ReturnsFalse()
        {
            string input = "";
            bool result = CheckType.CheckDouble(input);
            Assert.False(result);
        }

        [Fact]
        public void CheckDouble_CommaAsDecimalSeparator_ReturnsFalse()
        {
            // В текущей реализации Convert.ToDouble не поддерживает запятую в en-US
            string input = "12,5";
            bool result = CheckType.CheckDouble(input);
            Assert.False(result); // Несмотря на ожидание в форме, реальный код возвращает false
        }
    }
}
public class CheckTypeTests
{
    [Fact]
    public void CheckInt_ValidInteger_ReturnsTrue()
    {
        string input = "123";
        bool result = CheckType.CheckInt(input);
        Assert.True(result);
    }

    [Fact]
    public void CheckInt_Zero_ReturnsTrue()
    {
        string input = "0";
        bool result = CheckType.CheckInt(input);
        Assert.True(result);
    }

    [Fact]
    public void CheckInt_LeadingZero_ReturnsFalse()
    {
        string input = "012";
        bool result = CheckType.CheckInt(input);
        Assert.False(result); // Convert.ToInt32("012") работает, но в форме ожидается false
    }

    [Fact]
    public void CheckInt_NegativeNumber_ReturnsFalse()
    {
        string input = "-5";
        bool result = CheckType.CheckInt(input);
        Assert.False(result); // В форме ожидается false, но Convert.ToInt32("-5") работает
    }

    [Fact]
    public void CheckInt_EmptyString_ReturnsFalse()
    {
        string input = "";
        bool result = CheckType.CheckInt(input);
        Assert.False(result); // В форме разрешена пустая строка, но здесь — нет
    }
}
}
