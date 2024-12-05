namespace PersonMVC.Tests;
using PersonMVC.Data;
using PersonMVC.Models;
using Xunit;
using Microsoft.EntityFrameworkCore;

public class PersonServiceTests
{

    // Helper method to create an in-memory database context
    private PersonDbContext GetInMemoryDbContext()
    {
        var options = new DbContextOptionsBuilder<PersonDbContext>()
            .UseInMemoryDatabase("PersonTestDb")
            .Options;

        return new PersonDbContext(options);
    }


    /// <summary>
    /// Verifies that a new person is saved to the database when using the AddPerson method.
    /// </summary>
    [Fact]
    public void AddPerson_SavesPersonToDatabase()
    {
        Assert.Equal(1, 0);
    }
}
