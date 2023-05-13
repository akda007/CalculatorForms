using System.ComponentModel;

namespace CalculatorForms {
    public partial class MainForm: Form {
        private Calculator _calculator;

        public MainForm() {
            InitializeComponent();
            _calculator = new Calculator();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            //Asign events
            _calculator.OperationChanged += (o, a) => {
                display_calc.Text = _calculator.Operation;
            };
            _calculator.ResultChanged += (o, a) => {
                display_result.Text = _calculator.Result;
            };
        }

        //Link UI and Code
        private void bt_back_Click(object sender, EventArgs e) => _calculator.SendOperation(Calculator.Operations.Backspace);
        private void bt_eq_Click(object sender, EventArgs e) => _calculator.SendOperation(Calculator.Operations.Equals);
        private void bt_clear_Click(object sender, EventArgs e) => _calculator.SendOperation(Calculator.Operations.Clear);

        private void bt_sum_Click(object sender, EventArgs e) => _calculator.SendOperation(Calculator.Operations.Sum);
        private void bt_sub_Click(object sender, EventArgs e) => _calculator.SendOperation(Calculator.Operations.Sub);
        private void bt_mul_Click(object sender, EventArgs e) => _calculator.SendOperation(Calculator.Operations.Mul);
        private void bt_div_Click(object sender, EventArgs e) => _calculator.SendOperation(Calculator.Operations.Div);
        private void bt_pow_Click(object sender, EventArgs e) => _calculator.SendOperation(Calculator.Operations.Pow);

        private void bt_0_Click(object sender, EventArgs e) => _calculator.SendData("0");
        private void bt_1_Click(object sender, EventArgs e) => _calculator.SendData("1");
        private void bt_2_Click(object sender, EventArgs e) => _calculator.SendData("2");
        private void bt_3_Click(object sender, EventArgs e) => _calculator.SendData("3");
        private void bt_4_Click(object sender, EventArgs e) => _calculator.SendData("4");
        private void bt_5_Click(object sender, EventArgs e) => _calculator.SendData("5");
        private void bt_6_Click(object sender, EventArgs e) => _calculator.SendData("6");
        private void bt_7_Click(object sender, EventArgs e) => _calculator.SendData("7");
        private void bt_8_Click(object sender, EventArgs e) => _calculator.SendData("8");
        private void bt_9_Click(object sender, EventArgs e) => _calculator.SendData("9");
        private void bt_dot_Click(object sender, EventArgs e) => _calculator.SendData(".");

        
    }
}