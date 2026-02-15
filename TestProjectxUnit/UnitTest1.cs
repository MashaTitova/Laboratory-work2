using Xunit;
using CheckTypeLibrary;

public class CheckTypeTests
{
    [Fact]
    public void CheckDouble_ValidDouble_ReturnsTrue()
    {
        // Arrange
        string validDouble = "3,14";

        // Act
        bool result = CheckType.CheckDouble(validDouble);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckDouble_InvalidString_ReturnsFalse()
    {
        // Arrange
        string invalidString = "abc";

        // Act
        bool result = CheckType.CheckDouble(invalidString);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckDouble_EmptyString_ReturnsFalse()
    {
        // Arrange
        string emptyString = "";

        // Act
        bool result = CheckType.CheckDouble(emptyString);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckInt_ValidInteger_ReturnsTrue()
    {
        // Arrange
        string validInt = "42";

        // Act
        bool result = CheckType.CheckInt(validInt);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckInt_InvalidInteger_ReturnsFalse()
    {
        // Arrange
        string invalidInt = "3.14";

        // Act
        bool result = CheckType.CheckInt(invalidInt);

        // Assert
        Assert.False(result);
    }
    
}
