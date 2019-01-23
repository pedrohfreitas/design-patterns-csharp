# design-patterns-csharp
Projeto de implementação de Designers Patterns, com o C#, baseado no GoF (Livro: "Design PAtterns: Elements of Reusable Object-Oriented Software")

# conceito
Padrões de Proketo são soluções para problemas de desenvolvimento e arquitetora de software que podem ser utilizadas de diversas maneiras na construção de software independente da linguagem utilizada

# pilares
## Abstração
  O fato de você olhar o mundo real, e o transformalo em objetos dentro do software, no mundo da programação
## Herança
  Compartilhamento de caracteristicas dentro do objeto
## Encapsulamento
  Definir os nívels de acesso no objeto
## Polimmorfismo
  Um único objeto que tem a capacidade de se comportar de maneiras diferentes

# patterns criacionais
Tem como objeto a instanciação de objetos. "Programe para interfaces e não para implementações"

# tipos
## Padrão Criacionais
Dizem respeito ao processo de criação de objetos
## Padrões Estruturais
Lidam com a composição de classes ou objetos
## Padrões Comportamentais
Caracterizam as maneiras pelas quais as classes ou objetos interesagem 

# patterns
## Singleton
 - Patterns de Criação
 - Solteirão
 - Cenário: Controlar o acesso as instâncias de classes garantiando que seja instanciada apenas uma vez, para reduzir a utilização de memória.

 ## Factory Method
  - Patterns de Criação 
  - Método de Fábrica
  - Frase: "Abstração não deve depender de detalhes, detalhes é quem deve depender de abstrações"
  - Resumo: Cria uma instância de várias classes DERIVADAS
  - Cenário: Eu tenho vários objetos, mas eu não sei o tipo que deve ser instanciado. Preciso delegar a responsábilidade para que as subclasses especifiquem os objetos que criam.
  - Objetivo: também conhecido como Construtor Virtual, o objeto desse padrão é a possibilidade de criar uma fábria de objetos em tempo de execução e deixar que o objeto decida seu tipo dinamicamente. O Factory Method dispõe uma interface que cria um objeto, mas não as subclasses que irão decidir qual classe concreta instanciar.

## Abstract Factory
 - Patterns de Criação
 - Resumo: Cria uma instância de várias fámilias de classes 
 - Fornece uma interface para criar fámilias de objetos relacionados ou dependentes sem especificar suas classes concretas



# CLI Commands
dotnet new sln --name <SOLUTION_NAME>
dotnet new sln --name DesignPatterns

dotnet new console --name <PROJECT_NAME>
dotnet new console --name Singleton

dotnet sln <SOLUTION_NAME> add <PROJECT>
dotnet sln .\DesignPatterns.sln add .\Criacao\Singleton\Singleton.csproj

dotnet run --project <PROJECT_NAME>
dotnet run --project .\Criacao\Singleton\Singleton.csproj

# créditos
Curso Udemy - https://www.udemy.com/curso-de-design-patterns-com-c-desenvolvimento-avancado
