// Dificuldade do bot e lógica de movimentos inteligentes
const BotDifficulty = {
    EASY: 'easy',
    MEDIUM: 'medium',
    HARD: 'hard'
};

let currentDifficulty = BotDifficulty.EASY;

// Função para mudar a dificuldade do bot
function setBotDifficulty(difficulty) {
    currentDifficulty = difficulty;
}

// Função para verificar se há uma jogada vencedora disponível
function encontrarJogadaVencedora(elementosCelulas, jogador) {
    const cobinacoesDeVitoria = [
        [0, 1, 2],
        [3, 4, 5],
        [6, 7, 8], // Horizontais
        [0, 3, 6],
        [1, 4, 7],
        [2, 5, 8], // Verticais
        [0, 4, 8],
        [2, 4, 6] // Diagonais
    ];

    for (let combinacao of cobinacoesDeVitoria) {
        let [a, b, c] = combinacao;
        let celulas = [
            elementosCelulas[a],
            elementosCelulas[b],
            elementosCelulas[c]
        ];

        // Conta quantas células o jogador já tem na combinação
        let jogadorCelulas = celulas.filter(cell =>
            cell.classList.contains(jogador)).length;

        // Conta células vazias na combinação
        let celulasVazias = celulas.filter(cell =>
            !cell.classList.contains('x') &&
            !cell.classList.contains('bolinha'));

        // Se o jogador tem 2 células e há uma vazia, retorna a célula vazia
        if (jogadorCelulas === 2 && celulasVazias.length === 1) {
            return celulasVazias[0];
        }
    }
    return null;
}

// Função para encontrar a melhor jogada baseada na dificuldade
function encontrarMelhorJogada(elementosCelulas) {
    // Array com todas as células vazias
    const celulasVazias = [...elementosCelulas].filter(celula =>
        !celula.classList.contains('x') && !celula.classList.contains('bolinha')
    );

    if (celulasVazias.length === 0) return null;

    // Lógica baseada na dificuldade
    switch (currentDifficulty) {
        case BotDifficulty.EASY:
            // No modo fácil, 80% de chance de fazer uma jogada aleatória
            if (Math.random() < 0.8) {
                return celulasVazias[Math.floor(Math.random() * celulasVazias.length)];
            }
            // 20% de chance de fazer uma jogada inteligente
            break;

        case BotDifficulty.MEDIUM:
            // No modo médio, 50% de chance de fazer uma jogada inteligente
            if (Math.random() < 0.5) {
                return celulasVazias[Math.floor(Math.random() * celulasVazias.length)];
            }
            break;

        case BotDifficulty.HARD:
            // No modo difícil, sempre tenta fazer a melhor jogada
            break;
    }

    // Verifica se o bot pode vencer na próxima jogada
    let jogadaVencedora = encontrarJogadaVencedora(elementosCelulas, 'bolinha');
    if (jogadaVencedora) return jogadaVencedora;

    // Verifica se precisa bloquear o jogador
    let jogadaBloqueio = encontrarJogadaVencedora(elementosCelulas, 'x');
    if (jogadaBloqueio) return jogadaBloqueio;

    // Se o centro está vazio, tenta ocupá-lo (estratégia importante)
    if (!elementosCelulas[4].classList.contains('x') &&
        !elementosCelulas[4].classList.contains('bolinha')) {
        return elementosCelulas[4];
    }

    // Tenta ocupar os cantos vazios
    const cantos = [0, 2, 6, 8];
    const cantosVazios = cantos.filter(i =>
        !elementosCelulas[i].classList.contains('x') &&
        !elementosCelulas[i].classList.contains('bolinha')
    );

    if (cantosVazios.length > 0) {
        return elementosCelulas[cantosVazios[Math.floor(Math.random() * cantosVazios.length)]];
    }

    // Se nenhuma estratégia específica for aplicável, faz uma jogada aleatória
    return celulasVazias[Math.floor(Math.random() * celulasVazias.length)];
}

// Exporta as funções e constantes necessárias
window.BotDifficulty = BotDifficulty;
window.setBotDifficulty = setBotDifficulty;
window.encontrarMelhorJogada = encontrarMelhorJogada;