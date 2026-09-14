namespace SuperChocolateMilk.Core;

public class RecipeHelpers
{
    public static int CombineVolumes(int VolumeA, int VolumeB)
    {
        return VolumeA + VolumeB;
    }

    public static int LitersToMilliliters(int liters)
    {
        return liters * 1000;
    }

    public static double CalculateMilkWeightGrams(int volumeMl)
    {
        return volumeMl * 1.03;
    }
}