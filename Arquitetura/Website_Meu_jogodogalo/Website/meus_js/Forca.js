// Jogo da Forca
const palavras = {
    FRUTAS: ['BANANA', 'MAÇA', 'LARANJA', 'MORANGO', 'UVA', 'ABACAXI', 'PERA', 'MANGA', 'MELANCIA'],
    ANIMAIS: ['CACHORRO', 'GATO', 'ELEFANTE', 'LEAO', 'TIGRE', 'GIRAFA', 'MACACO', 'ZEBRA'],
    PAISES: ['BRASIL', 'PORTUGAL', 'ESPANHA', 'FRANCA', 'ITALIA', 'ALEMANHA', 'JAPAO', 'CHINA'],
    CORES: ['VERMELHO', 'AZUL', 'VERDE', 'AMARELO', 'ROXO', 'LARANJA', 'BRANCO', 'PRETO']
};

class JogoDaForca {
    constructor() {
        this.palavraSecreta = '';
        this.categoria = '';
        this.letrasAdivinhadas = new Set();
        this.letrasErradas = new Set();
        this.maxTentativas = 6;
        this.inicializarElementos();
        this.inicializarEventos();
    }

    inicializarElementos() {
        this.palavraElement = document.getElementById('palavra');
        this.categoriaElement = document.getElementById('categoria');
        this.letrasErradasElement = document.getElementById('letras-erradas');
        this.tentativasElement = document.getElementById('tentativas');
        this.mensagemElement = document.getElementById('mensagem');
        this.forcaElement = document.getElementById('forca');
        this.teclasElement = document.getElementById('teclado');
    }

    inicializarEventos() {
        document.addEventListener('keydown', (e) => this.tentarLetra(e.key.toUpperCase()));
        document.getElementById('novo-jogo').addEventListener('click', () => this.iniciarNovoJogo());
    }

    iniciarNovoJogo() {
        // Escolhe categoria e palavra aleatória
        const categorias = Object.keys(palavras);
        this.categoria = categorias[Math.floor(Math.random() * categorias.length)];
        const palavrasDaCategoria = palavras[this.categoria];
        this.palavraSecreta = palavrasDaCategoria[Math.floor(Math.random() * palavrasDaCategoria.length)];

        // Reseta o estado do jogo
        this.letrasAdivinhadas.clear();
        this.letrasErradas.clear();

        // Atualiza a interface
        this.atualizarInterface();
        this.criarTeclado();
        this.desenharForca(0);
    }

    tentarLetra(letra) {
        if (!/[A-Z]/.test(letra)) return; // Aceita apenas letras
        if (this.letrasAdivinhadas.has(letra) || this.letrasErradas.has(letra)) return; // Letra já tentada

        if (this.palavraSecreta.includes(letra)) {
            this.letrasAdivinhadas.add(letra);
        } else {
            this.letrasErradas.add(letra);
            this.desenharForca(this.letrasErradas.size);
        }

        this.atualizarInterface();
        this.verificarFimDeJogo();
    }

    atualizarInterface() {
        // Atualiza a palavra
        this.palavraElement.textContent = this.palavraSecreta
            .split('')
            .map(letra => this.letrasAdivinhadas.has(letra) ? letra : '_')
            .join(' ');

        // Atualiza categoria
        this.categoriaElement.textContent = `Categoria: ${this.categoria}`;

        // Atualiza letras erradas
        this.letrasErradasElement.textContent = `Letras erradas: ${Array.from(this.letrasErradas).join(', ')}`;

        // Atualiza tentativas restantes
        this.tentativasElement.textContent = `Tentativas restantes: ${this.maxTentativas - this.letrasErradas.size}`;
    }

    verificarFimDeJogo() {
        // Verifica vitória
        const palavraCompleta = this.palavraSecreta
            .split('')
            .every(letra => this.letrasAdivinhadas.has(letra));

        if (palavraCompleta) {
            this.mensagemElement.textContent = 'Parabéns! Você venceu!';
            this.desabilitarJogo();
            return;
        }

        // Verifica derrota
        if (this.letrasErradas.size >= this.maxTentativas) {
            this.mensagemElement.textContent = `Game Over! A palavra era: ${this.palavraSecreta}`;
            this.desabilitarJogo();
        }
    }

    criarTeclado() {
        this.teclasElement.innerHTML = '';
        'ABCDEFGHIJKLMNOPQRSTUVWXYZ'.split('').forEach(letra => {
            const botao = document.createElement('button');
            botao.textContent = letra;
            botao.className = 'tecla';
            botao.addEventListener('click', () => this.tentarLetra(letra));
            this.teclasElement.appendChild(botao);
        });
    }

    desabilitarJogo() {
        const teclas = document.querySelectorAll('.tecla');
        teclas.forEach(tecla => tecla.disabled = true);
    }

    desenharForca(erros) {
        const canvas = this.forcaElement.getContext('2d');
        canvas.clearRect(0, 0, this.forcaElement.width, this.forcaElement.height);
        canvas.lineWidth = 2;
        canvas.strokeStyle = '#fff';

        // Base
        canvas.beginPath();
        canvas.moveTo(50, 150);
        canvas.lineTo(150, 150);
        canvas.stroke();

        if (erros > 0) {
            // Poste vertical
            canvas.beginPath();
            canvas.moveTo(100, 150);
            canvas.lineTo(100, 20);
            canvas.stroke();
        }

        if (erros > 1) {
            // Topo
            canvas.beginPath();
            canvas.moveTo(100, 20);
            canvas.lineTo(140, 20);
            canvas.stroke();
        }

        if (erros > 2) {
            // Corda
            canvas.beginPath();
            canvas.moveTo(140, 20);
            canvas.lineTo(140, 40);
            canvas.stroke();
        }

        if (erros > 3) {
            // Cabeça
            canvas.beginPath();
            canvas.moveTo(140, 50);
            canvas.arc(140, 50, 10, 0, Math.PI * 2);
            canvas.stroke();
        }

        if (erros > 4) {
            // Corpo
            canvas.beginPath();
            canvas.moveTo(140, 60);
            canvas.lineTo(140, 100);
            canvas.stroke();

            // Braços
            canvas.beginPath();
            canvas.moveTo(140, 70);
            canvas.lineTo(120, 85);
            canvas.moveTo(140, 70);
            canvas.lineTo(160, 85);
            canvas.stroke();
        }

        if (erros > 5) {
            // Pernas
            canvas.beginPath();
            canvas.moveTo(140, 100);
            canvas.lineTo(120, 125);
            canvas.moveTo(140, 100);
            canvas.lineTo(160, 125);
            canvas.stroke();
        }
    }
}

// Inicializa o jogo quando a página carregar
document.addEventListener('DOMContentLoaded', () => {
    const jogo = new JogoDaForca();
    jogo.iniciarNovoJogo();
});