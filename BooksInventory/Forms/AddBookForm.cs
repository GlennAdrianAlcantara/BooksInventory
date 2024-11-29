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
using BooksInventory.Controller;
using BooksInventory.DAO;
using BooksInventory.Data;
using BooksInventory.Services;



namespace BooksInventory.Forms
{
    public partial class AddBookForm : Form
    {
        public event Action BookAdded;
        private readonly BooksController _booksController;
        public AddBookForm()
        {
            InitializeComponent();
            var context = new ApplicationDbContext(); // Initialize context
            var booksRepository = new BooksRepository(context); // Initialize repository
            var booksServices = new BooksServices(booksRepository); // Initialize services
            _booksController = new BooksController(booksServices); // Initialize controller
        


    }

        private void titletxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void authortxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptiontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void publishedDATE_ValueChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            {
                string bookTitle = titletxt.Text;
                string bookAuthor = authortxt.Text;
                string bookDescription = descriptiontxt.Text;
                DateTime publishedDate = publishedDATE.Value;  // Assuming publishedDATE is a DateTimePicker

                DateTime createdDate = DateTime.Now; // Set created date

                // Pass book details to controller to add the book
                _booksController.AddBook(bookTitle, bookAuthor, bookDescription, publishedDate, createdDate);

                // Show success message
                MessageBox.Show("Book Added Successfully", "Information");

                // Notify parent form that a book has been added
                BookAdded?.Invoke();

                // Close the form after adding
                this.Close();
            }
        }

        }
    }

