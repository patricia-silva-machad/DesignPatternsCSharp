# DesignPatternsCSharp


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

    Factory Method, Abstract Method and Builder. 

- Estrutural

    Adapter and Bridge.

- Comportamental 

    Chain of Responsability 