***POC - Criando uma aplicação de transferências bancarias com .NET***  - resumo

**Objetivos do Projeto** 

1. Orientação a Objetos na prática
2. Criar uma classe que simula uma conta bancária
3. Criar simulação de transferência bancária.

**PARTE 1**

**Revisão OO - POO na prática.**

PROCEDURAL x Orientação a Objetos

| PROCEDURAL                           | Orientação a Objetos                             |
| ------------------------------------ | ------------------------------------------------ |
| Criar código rapidamente             | Mais fácil de manter                             |
| Mais difícil para manter             | Reuso                                            |
| Pequenos times e pequenas aplicações | Mais fácil e rápido de adicionar funcionalidades |
|                                      | Em alguns casos, menor performance               |
|                                      | Curva de aprendizado um pouco maior              |
|                                      |                                                  |

**Conceitos Básicos **-- Classe e Objeto

- As classes formam a estrutura de atributos (propriedades) e métodos (ações) e usam essas informações para construir objetos.

- Exemplo 1 - a classe é como a planta de uma casa ; e o Objeto é a construção obedecendo a estrutura definida na classe, podendo ter casas com cores, portas, janelas e tipos de telhado diferentes, mas obedecendo a planta da casa.

- Exemplo 2 (classes com métodos ) - Definimos uma classe Pokémon, contendo --( nome , tipo, vidas )=> Atributos ---  (ataque(), esquiva(), evolui())=> Métodos ||| então construindo um Objeto dessa classe ficaria: nome: Pikachu , tipo: elétrico , vidas: 70 -- que terá as ações(métodos) ataque, esquiva, evolui.

- Nas classes temos o conceito de herança(um dos pilares da POO) que é a habilidade de construir novas classes em cima de classes já existentes. O maior benefício da herança é a reutilização de código, no exemplo da Classe Pokémon -- existem Pokémon que evoluíram de outros, e herdam as características do Pokémon primário e podem ter suas próprias características.

  

**PARTE 2**

**Collections**

Inicialmente tinhamos :

Arrays

- Vetores

- Objetos do mesmo tipo

- Itens são chamados elementos

  

  Tipos de declaração de array em C#

  ```c#
  // declaração de uma array de inteiros
  int[] numeros;
  //declaração determinando a quantidade de elementos
  int[] numeros = new int[15];
  //declaração determinando a quantidade de elementos e os valores
  int[] numeros = new int[1,2,3,4,5,6,7,8,9];
  // ou ainda o mais usado
  string[] meses = new {"janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", ...};
  ```

Como vimos arrays são usados quando o tamanho da coleção é conhecida, mas frequentemente não sabemos o tamanho ou ainda quais elementos podem ser adicionados/removidos durante a execução.

Para essas situações usamos as collections, para isso usamos a seguinte classe:

```c#
using System.Collections.Generic;
```

A coleção mais comum em C# é a List<T>, onde T é a classe dos objetos que serão os elementos da lista/ coleção.

Acesse:

https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.list-1.find?view=net-5.0