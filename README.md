Este projeto de console em C# demonstra a aplicação de alguns dos principais padrões de projetos criacionais: Factory, Singleton, Builder e Prototype. A ideia é alinhar a teoria com a prática, permitindo visualizar de forma concreta como esses padrões podem ser implementados e utilizados no desenvolvimento de software.

Visão Geral
Durante minha formação em Padrões de Projetos Criacionais na Pluralsight, aprofundei o entendimento teórico e prático desses padrões. Embora já usasse alguns deles no dia a dia (inclusive o Fluent Builder, sem saber que já fazia parte dos padrões), essa formação me permitiu explorar variações e aplicações que antes não conhecia.

Neste projeto, você encontrará exemplos que ilustram:

Factory: Como criar objetos sem expor a lógica de instanciamento ao cliente, utilizando um indicador (enum) para escolher a implementação correta.
Singleton: Como garantir que apenas uma instância de uma classe seja criada durante o ciclo de vida da aplicação, com controle de acesso seguro a partir de múltiplas threads.
Builder: Como construir objetos complexos passo a passo, utilizando um estilo fluent para tornar o código mais legível e modular.
Prototype: Como clonar objetos existentes (com suporte para clonagem profunda) para criar novos objetos sem a necessidade de reconstruí-los do zero.

Tecnologias Utilizadas
C# (.NET Core / .NET 5 ou superior)
Visual Studio como ambiente de desenvolvimento
Git e GitHub para versionamento e compartilhamento do código
Estrutura do Projeto
/DesignPatternsCreational
/Creational/Factory: Exemplo do padrão Factory.
/Creational/Singleton: Exemplo do padrão Singleton.
/Creational/Builder: Exemplo do padrão Builder.
/Creational/Prototype: Exemplo do padrão Prototype.

/Docs: Documentação adicional e certificados da formação.
