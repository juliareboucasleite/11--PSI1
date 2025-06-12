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
    let tempoPorJogada = TEMPOS_POR_DIFICULDADE.easy;

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
                selectedDifficulty = dificuldadeSelecionada;
                tempoPorJogada = TEMPOS_POR_DIFICULDADE[dificuldadeSelecionada];
                if (gameStarted) {
                    clearInterval(tempoLimite);
                    iniciarTemporizador();
                } else {
                    tempoDisplay.innerText = tempoPorJogada.toFixed(1);
                }
            }
        });
    }

    // Verifica se as configurações são válidas
    function verificarConfiguracoes() {
        return selectedDifficulty !== null;
    }

    // Prepara o jogo para começar
    const prepararJogo = () => {
        turnoBolinha = false;
        gameStarted = false;
        grid.classList.remove('game-started');
        startButton.textContent = 'Começar Jogo';

        elementosCelulas.forEach(celula => {
            celula.classList.remove("bolinha", "x");
            celula.removeEventListener("click", pegaClick);
        });

        grid.classList.remove('bolinha');
        grid.classList.add('x');
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

        elementosCelulas.forEach(celula => {
            celula.addEventListener("click", pegaClick);
        });

        iniciarTemporizador();
    };

    const iniciarTemporizador = () => {
        if (!gameStarted || turnoBolinha) return;

        clearInterval(tempoLimite);
        let tempoRestante = tempoPorJogada;
        tempoDisplay.innerText = tempoRestante.toFixed(1);

        tempoLimite = setInterval(() => {
            tempoRestante = Math.max(0, tempoRestante - 0.1);
            tempoDisplay.innerText = tempoRestante.toFixed(1);

            if (tempoRestante <= 0) {
                clearInterval(tempoLimite);
                trocaTurnos();
            }
        }, 100);
    };

    const pegaClick = (e) => {
        // Impede jogador de jogar quando não é seu turno ou como O
        if (!gameStarted || turnoBolinha) {
            return;
        }

        const celula = e.target;
        if (celula.classList.contains("x") || celula.classList.contains("bolinha")) {
            return;
        }

        clearInterval(tempoLimite);
        celula.classList.add("x");
        celula.removeEventListener("click", pegaClick);

        if (verificarVitoria("x")) {
            finalizarJogo(false);
        } else if (verificarEmpate()) {
            finalizarJogo(true);
        } else {
            trocaTurnos();
        }
    };

    const trocaTurnos = () => {
        if (!gameStarted) return;

        turnoBolinha = !turnoBolinha;
        grid.classList.remove('bolinha', 'x');
        grid.classList.add(turnoBolinha ? 'bolinha' : 'x');

        if (turnoBolinha) {
            clearInterval(tempoLimite);
            tempoDisplay.innerText = tempoPorJogada.toFixed(1);
            // Faz o bot jogar após um pequeno delay
            setTimeout(() => {
                if (gameStarted && turnoBolinha) {
                    jogadaBot();
                }
            }, 500);
        } else {
            iniciarTemporizador();
        }
    };

    const jogadaBot = () => {
        if (!gameStarted || !turnoBolinha) return;

        const celulasVazias = [...elementosCelulas].filter(
            celula => !celula.classList.contains('x') && !celula.classList.contains('bolinha')
        );

        if (celulasVazias.length > 0) {
            const celulaEscolhida = celulasVazias[Math.floor(Math.random() * celulasVazias.length)];
            celulaEscolhida.classList.add("bolinha");
            celulaEscolhida.removeEventListener("click", pegaClick);

            if (verificarVitoria("bolinha")) {
                finalizarJogo(false);
            } else if (verificarEmpate()) {
                finalizarJogo(true);
            } else {
                trocaTurnos();
            }
        }
    };

    const verificarVitoria = (jogador) => {
        return cobinacoesDeVitoria.some(combinacao => {
            return combinacao.every(index => {
                return elementosCelulas[index].classList.contains(jogador);
            });
        });
    };

    const verificarEmpate = () => {
        return [...elementosCelulas].every(celula => {
            return celula.classList.contains('x') || celula.classList.contains('bolinha');
        });
    };

    const finalizarJogo = (empate) => {
        clearInterval(tempoLimite);
        gameStarted = false;
        startButton.textContent = 'Novo Jogo';

        elementosCelulas.forEach(celula => {
            celula.removeEventListener("click", pegaClick);
        });

        if (empate) {
            texto.innerText = "EMPATE!";
        } else {
            texto.innerText = turnoBolinha ? "O Bot O VENCEU!" : "O Jogador X VENCEU!";
            if (turnoBolinha) {
                pontuacaoO++;
                pontosO.innerText = pontuacaoO;
            } else {
                pontuacaoX++;
                pontosX.innerText = pontuacaoX;
            }
        }

        mensagem.classList.add('mostra-mensagem');
    };

    // Event Listeners
    reinicia.addEventListener('click', prepararJogo);
    startButton.addEventListener('click', iniciarJogo);

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