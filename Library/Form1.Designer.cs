﻿namespace Library
{
	partial class Form1
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
			this.addBook = new System.Windows.Forms.Button();
			this.tabs = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.bookInput = new System.Windows.Forms.TextBox();
			this.searchBook = new System.Windows.Forms.Button();
			this.bookList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.searchReaders = new System.Windows.Forms.Button();
			this.addReader = new System.Windows.Forms.Button();
			this.readerList = new System.Windows.Forms.ListView();
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.readerInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabs.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// addBook
			// 
			this.addBook.Location = new System.Drawing.Point(267, 24);
			this.addBook.Name = "addBook";
			this.addBook.Size = new System.Drawing.Size(98, 23);
			this.addBook.TabIndex = 2;
			this.addBook.Text = "Add new book";
			this.addBook.UseVisualStyleBackColor = true;
			this.addBook.Click += new System.EventHandler(this.addBook_Click);
			// 
			// tabs
			// 
			this.tabs.Controls.Add(this.tabPage1);
			this.tabs.Controls.Add(this.tabPage2);
			this.tabs.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabs.Location = new System.Drawing.Point(4, 31);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(412, 235);
			this.tabs.TabIndex = 1;
			this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.bookList);
			this.tabPage1.Controls.Add(this.searchBook);
			this.tabPage1.Controls.Add(this.bookInput);
			this.tabPage1.Controls.Add(this.addBook);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(404, 209);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Search Books";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Transparent;
			this.tabPage2.Controls.Add(this.readerInput);
			this.tabPage2.Controls.Add(this.readerList);
			this.tabPage2.Controls.Add(this.addReader);
			this.tabPage2.Controls.Add(this.searchReaders);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(404, 209);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Search readers";
			// 
			// bookInput
			// 
			this.bookInput.Location = new System.Drawing.Point(5, 26);
			this.bookInput.Name = "bookInput";
			this.bookInput.Size = new System.Drawing.Size(175, 20);
			this.bookInput.TabIndex = 0;
			// 
			// searchBook
			// 
			this.searchBook.Location = new System.Drawing.Point(186, 24);
			this.searchBook.Name = "searchBook";
			this.searchBook.Size = new System.Drawing.Size(75, 23);
			this.searchBook.TabIndex = 1;
			this.searchBook.Text = "Search";
			this.searchBook.UseVisualStyleBackColor = true;
			// 
			// bookList
			// 
			this.bookList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.bookList.Location = new System.Drawing.Point(6, 53);
			this.bookList.Name = "bookList";
			this.bookList.Size = new System.Drawing.Size(392, 150);
			this.bookList.TabIndex = 3;
			this.bookList.UseCompatibleStateImageBehavior = false;
			this.bookList.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Author";
			this.columnHeader1.Width = 80;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Title";
			this.columnHeader2.Width = 120;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Published";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 58;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "ISBN";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Pages";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader5.Width = 45;
			// 
			// searchReaders
			// 
			this.searchReaders.Location = new System.Drawing.Point(187, 24);
			this.searchReaders.Name = "searchReaders";
			this.searchReaders.Size = new System.Drawing.Size(75, 23);
			this.searchReaders.TabIndex = 1;
			this.searchReaders.Text = "Search";
			this.searchReaders.UseVisualStyleBackColor = true;
			this.searchReaders.Click += new System.EventHandler(this.searchReaders_Click);
			// 
			// addReader
			// 
			this.addReader.Location = new System.Drawing.Point(268, 24);
			this.addReader.Name = "addReader";
			this.addReader.Size = new System.Drawing.Size(98, 23);
			this.addReader.TabIndex = 2;
			this.addReader.Text = "Add new reader";
			this.addReader.UseVisualStyleBackColor = true;
			this.addReader.Click += new System.EventHandler(this.addReader_Click);
			// 
			// readerList
			// 
			this.readerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
			this.readerList.Location = new System.Drawing.Point(6, 53);
			this.readerList.Name = "readerList";
			this.readerList.Size = new System.Drawing.Size(394, 150);
			this.readerList.TabIndex = 3;
			this.readerList.UseCompatibleStateImageBehavior = false;
			this.readerList.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "First name";
			this.columnHeader6.Width = 80;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Last name";
			this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader7.Width = 80;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "ID";
			this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// readerInput
			// 
			this.readerInput.Location = new System.Drawing.Point(6, 26);
			this.readerInput.Name = "readerInput";
			this.readerInput.Size = new System.Drawing.Size(175, 20);
			this.readerInput.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Enter search criteria";
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Date of birth";
			this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader9.Width = 80;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Address";
			this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader10.Width = 80;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(420, 269);
			this.Controls.Add(this.tabs);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.tabs.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addBook;
		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button searchBook;
		private System.Windows.Forms.TextBox bookInput;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ListView bookList;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Button addReader;
		private System.Windows.Forms.Button searchReaders;
		private System.Windows.Forms.ListView readerList;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.TextBox readerInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
	}
}

