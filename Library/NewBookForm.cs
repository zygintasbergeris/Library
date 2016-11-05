﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
	public partial class NewBookForm : Form
	{
		BookDictionary books = new BookDictionary();

		public NewBookForm(BookDictionary books)
		{
			InitializeComponent();
			this.books = books;
			newCopy.Checked = false;
			newBook.Checked = false;
		}

		private void newCopy_CheckedChanged(object sender, EventArgs e)
		{
			author.Enabled = true;
			title.Enabled = true;
			ISBN.Enabled = false;
			year.Enabled = false;
			pages.Enabled = false;
			addBook.Enabled = true;
		}

		private void newBook_CheckedChanged(object sender, EventArgs e)
		{
			author.Enabled = true;
			title.Enabled = true;
			ISBN.Enabled = true;
			year.Enabled = true;
			pages.Enabled = true;
			addBook.Enabled = true;
		}

		private void addBook_Click(object sender, EventArgs e)
		{
			int pg, yr;
			if (int.TryParse(pages.Text, out pg))
			{
				errorProvider1.SetError(pages, "Not a number");
				return;
			}
			else
			{
				errorProvider1.Clear();
			}
			if (int.TryParse(year.Text, out yr))
			{
				errorProvider2.SetError(year, "Not a number");
				return;
			}
			else
			{
				errorProvider1.Clear();
			}

			if (newCopy.Checked)
			{
				Book book = books.FindBook(title.Text, author.Text);
				if (book != null)
					books.Add(new BookCopy(book));
				else
					MessageBox.Show("Copy with this author and title pair was not found", "Error", MessageBoxButtons.OK);
			}
			else
			{
				if (newBook.Checked)
				{
					Book book = new Book(ISBN.Text, title.Text, author.Text, (short)yr, pg);
					books.Add(new BookCopy(book));
				}
				else
				{
					MessageBox.Show("New book type not selected", "Error", MessageBoxButtons.OK);
				}
			}
		}
	}
}
