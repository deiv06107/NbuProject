using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class MoviesDBContext : DbContext
    {
        public MoviesDBContext() : base("Movies")
        {
            SqlProviderServices ensureDLLIsCopied = SqlProviderServices.Instance;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie").Property(e => e.ID)
                                                         .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                                                                              new IndexAnnotation(new IndexAttribute()));

        }

        public static MoviesDBContext Create()
        {
            return new MoviesDBContext();
        }

        private GenericRepository<Movie> movieRepo;
        public GenericRepository<Movie> MovieRepo
        {
            get
            {
                if (movieRepo == null)
                {
                    movieRepo = new GenericRepository<Movie>(this);
                }
                return movieRepo;
            }
        }
    }
}
