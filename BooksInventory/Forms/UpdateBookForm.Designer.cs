namespace BooksInventory.Forms
{
    partial class UpdateBookForm
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            updateBtn = new Button();
            publishedDATE = new DateTimePicker();
            descriptiontxt = new TextBox();
            authortxt = new TextBox();
            titletxt = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 318);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 19;
            label5.Text = "PublishedDate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 203);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 18;
            label4.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 138);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 17;
            label3.Text = "Author:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 70);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 16;
            label2.Text = "Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(100, 21);
            label1.Name = "label1";
            label1.Size = new Size(196, 40);
            label1.TabIndex = 15;
            label1.Text = "Update Book";
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(255, 128, 0);
            updateBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = SystemColors.ButtonFace;
            updateBtn.Location = new Point(131, 392);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(118, 39);
            updateBtn.TabIndex = 14;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // publishedDATE
            // 
            publishedDATE.Location = new Point(35, 341);
            publishedDATE.Name = "publishedDATE";
            publishedDATE.Size = new Size(319, 23);
            publishedDATE.TabIndex = 13;
            publishedDATE.ValueChanged += publishedDATE_ValueChanged;
            // 
            // descriptiontxt
            // 
            descriptiontxt.Location = new Point(35, 226);
            descriptiontxt.Multiline = true;
            descriptiontxt.Name = "descriptiontxt";
            descriptiontxt.Size = new Size(319, 78);
            descriptiontxt.TabIndex = 12;
            descriptiontxt.TextChanged += descriptiontxt_TextChanged;
            // 
            // authortxt
            // 
            authortxt.Location = new Point(35, 161);
            authortxt.Multiline = true;
            authortxt.Name = "authortxt";
            authortxt.Size = new Size(319, 34);
            authortxt.TabIndex = 11;
            authortxt.TextChanged += authortxt_TextChanged;
            // 
            // titletxt
            // 
            titletxt.Location = new Point(35, 93);
            titletxt.Multiline = true;
            titletxt.Name = "titletxt";
            titletxt.Size = new Size(319, 34);
            titletxt.TabIndex = 10;
            titletxt.TextChanged += titletxt_TextChanged;
            // 
            // UpdateBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(updateBtn);
            Controls.Add(publishedDATE);
            Controls.Add(descriptiontxt);
            Controls.Add(authortxt);
            Controls.Add(titletxt);
            Name = "UpdateBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateBookForm";
            Load += UpdateBookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button updateBtn;
        private DateTimePicker publishedDATE;
        private TextBox descriptiontxt;
        private TextBox authortxt;
        private TextBox titletxt;
    }
}