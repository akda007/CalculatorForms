namespace CalculatorForms.CalculatorEngine {
   
    public class Logic {
        public double Calculate(Operations? op, double? a, double? b) {
            if(a == null || b == null)
                return 0;

            switch(op) {
                case Operations.Sum:
                    return a.Value + b.Value;

                case Operations.Sub:
                    return a.Value - b.Value;

                case Operations.Div:
                    return a.Value / b.Value;

                case Operations.Mul:
                    return a.Value * b.Value;

                case Operations.Pow:
                    return Math.Pow(a.Value, b.Value);
            }

            return 0;
        }

    }
}