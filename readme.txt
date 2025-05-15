RockPaperScissors refactored accoring to the tutorial "Dependency Injection in C# ❘ A Hands-On Guide to Boosting Code Flexibility and Testability"
https://www.youtube.com/watch?v=cCSrPZroICg

Tip: 
- add new classes with CLI command "dotnet new class -n <classname>"

Steps:
- add interface IPlayer with one method GetChoice
- implement IPlayer interface in HumanPlayer, ComputerPlayer and ForcedPlayer classes
- modify GameManager class to take two IPlayers as constructor parameters
- modify GameManager class to use IPlayers to play the game
- add new project (Ctrl+shift+P) to the solution - type "xUnit Test Project", name UnitTests
- add reference to the new project to the rockpaperscissors project
 (dotnet add <path to UnitTests project> reference <path to rockpaperscissor project>)
