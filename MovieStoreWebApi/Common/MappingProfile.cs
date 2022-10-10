using AutoMapper;
using MovieStoreWebApi.Application.ActorActressOperations.Commands.CreateActorActress;
using MovieStoreWebApi.Entities;
using static MovieStoreWebApi.Application.ActorActressOperations.Commands.CreateActorActress.CreateActorActressCommand;
using static MovieStoreWebApi.Application.ActorActressOperations.Commands.UpdateActorActress.UpdateActorActressCommand;
using static MovieStoreWebApi.Application.ActorActressOperations.Queries.GetActorActressDetail.GetActorActressDetailQuery;
using static MovieStoreWebApi.Application.ActorActressOperations.Queries.GetActorActress.GetActorActressQuery;

namespace MovieStoreWebApi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateActorActressModel, ActorActress>();
            CreateMap<ActorActress , ActorActressViewModel>();
            CreateMap<ActorActress, ActorActressDetailViewModel>();
            CreateMap<UpdateActorActressModel, ActorActress>();

        }
    }
}
