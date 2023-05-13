using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForms {
    public class Calculator {
        delegate double MathOp(double a, double b);

        public enum Operations {
            Sum, Sub, Mul, Div, Pow, Equals, Backspace, Clear
        }

        public enum Status {
            WritingNumberA,
            WritingNumberB,
            Waiting,
        }

        private double? firstNumber;
        private double? secondNumber;
        private double? resultNumber;
        private string? _numberStr;

        public string Operation { get { return _operation; } }
        private string _operation;
        private Operations? _op = null;
        public string Result { get { return _result; } }
        private string _result;

        public event EventHandler OperationChanged;
        public event EventHandler ResultChanged;

        public Status CurrentStatus = Status.Waiting;

        private void InvokeOperationChanged() => OperationChanged?.Invoke(this, EventArgs.Empty);
        private void InvokeResultChanged() => ResultChanged?.Invoke(this, EventArgs.Empty);
        private void RaiseEvents() {
            InvokeResultChanged();
            InvokeOperationChanged();
        }

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

        private void Execute() {

            resultNumber = Calculate(_op, firstNumber, secondNumber);
            
            //raise events
            _numberStr = string.Empty;
            _result = resultNumber.ToString();
            _operation = $"{_op.ToString()}({firstNumber}, {secondNumber})";

            CurrentStatus = Status.Waiting;
            RaiseEvents();
        }


        private void MathOperation(Operations op) {

            

            if(string.IsNullOrEmpty(_numberStr)) { //Todo: ao apertar = novamente isso deve ocorrer ao inves de apertar o botao de op
                if(op == Operations.Sub && firstNumber == null) {
                    _numberStr = "-";
                    _result = _numberStr;
                    RaiseEvents();
                    return;
                }

                _op = op;

                CurrentStatus = Status.WritingNumberB;
                return;
            }

            if(CurrentStatus == Status.WritingNumberA) {
                

                firstNumber = double.Parse(_numberStr);
                _op = op;

                CurrentStatus = Status.WritingNumberB;
                _numberStr = string.Empty;
            } else if (CurrentStatus == Status.WritingNumberB) {
                secondNumber = double.Parse(_numberStr);

                Execute();

                firstNumber = resultNumber;
                _numberStr = string.Empty;

                CurrentStatus = Status.WritingNumberA;
                _op = op;
            }            
        }

        public void Clear() {
            (firstNumber, secondNumber, resultNumber, _numberStr, _op, _operation, _result) = (default, default, default, default, default, string.Empty, string.Empty);

            CurrentStatus = Status.WritingNumberA;
            RaiseEvents();
        }

        public void SendOperation(Operations op) {
            switch (op) {
                //Reset Calculator
                case Operations.Clear:
                    Clear();
                    return;

                case Operations.Equals:
                    if (string.IsNullOrEmpty(_numberStr)) {
                        firstNumber = resultNumber;
                    } else {
                        if (resultNumber != null) {
                            firstNumber = resultNumber;
                        }

                        secondNumber = double.Parse(_numberStr);
                    }

                    Execute();
                    return;

                case Operations.Backspace:
                    _numberStr = _numberStr.Remove(_numberStr.Length - 1);
                    _result = _numberStr;
                    RaiseEvents();
                    return;

                default:
                    MathOperation(op);
                    return;
            }

        }

        public void SendData(string num) {

            switch(CurrentStatus) {
                case Status.Waiting:
                    Clear();
                    _numberStr = num;
                    CurrentStatus = Status.WritingNumberA;

                    break;

                default:
                    _numberStr += num;
                    break;
            }
            _result = _numberStr;
            RaiseEvents();
        }

        public Calculator()
        {
            firstNumber = null;
            secondNumber = null;
            resultNumber = null;
            _result = string.Empty;
            _operation = string.Empty;
            _numberStr = string.Empty;

            CurrentStatus = Status.WritingNumberA;
        }
    }
}
