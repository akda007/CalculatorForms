using System.Globalization;

namespace CalculatorForms.CalculatorEngine
{
    public enum Operations { Sum, Sub, Mul, Div, Pow, Equals, Backspace, Clear }
    public enum Status { ReadingFirstNumber, ReadingSecondNumber, Waiting }


    public class Calculator {
        //Initialize variables
        private double? firstNumber;

        private double? secondNumber;
        private double? resultNumber;
        private string? currentNumberStr;

        private Logic calculatorLogic;

        //Operations History string
        public string Operation { get { return operationStr; } }
        private string operationStr;

        //Result string
        public string Result { get { return result; } }
        private string result;

        private Operations? operation = null;
        public Status CurrentStatus;

        public event EventHandler OperationChanged;

        public event EventHandler ResultChanged;

        private void InvokeOperationChanged() => OperationChanged?.Invoke(this, EventArgs.Empty);

        private void InvokeResultChanged() => ResultChanged?.Invoke(this, EventArgs.Empty);

        //Raise events to Update GUI
        private void RaiseEvents() {
            InvokeResultChanged();
            InvokeOperationChanged();
        }

        private void UpdateOperationString(string str) {
            operationStr = str;
            InvokeOperationChanged();
        }

        //Reset Calculator
        public void Clear() {
            //Set all vars to default
            (firstNumber, secondNumber, resultNumber, currentNumberStr, operation, operationStr, result) = (default, default, default, default, default, string.Empty, string.Empty);

            CurrentStatus = Status.ReadingFirstNumber;
            RaiseEvents();
        }
        

        //Manage UI/Math Logic
        private void Execute() {
            resultNumber = calculatorLogic.Calculate(operation, firstNumber, secondNumber);

            //Cleanup for the next run
            currentNumberStr = string.Empty;
            result = resultNumber.ToString();

            CurrentStatus = Status.Waiting;

            //Update UI
            RaiseEvents();
            UpdateOperationString($"{firstNumber} {Utils.GetOperationSymbol(operation == null ? Operations.Equals : operation.Value)} {secondNumber} =");
        }

        double ParseNumber(string d) {
            if(double.TryParse(d, NumberStyles.Any, CultureInfo.InvariantCulture, out double val)) {
                return val;
            }
            return 0;
        }

        private void DoOperation(Operations op) {
            if(string.IsNullOrEmpty(currentNumberStr)) {
                //Logic to recognize negative numbers
                if(op == Operations.Sub && firstNumber == null) {
                    currentNumberStr = "-";
                    result = currentNumberStr;
                    RaiseEvents();
                    return;
                }

                //Logic to handle operations after the first run is completed
                operation = op;

                CurrentStatus = Status.ReadingSecondNumber;
                UpdateOperationString($"{resultNumber} {Utils.GetOperationSymbol(op)}");
                return;
            }

            //Logic to read and handle the numbers when an operation is pressed
            if(CurrentStatus == Status.ReadingFirstNumber) {
                firstNumber = ParseNumber(currentNumberStr);
                operation = op;

                CurrentStatus = Status.ReadingSecondNumber;
                UpdateOperationString($"{currentNumberStr} {Utils.GetOperationSymbol(op)}");
                currentNumberStr = string.Empty;
            } else if(CurrentStatus == Status.ReadingSecondNumber) {
                secondNumber = ParseNumber(currentNumberStr);

                Execute();

                firstNumber = resultNumber;
                currentNumberStr = string.Empty;

                CurrentStatus = Status.ReadingFirstNumber;
                operation = op;
            }
        }

        //Method to recieve operations
        public void SendOperation(Operations op) {
            switch(op) {
                //Reset Calculator
                case Operations.Clear:
                    Clear();
                    return;

                case Operations.Equals:
                    if(operation == null && secondNumber == null)
                        return;

                    if(string.IsNullOrEmpty(currentNumberStr)) {
                        firstNumber = resultNumber;
                    } else {
                        if(resultNumber != null) {
                            firstNumber = resultNumber;
                        }

                        secondNumber = ParseNumber(currentNumberStr);
                    }
                    
                    Execute();
                    return;

                case Operations.Backspace:
                    if(!string.IsNullOrEmpty(currentNumberStr)) {
                        currentNumberStr = currentNumberStr.Remove(currentNumberStr.Length - 1);
                        result = currentNumberStr;
                    }
                    RaiseEvents();
                    return;

                default:
                    DoOperation(op);
                    return;
            }
        }

        //Method to recieve data: 1-9 and .
        public void SendData(string num) {
            switch(CurrentStatus) {
                //Logic to restart the calculator if a number
                //is pressed after the first run is complete.
                case Status.Waiting:
                    Clear();
                    currentNumberStr = num;
                    CurrentStatus = Status.ReadingFirstNumber;

                    break;

                default:
                    currentNumberStr += num;
                    break;
            }
            result = currentNumberStr;
            RaiseEvents();
        }

        public Calculator() {
            firstNumber = null;
            secondNumber = null;
            resultNumber = null;
            result = string.Empty;
            operationStr = string.Empty;
            currentNumberStr = string.Empty;

            CurrentStatus = Status.ReadingFirstNumber;
            calculatorLogic = new Logic();
        }
    }
}