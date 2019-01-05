using BookService.WebAPI.DTO;
using BookService.WebAPI.Models;
using BookService.WebAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BookService.WebAPI.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerCrudBase<Book, BookRepository>
    {

        public BooksController(BookRepository bookRepository): base (bookRepository)
        {
        }

        // GET: api/Books
        [HttpGet]
        public override async Task<IActionResult> Get()
        {
            return Ok(await repository.GetAllInclusive());
        }

        // GET: api/Books/Basic
        [HttpGet]
        [Route("Basic")]
        public async Task<IActionResult> GetBookBasic()
        {
            return Ok(await repository.ListBookBasic());
        }

        //// GET: api/books/imagebyname/book2.jpg
        //[HttpGet]
        //[Route("ImageByName/{filename}")]
        //public IActionResult ImageByFileName(string filename)
        //{
        //    var image = Path.Combine(Directory.GetCurrentDirectory(),
        //                     "wwwroot", "images", filename);
        //    return PhysicalFile(image, "image/jpeg");
        //}

        //GET:api/books/imagebyname/book2.jpg

        [HttpGet]
        [Route("ImageByName/{filename}")]
        public IActionResult ImageByFileName(string filename)
            {
            var imagepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", filename);
            return PhysicalFile(imagepath, "image/jpeg");

                }



        //// GET: api/books/imagebyid/6
        //[HttpGet]
        //[Route("ImageById/{bookid}")]
        //public async Task<IActionResult> ImageById(int bookid)
        //{
        //    BookDetail book = await repository.GetDetailById(bookid);
        //    return ImageByFileName(book.FileName);
        //}

        //GET : api/books/ImageById/6
        [HttpGet]
        [Route("ImageById/{bookid}")]
        public async Task<IActionResult> ImageById(int bookid)
        {
            BookDetail bookdetail = await repository.GetDetailledBookViaId(bookid);
            return ImageByFileName(bookdetail.FileName);
        }

        [HttpPost]
        [Route("ImagePost")]
        public async Task<IActionResult> ImageUpload(IFormFile uploadedFile)
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", uploadedFile.FileName);
            if (uploadedFile.Length > 0)
            {
                using (var stream = new FileStream(filepath, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(stream);
                }

            }
            return Ok(new { count = 1, uploadedFile.Length });
        }

        [HttpPost]
        [Route("afbeelding")]
        public async Task<IActionResult> AfbeeldingUploaden( IFormFile fileuploaded)
        {
            var filePathje = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploadedimages", fileuploaded.FileName);
            if (fileuploaded.Length > 0)
            {
                using (var stream = new FileStream(filePathje, FileMode.Create))
                {
                    await fileuploaded.CopyToAsync(stream);
                }
            }

            return Ok(new { count = 1, fileuploaded.Length });
        }

    }
}