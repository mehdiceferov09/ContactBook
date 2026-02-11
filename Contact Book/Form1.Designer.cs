namespace Contact_Book
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameBox = new TextBox();
            MailBox = new TextBox();
            NumberBox = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SaveBtn = new Button();
            DeleteBtn = new Button();
            EditBtn = new Button();
            Table = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)NumberBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Table).BeginInit();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Location = new Point(222, 32);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(281, 50);
            NameBox.TabIndex = 0;
            // 
            // MailBox
            // 
            MailBox.Location = new Point(222, 218);
            MailBox.Name = "MailBox";
            MailBox.Size = new Size(450, 50);
            MailBox.TabIndex = 2;
            // 
            // NumberBox
            // 
            NumberBox.Location = new Point(222, 117);
            NumberBox.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            NumberBox.Name = "NumberBox";
            NumberBox.Size = new Size(450, 50);
            NumberBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 32);
            label1.Name = "label1";
            label1.Size = new Size(105, 45);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 122);
            label2.Name = "label2";
            label2.Size = new Size(137, 45);
            label2.TabIndex = 5;
            label2.Text = "Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 223);
            label3.Name = "label3";
            label3.Size = new Size(109, 45);
            label3.TabIndex = 6;
            label3.Text = "E-mail";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(841, 32);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(268, 64);
            SaveBtn.TabIndex = 7;
            SaveBtn.Text = "Save Contact";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(841, 133);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(268, 64);
            DeleteBtn.TabIndex = 8;
            DeleteBtn.Text = "Delete Contact";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(841, 223);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(268, 64);
            EditBtn.TabIndex = 9;
            EditBtn.Text = "Edit Contact";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // Table
            // 
            Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Table.Location = new Point(21, 352);
            Table.Name = "Table";
            Table.RowHeadersWidth = 62;
            Table.Size = new Size(1396, 446);
            Table.TabIndex = 10;
            Table.CellContentClick += Table_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 810);
            Controls.Add(Table);
            Controls.Add(EditBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NumberBox);
            Controls.Add(MailBox);
            Controls.Add(NameBox);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumberBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameBox;
        private TextBox MailBox;
        private NumericUpDown NumberBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button SaveBtn;
        private Button DeleteBtn;
        private Button EditBtn;
        private DataGridView Table;
    }
}
