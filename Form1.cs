namespace BankAccountWFA
{
    public partial class Form1 : Form
    {
        private List<BankAccount> _bankAccountsList = new List<BankAccount> ();
        private BankAccount _bankAccountSelected;
        public Form1 ()
        {
            InitializeComponent ();

            BankAccount bankAccount = new BankAccount ("Rafa");
            _bankAccountsList.Add (bankAccount);

            bankAccount = new BankAccount ("Willy");
            _bankAccountsList.Add (bankAccount);

            BankAccountsGrid.DataSource = _bankAccountsList;
            _bankAccountSelected = _bankAccountsList[0];
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
            _bankAccountSelected.Balance += AmountNum.Value;
            RefreshGrid ();
        }

        private void BankAccountsGrid_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            _bankAccountSelected = _bankAccountsList[e.RowIndex];
        }

        private void WithdrawBtn_Click (object sender, EventArgs e)
        {
            _bankAccountSelected.Balance -= AmountNum.Value;
            RefreshGrid ();
        }
    }
}
