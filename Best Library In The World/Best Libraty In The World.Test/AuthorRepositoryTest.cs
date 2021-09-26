using Best_Library_In_The_World.Controllers;
using Best_Library_In_The_World.Domain;
using Best_Library_In_The_World.Repositories;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Best_Libraty_In_The_World.Test
{


    [Fact]
    public async Task GetAll_shouldReturn200_whenDataExists()
    {
        // arrange
        // •    Instans with moq – new Mock<what I am trying to mock and it has to be abstract>(); 
        var dataSource = new Mock<IAuthorRepository>();
        List<Author> authorList = new List<Author>();
        authorList.Add(new Author());
        authorList.Add(new Author());

        dataSource
            .Setup(s => s.getAuthors())
            .ReturnsAsync(authorList);
        // act
        var classThatIsTested = new AuthorNotScaffoldController(dataSource.Object);
        var result = await classThatIsTested.getAuthors();
        //assert
        var statusCodeResult = (IStatusCodeActionResult)result;
        Assert.Equal(200, statusCodeResult.StatusCode);
    }

    [Fact]
    public async Task getAll_shouldReturn204_whenNoAuthors()
    {
        // arrange
        // •    Instans with moq – new Mock<what I am trying to mock and it has to be abstract>(); 
        var dataSource = new Mock<IAuthorRepository>();
        List<Author> authorList = new List<Author>();
        //authorList.Add(new Author());
        //authorList.Add(new Author());

        dataSource
            .Setup(s => s.getAuthors())
            .ReturnsAsync(authorList);
        // act
        var classThatIsTested = new AuthorNotScaffoldController(dataSource.Object);
        var result = await classThatIsTested.getAuthors();
        //assert
        var statusCodeResult = (IStatusCodeActionResult)result;
        Assert.Equal(204, statusCodeResult.StatusCode);
    }

    [Fact]
    public async Task getAll_shouldReturn500_whenAuthorDoesNotExists()
    {
        // arrange
        var dataSource = new Mock<IAuthorRepository>();
        List<Author> authorList = null;
        //authorList.Add(new Author());
        //authorList.Add(new Author());

        dataSource
            .Setup(s => s.getAuthors())
            .ReturnsAsync(authorList);
        // act
        var classThatIsTested = new AuthorNotScaffoldController(dataSource.Object);
        var result = await classThatIsTested.getAuthors();
        //assert
        var statusCodeResult = (IStatusCodeActionResult)result;
        Assert.Equal(500, statusCodeResult.StatusCode);
    }

}
