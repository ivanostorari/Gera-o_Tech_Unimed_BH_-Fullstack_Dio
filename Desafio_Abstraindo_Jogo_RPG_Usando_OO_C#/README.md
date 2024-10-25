Ivan Wagner.

# Abstraindo um jogo de RPG Usando Orientação a Objetos com C#

Este projeto demonstra a construção de um jogo de RPG básico usando princípios de programação orientada a objetos em C#.

### Descrição do Projeto
O projeto consiste na criação de uma estrutura de classes que representam personagens em um jogo de RPG. Cada personagem possui atributos como nome, nível, tipo de herói, pontos de vida (HP) e força. A lógica do jogo inclui métodos para atacar, aumentar velocidade e gerenciar atributos de vitalidade e magia.

### Estrutura de Classes

#### Classe _Hero_

A classe Hero é uma classe abstrata que serve como base para diferentes tipos de heróis. Ela contém os seguintes atributos e métodos:

#### Atributos:

* Name: Nome do herói.

* Level: Nível do herói.

* HeroType: Tipo de herói.

* HP: Pontos de vida do herói.

* Strength: Força do herói.

#### Métodos:

* ToString(): Retorna uma string com informações do herói.

* Attack(): Método virtual que retorna uma mensagem de ataque.

* Speed(): Aumenta a velocidade do herói dependendo de seus pontos de vida.

* Vitality(): Ajusta a força do herói com base nos pontos de vida.

* Magic(): Ajusta a força mágica, defesa mágica e evasão do herói com base nos pontos de vida.

#### Classes _Knight_ e _Wizard_

As classes _Knight_ e _Wizard_ herdam de Hero e representam tipos específicos de heróis.

* _Knight_: Herói que usa espada.

* _Wizard_: Herói que usa magia.

### Exemplo de Uso

Aqui está um exemplo de como criar e usar as classes Knight e Wizard no programa principal:

~~~CSharp
public class Program {
    public static void Main(string[] args) {
        Knight Arus = new Knight("Arus", 23, "Knight", 15, 12);
        Wizard wizard = new Wizard("Jennica", 23, "White Wizard", 9, 8);

        Console.WriteLine(Arus.Attack());
        wizard.Speed(); // Executa o método Speed para o wizard
    
~~~