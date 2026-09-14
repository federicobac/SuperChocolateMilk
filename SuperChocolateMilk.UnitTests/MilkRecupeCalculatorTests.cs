using System.Diagnostics;

namespace SuperChocolateMilk.UnitTests;

using Xunit;
using SuperChocolateMilk.Core;

public class MilkRecipeCalculatorTests
{
    [Fact]
    public void CalculateChocolateSyrup_RegularRichness_ReturnsTenPercentRatio()
    {
        //Arrange
        int milkVolume = 1000;
        string richness = "REGULAR";
        
        
        decimal result = MilkRecipeCalculator.CalculateChocolateSyrupRequired(milkVolume, richness);
        
        Assert.Equal(100m, result);
    }

    [Theory]
    [InlineData(1000, "LIGHT", 75)]
    [InlineData(1000, "EXTRA", 150)]
    [InlineData(1000, "ULTRA_CHOCO", 200)]
    [InlineData(0, "REGULAR", 0)]
    public void CalculateChocolateSyrup_VariosScenarios_ReturnsExcpectedAmount(
        int milkVolume, string richness, decimal expectedSyrup)
    {
        //Act
        decimal actualResult = MilkRecipeCalculator.CalculateChocolateSyrupRequired(milkVolume, richness);
        
        //Assert: verify actual matches expected for each row
        Assert.Equal(expectedSyrup, actualResult);
    }
}