using AutoMapper;
using MediatR;
using RP.Application.Interfaces;
using RP.Application.Wrappers;

namespace RP.Application.Features.Store.Commands
{
    public class CreateStoreCommand : IRequest<Response<int>>
    {
        public string Name { get; set; }
        public string Cover { get; set; }
        public string Description { get; set; }
        public string Schedule { get; set; }
        public string Location { get; set; }
    }

    public class CreateStoreCommandHandler : IRequestHandler<CreateStoreCommand, Response<int>>
    {
        private readonly IStoreRepository _storeRepository;
        private readonly IMapper _mapper;
        public CreateStoreCommandHandler(IStoreRepository storeRepository , IMapper mapper)
        {
            _storeRepository = storeRepository;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateStoreCommand request, CancellationToken cancellationToken)
        {
            var entry = new Domain.Entities.Store
            {
                Cover = request.Cover,
                Description = request.Description,
                Schedule = request.Schedule,
                Location = request.Location,
                Name = request.Name,
            };

            await _storeRepository.AddAsync(entry);
            return new Response<int>(entry.Id, "Registro ingresado correctamente");
        }
    }
}
