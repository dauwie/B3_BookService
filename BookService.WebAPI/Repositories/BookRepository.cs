using BookService.WebAPI.DTO;
using BookService.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookService.WebAPI.Repositories
{

    public class BookRepository: Repository<Book>
    {

        public BookRepository(BookServiceContext context): base(context)
        {
        }
        //public async Task<List<Book>> GetAllInclusive()
        //{
        //    return await GetAll()
        //        .Include(b => b.Author)
        //        .Include(b => b.Publisher)
        //        .ToListAsync();
        //}

            public async Task<List<Book>> GetAllInclusive()
        {
            return await GetAll().Include(b => b.Author).Include(b => b.Publisher).ToListAsync();
        }

        //public async Task<List<BookBasic>> ListBasic()
        //{
        //    // return a list of BookBasic DTO-items (Id and Title only)
        //    return await db.Books.Select(b => new BookBasic
        //    {
        //        Id = b.Id,
        //        Title = b.Title
        //    }).ToListAsync();
        //}

           public async Task<List<BookBasic>> ListBookBasic()
        {
            return await db.Books.Select(b => new BookBasic { Id = b.Id, Title = b.Title }).ToListAsync();
        }

        //public async Task<BookDetail> GetDetailById(int id)
        //{
        //    return await db.Books.Select(b => new BookDetail
        //    {
        //        Id = b.Id,
        //        Title = b.Title,
        //        ISBN = b.ISBN,
        //        Year = b.Year,
        //        Price = b.Price,
        //        NumberOfPages = b.NumberOfPages,
        //        AuthorId = b.Author.Id,
        //        AuthorName = $"{b.Author.LastName} {b.Author.FirstName}",
        //        PublisherId = b.Publisher.Id,
        //        PublisherName = b.Publisher.Name,
        //        FileName = b.FileName
        //    }).FirstOrDefaultAsync(b => b.Id == id);
        //}

        //repository is een functie
        public async Task<BookDetail> GetDetailledBookViaId(int id)
        {
            BookDetail bookdetailleke = await db.Books.Select(b => new BookDetail
            {
                AuthorId = b.AuthorId,
                AuthorName = $"{b.Author.FirstName} {b.Author.LastName} test",
                FileName = b.FileName,
                Id = b.Id,
                ISBN = b.ISBN,
                NumberOfPages = b.NumberOfPages,
                Price = b.Price,
                PublisherId = b.PublisherId,
                PublisherName = b.Publisher.Name,
                Title = b.Title,
                Year = b.Year

            }).Where(b => b.Id == id).SingleOrDefaultAsync();
            return bookdetailleke;
        }
    }


}
