using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Models;
using Bookstore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data =  _bookRepository.GetAllBooks();
            return View();
        } //ruta: /

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
            //return $"book with id ={id}";
        } //ruta:/book/getbook/5

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBooks(bookName, authorName);
            //return $"Book with name = {bookname} & Author = {authorName}";
        } //ruta:/book/searchbooks?bookname=any&authorName=any
    }
}
