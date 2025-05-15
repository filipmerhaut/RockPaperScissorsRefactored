RockPaperScissors refactored accoring to the tutorial "Dependency Injection in C# ❘ A Hands-On Guide to Boosting Code Flexibility and Testability"
https://www.youtube.com/watch?v=cCSrPZroICg

IMPORANT: 
- in VS Code, add new classes with CLI command "dotnet new class -n <classname>"
- once you add new UnitTests projects, you need to move the original "root" project to a new folder, e.g. "Game",
  so that the project .csproj file is not in the same folder as the new solution .sln file

Steps:
- add interface IPlayer with one method GetChoice
- implement IPlayer interface in HumanPlayer, ComputerPlayer and ForcedPlayer classes
- modify GameManager class to take two IPlayers as constructor parameters
- modify GameManager class to use IPlayers to play the game
- move the original "root" project to a new folder, e.g. "Game"
- add new project (Ctrl+shift+P) to the solution - type "xUnit Test Project", name UnitTests
- add reference to the new project to the rockpaperscissors project
 (dotnet add <path to UnitTests project> reference <path to rockpaperscissor project>)
- modify GameManager.PlayRound() method to return a RoundResult enum
- make the GameManager.PlayRound() method public so that it can be called from unit tests
- create unit tests for the GameManager.PlayRound() method, using the ForcedPlayer class to simulate the human and computer players

