using project_2.Algorithm;
using project_2.Array;
using project_2.Logger;

var arrayGenerator = new ArrayGenerator();
var algorithmManager = new AlgorithmManager();
var logger = new Logger();
const int thousand = 1000;

foreach (var algorithmType in Enum.GetValues<AlgorithmType>())
{
    foreach (var arrayValueType in Enum.GetValues<ArrayValueType>())
    {
        RunComplexityForRange(
            10 * thousand,
            100 * thousand,
            10 * thousand,
            algorithmType,
            arrayValueType
        );
    }
}
logger.OutputToFile();

return;

void RunComplexityForRange(
    int min,
    int max,
    int step,
    AlgorithmType algorithmType,
    ArrayValueType arrayValueType
) {
    for (var arrayLength = min; arrayLength <= max; arrayLength+= step)
    {
        var generatedArray = arrayGenerator.Generate(arrayValueType, arrayLength);
        logger.AddEntry(
            algorithmType.ToString(),
            arrayValueType.ToString(),
            arrayLength,
            algorithmManager.GetTimeComplexity(algorithmType, generatedArray)
        );
    }
}