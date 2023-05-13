namespace CalculatorForms {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            display_calc = new Label();
            display_result = new Label();
            buttonGrid = new TableLayoutPanel();
            button1 = new Button();
            bt_dot = new Button();
            bt_0 = new Button();
            bt_3 = new Button();
            bt_2 = new Button();
            bt_1 = new Button();
            bt_6 = new Button();
            bt_5 = new Button();
            bt_4 = new Button();
            bt_9 = new Button();
            bt_8 = new Button();
            bt_7 = new Button();
            bt_pow = new Button();
            bt_div = new Button();
            bt_mul = new Button();
            bt_back = new Button();
            bt_sub = new Button();
            bt_sum = new Button();
            bt_eq = new Button();
            buttonGrid.SuspendLayout();
            SuspendLayout();
            // 
            // display_calc
            // 
            display_calc.BackColor = Color.White;
            display_calc.Dock = DockStyle.Top;
            display_calc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            display_calc.Location = new Point(0, 0);
            display_calc.Name = "display_calc";
            display_calc.Size = new Size(322, 30);
            display_calc.TabIndex = 0;
            display_calc.TextAlign = ContentAlignment.MiddleRight;
            // 
            // display_result
            // 
            display_result.BackColor = Color.White;
            display_result.Dock = DockStyle.Top;
            display_result.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            display_result.Location = new Point(0, 30);
            display_result.Name = "display_result";
            display_result.Size = new Size(322, 30);
            display_result.TabIndex = 1;
            display_result.Text = "0";
            display_result.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonGrid
            // 
            buttonGrid.ColumnCount = 4;
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            buttonGrid.Controls.Add(button1, 0, 4);
            buttonGrid.Controls.Add(bt_dot, 2, 4);
            buttonGrid.Controls.Add(bt_0, 1, 4);
            buttonGrid.Controls.Add(bt_3, 2, 3);
            buttonGrid.Controls.Add(bt_2, 1, 3);
            buttonGrid.Controls.Add(bt_1, 0, 3);
            buttonGrid.Controls.Add(bt_6, 2, 2);
            buttonGrid.Controls.Add(bt_5, 1, 2);
            buttonGrid.Controls.Add(bt_4, 0, 2);
            buttonGrid.Controls.Add(bt_9, 2, 1);
            buttonGrid.Controls.Add(bt_8, 1, 1);
            buttonGrid.Controls.Add(bt_7, 0, 1);
            buttonGrid.Controls.Add(bt_pow, 0, 0);
            buttonGrid.Controls.Add(bt_div, 1, 0);
            buttonGrid.Controls.Add(bt_mul, 2, 0);
            buttonGrid.Controls.Add(bt_back, 3, 0);
            buttonGrid.Controls.Add(bt_sub, 3, 1);
            buttonGrid.Controls.Add(bt_sum, 3, 2);
            buttonGrid.Controls.Add(bt_eq, 3, 3);
            buttonGrid.Dock = DockStyle.Fill;
            buttonGrid.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            buttonGrid.Location = new Point(0, 60);
            buttonGrid.Margin = new Padding(1);
            buttonGrid.Name = "buttonGrid";
            buttonGrid.Padding = new Padding(4);
            buttonGrid.RowCount = 5;
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buttonGrid.Size = new Size(322, 281);
            buttonGrid.TabIndex = 2;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(5, 221);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(76, 55);
            button1.TabIndex = 20;
            button1.Text = "C";
            button1.UseVisualStyleBackColor = true;
            // 
            // bt_dot
            // 
            bt_dot.Dock = DockStyle.Fill;
            bt_dot.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_dot.Location = new Point(161, 221);
            bt_dot.Margin = new Padding(1);
            bt_dot.Name = "bt_dot";
            bt_dot.Size = new Size(76, 55);
            bt_dot.TabIndex = 18;
            bt_dot.Text = ".";
            bt_dot.UseVisualStyleBackColor = true;
            bt_dot.Click += bt_dot_Click;
            // 
            // bt_0
            // 
            bt_0.Dock = DockStyle.Fill;
            bt_0.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_0.Location = new Point(83, 221);
            bt_0.Margin = new Padding(1);
            bt_0.Name = "bt_0";
            bt_0.Size = new Size(76, 55);
            bt_0.TabIndex = 17;
            bt_0.Text = "0";
            bt_0.UseVisualStyleBackColor = true;
            bt_0.Click += bt_0_Click;
            // 
            // bt_3
            // 
            bt_3.Dock = DockStyle.Fill;
            bt_3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_3.Location = new Point(161, 167);
            bt_3.Margin = new Padding(1);
            bt_3.Name = "bt_3";
            bt_3.Size = new Size(76, 52);
            bt_3.TabIndex = 15;
            bt_3.Text = "3";
            bt_3.UseVisualStyleBackColor = true;
            bt_3.Click += bt_3_Click;
            // 
            // bt_2
            // 
            bt_2.Dock = DockStyle.Fill;
            bt_2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_2.Location = new Point(83, 167);
            bt_2.Margin = new Padding(1);
            bt_2.Name = "bt_2";
            bt_2.Size = new Size(76, 52);
            bt_2.TabIndex = 14;
            bt_2.Text = "2";
            bt_2.UseVisualStyleBackColor = true;
            bt_2.Click += bt_2_Click;
            // 
            // bt_1
            // 
            bt_1.Dock = DockStyle.Fill;
            bt_1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_1.Location = new Point(5, 167);
            bt_1.Margin = new Padding(1);
            bt_1.Name = "bt_1";
            bt_1.Size = new Size(76, 52);
            bt_1.TabIndex = 13;
            bt_1.Text = "1";
            bt_1.UseVisualStyleBackColor = true;
            bt_1.Click += bt_1_Click;
            // 
            // bt_6
            // 
            bt_6.Dock = DockStyle.Fill;
            bt_6.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_6.Location = new Point(161, 113);
            bt_6.Margin = new Padding(1);
            bt_6.Name = "bt_6";
            bt_6.Size = new Size(76, 52);
            bt_6.TabIndex = 11;
            bt_6.Text = "6";
            bt_6.UseVisualStyleBackColor = true;
            bt_6.Click += bt_6_Click;
            // 
            // bt_5
            // 
            bt_5.Dock = DockStyle.Fill;
            bt_5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_5.Location = new Point(83, 113);
            bt_5.Margin = new Padding(1);
            bt_5.Name = "bt_5";
            bt_5.Size = new Size(76, 52);
            bt_5.TabIndex = 10;
            bt_5.Text = "5";
            bt_5.UseVisualStyleBackColor = true;
            bt_5.Click += bt_5_Click;
            // 
            // bt_4
            // 
            bt_4.Dock = DockStyle.Fill;
            bt_4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_4.Location = new Point(5, 113);
            bt_4.Margin = new Padding(1);
            bt_4.Name = "bt_4";
            bt_4.Size = new Size(76, 52);
            bt_4.TabIndex = 9;
            bt_4.Text = "4";
            bt_4.UseVisualStyleBackColor = true;
            bt_4.Click += bt_4_Click;
            // 
            // bt_9
            // 
            bt_9.Dock = DockStyle.Fill;
            bt_9.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_9.Location = new Point(161, 59);
            bt_9.Margin = new Padding(1);
            bt_9.Name = "bt_9";
            bt_9.Size = new Size(76, 52);
            bt_9.TabIndex = 7;
            bt_9.Text = "9";
            bt_9.UseVisualStyleBackColor = true;
            bt_9.Click += bt_9_Click;
            // 
            // bt_8
            // 
            bt_8.Dock = DockStyle.Fill;
            bt_8.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_8.Location = new Point(83, 59);
            bt_8.Margin = new Padding(1);
            bt_8.Name = "bt_8";
            bt_8.Size = new Size(76, 52);
            bt_8.TabIndex = 6;
            bt_8.Text = "8";
            bt_8.UseVisualStyleBackColor = true;
            bt_8.Click += bt_8_Click;
            // 
            // bt_7
            // 
            bt_7.Dock = DockStyle.Fill;
            bt_7.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_7.Location = new Point(5, 59);
            bt_7.Margin = new Padding(1);
            bt_7.Name = "bt_7";
            bt_7.Size = new Size(76, 52);
            bt_7.TabIndex = 5;
            bt_7.Text = "7";
            bt_7.UseVisualStyleBackColor = true;
            bt_7.Click += bt_7_Click;
            // 
            // bt_pow
            // 
            bt_pow.Dock = DockStyle.Fill;
            bt_pow.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_pow.Location = new Point(5, 5);
            bt_pow.Margin = new Padding(1);
            bt_pow.Name = "bt_pow";
            bt_pow.Size = new Size(76, 52);
            bt_pow.TabIndex = 0;
            bt_pow.Text = "^";
            bt_pow.UseVisualStyleBackColor = true;
            bt_pow.Click += bt_pow_Click;
            // 
            // bt_div
            // 
            bt_div.Dock = DockStyle.Fill;
            bt_div.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_div.Location = new Point(83, 5);
            bt_div.Margin = new Padding(1);
            bt_div.Name = "bt_div";
            bt_div.Size = new Size(76, 52);
            bt_div.TabIndex = 2;
            bt_div.Text = "/";
            bt_div.UseVisualStyleBackColor = true;
            bt_div.Click += bt_div_Click;
            // 
            // bt_mul
            // 
            bt_mul.Dock = DockStyle.Fill;
            bt_mul.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_mul.Location = new Point(161, 5);
            bt_mul.Margin = new Padding(1);
            bt_mul.Name = "bt_mul";
            bt_mul.Size = new Size(76, 52);
            bt_mul.TabIndex = 3;
            bt_mul.Text = "*";
            bt_mul.UseVisualStyleBackColor = true;
            bt_mul.Click += bt_mul_Click;
            // 
            // bt_back
            // 
            bt_back.Dock = DockStyle.Fill;
            bt_back.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_back.Location = new Point(239, 5);
            bt_back.Margin = new Padding(1);
            bt_back.Name = "bt_back";
            bt_back.Size = new Size(78, 52);
            bt_back.TabIndex = 4;
            bt_back.Text = "⌫ ";
            bt_back.UseVisualStyleBackColor = true;
            bt_back.Click += bt_back_Click;
            // 
            // bt_sub
            // 
            bt_sub.Dock = DockStyle.Fill;
            bt_sub.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_sub.Location = new Point(239, 59);
            bt_sub.Margin = new Padding(1);
            bt_sub.Name = "bt_sub";
            bt_sub.Size = new Size(78, 52);
            bt_sub.TabIndex = 12;
            bt_sub.Text = "-";
            bt_sub.UseVisualStyleBackColor = true;
            bt_sub.Click += bt_sub_Click;
            // 
            // bt_sum
            // 
            bt_sum.Dock = DockStyle.Fill;
            bt_sum.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_sum.Location = new Point(239, 113);
            bt_sum.Margin = new Padding(1);
            bt_sum.Name = "bt_sum";
            bt_sum.Size = new Size(78, 52);
            bt_sum.TabIndex = 19;
            bt_sum.Text = "+";
            bt_sum.UseVisualStyleBackColor = true;
            bt_sum.Click += bt_sum_Click;
            // 
            // bt_eq
            // 
            bt_eq.Dock = DockStyle.Fill;
            bt_eq.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_eq.Location = new Point(239, 167);
            bt_eq.Margin = new Padding(1);
            bt_eq.Name = "bt_eq";
            buttonGrid.SetRowSpan(bt_eq, 2);
            bt_eq.Size = new Size(78, 109);
            bt_eq.TabIndex = 1;
            bt_eq.Text = "=";
            bt_eq.UseVisualStyleBackColor = true;
            bt_eq.Click += bt_eq_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 341);
            Controls.Add(buttonGrid);
            Controls.Add(display_result);
            Controls.Add(display_calc);
            MinimumSize = new Size(210, 270);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Calculator";
            Load += MainForm_Load;
            buttonGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label display_calc;
        private Label display_result;
        private TableLayoutPanel buttonGrid;
        private Button bt_pow;
        private Button bt_dot;
        private Button bt_0;
        private Button bt_3;
        private Button bt_2;
        private Button bt_1;
        private Button bt_sub;
        private Button bt_6;
        private Button bt_5;
        private Button bt_4;
        private Button bt_9;
        private Button bt_8;
        private Button bt_7;
        private Button bt_eq;
        private Button bt_div;
        private Button bt_mul;
        private Button bt_back;
        private Button bt_sum;
        private Button button1;
    }
}