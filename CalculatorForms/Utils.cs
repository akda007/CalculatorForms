using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForms {
    public class Utils {
        private static Dictionary<Calculator.Operations, string> opDict = new Dictionary<Calculator.Operations, string>() {
            {Calculator.Operations.Sub, "-"},
            {Calculator.Operations.Sum, "+"},
            {Calculator.Operations.Mul, "*"},
            {Calculator.Operations.Div, "/"},
            {Calculator.Operations.Pow, "^"},
            {Calculator.Operations.Backspace, "⌫"},
            {Calculator.Operations.Equals, "="},
            {Calculator.Operations.Clear, "C"}
        };

        public static string GetOperationSymbol(Calculator.Operations op) {
            return opDict[op];
        }
    }
}
