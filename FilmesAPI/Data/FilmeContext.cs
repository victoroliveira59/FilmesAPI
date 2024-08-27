using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

using FilmesAPI.Models;

using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data;

public class FilmeContext : DbContext
{

    public FilmeContext(DbContextOptions<FilmeContext> opts)
        : base(opts)
    {

    }
    public DbSet<Filme> Filmes { get; set; }
}
