﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieStoreWebApi.DBOperations;
using MovieStoreWebApi.Entities;

namespace MovieStoreWebApi.Application.MovieOperations.Queries.GetMovieDetail
{
    public class GetMovieDetailQuery
    {
        public int MovieId { get; set; }
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetMovieDetailQuery(IMovieStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public MovieDetailViewModel Handle()
        {
            var movie = _dbContext.Movies.Include(x=> x.Director).Include(x=> x.Genre).Where(x => x.Id == MovieId).FirstOrDefault();
            if (movie == null)
            {
                throw new InvalidOperationException("Böyle bir film bulunamadı");
            }

            MovieDetailViewModel vm = _mapper.Map<MovieDetailViewModel>(movie);
            return vm;
        }


        public class MovieDetailViewModel
        {
            public string Title { get; set; }
            public string Director { get; set; }
            public string Genre { get; set; }
            public double Price { get; set; }
        }
    }
}
