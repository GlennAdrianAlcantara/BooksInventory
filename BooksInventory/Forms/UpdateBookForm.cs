using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksInventory.Models;

namespace BooksInventory.Forms
{
    public partial class UpdateBookForm : Form
    {
        private BookItem bookItem;

        // Event to notify the parent form that the book has been updated
        public event Action<BookItem> BookUpdated;
        public UpdateBookForm()
        {
            InitializeComponent();
        }
        public UpdateBookForm(BookItem bookItem)
        {
            InitializeComponent();
            this.bookItem = bookItem;

            // Populate the form with the current book details
            titletxt.Text = bookItem.Title;
            authortxt.Text = bookItem.Author;
            descriptiontxt.Text = bookItem.Description;
            publishedDATE.Value = bookItem.PublishedDate;
        }


        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Update the book's details
            bookItem.Title = titletxt.Text;
            bookItem.Author = authortxt.Text;
            bookItem.Description = descriptiontxt.Text;
            bookItem.PublishedDate = publishedDATE.Value;
            bookItem.UpdatedDate = DateTime.Now;  // Automatically update the 'UpdatedDate'

            // Trigger the BookUpdated event
            BookUpdated?.Invoke(bookItem);

            // Close the form after updating
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void titletxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void authortxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateBookForm_Load(object sender, EventArgs e)
        {

        }

        private void descriptiontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void publishedDATE_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
