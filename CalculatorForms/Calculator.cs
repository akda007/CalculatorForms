namespace CalculatorForms {

    public class Calculator {

        public enum Operations { Sum, Sub, Mul, Div, Pow, Equals, Backspace, Clear }

        public enum Status { ReadingFirstNumber, ReadingSecondNumber, Waiting }

        //Initialize variables
        private double? firstNumber;

        private double? secondNumber;
        private double? resultNumber;
        private string? _numberStr;

        //Operations History string
        public string Operation { get { return _oprationStr; } }

        private string _oprationStr;

        //Result string
        public string Result { get { return _result; } }

        private string _result;

        private Operations? _operation = null;
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
            _oprationStr = str;
            InvokeOperationChanged();
        }

        //Reset Calculator
        public void Clear() {
            //Set all vars to default
            (firstNumber, secondNumber, resultNumber, _numberStr, _operation, _oprationStr, _result) = (default, default, default, default, default, string.Empty, string.Empty);

            CurrentStatus = Status.ReadingFirstNumber;
            RaiseEvents();
        }

        //Math Logic
        private double Calculate(Operations? op, double? a, double? b) {
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

        //Manage UI/Math Logic
        private void Execute() {
            resultNumber = Calculate(_operation, firstNumber, secondNumber);

            //Cleanup for the next run
            _numberStr = string.Empty;
            _result = resultNumber.ToString();

            CurrentStatus = Status.Waiting;

            //Update UI
            RaiseEvents();
            UpdateOperationString($"{firstNumber} {Utils.GetOperationSymbol(_operation == null ? Operations.Equals : _operation.Value)} {secondNumber} =");
        }

        private void DoOperation(Operations op) {
            if(string.IsNullOrEmpty(_numberStr)) {
                //Logic to recognize negative numbers
                if(op == Operations.Sub && firstNumber == null) {
                    _numberStr = "-";
                    _result = _numberStr;
                    RaiseEvents();
                    return;
                }

                //Logic to handle operations after the first run is completed
                _operation = op;

                CurrentStatus = Status.ReadingSecondNumber;
                UpdateOperationString($"{resultNumber} {Utils.GetOperationSymbol(op)}");
                return;
            }

            //Logic to read and handle the numbers when an operation is pressed
            if(CurrentStatus == Status.ReadingFirstNumber) {
                firstNumber = double.Parse(_numberStr);
                _operation = op;

                CurrentStatus = Status.ReadingSecondNumber;
                UpdateOperationString($"{_numberStr} {Utils.GetOperationSymbol(op)}");
                _numberStr = string.Empty;
            } else if(CurrentStatus == Status.ReadingSecondNumber) {
                secondNumber = double.Parse(_numberStr);

                Execute();

                firstNumber = resultNumber;
                _numberStr = string.Empty;

                CurrentStatus = Status.ReadingFirstNumber;
                _operation = op;
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
                    if(string.IsNullOrEmpty(_numberStr)) {
                        firstNumber = resultNumber;
                    } else {
                        if(resultNumber != null) {
                            firstNumber = resultNumber;
                        }

                        secondNumber = double.Parse(_numberStr);
                    }
                    
                    Execute();
                    return;

                case Operations.Backspace:
                    if(!string.IsNullOrEmpty(_numberStr)) {
                        _numberStr = _numberStr.Remove(_numberStr.Length - 1);
                        _result = _numberStr;
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
                    _numberStr = num;
                    CurrentStatus = Status.ReadingFirstNumber;

                    break;

                default:
                    _numberStr += num;
                    break;
            }
            _result = _numberStr;
            RaiseEvents();
        }

        public Calculator() {
            firstNumber = null;
            secondNumber = null;
            resultNumber = null;
            _result = string.Empty;
            _oprationStr = string.Empty;
            _numberStr = string.Empty;

            CurrentStatus = Status.ReadingFirstNumber;
        }
    }
}