namespace project_2.Array;

public class ArrayGenerator
{
    private readonly Random _random = new();
    
    public int[] Generate(ArrayValueType valueType, int length)
    {
        var array = new int[length];

        switch (valueType)
        {
            case ArrayValueType.Constant:
                PopulateStatic(array);
                break;
            case ArrayValueType.Ascending:
                PopulateAscending(array);
                break;
            case ArrayValueType.Descending:
                PopulateDescending(array);
                break;
            case ArrayValueType.Random:
                PopulateRandom(array);
                break;
            case ArrayValueType.VShaped:
                PopulateVShaped(array);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(valueType), valueType, null);
        }
        
        return array;
    }

    private void PopulateStatic(int[] arrayToPopulate)
    {
        for (var i = 0; i < arrayToPopulate.Length; i++)
        {
            arrayToPopulate[i] = 1;
        }
    }

    private void PopulateAscending(int[] arrayToPopulate)
    {
        for (var i = 0; i < arrayToPopulate.Length; i++)
        {
            arrayToPopulate[i] = i;
        }
    }

    private void PopulateDescending(int[] arrayToPopulate)
    {
        int count = 0;

        for (var i = arrayToPopulate.Length - 1; i >= 0; i--)
        {
            arrayToPopulate[i] = count++;
        }
    }

    private void PopulateRandom(int[] arrayToPopulate)
    {
        for (var i = arrayToPopulate.Length - 1; i >= 0; i--)
        {
            arrayToPopulate[i] = _random.Next();
        }
    }

    private void PopulateVShaped(int[] arrayToPopulate)
    {
        var count = 0;

        for (var i = arrayToPopulate.Length / 2; i > 0; i--)
        {
            arrayToPopulate[count++] = i;
        }

        for (var i = 0; i < arrayToPopulate.Length / 2; i++)
        {
            arrayToPopulate[count++] = i;
        }
    }
}