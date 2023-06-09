# DesignPatternsCSharp

- Curso Design Patterns com C# - Entendendo Padrões de Projetos (Udemy)

Seção 1 - Entendendo o princípio SOLID
 

S - Single Responsability Principle (Principio da Responsabilidade Única)
  "Nunca deve haver mais de um motivo para uma classe mudar." Criando classes simples e objetivas que trabalha com um unico assunto. 
  Classes com mais de um objetivo sai do principio SRP e passa a ser uma classe inflada.
  
O - Open/Closed Principle (Principio aberto/fechado)
  "Aberto para extensão e Fechado para modificação." a entidade pode permitir que o seu comportamento seja estendido sem modificar seu código-fonte.
  
L - Liskov Substitution Principle (Principio da Substituição de Liskov)
  "Uma classe derivada pode ser substituível por sua classe base." Dirigida a interface, caso precise fazer alguma substituição o codigo nao vai quebrar. 
  
I - Interface Segregation Principle (Principio da Segregação de Interfaces)
  "Classes nao devem ser forçadas a depender de métodos que nao usam." É possivel criar mais de uma interface, evitando deixar metodos vazios dentro da classes fazendo uma segregação da interface.

D - Dependency Inversion Principle (Principio da Inversão de Dependencia)
  "Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações; Abstrações não devem depender de detalhes." 



  Seção 2 - Gang of Four (Gangue dos Quatro)


Classificado por 3 categorias, veremos os seguintes  

- Criacional 

    Factory Method: define uma interface para criar um objeto, mais deixa que as subclasses decidam qual classe instânciar. O Factory Method permite a uma classe adiar a instânciação às subclasses.

    Abstract Method: define uma interface para criar todos os produtos distintos, mas deixa a criação real do produto para classes fábrica concretas.

    Builder: utilizado quando formos construir um objeto complexo. Quebrando o processo de criação do projeto em etapas. 

- Estrutural

    Adapter: permite que as classes trabalhem juntas que não poderiam de outra forma por causa de interfaces incompatíveis. Agrupe uma classe existente com uma nova interface. Ex: benjamin, ele faz a adaptação/conversao da interface de um objeto para que outro objeto possa compreender as informações.

    Bridge: é um padrão de projeto estrutural que permite que você divida uma classe grande ou um conjunto de classes intimamente ligadas em duas hierarquias separadas—abstração e implementação—que podem ser desenvolvidas independentemente umas das outras.

- Comportamental 

    Chain of Responsability: é um padrão de projeto comportamental que permite que você passe pedidos por uma corrente de handlers. Ao receber um pedido, cada handler decide se processa o pedido ou o passa adiante para o próximo handler na corrente.
