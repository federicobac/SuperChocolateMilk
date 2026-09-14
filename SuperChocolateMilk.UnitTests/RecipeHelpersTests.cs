using SuperChocolateMilk.Core;

namespace SuperChocolateMilk.UnitTests;

public class RecipeHelpersTests
{
    [Fact]
    public void CombineVolumes_TwoPositiveVolumes_ReturnsSum()
    {
        //Arrange
        int volumeA = 250;
        int volumeB = 750;
        
        //Act
        int result = RecipeHelpers.CombineVolumes(volumeA, volumeB);
        
        //Assert
        Assert.Equal(1000, result);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1000)]
    [InlineData(2, 2000)]
    [InlineData(5, 5000)]
    public void LitersToMilliliters_VariousLiters_ReturnsConvertedMilliliters(int liters, int expected)
    {
        //Act
        int result = RecipeHelpers.LitersToMilliliters(liters);

        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CalculateMilkWeightGrams_OneLiter_Returns1030Grams()
    {
        //Arrange
        int volumeMl = 1000;
        
        //Act
        double result = RecipeHelpers.CalculateMilkWeightGrams(volumeMl);
        
        //Assert
        Assert.Equal(1030.0, result, precision: 2);
    }
}