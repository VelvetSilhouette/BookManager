using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class AddBookControl : AddbookForm
    {
        private List<Books> bookList;

        public List<Books> NewBook { get; set; } = new List<Books>();

        public AddBookControl(List<Books> bookList)
        {
            InitializeComponent();

            this.bookList = bookList;
        }
        // model class k tao constructor
        // depends, k phai moi class deu can constructor
        // class chua data tu db, class trong List<> k tao contrustor

        // khong
        //tryen qua constructor cua form 2
        // muon form 1 doc nguoc lai thi form 2 tao 1 property r cho form 1 doc tu do
        // khong dung ref
        // chua bang 1 goc
        // dung tabcontrol
        private void addbookbtn_Click(object sender, EventArgs e)
        {
            if (titletxtbx.Text != "" && authortxtb.Text != "" && yearpubtxtbx.Text != "")
            {
                if (!DuplicateBookCheck())
                {
                    NewBook.Add(new Books() { Title = titletxtbx.Text, Author = authortxtb.Text, YearPublished = Convert.ToInt32(yearpubtxtbx.Text) });
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Add Book Successfully", "Message");
                }
                else
                {
                    MessageBox.Show("This book already exist","Duplicate Warning");
                }
            }
            else
            {
                    MessageBox.Show("Add book failed, Please check your data", "Warning"); 
            } 
                
            // cho nay la set dialog cho form
            
        }

        private void yearpubtxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || !char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private bool DuplicateBookCheck()
        {
            foreach (Books e in bookList)
            {
                if (e.Title == titletxtbx.Text && e.Author == authortxtb.Text)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
