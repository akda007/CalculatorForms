namespace CalculatorForms.CalculatorEngine
{
    public class Utils
    {
        private static Dictionary<Operations, string> opDict = new Dictionary<Operations, string>() {
            {Operations.Sub, "-"},
            {Operations.Sum, "+"},
            {Operations.Mul, "*"},
            {Operations.Div, "/"},
            {Operations.Pow, "^"},
            {Operations.Backspace, "⌫"},
            {Operations.Equals, "="},
            {Operations.Clear, "C"}
        };

        public static string GetOperationSymbol(Operations op)
        {
            return opDict[op];
        }
    }
}
