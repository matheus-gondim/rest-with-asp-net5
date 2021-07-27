using RestWithASPNETUdemy.Data.Converter.Implementation;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository.Generic;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;
        private readonly PersonConverter _converter; 

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public List<PersonVO> FindAll()
        {
            var result = _repository.FindAll();
            return _converter.Parse(result);
        }

        public PersonVO FindById(long id)
        {
            var result = _repository.FindById(id);
            return _converter.Parse(result);
        }

        public PersonVO Create(PersonVO person)
        {
            var vo = _converter.Parse(person);
            var result = _repository.Create(vo);
            return _converter.Parse(result);
        }


        public PersonVO Update(PersonVO person)
        {
            var vo = _converter.Parse(person);
            var result = _repository.Update(vo);
            return _converter.Parse(result);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
