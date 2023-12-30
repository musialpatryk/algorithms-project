namespace project_2.Algorithm.Implementation;

public class InsertionSort : IImplementation
{
    public void Execute(int[] array)
    {
        for (var i = 1; i < array.Length; i++)
        {
            var value = array[i];
            for (var j = i - 1; j >= 0;)
            {
                if (value < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                    array[j + 1] = value;
                } 
                else
                {
                    break;
                }
            }
        }
    }
}