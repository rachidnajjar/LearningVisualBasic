# LearningVisualBasic
Contient une solution avec tous les projets vb.net

- Créer la solution :                   dotnet new sln -n LearningVisualBasic
- Créer un projet :                     dotnet new console -n HelloConsole -lang vb
- ajouter le projet dans la solution :  dotnet sln add HelloConsole/HelloConsole.vbproj
- Créer un projet de test unitaire :    dotnet new mstest -n HelloConsole.Test -lang vb
- Ajouter la référence au projet :      dotnet add HelloConsole.Test/HelloConsole.Test.vbproj reference HelloConsole/HelloConsole.vbproj
- ajouter le projet dans la solution :  dotnet sln add HelloConsole.Test/HelloConsole.Test.vbproj
- compiler la solution :                dotnet build
- lister les test présents :            dotnet test -t
- lancer les test:                      dotnet test