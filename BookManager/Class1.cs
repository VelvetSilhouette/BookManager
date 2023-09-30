using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    public class BookListUpdate
    {
        public static void UpdateBookList(ComboBox BkLstBx, List<Books> bookList)
        {
            BkLstBx.DataSource = null;
            BkLstBx.DataSource = bookList;
            BkLstBx.DisplayMember = "Title";
        }
    }
}
