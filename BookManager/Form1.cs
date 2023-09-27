using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace BookManager
{
    public partial class Form1 : Form
    {

        private List<Books> bookList = new List<Books>();

        public Form1()
        {
            InitializeComponent();
            bookList.Add(new Books() { Title = "Testbook1", Author = "Author1", YearPublished = 1111 });
            bookList.Add(new Books() { Title = "Testbook2", Author = "Author2", YearPublished = 2222 });
            bookList.Add(new Books() { Title = "Testbook3", Author = "Author3", YearPublished = 3333 });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBookControl addBookControl = new AddBookControl(bookList);
            addBookControl.ShowDialog(); // cho nay la hien dialog

            // sau khi co dialogresult roi thi xu li neu dialogresult = ok
            if (addBookControl.DialogResult == DialogResult.OK)
            {
                bookList.Add(addBookControl.NewBook[addBookControl.NewBook.Count - 1]);
            }
        }

        private void ShwAllBtn_Click(object sender, EventArgs e)
        {
            BkLstBx.DataSource = null;
            BkLstBx.DataSource = bookList;
            BkLstBx.DisplayMember = "Title";

        }

        private void BkLstBx_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            BookInfo.Items.Clear();
            if (comboBox.SelectedValue != null)
            {
                var SelectedBook = comboBox.SelectedValue as Books;
                ListViewItem Book1 = new ListViewItem();
                Book1.Text = SelectedBook.Title;
                Book1.SubItems.Add(SelectedBook.Author);
                Book1.SubItems.Add(Convert.ToString(SelectedBook.YearPublished));
                BookInfo.Items.Add(Book1);

            }



        }

        private void FndBkBtn_Click(object sender, EventArgs e)
        {

        }
    } //ket qua tra ve sau khi hien ShowDialog


    public partial class AddbookForm : Form
    {
        public AddbookForm()
        {
            ShowInTaskbar = true;

        }
    }
}

