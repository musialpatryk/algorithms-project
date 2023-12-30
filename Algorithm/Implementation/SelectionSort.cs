namespace project_2.Algorithm.Implementation;

public class SelectionSort : IImplementation
{
    public void Execute(int[] array)
    {
        for (var i = 0; i < array.Length - 1; i++) {
            var smallest = i;
            for (var j = i + 1; j < array.Length; j++) {
                if (array[j] < array[smallest]) {
                    smallest = j;
                }
            }
            (array[smallest], array[i]) = (array[i], array[smallest]);
        }
    }
}