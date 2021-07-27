using RestWithASPNETUdemy.Data.Converter.Implementation;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository.Generic;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IRepository<Book> _repository;
        private readonly BookConverter _converter;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        public BookVO Create(BookVO book)
        {
            var vo = _converter.Parse(book);
            var result = _repository.Create(vo);
            return _converter.Parse(result);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<BookVO> FindAll()
        {
            var result = _repository.FindAll();
            return _converter.Parse(result);
        }

        public BookVO FindById(long id)
        {
            var result = _repository.FindById(id);
            return _converter.Parse(result);
        }

        public BookVO Update(BookVO book)
        {
            var vo = _converter.Parse(book);
            var result = _repository.Update(vo);
            return _converter.Parse(result);
        }
    }
}
