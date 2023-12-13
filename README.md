
# Documentação do Projeto Portfolio - Abstração de Personagens de RPG
## Introdução
O projeto consiste na implementação de uma abstração de personagens de RPG em C# utilizando a programação orientada a objetos. A abstração inclui a definição de uma classe base chamada Heros e quatro classes derivadas: Knight, Ninja, WhiteWizard e BlackWizard, cada uma representando um tipo específico de personagem.

## Estrutura do Projeto
O projeto está organizado em um conjunto de arquivos que compõem as classes e a lógica de execução principal. Abaixo estão os principais arquivos:

### Arquivo Principal
Program.cs: Contém o código principal que cria instâncias dos personagens e chama seus métodos.
### Arquivos de Classes
Heros.cs: Define a classe abstrata Heros, que serve como classe base para os personagens.

Knight.cs: Implementa a classe Knight, derivada de Heros, representando um cavaleiro.

Ninja.cs: Implementa a classe Ninja, derivada de Heros, representando um ninja.

WhiteWizard.cs: Implementa a classe WhiteWizard, derivada de Heros, representando um mago branco.

BlackWizard.cs: Implementa a classe BlackWizard, derivada de Heros, representando um mago negro.

## Uso do Projeto
O uso do projeto é exemplificado no arquivo Program.cs, onde quatro instâncias diferentes dos personagens são criadas (um cavaleiro, um ninja, um mago branco e um mago negro) e seus métodos Apresentar e Atacar são chamados.

## Conclusão
O projeto "Portfolio" oferece uma estrutura básica para representar e interagir com personagens de RPG. A utilização de classes abstratas e herança proporciona uma forma flexível de adicionar novos tipos de personagens no futuro, facilitando a expansão do projeto conforme necessário.