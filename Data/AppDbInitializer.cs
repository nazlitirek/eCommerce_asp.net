using eCommerce.Data.Enums;
using eCommerce.Models;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Data
{
	public class AppDbInitializer
	{
		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

				if(!context.Cinemas.Any())
				{
					context.Cinemas.AddRange(new List<Cinema>()
					{
						new Cinema()
						{
							Name = "Cinema 1",
							Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
							Description = "This is the description of the first cinema"
						},
						new Cinema()
						{
							Name = "Cinema 2",
							Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
							Description = "This is the description of the first cinema"
						},
						new Cinema()
						{
							Name = "Cinema 3",
							Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
							Description = "This is the description of the first cinema"
						},
						new Cinema()
						{
							Name = "Cinema 4",
							Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
							Description = "This is the description of the first cinema"
						},
						new Cinema()
						{
							Name = "Cinema 5",
							Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
							Description = "This is the description of the first cinema"
						},
					});
					context.SaveChanges();
				}
				
				if (!context.Actors.Any())
				{
					context.Actors.AddRange(new List<Actor>()
					{
						new Actor()
						{
							FullName = "Actor 1",
							Bio = "This is the Bio of the first actor",
							ProfilePictureUrl = "https://img.mensxp.com/media/content/2020/Jun/How-Different-Bollywood-Actors-Look-Before-And-After-Stardom1400_5ed4e7bb59b05.jpeg?w=1100&h=513&cc=1"

						},
						new Actor()
						{
							FullName = "Actor 2",
							Bio = "This is the Bio of the second actor",
							ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-2.jpeg"
						},
						new Actor()
						{
							FullName = "Actor 3",
							Bio = "This is the Bio of the second actor",
							ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-3.jpeg"
						},
						new Actor()
						{
							FullName = "Actor 4",
							Bio = "This is the Bio of the second actor",
							ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-4.jpeg"
						},
						new Actor()
						{
							FullName = "Actor 5",
							Bio = "This is the Bio of the second actor",
							ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-5.jpeg"
						}
					});
					context.SaveChanges();
				}
				
				if (!context.Producers.Any())
				{
					context.Producers.AddRange(new List<Producer>()
					{
						new Producer()
						{
							FullName = "Producer 1",
							Bio = "This is the Bio of the first actor",
							ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-1.jpeg"

						},
						new Producer()
						{
							FullName = "Producer 2",
							Bio = "This is the Bio of the second actor",
							ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-2.jpeg"
						},
						new Producer()
						{
							FullName = "Producer 3",
							Bio = "This is the Bio of the second actor",
							ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-3.jpeg"
						},
						new Producer()
						{
							FullName = "Producer 4",
							Bio = "This is the Bio of the second actor",
							ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-4.jpeg"
						},
						new Producer()
						{
							FullName = "Producer 5",
							Bio = "This is the Bio of the second actor",
							ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-5.jpeg"
						}
					});
					context.SaveChanges();
				}

				if (!context.Movies.Any())
				{
					context.Movies.AddRange(new List<Movie>()
					{
						new Movie()
						{
							Name = "Life",
							Description = "This is the Life movie description",
							Price = 39.50,
							ImageUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
							StartDate = DateTime.Now.AddDays(-10),
							EndDate = DateTime.Now.AddDays(10),
							CinemaId = 6,
							ProducerId = 8,
							MovieCategory = MovieCategory.Documentary
						},
						new Movie()
						{
							Name = "The Shawshank Redemption",
							Description = "This is the Shawshank Redemption description",
							Price = 29.50,
							ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
							StartDate = DateTime.Now,
							EndDate = DateTime.Now.AddDays(3),
							CinemaId = 7,
							ProducerId = 6,
							MovieCategory = MovieCategory.Action
						},
						new Movie()
						{
							Name = "Ghost",
							Description = "This is the Ghost movie description",
							Price = 39.50,
							ImageUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
							StartDate = DateTime.Now,
							EndDate = DateTime.Now.AddDays(7),
							CinemaId = 8,
							ProducerId = 7,
							MovieCategory = MovieCategory.Horror
						},
						new Movie()
						{
							Name = "Race",
							Description = "This is the Race movie description",
							Price = 39.50,
							ImageUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
							StartDate = DateTime.Now.AddDays(-10),
							EndDate = DateTime.Now.AddDays(-5),
							CinemaId = 9,
							ProducerId = 6,
							MovieCategory = MovieCategory.Documentary
						},
						new Movie()
						{
							Name = "Scoob",
							Description = "This is the Scoob movie description",
							Price = 39.50,
							ImageUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
							StartDate = DateTime.Now.AddDays(-10),
							EndDate = DateTime.Now.AddDays(-2),
							CinemaId = 10,
							ProducerId = 6,
							MovieCategory = MovieCategory.Cartoon
						},
						new Movie()
						{
							Name = "Cold Soles",
							Description = "This is the Cold Soles movie description",
							Price = 39.50,
							ImageUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
							StartDate = DateTime.Now.AddDays(3),
							EndDate = DateTime.Now.AddDays(20),
							CinemaId = 7,
							ProducerId = 6,
							MovieCategory = MovieCategory.Drama
						}
					});
					context.SaveChanges();
				}

				if (!context.Actors_Movies.Any())
				{
					context.Actors_Movies.AddRange(new List<Actor_Movie>()
					{
						new Actor_Movie()
						{
							ActorId = 11,
							MovieId = 10
						},
						new Actor_Movie()
						{
							ActorId = 12,
							MovieId = 11
						},

						 new Actor_Movie()
						{
							ActorId = 13,
							MovieId = 12
						},
						 new Actor_Movie()
						{
							ActorId = 11,
							MovieId = 11
						},

						new Actor_Movie()
						{
							ActorId = 12,
							MovieId = 14
						},
						
						
					});
					context.SaveChanges();
				}
			}
		}
	}
}
