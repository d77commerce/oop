﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
   public class Library:IEnumerable<Book>
    {
        private List<Book> books;
     

        public Library(params Book[] books)
        {
            this.books =  new List<Book>( books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            for (int index = 0; index < books.Count; index++)
            {
                yield return books[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
