namespace BankAccountWFA
{
    public partial class Form1 : Form
    {
        private List<BankAccount> _bankAccountsList = new List<BankAccount> ();        
        public Form1 ()
        {
            InitializeComponent ();

            BankAccount bankAccount = new BankAccount ("Rafa");
            _bankAccountsList.Add (bankAccount);

            bankAccount = new BankAccount ("Willy");
            _bankAccountsList.Add (bankAccount);

            BankAccountsGrid.DataSource = _bankAccountsList;            
        }

        private void CreateAccountBtn_Click (object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty (OwnerTxt.Text))
                return;

            BankAccount bankAccount = new BankAccount (OwnerTxt.Text);
            _bankAccountsList.Add (bankAccount);

            RefreshGrid ();
            OwnerTxt.Text = string.Empty;
        }

        private void RefreshGrid ()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = _bankAccountsList;
        }

        private void DepositBtn_Click (object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount? bankAccountSelected = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string msg = bankAccountSelected.Deposit(AmountNum.Value);
                AmountNum.Value = BankAccount.MinimunAmount;
                RefreshGrid ();
                MessageBox.Show(msg);
            }
        }
        

        private void WithdrawBtn_Click (object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount? bankAccountSelected = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string msg = bankAccountSelected.Withdraw(AmountNum.Value);
                AmountNum.Value = BankAccount.MinimunAmount;
                RefreshGrid ();
                MessageBox.Show (msg);
            }
        }
    }
}
