using MediatR;
using RP.Application.Interfaces;
using RP.Application.Wrappers;

namespace RP.Application.Features.Store.Query
{
    public class StoreGetByIdQuery : IRequest<Response<RP.Domain.Entities.Store>>
    {
        public int Id { get; set; }
    }

    public class StoreGetByIdQueryHandler : IRequestHandler<StoreGetByIdQuery, Response<RP.Domain.Entities.Store>>
    {
        private readonly IStoreRepository _storeRepository;

        public StoreGetByIdQueryHandler(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public async Task<Response<RP.Domain.Entities.Store>> Handle(StoreGetByIdQuery request, CancellationToken cancellationToken)
        {
            var store = await _storeRepository.GetByIdAsync(request.Id);

            return new Response<RP.Domain.Entities.Store>(store);
        }
    }
}
