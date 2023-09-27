namespace BookManager
{
    partial class AddBookControl
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
            titletxtbx = new TextBox();
            authortxtb = new TextBox();
            yearpubtxtbx = new TextBox();
            titlelb = new Label();
            authorlb = new Label();
            yearpublb = new Label();
            addbookbtn = new Button();
            SuspendLayout();
            // 
            // titletxtbx
            // 
            titletxtbx.Location = new Point(119, 40);
            titletxtbx.Margin = new Padding(3, 4, 3, 4);
            titletxtbx.Name = "titletxtbx";
            titletxtbx.Size = new Size(269, 27);
            titletxtbx.TabIndex = 0;
            // 
            // authortxtb
            // 
            authortxtb.Location = new Point(119, 117);
            authortxtb.Margin = new Padding(3, 4, 3, 4);
            authortxtb.Name = "authortxtb";
            authortxtb.Size = new Size(269, 27);
            authortxtb.TabIndex = 1;
            // 
            // yearpubtxtbx
            // 
            yearpubtxtbx.Location = new Point(119, 195);
            yearpubtxtbx.Margin = new Padding(3, 4, 3, 4);
            yearpubtxtbx.Name = "yearpubtxtbx";
            yearpubtxtbx.Size = new Size(269, 27);
            yearpubtxtbx.TabIndex = 2;
            yearpubtxtbx.KeyPress += yearpubtxtbx_KeyPress;
            // 
            // titlelb
            // 
            titlelb.AutoSize = true;
            titlelb.Location = new Point(77, 51);
            titlelb.Name = "titlelb";
            titlelb.Size = new Size(38, 20);
            titlelb.TabIndex = 3;
            titlelb.Text = "Title";
            // 
            // authorlb
            // 
            authorlb.AutoSize = true;
            authorlb.Location = new Point(59, 128);
            authorlb.Name = "authorlb";
            authorlb.Size = new Size(54, 20);
            authorlb.TabIndex = 4;
            authorlb.Text = "Author";
            // 
            // yearpublb
            // 
            yearpublb.AutoSize = true;
            yearpublb.Location = new Point(14, 205);
            yearpublb.Name = "yearpublb";
            yearpublb.Size = new Size(105, 20);
            yearpublb.TabIndex = 5;
            yearpublb.Text = "Year Published";
            // 
            // addbookbtn
            // 
            addbookbtn.Location = new Point(191, 252);
            addbookbtn.Margin = new Padding(3, 4, 3, 4);
            addbookbtn.Name = "addbookbtn";
            addbookbtn.Size = new Size(86, 31);
            addbookbtn.TabIndex = 6;
            addbookbtn.Text = "Add Book";
            addbookbtn.UseVisualStyleBackColor = true;
            addbookbtn.Click += addbookbtn_Click;
            // 
            // AddBookControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 296);
            Controls.Add(addbookbtn);
            Controls.Add(yearpublb);
            Controls.Add(authorlb);
            Controls.Add(titlelb);
            Controls.Add(yearpubtxtbx);
            Controls.Add(authortxtb);
            Controls.Add(titletxtbx);
            Name = "AddBookControl";
            Text = "Add Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titletxtbx;
        private TextBox authortxtb;
        private TextBox yearpubtxtbx;
        private Label titlelb;
        private Label authorlb;
        private Label yearpublb;
        private Button addbookbtn;
    }
}