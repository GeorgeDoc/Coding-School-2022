using Classes;
using Session_15_EF.Repositories;

namespace EF1 {
    public partial class Menu : Form {

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private List<Transaction> _transactions = new List<Transaction>();

        public Menu(IEntityRepo<Transaction> transactionRepo) {
            InitializeComponent();
            _transactionRepo = _transactionRepo;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            var transTile = textBox1.Text;
            if (string.IsNullOrEmpty(transTile))
                return;
            var transaction = new Transaction() { TotalPrice = 20 }; //too tiredand out of time          
            _transactionRepo.Create(transaction);
            textBox1.Text = String.Empty;
            RefreshTransactions();
        }

        private void Menu_Load(object sender, EventArgs e) {
            RefreshTransactions();
        }

        private void RefreshTransactions() {
            _transactions = _transactionRepo.GetAll();
            gridControl1.DataSource = null;
            gridControl1.DataSource = _transactions;
            gridControl1.Refresh();
            gridControl1.Update();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _transactions;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedTransaction = selectedRow.DataBoundItem as Transaction;
                if (selectedTransaction is not null) {
                    
                    _transactionRepo.Update(selectedTransaction.ID, selectedTransaction);
                    RefreshTransactions();
                }
            }
        }
    }
}