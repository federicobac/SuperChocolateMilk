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

    public static bool IsValidBatchSize(int totalMl)
    {
        return totalMl > 0;
    }

    public static string FormatTankLabel(int tankId, string contents)
    {
        return $"Tank-{tankId}: {contents}";
    }

    public static int CalculateRequiredBottles(int totalVolumeMl)
    {
        return (int)Math.Ceiling(totalVolumeMl / 250.0);
    }
}