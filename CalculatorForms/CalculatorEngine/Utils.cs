namespace CalculatorForms.CalculatorEngine
{
    public class Utils
    {
        private static Dictionary<Logic.Operations, string> opDict = new Dictionary<Logic.Operations, string>() {
            {Logic.Operations.Sub, "-"},
            {Logic.Operations.Sum, "+"},
            {Logic.Operations.Mul, "*"},
            {Logic.Operations.Div, "/"},
            {Logic.Operations.Pow, "^"},
            {Logic.Operations.Backspace, "⌫"},
            {Logic.Operations.Equals, "="},
            {Logic.Operations.Clear, "C"}
        };

        public static string GetOperationSymbol(Logic.Operations op)
        {
            return opDict[op];
        }
    }
}
