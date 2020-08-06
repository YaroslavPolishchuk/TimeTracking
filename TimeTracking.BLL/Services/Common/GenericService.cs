using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace TimeTracking.BLL.Services
{
    public abstract class GenericService<TEnity,TBEntity, Tkey> : IGenericService<TBEntity, Tkey> where TEnity : class, new()                                                                                                        
                                                                                                       where TBEntity:class,new()                   
    {       

        protected GenericService(IGenericRepository<TEnity, Tkey> repository)
        {
            _repository = repository;
            _mapper = GetMapper();
        }

        protected IGenericRepository<TEnity, Tkey> _repository;
        protected readonly IMapper _mapper;
        
        public virtual IMapper GetMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping();                
                cfg.CreateMap<TEnity, TBEntity>().ReverseMap();
            }).CreateMapper();
        }
        public IEnumerable<TBEntity> GetAll()
        {
            return _repository.GetAllData().Select(e => _mapper.Map<TBEntity>(e));
        }        
        
        public TBEntity Add(TBEntity obj)
        {
            var dbEntity = _mapper.Map<TEnity>(obj);
            _repository.Add(dbEntity);
            _repository.Save();
            return _mapper.Map<TBEntity>(dbEntity);
        }       

        public IEnumerable<TBEntity> FindBy(Expression<Func<TBEntity, bool>> predicate)
        {
            try
            {
                Expression<Func<TEnity, bool>> predicateEntity = _mapper.Map<Expression<Func<TEnity, bool>>>(predicate);
                return _repository.FindBy(predicateEntity).Select(o => _mapper.Map<TBEntity>(o));
            }
            catch
            {
                throw new Exception();
            }
        }

        public TBEntity Get(Tkey id)
        {
            return _mapper.Map<TBEntity>(_repository.Get(id));
        }
        public TBEntity Update(TBEntity obj)
        {
            var dbEntity = _mapper.Map<TEnity>(obj);
            _repository.Update(dbEntity);
            _repository.Save();
            return _mapper.Map<TBEntity>(dbEntity);
        }

        public TBEntity Delete(Tkey id)
        {
            var dbEntity = _repository.Get(id);
            _repository.Delete(dbEntity);
            _repository.Save();
            return _mapper.Map<TBEntity>(dbEntity);
        }
        
        
    }
}
