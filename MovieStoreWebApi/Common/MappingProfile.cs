using AutoMapper;
using MovieStoreWebApi.Application.ActorActressOperations.Commands.CreateActorActress;
using MovieStoreWebApi.Entities;
using static MovieStoreWebApi.Application.ActorActressOperations.Commands.CreateActorActress.CreateActorActressCommand;
using static MovieStoreWebApi.Application.ActorActressOperations.Commands.UpdateActorActress.UpdateActorActressCommand;
using static MovieStoreWebApi.Application.ActorActressOperations.Queries.GetActorActressDetail.GetActorActressDetailQuery;
using static MovieStoreWebApi.Application.ActorActressOperations.Queries.GetActorActress.GetActorActressQuery;
using static MovieStoreWebApi.Application.DirectorOperations.Queries.GetDirectors.GetDirectorsQuery;
using static MovieStoreWebApi.Application.DirectorOperations.Queries.GetDirectorDetail.GetDirectorDetailQuery;
using static MovieStoreWebApi.Application.DirectorOperations.Commands.CreateDirector.CreateDirectorCommand;
using MovieStoreWebApi.Application.DirectorOperations.Commands.UpdateDirector;
using static MovieStoreWebApi.Application.DirectorOperations.Commands.UpdateDirector.UpdateDirectorCommand;
using static MovieStoreWebApi.Application.GenreOperations.Commands.CreateGenre.CreateGenreCommand;
using static MovieStoreWebApi.Application.GenreOperations.Queries.GetGenres.GetGenresQuery;
using static MovieStoreWebApi.Application.GenreOperations.Queries.GetGenreDetail.GetGenreDetailQuery;
using static MovieStoreWebApi.Application.GenreOperations.Commands.UpdateGenre.UpdateGenreCommand;

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

            CreateMap<CreateDirectorViewModel, Director>();
            CreateMap<Director, DirectorViewModel>();
            CreateMap<Director, DirectorDetailViewModel>();
            CreateMap<UpdateDirectorViewModel, Director>();

            CreateMap<CreateGenreViewModel, Genre>();
            CreateMap<Genre, GenreViewModel>();
            CreateMap<Genre, GenreDetailViewModel>();
            CreateMap<UpdateGenreViewModel, Genre>();
        }
    }
}
