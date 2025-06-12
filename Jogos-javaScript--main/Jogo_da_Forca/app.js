const palavras = [
    { palavra: "banana", dica: "Fruta amarela e doce" },
    { palavra: "elefante", dica: "O maior animal terrestre" },
    { palavra: "javascript", dica: "Linguagem de programação web" },
    { palavra: "computador", dica: "Máquina para processar dados" },
    { palavra: "oceano", dica: "Grande massa de água salgada" },
    { palavra: "carro", dica: "Veículo com quatro rodas" },
    { palavra: "programador", dica: "Pessoa que escreve código" },
    { palavra: "floresta", dica: "Grande área coberta de árvores" },
    { palavra: "montanha", dica: "Elevação natural do terreno" }
];

let palavraSecreta = "";
let dica = "";
let letrasCorretas = new Set();
let letrasErradas = new Set();
let tentativas = 6;

const wordDisplay = document.getElementById("wordDisplay");
const attemptsDisplay = document.getElementById("attempts");
const hintDisplay = document.getElementById("hint");
const messageDisplay = document.getElementById("message");
const keyboardDiv = document.getElementById("keyboard");
const canvas = document.getElementById("forcaCanvas");
const ctx = canvas.getContext("2d");

const letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".split("");

function iniciarJogo() {
    const randomIndex = Math.floor(Math.random() * palavras.length);
    palavraSecreta = palavras[randomIndex].palavra.toUpperCase();
    dica = palavras[randomIndex].dica;

    letrasCorretas.clear();
    letrasErradas.clear();
    tentativas = 6;
    attemptsDisplay.textContent = tentativas;
    hintDisplay.textContent = dica;
    messageDisplay.textContent = "";
    keyboardDiv.innerHTML = "";
    wordDisplay.textContent = "";

    desenharForca();
    montarTeclado();
    mostrarPalavra();
}

function desenharForca() {
    ctx.clearRect(0, 0, canvas.width, canvas.height);
    ctx.lineWidth = 3;
    ctx.strokeStyle = "#7b52b1";

    // Base
    ctx.beginPath();
    ctx.moveTo(10, 290);
    ctx.lineTo(240, 290);
    ctx.stroke();

    // Poste
    ctx.beginPath();
    ctx.moveTo(40, 290);
    ctx.lineTo(40, 20);
    ctx.stroke();

    // Barra horizontal
    ctx.beginPath();
    ctx.moveTo(40, 20);
    ctx.lineTo(180, 20);
    ctx.stroke();

    // Corda
    ctx.beginPath();
    ctx.moveTo(180, 20);
    ctx.lineTo(180, 50);
    ctx.stroke();

    // Cabeça
    if (tentativas <= 5) {
        ctx.beginPath();
        ctx.arc(180, 70, 20, 0, Math.PI * 2);
        ctx.stroke();
    }
    // Corpo
    if (tentativas <= 4) {
        ctx.beginPath();
        ctx.moveTo(180, 90);
        ctx.lineTo(180, 170);
        ctx.stroke();
    }
    // Braço esquerdo
    if (tentativas <= 3) {
        ctx.beginPath();
        ctx.moveTo(180, 110);
        ctx.lineTo(140, 140);
        ctx.stroke();
    }
    // Braço direito
    if (tentativas <= 2) {
        ctx.beginPath();
        ctx.moveTo(180, 110);
        ctx.lineTo(220, 140);
        ctx.stroke();
    }
    // Perna esquerda
    if (tentativas <= 1) {
        ctx.beginPath();
        ctx.moveTo(180, 170);
        ctx.lineTo(140, 220);
        ctx.stroke();
    }
    // Perna direita
    if (tentativas <= 0) {
        ctx.beginPath();
        ctx.moveTo(180, 170);
        ctx.lineTo(220, 220);
        ctx.stroke();
    }
}

function montarTeclado() {
    letras.forEach(letra => {
        const button = document.createElement("button");
        button.className = "key";
        button.textContent = letra;
        button.id = `key_${letra}`;
        button.addEventListener("click", () => verificarLetra(letra));
        keyboardDiv.appendChild(button);
    });
}

function mostrarPalavra() {
    let display = "";
    for (let letra of palavraSecreta) {
        display += letrasCorretas.has(letra) ? letra + " " : "_ ";
    }
    wordDisplay.textContent = display.trim();
}

function verificarLetra(letra) {
    if (letrasCorretas.has(letra) || letrasErradas.has(letra)) return;

    if (palavraSecreta.includes(letra)) {
        letrasCorretas.add(letra);
        mostrarPalavra();
        messageDisplay.textContent = "Boa! Letra correta!";
        messageDisplay.style.color = "#4caf50";
    } else {
        letrasErradas.add(letra);
        tentativas--;
        attemptsDisplay.textContent = tentativas;
        messageDisplay.textContent = "Ops! Letra errada!";
        messageDisplay.style.color = "#e53935";
    }
    desenharForca();
    desabilitarTecla(letra);
    verificarFimDeJogo();
}

function desabilitarTecla(letra) {
    const button = document.getElementById(`key_${letra}`);
    if (button) button.disabled = true;
}

function verificarFimDeJogo() {
    if (tentativas <= 0) {
        messageDisplay.textContent = `Você perdeu! A palavra era: ${palavraSecreta}`;
        desabilitarTodasTeclas();
    } else if ([...palavraSecreta].every(letra => letrasCorretas.has(letra))) {
        messageDisplay.textContent = "Parabéns! Você ganhou!";
        desabilitarTodasTeclas();
    }
}

function desabilitarTodasTeclas() {
    letras.forEach(letra => {
        const button = document.getElementById(`key_${letra}`);
        if (button) button.disabled = true;
    });
}

document.addEventListener("keydown", e => {
    const letra = e.key.toUpperCase();
    if (letras.includes(letra)) {
        verificarLetra(letra);
    }
});

document.getElementById("restartBtn").addEventListener("click", iniciarJogo);

iniciarJogo();