using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Library:IEnumerable<Books>
{
    private List<Books> books;

    public Library(params Books[] books)
    {
        this.books = new List<Books>(books);
    }

    public IEnumerator <Books> GetEnumerator()
    {
        return new LibraryIterator(this.books);
    }
    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    private class LibraryIterator : IEnumerator<Books>
    {
        private IReadOnlyList<Books> books;
        private int currentIndex = -1;

        public LibraryIterator(List<Books> books)
        {
            this.books = books;
        }

        public Books Current => this.books[currentIndex];
        object IEnumerator.Current => this.Current;
        public void Dispose() { }
        public void Reset() { }
        public bool MoveNext() => ++this.currentIndex < this.books.Count;
    }
}

