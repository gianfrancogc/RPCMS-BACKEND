using MediatR;
using RP.Application.Interfaces;
using RP.Application.Wrappers;

namespace RP.Application.Features.Store.Commands
{
    public class UpdateStoreCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cover { get; set; }
        public string Description { get; set; }
        public string Schedule { get; set; }
        public string Location { get; set; }
    }

    public class UpdateStoreCommandHandler : IRequestHandler<UpdateStoreCommand, Response<int>>
    {
        private readonly IStoreRepository _storeRepository;
        public UpdateStoreCommandHandler(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }
        public async Task<Response<int>> Handle(UpdateStoreCommand command, CancellationToken cancellationToken)
        {
            var permission = await _storeRepository.GetByIdAsync(command.Id);

            if (permission == null)
            {
                throw new Exception($"Store Not Found.");
            }
            else
            {
                permission.Name = command.Name;
                permission.Description = command.Description;
                permission.Cover = command.Cover;
                permission.Location = command.Location;
                permission.Schedule = command.Schedule;
                await _storeRepository.UpdateAsync(permission);
                return new Response<int>(permission.Id, "Actualizado correctamente");
            }
        }
    }
}
