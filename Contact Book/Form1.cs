namespace Contact_Book
{
    public partial class Form1 : Form
    {

        List<Contact> Contacts = new List<Contact>();

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameBox.Text))
            {
                Contacts.Add(new Contact(NameBox.Text, MailBox.Text, NumberBox.Value));
                MessageBox.Show("Contact added successfully");
            }

            else
            {
                MessageBox.Show("You must enter at least a name to add a contact.");
            }

            NameBox.Text = string.Empty;
            MailBox.Text = string.Empty;
            NumberBox.Value = 0;

            RefreshGrid();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Table.SelectedRows.Count == 1)
            {
                Contact selectedContact = Table.SelectedRows[0].DataBoundItem as Contact;
                Contacts.Remove(selectedContact);
                MessageBox.Show("Contact deleted successfully");
            }

            else
            {
                MessageBox.Show("Please select a row to delete.");
            }

            RefreshGrid();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (Table.SelectedRows.Count == 1)
            {
                Contact selectedContact = Table.SelectedRows[0].DataBoundItem as Contact;

                selectedContact.Mail = MailBox.Text;
                selectedContact.Number = Convert.ToInt32(NumberBox.Value);
            }

            else
            {
                MessageBox.Show("Please select a row to edit.");
            }

            RefreshGrid();

            NameBox.Text = string.Empty;
            MailBox.Text = string.Empty;
            NumberBox.Value = 0;
        }

        public void RefreshGrid()
        {
            Table.DataSource = null;
            Table.DataSource = Contacts;
        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Table.SelectedRows.Count != 1) return;

            if (Table.SelectedRows[0].DataBoundItem is not Contact c) return;

            NameBox.Text = c.Name;
            MailBox.Text = c.Mail;
            NumberBox.Value = c.Number;
        }
    }
}
