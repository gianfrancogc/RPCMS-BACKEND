using AutoMapper;
using MediatR;
using RP.Application.Dtos;
using RP.Application.Interfaces;
using RP.Application.Wrappers;

namespace RP.Application.Features.Store.Query
{
    public class StoreGetAllQuery : IRequest<Response<List<RP.Domain.Entities.Store>>>
    {
        public class StoreGetAllQueryHandler : IRequestHandler<StoreGetAllQuery, Response<List<RP.Domain.Entities.Store>>>
        {
            private readonly IStoreRepository _storeRepository;
            public StoreGetAllQueryHandler(IStoreRepository storeRepository)
            {
                _storeRepository = storeRepository;
            }

            public async Task<Response<List<RP.Domain.Entities.Store>>> Handle(StoreGetAllQuery request, CancellationToken cancellationToken)
            {
                var stores = await _storeRepository.GetAllAsync();

                return new Response<List<RP.Domain.Entities.Store>>(stores.ToList());
            }
        }
    }
}
