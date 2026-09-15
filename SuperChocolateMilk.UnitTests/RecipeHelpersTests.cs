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

    [Theory]
    [InlineData(1, true)]
    [InlineData(100, true)]
    [InlineData(0, false)]
    [InlineData(-5, false)]
    public void IsValidBatchSize_VariousVolumes_ReturnsExpected(int totalMl, bool expected)
    {
        //Act
        bool result = RecipeHelpers.IsValidBatchSize(totalMl);

        //Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, "Milk", "Tank-1: Milk")]
    [InlineData(42, "Chocolate", "Tank-42: Chocolate")]
    [InlineData(7, "Syrup", "Tank-7: Syrup")]
    [InlineData(8, "", "Tank-8: ")]
    public void FormatTankLabel_VariousInputs_ReturnsFormattedLabel(
        int tankId, string label, string expected)
    {
        string result = RecipeHelpers.FormatTankLabel(tankId, label);
        
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, 0)] // zero
    [InlineData(1, 1)] // just above zero
    [InlineData(250, 1)] // exact multiple
    [InlineData(251, 2)] // just over — catches Ceiling vs truncation bugs
    [InlineData(500, 2)] // exact multiple
    [InlineData(501, 3)] // just over
    [InlineData(750, 3)] // exact
    public void CalculateRequiredBottles_VariousInputs_ReturnsCeiling(
        int totalVolumeMl, int expected)
    {
        int result = RecipeHelpers.CalculateRequiredBottles(totalVolumeMl);
        Assert.Equal(expected, result);
    }


}