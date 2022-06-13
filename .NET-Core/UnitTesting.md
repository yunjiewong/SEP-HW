<h2 align="center"> Unit Testing </h2>


1. priority 
2. testing framework:MS Test, NUnit, xUnit
3. mocking Framewokr: **Moq**, FakeItEasy, NSubstitute

testing should be very fast, short ... in memory data
  //AAA
      //Arrange, Act, Assert
```
[TestClass]
public class MovieServiceUnitTest
{
    private MovieService sut;
    
    [TestInitialize]
    
    [TestMethod]
    Public async Task Task....()
    {
      //mock object, data, method etc ARRANGE
      _sut = new MovieService(new MockMovieRepository);
      var movies = await _sut.getTop...;   //ACT
      
      //check actual output with expected data
      Assert.IsNotNull(movies)  //Assert
      
```


big cloud provider
1. AWS
2. Azure

1.Domain name 2. deploy your application code  3.build your own server

IaaS Infrastructure as a Service
PaaD platform as a Service
SaaS Software as a Service

CI continuous Integration
  - automated tests execute as part of the CI process to ensure quality
  - main branch , feature branch,
CD continuous delivery
