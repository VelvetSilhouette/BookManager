namespace BookManager
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
            BkLstBx = new ComboBox();
            menuStrip1 = new MenuStrip();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            FndBkBtn = new Button();
            ShwAllBtn = new Button();
            ByTitlerb = new RadioButton();
            ByAuthorrb = new RadioButton();
            ByPubYearrb = new RadioButton();
            groupBox1 = new GroupBox();
            Searchtxtbox = new TextBox();
            BookInfo = new ListView();
            Title = new ColumnHeader();
            Author = new ColumnHeader();
            YearPublished = new ColumnHeader();
            infolbl = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BkLstBx
            // 
            BkLstBx.DropDownStyle = ComboBoxStyle.Simple;
            BkLstBx.FormattingEnabled = true;
            BkLstBx.Location = new Point(12, 80);
            BkLstBx.Name = "BkLstBx";
            BkLstBx.Size = new Size(170, 148);
            BkLstBx.TabIndex = 0;
            BkLstBx.SelectedValueChanged += BkLstBx_SelectedValueChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(649, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            button1.Location = new Point(12, 45);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Add Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FndBkBtn
            // 
            FndBkBtn.Location = new Point(188, 45);
            FndBkBtn.Name = "FndBkBtn";
            FndBkBtn.Size = new Size(94, 29);
            FndBkBtn.TabIndex = 3;
            FndBkBtn.Text = "Find Book";
            FndBkBtn.UseVisualStyleBackColor = true;
            FndBkBtn.Click += FndBkBtn_Click;
            // 
            // ShwAllBtn
            // 
            ShwAllBtn.Location = new Point(288, 45);
            ShwAllBtn.Name = "ShwAllBtn";
            ShwAllBtn.Size = new Size(94, 29);
            ShwAllBtn.TabIndex = 5;
            ShwAllBtn.Text = "Show All";
            ShwAllBtn.UseVisualStyleBackColor = true;
            ShwAllBtn.Click += ShwAllBtn_Click;
            // 
            // ByTitlerb
            // 
            ByTitlerb.AutoSize = true;
            ByTitlerb.Location = new Point(6, 26);
            ByTitlerb.Name = "ByTitlerb";
            ByTitlerb.Size = new Size(59, 24);
            ByTitlerb.TabIndex = 6;
            ByTitlerb.TabStop = true;
            ByTitlerb.Text = "Title";
            ByTitlerb.UseVisualStyleBackColor = true;
            // 
            // ByAuthorrb
            // 
            ByAuthorrb.AutoSize = true;
            ByAuthorrb.Location = new Point(6, 56);
            ByAuthorrb.Name = "ByAuthorrb";
            ByAuthorrb.Size = new Size(75, 24);
            ByAuthorrb.TabIndex = 7;
            ByAuthorrb.TabStop = true;
            ByAuthorrb.Text = "Author";
            ByAuthorrb.UseVisualStyleBackColor = true;
            // 
            // ByPubYearrb
            // 
            ByPubYearrb.AutoSize = true;
            ByPubYearrb.Location = new Point(6, 86);
            ByPubYearrb.Name = "ByPubYearrb";
            ByPubYearrb.Size = new Size(126, 24);
            ByPubYearrb.TabIndex = 8;
            ByPubYearrb.TabStop = true;
            ByPubYearrb.Text = "Year Published";
            ByPubYearrb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ByTitlerb);
            groupBox1.Controls.Add(ByPubYearrb);
            groupBox1.Controls.Add(ByAuthorrb);
            groupBox1.Location = new Point(188, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lookup By";
            // 
            // Searchtxtbox
            // 
            Searchtxtbox.Location = new Point(194, 80);
            Searchtxtbox.Name = "Searchtxtbox";
            Searchtxtbox.Size = new Size(222, 27);
            Searchtxtbox.TabIndex = 10;
            // 
            // BookInfo
            // 
            BookInfo.Columns.AddRange(new ColumnHeader[] { Title, Author, YearPublished });
            BookInfo.Location = new Point(12, 284);
            BookInfo.Name = "BookInfo";
            BookInfo.Size = new Size(446, 95);
            BookInfo.TabIndex = 11;
            BookInfo.UseCompatibleStateImageBehavior = false;
            BookInfo.View = View.Details;
            // 
            // Title
            // 
            Title.Text = "Title";
            Title.Width = 200;
            // 
            // Author
            // 
            Author.Text = "Author";
            Author.Width = 120;
            // 
            // YearPublished
            // 
            YearPublished.Text = "Published Year";
            YearPublished.Width = 120;
            // 
            // infolbl
            // 
            infolbl.AutoSize = true;
            infolbl.Location = new Point(12, 261);
            infolbl.Name = "infolbl";
            infolbl.Size = new Size(73, 20);
            infolbl.TabIndex = 12;
            infolbl.Text = "Book Info";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 450);
            Controls.Add(infolbl);
            Controls.Add(BookInfo);
            Controls.Add(Searchtxtbox);
            Controls.Add(groupBox1);
            Controls.Add(ShwAllBtn);
            Controls.Add(FndBkBtn);
            Controls.Add(button1);
            Controls.Add(BkLstBx);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox BkLstBx;
        private MenuStrip menuStrip1;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button FndBkBtn;
        private Button ShwAllBtn;
        private RadioButton ByTitlerb;
        private RadioButton ByAuthorrb;
        private RadioButton ByPubYearrb;
        private GroupBox groupBox1;
        private TextBox Searchtxtbox;
        private ListView BookInfo;
        private Label infolbl;
        private ColumnHeader Title;
        private ColumnHeader Author;
        private ColumnHeader YearPublished;
    }
}