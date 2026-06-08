# Draftossauros

Projeto desenvolvido em C# inspirado no jogo de tabuleiro **Draftosaurus**.  
O sistema simula partidas com dinossauros, tabuleiros, cercados, regras de posicionamento e validação de jogadas.

## Sobre o projeto

O objetivo do projeto é implementar uma versão digital/autônoma do Draftosaurus, permitindo criar partidas, gerenciar jogadores, controlar turnos, validar jogadas e aplicar as regras dos cercados do tabuleiro.

O código possui integração com uma biblioteca/servidor de jogo, além de classes próprias para representar jogadores, dinossauros, dados, tabuleiro, cercados e jogadas.

## Funcionalidades

- Criação e entrada em partidas;
- Listagem de partidas e jogadores;
- Controle de turno;
- Leitura da face do dado;
- Representação do tabuleiro;
- Representação dos dinossauros;
- Validação de jogadas;
- Aplicação das regras dos cercados;
- Bot autônomo para tomada de decisão;
- Comunicação com o servidor do jogo.

## Regras implementadas

O projeto valida tanto as regras dos cercados quanto as restrições do dado.

Entre as regras de cercados implementadas estão:

- **Floresta da Igualdade**: aceita apenas dinossauros da mesma espécie;
- **Campina da Diferença**: aceita apenas espécies diferentes;
- **Mata Tripla**: aceita até três dinossauros;
- **Rei da Selva** e **Solitário**: aceitam apenas um dinossauro;
- **Rio**: funciona como área livre para posicionamento.

Também há validação para faces do dado, como Floresta, Pradaria, Banheiros, Alimentação, Cercado Vazio e T-Rex.

## Estrutura do projeto

```txt
Draftossauros/
├── Client/
│   ├── Manual.pdf
│   ├── Tabuleiro.pdf
│   ├── Tabuleiro.png
│   └── Draftosaurus Métodos.pdf
│
├── SistemaAutonomo/
│   ├── Controllers/
│   │   ├── Partida.cs
│   │   ├── Program.cs
│   │   ├── RegraJogada.cs
│   │   └── ValidarJogada.cs
│   │
│   ├── Entidades/
│   │   ├── Bot/
│   │   │   ├── Bot.cs
│   │   │   └── JogadaBot.cs
│   │   └── Jogador.cs
│   │
│   ├── Model/
│   │   ├── Cercados/
│   │   ├── Dado.cs
│   │   ├── Dinossauro.cs
│   │   ├── Rio.cs
│   │   └── Tabuleiro.cs
│   │
│   ├── Views/
│   ├── Helpers/
│   ├── Resources/
│   ├── Dinossauros.cs
│   └── SistemaAutonomo.csproj
│
└── README.md
