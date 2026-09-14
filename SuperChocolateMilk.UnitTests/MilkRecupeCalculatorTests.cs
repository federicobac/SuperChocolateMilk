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
}