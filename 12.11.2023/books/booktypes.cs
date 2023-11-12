using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2023.books
{
    internal class booktypes
    {
        readonly string BooksLibrary;
        public string Names;
        private int _booktypesnumber;
        protected string BookTypes;

        public string BooksLanguage;
       
        public int BookNumber 
        {  
            get
            {
                return _booktypesnumber;
            }
            
            set 
            { 
            
                if (_booktypesnumber != value) 
                {
                _booktypesnumber = value;
                }
                else
                {
                    Console.WriteLine("qeyd olunan seife sayi, lazim olunan seife sayindan azdir");
                }   
            }   
        }  
        public booktypes()
        {
            Names = "Sherlock holmes";
            BooksLanguage = "English";
            _booktypesnumber= 5;
        }
        public void Book()
        {
            Names = "xoxo";
            BooksLanguage = "English";
            _booktypesnumber = 1;
        }
    }
}
