namespace BankAccountWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            List<BankAccount> bankAccountsList = new List<BankAccount> ();
            BankAccount bankAccount = new BankAccount ("Rafa");
            //bankAccount.Owner = "Rafa";
            //bankAccount.AccountNumber = Guid.NewGuid ();
            //bankAccount.Balance = 10000;
            bankAccountsList.Add (bankAccount);

            bankAccount = new BankAccount ("Willy");
            //bankAccount.Owner = "Willy";
            //bankAccount.AccountNumber = Guid.NewGuid ();
            //bankAccount.Balance = 700;

            bankAccountsList.Add (bankAccount);
            BankAccountsGrid.DataSource = bankAccountsList;
        }
    }
}
