﻿using AutoMapper;
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
using static MovieStoreWebApi.Application.MovieOperations.Queries.GetMovies.GetMoviesQuery;
using static MovieStoreWebApi.Application.MovieOperations.Queries.GetMovieDetail.GetMovieDetailQuery;
using static MovieStoreWebApi.Application.MovieOperations.Commands.CreateMovie.CreateMovieCommand;
using static MovieStoreWebApi.Application.MovieOperations.Commands.UpdateMovie.UpdateMovieCommand;

namespace MovieStoreWebApi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //ActorActress Mapping
            CreateMap<CreateActorActressModel, ActorActress>();
            CreateMap<ActorActress , ActorActressViewModel>();
            CreateMap<ActorActress, ActorActressDetailViewModel>();
            CreateMap<UpdateActorActressModel, ActorActress>();

            //Director Mapping
            CreateMap<CreateDirectorViewModel, Director>();
            CreateMap<Director, DirectorViewModel>();
            CreateMap<Director, DirectorDetailViewModel>();
            CreateMap<UpdateDirectorViewModel, Director>();

            //Genre Mapping
            CreateMap<CreateGenreViewModel, Genre>();
            CreateMap<Genre, GenreViewModel>();
            CreateMap<Genre, GenreDetailViewModel>();
            CreateMap<UpdateGenreViewModel, Genre>();

            //Movie Mapping
            CreateMap<Movie, MovieViewModel>().ForMember(dest => dest.Director, opt => opt.MapFrom(src => src.Director.Name + " " +src.Director.Surname));
            CreateMap<Movie, MovieDetailViewModel>().ForMember(dest => dest.Director, opt => opt.MapFrom(src => src.Director.Name + " " + src.Director.Surname))
                                                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.GenreTitle));
                                                    
                                                    
            CreateMap<CreateMovieViewModel, Movie>();
            CreateMap<UpdateMovieViewModel, Movie>();
                
        }
    }
}
