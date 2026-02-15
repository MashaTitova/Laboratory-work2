using Xunit;
using AlgebraicProgressionLibrary;

public class AlgebraicProgressionTests
{
    [Fact]
    public void SequenceGenerator_SimpleProgression_ReturnsCorrectString()
    {
        // Arrange
        double first = 1;
        double diff = 2;
        int count = 4;

        // Act
        string result = AlgebraicProgression.Sequence_generator(first, diff, count);

        // Assert
        Assert.Equal("1 + 3 + 5 + 7", result);
    }

    [Fact] 
    public void ProgressionSum_SimpleCase_ReturnsCorrectSum()
    {
        // Arrange
        double first = 1;
        double diff = 2;
        int count = 4;

        // Act
        double sum = AlgebraicProgression.Progression_Sum(first, diff, count);

        // Assert
        Assert.Equal(16.0, sum, 5); // Точность до 5 знаков
    }

    [Fact]
    public void ProgressionSum_ZeroCount_ReturnsZero()
    {
        // Arrange
        double first = 5;
        double diff = 3;
        int count = 0;

        // Act
        double sum = AlgebraicProgression.Progression_Sum(first, diff, count);

        // Assert
        Assert.Equal(0.0, sum);
    }

    [Fact]
    public void ShowFormula_ReturnsCorrectFormulaString()
    {
        // Arrange
        double first = 2;
        double diff = 3;
        int count = 5;

        // Act
        string formula = AlgebraicProgression.Show_Formula(first, diff, count);

        // Assert
        Assert.Equal("(5 / 2) * (2 * 2 + (5 - 1) * 3)", formula);
    }
}
