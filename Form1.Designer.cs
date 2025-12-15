namespace BankAccountWFA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            DepositBtn = new Button ();
            WithdrawBtn = new Button ();
            label1 = new Label ();
            label2 = new Label ();
            OwnerTxt = new TextBox ();
            AmountNum = new NumericUpDown ();
            BankAccountsGrid = new DataGridView ();
            CreateAccountBtn = new Button ();
            label3 = new Label ();
            InterestRateNum = new NumericUpDown ();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit ();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).BeginInit ();
            SuspendLayout ();
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point (454, 336);
            DepositBtn.Margin = new Padding (5, 6, 5, 6);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size (129, 46);
            DepositBtn.TabIndex = 0;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point (593, 336);
            WithdrawBtn.Margin = new Padding (5, 6, 5, 6);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size (129, 46);
            WithdrawBtn.TabIndex = 1;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point (20, 22);
            label1.Name = "label1";
            label1.Size = new Size (79, 30);
            label1.TabIndex = 2;
            label1.Text = "Owner:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point (20, 352);
            label2.Name = "label2";
            label2.Size = new Size (93, 30);
            label2.TabIndex = 3;
            label2.Text = "Amount:";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point (106, 17);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size (202, 35);
            OwnerTxt.TabIndex = 4;
            // 
            // AmountNum
            // 
            AmountNum.Increment = new decimal (new int[] { 50, 0, 0, 0 });
            AmountNum.Location = new Point (119, 347);
            AmountNum.Maximum = new decimal (new int[] { 1000000, 0, 0, 0 });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size (201, 35);
            AmountNum.TabIndex = 5;
            AmountNum.Value = new decimal (new int[] { 50, 0, 0, 0 });
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point (340, 17);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.Size = new Size (464, 310);
            BankAccountsGrid.TabIndex = 6;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point (106, 115);
            CreateAccountBtn.Margin = new Padding (5, 6, 5, 6);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size (202, 46);
            CreateAccountBtn.TabIndex = 7;
            CreateAccountBtn.Text = "Create Account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point (106, 69);
            label3.Name = "label3";
            label3.Size = new Size (91, 30);
            label3.TabIndex = 8;
            label3.Text = "Int Rate:";
            // 
            // InterestRateNum
            // 
            InterestRateNum.Location = new Point (248, 64);
            InterestRateNum.Maximum = new decimal (new int[] { 1000000, 0, 0, 0 });
            InterestRateNum.Name = "InterestRateNum";
            InterestRateNum.Size = new Size (60, 35);
            InterestRateNum.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF (12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size (816, 397);
            Controls.Add (InterestRateNum);
            Controls.Add (label3);
            Controls.Add (CreateAccountBtn);
            Controls.Add (BankAccountsGrid);
            Controls.Add (AmountNum);
            Controls.Add (OwnerTxt);
            Controls.Add (label2);
            Controls.Add (label1);
            Controls.Add (WithdrawBtn);
            Controls.Add (DepositBtn);
            Font = new Font ("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding (5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit ();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit ();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).EndInit ();
            ResumeLayout (false);
            PerformLayout ();
        }

        #endregion

        private Button DepositBtn;
        private Button WithdrawBtn;
        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button CreateAccountBtn;
        private Label label3;
        private NumericUpDown InterestRateNum;
    }
}
