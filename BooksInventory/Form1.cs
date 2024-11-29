using BooksInventory.Forms;
using BooksInventory.Controller;
using BooksInventory.DAO;
using BooksInventory.Models;
using BooksInventory.Services;
using BooksInventory.Data;
using static System.Reflection.Metadata.BlobBuilder;







namespace BooksInventory
{
    public partial class Dashboard : Form
    {
        public readonly BooksController _booksController;

        public Dashboard()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var booksRepository = new BooksRepository(context);
            var booksServices = new BooksServices(booksRepository);
            _booksController = new BooksController(booksServices);


        }




        private void LoadBooks()
        {

            panelBooks.Controls.Clear();
            panelBooks.AutoScroll = true;   // Enable scrolling if the content overflows
            panelBooks.WrapContents = true; // Allow wrapping content within the available space
            panelBooks.FlowDirection = FlowDirection.LeftToRight;  // Switch to TopDown if you prefer vertical layout
            panelBooks.Size = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 100); // Dynamic width & height
            panelBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            var books = _booksController.GetAllBooks();
            foreach (var book in books)
            {
                AddBookCard(book);
            }

        }


        private void AddBookCard(BookItem bookItem)
        {

            // Define a modern color palette
            Color cardBackgroundColor = Color.FromArgb(33, 150, 243); // Light blue
            Color titleColor = Color.FromArgb(255, 255, 255); // White
            Color contentColor = Color.FromArgb(230, 230, 230); // Light gray for content
            Color dateColor = Color.FromArgb(200, 200, 200); // Slightly darker gray for date
            Color actionColor = Color.FromArgb(244, 67, 54); // Red for delete, Gold for edit
            Color buttonBackgroundColor = Color.FromArgb(0, 123, 255); // Darker blue for button
            Color buttonTextColor = Color.White; // White text for button

            // Card Panel setup
            var cardPanel = new Panel
            {
                Size = new Size(370, 160),
                BackColor = cardBackgroundColor,
                Margin = new Padding(10),
                Padding = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Delete Icon
            var deleteIcon = new Label
            {
                Text = "✖",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = actionColor,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 30, 5),
                AutoSize = true
            };
            deleteIcon.Click += (sender, e) => DeleteBook(bookItem);
            cardPanel.Controls.Add(deleteIcon);

            // Edit Icon
            var editIcon = new Label
            {
                Text = "✏",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Gold,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 60, 5),
                AutoSize = true
            };
            editIcon.Click += (sender, e) => UpdateBook(bookItem);
            cardPanel.Controls.Add(editIcon);

            // Title Label
            var titleLabel = new Label
            {
                Text = bookItem.Title,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = titleColor,
                Location = new Point(10, 10),
                AutoSize = true
            };
            cardPanel.Controls.Add(titleLabel);


            // Author Label
            var authorLabel = new Label
            {
                Text = "By " + bookItem.Author,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = contentColor,
                Location = new Point(10, 40),
                AutoSize = true
            };
            cardPanel.Controls.Add(authorLabel);

            // Description Label
            var descriptionLabel = new Label
            {
                Text = bookItem.Description,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = contentColor,
                Location = new Point(10, 60),
                Size = new Size(350, 50),
                AutoSize = false
            };
            cardPanel.Controls.Add(descriptionLabel);
            // Date Label - Show Added or Last Updated date
            var dateLabel = new Label
            {
                // If the UpdatedDate is not set (for a newly added book), show "Added on"
                Text = bookItem.UpdatedDate == default(DateTime)
                    ? $"Added on: {bookItem.CreatedDate:MMMM dd, yyyy hh:mm tt}"
                    : $"Last updated on: {bookItem.UpdatedDate:MMMM dd, yyyy hh:mm tt}",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = dateColor,
                Location = new Point(10, 110),
                AutoSize = true
            };
            cardPanel.Controls.Add(dateLabel);

            // View Details Button
            var viewDetailsButton = new Button
            {
                Text = "View Details",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = buttonBackgroundColor,
                ForeColor = buttonTextColor,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(100, 30),
                Location = new Point(cardPanel.Width - 120, cardPanel.Height - 40)
            };
            viewDetailsButton.FlatAppearance.BorderSize = 0;
            viewDetailsButton.Click += (sender, e) => ShowBookDetails(bookItem);
            cardPanel.Controls.Add(viewDetailsButton);

            panelBooks.Controls.Add(cardPanel);
        }
        private void ShowBookDetails(BookItem bookItem)
        {
            string details = $"Title: {bookItem.Title}\n\n" +
                             $"Author: {bookItem.Author}\n\n" +
                             $"Description:\n{bookItem.Description}\n\n" +
                             $"Published Date: {bookItem.PublishedDate:MMMM dd, yyyy}\n\n" +  // Added Published Date
                             $"Date Added: {bookItem.CreatedDate:MMMM dd, yyyy hh:mm tt}";

            MessageBox.Show(details, "Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateBook(BookItem bookItem)
        {
            var updateBookForm = new UpdateBookForm(bookItem);

            updateBookForm.BookUpdated += (updatedBook) =>
            {
                _booksController.UpdateBook(updatedBook);
                LoadBooks();
                MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            updateBookForm.ShowDialog();
        }
        private void DeleteBook(BookItem bookItem)
        {
            var confirmResult = MessageBox.Show($"Are you sure to delete {bookItem.Title}?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _booksController.DeleteBook(bookItem.Id);
                LoadBooks();
            }
        

    }

     
        private void addBtn_Click(object sender, EventArgs e)
        {

            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void panelBooks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
          
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addBookForm = new AddBookForm();
            addBookForm.BookAdded += LoadBooks;
            addBookForm.ShowDialog();

        }
    }
}

