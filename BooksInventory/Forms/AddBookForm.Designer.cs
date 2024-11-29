namespace BooksInventory.Forms
{
    partial class AddBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titletxt = new TextBox();
            authortxt = new TextBox();
            descriptiontxt = new TextBox();
            publishedDATE = new DateTimePicker();
            saveBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // titletxt
            // 
            titletxt.Location = new Point(52, 116);
            titletxt.Multiline = true;
            titletxt.Name = "titletxt";
            titletxt.Size = new Size(319, 34);
            titletxt.TabIndex = 0;
            titletxt.TextChanged += titletxt_TextChanged;
            // 
            // authortxt
            // 
            authortxt.Location = new Point(52, 184);
            authortxt.Multiline = true;
            authortxt.Name = "authortxt";
            authortxt.Size = new Size(319, 34);
            authortxt.TabIndex = 1;
            authortxt.TextChanged += authortxt_TextChanged;
            // 
            // descriptiontxt
            // 
            descriptiontxt.Location = new Point(52, 249);
            descriptiontxt.Multiline = true;
            descriptiontxt.Name = "descriptiontxt";
            descriptiontxt.Size = new Size(319, 78);
            descriptiontxt.TabIndex = 2;
            descriptiontxt.TextChanged += descriptiontxt_TextChanged;
            // 
            // publishedDATE
            // 
            publishedDATE.Location = new Point(52, 364);
            publishedDATE.Name = "publishedDATE";
            publishedDATE.Size = new Size(319, 23);
            publishedDATE.TabIndex = 3;
            publishedDATE.ValueChanged += publishedDATE_ValueChanged;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(255, 128, 0);
            saveBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = SystemColors.ButtonFace;
            saveBtn.Location = new Point(148, 415);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(118, 39);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(135, 32);
            label1.Name = "label1";
            label1.Size = new Size(152, 40);
            label1.TabIndex = 5;
            label1.Text = "Add Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 93);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 6;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 161);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 7;
            label3.Text = "Author:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 226);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 8;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(52, 341);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 9;
            label5.Text = "PublishedDate:";
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 476);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saveBtn);
            Controls.Add(publishedDATE);
            Controls.Add(descriptiontxt);
            Controls.Add(authortxt);
            Controls.Add(titletxt);
            Name = "AddBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titletxt;
        private TextBox authortxt;
        private TextBox descriptiontxt;
        private DateTimePicker publishedDATE;
        private Button saveBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}