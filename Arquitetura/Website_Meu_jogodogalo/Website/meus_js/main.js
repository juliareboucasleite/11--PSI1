//Pego o Layout das grades de: https://github.com/gabriel-bto/jogo-da-velha/blob/24c7bbdb849567801258fedd1b5d00122e46ed61/index.html

document.addEventListener("DOMContentLoaded", () => {
    const elementosCelulas = document.querySelectorAll('.grid-celulas');
    const grid = document.querySelector('.grid');
    const mensagem = document.querySelector('.mensagem');
    const texto = document.querySelector('.mensagem-texto');
    const reinicia = document.querySelector('.mensagem-button');
    const startButton = document.getElementById('start-game');
    const difficultyBtns = document.querySelectorAll('.difficulty-btn');
    const tempoDisplay = document.getElementById('tempo');

    let turnoBolinha;
    let tempoLimite;
    let gameStarted = false;
    let selectedDifficulty = null;

    // Define tempos por dificuldade
    const TEMPOS_POR_DIFICULDADE = {
        'easy': 5,
        'medium': 3.5,
        'hard': 2
    };
    let tempoPorJogada = TEMPOS_POR_DIFICULDADE.easy; // Valor padrão

    const cobinacoesDeVitoria = [
        [0, 1, 2],
        [3, 4, 5],
        [6, 7, 8],
        [0, 3, 6],
        [1, 4, 7],
        [2, 5, 8],
        [0, 4, 8],
        [2, 4, 6],
    ];

    // Atualiza visual dos botões de dificuldade
    function atualizarBotoesDificuldade(dificuldadeSelecionada) {
        difficultyBtns.forEach(btn => {
            btn.classList.remove('active');
            if (btn.dataset.difficulty === dificuldadeSelecionada) {
                btn.classList.add('active');
                tempoPorJogada = TEMPOS_POR_DIFICULDADE[dificuldadeSelecionada];
                if (gameStarted) {
                    clearInterval(tempoLimite);
                    iniciarTemporizador();
                } else {
                    tempoDisplay.innerText = tempoPorJogada;
                }
            }
        });
    }

    // Verifica se as configurações são válidas
    function verificarConfiguracoes() {
        return selectedDifficulty !== null;
    }

    // Inicia o temporizador
    const iniciarTemporizador = () => {
        if (!gameStarted) return;

        clearInterval(tempoLimite);
        let tempoRestante = tempoPorJogada;
        tempoDisplay.innerText = tempoRestante.toFixed(1);

        tempoLimite = setInterval(() => {
            tempoRestante -= 0.1;
            tempoDisplay.innerText = tempoRestante.toFixed(1);

            if (tempoRestante <= 0) {
                clearInterval(tempoLimite);
                trocaTurnos();
            }
        }, 100);
    };

    // Prepara o jogo para começar
    const prepararJogo = () => {
        turnoBolinha = false;
        gameStarted = false;
        grid.classList.remove('game-started');
        startButton.textContent = 'Começar Jogo';

        for (const celulas of elementosCelulas) {
            celulas.classList.remove("bolinha");
            celulas.classList.remove("x");
            celulas.removeEventListener("click", pegaClick);
        }

        trocaClasse();
        mensagem.classList.remove('mostra-mensagem');
        clearInterval(tempoLimite);
        tempoDisplay.innerText = tempoPorJogada.toFixed(1);
    };

    // Inicia o jogo
    const iniciarJogo = () => {
        if (!verificarConfiguracoes()) {
            alert('Selecione uma dificuldade para começar!');
            return;
        }

        gameStarted = true;
        grid.classList.add('game-started');
        startButton.textContent = 'Jogo em Andamento';

        for (const celulas of elementosCelulas) {
            celulas.addEventListener("click", pegaClick, { once: true });
        }

        iniciarTemporizador();
    };

    const finalizaJogo = (empate) => {
        clearInterval(tempoLimite);
        gameStarted = false;
        startButton.textContent = 'Novo Jogo';

        if (empate) {
            texto.innerText = "EMPATE!";
        } else {
            const simbolo = turnoBolinha ? "O" : "X";
            texto.innerText = `Jogador ${simbolo} VENCEU!`;
            if (turnoBolinha) {
                pontuacaoO++;
                pontosO.innerText = pontuacaoO;
            } else {
                pontuacaoX++;
                pontosX.innerText = pontuacaoX;
            }
        }

        for (const celulas of elementosCelulas) {
            grid.classList.remove('bolinha');
            grid.classList.remove('x');
            celulas.removeEventListener("click", pegaClick);
        }
        mensagem.classList.add('mostra-mensagem');
    };

    const verificacaoPorVitoria = (turnoAtual) => {
        return cobinacoesDeVitoria.some((combinacao) => {
            return combinacao.every((index) => {
                return elementosCelulas[index].classList.contains(turnoAtual);
            });
        });
    };

    const verificacaoPorEmpate = () => {
        return [...elementosCelulas].every((celulas) => {
            return celulas.classList.contains('x') || celulas.classList.contains('bolinha');
        });
    };

    const adicionaEscolha = (celula, adicionaClasse) => celula.classList.add(adicionaClasse);

    const trocaClasse = () => {
        grid.classList.remove('bolinha');
        grid.classList.remove('x');

        if (turnoBolinha) {
            grid.classList.add('bolinha');
        } else {
            grid.classList.add('x');
        }
    };

    const trocaTurnos = () => {
        if (!gameStarted) return;
        turnoBolinha = !turnoBolinha;
        trocaClasse();
        iniciarTemporizador();
    };

    const pegaClick = (e) => {
        if (!gameStarted) return;

        clearInterval(tempoLimite);
        const celula = e.target;

        if (celula.classList.contains("x") || celula.classList.contains("bolinha")) {
            return;
        }

        const adicionaClasse = turnoBolinha ? "bolinha" : "x";
        adicionaEscolha(celula, adicionaClasse);

        const vencedor = verificacaoPorVitoria(adicionaClasse);
        const empate = verificacaoPorEmpate();

        if (vencedor) {
            finalizaJogo(false);
        } else if (empate) {
            finalizaJogo(true);
        } else {
            trocaTurnos();
        }
    };

    // Event Listeners
    reinicia.addEventListener('click', prepararJogo);
    startButton.addEventListener('click', iniciarJogo);

    // Dificuldade
    difficultyBtns.forEach(btn => {
        btn.addEventListener('click', () => {
            if (!gameStarted) {
                selectedDifficulty = btn.dataset.difficulty;
                atualizarBotoesDificuldade(selectedDifficulty);
            }
        });
    });

    // Pontuação
    const pontosX = document.getElementById('pontosX');
    const pontosO = document.getElementById('pontosO');
    let pontuacaoX = 0;
    let pontuacaoO = 0;

    // Inicializa o jogo
    prepararJogo();
});