﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Library : IEnumerable<Book>
{
    private List<Book> books;

    public Library(params Book[] books)
    {
        this.books = new List<Book>(books);
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(this.books);
    }
    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    private class LibraryIterator : IEnumerator<Book>
    {
        private List<Book> books;
        private int currentIndex = -1;

        public LibraryIterator(List<Book> books)
        {
            this.books = books;
        }

        public Book Current => this.books[currentIndex];
        object IEnumerator.Current => this.Current;
        public void Dispose() { }
        public bool MoveNext() => ++this.currentIndex < this.books.Count;
        public void Reset() => this.currentIndex = -1;

    }

}

