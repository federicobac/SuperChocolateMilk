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
}