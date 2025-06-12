function openExercise(url) {
    const modal = document.getElementById('exerciseModal');
    const iframe = document.getElementById('exerciseFrame');

    // Limpar o iframe antes de carregar novo conteúdo
    iframe.src = '';

    // Mostrar modal
    modal.style.display = 'flex';

    // Carregar URL após um pequeno delay para garantir que o modal está visível
    setTimeout(() => {
        iframe.src = url;

        // Enviar tema atual para o iframe após ele carregar
        iframe.onload = () => {
            const currentTheme = localStorage.getItem('selectedTheme') || 'theme-white';
            iframe.contentWindow.postMessage({
                type: 'themeChange',
                theme: currentTheme
            }, '*');
        };
    }, 100);
}

function closeExercise() {
    const modal = document.getElementById('exerciseModal');
    const iframe = document.getElementById('exerciseFrame');
    iframe.src = '';
    modal.style.display = 'none';
}

function toggleMusic() {
    const music = document.getElementById('background-music');
    const btn = document.getElementById('music-btn');
    if (music.paused) {
        music.play();
        btn.textContent = '🔇';
    } else {
        music.pause();
        btn.textContent = '🎵';
    }
}

const themes = ["theme-white", "theme-dark", "theme-warm"];
let currentTheme = 0;

function cycleTheme() {
    document.body.classList.remove(...themes);
    currentTheme = (currentTheme + 1) % themes.length;
    document.body.classList.add(themes[currentTheme]);

    const btn = document.getElementById("theme-btn");
    btn.textContent = currentTheme === 1 ? "🌙" : currentTheme === 2 ? "🌤️" : "🎨";
}

function initializeThemes() {
    const themeOptions = document.querySelectorAll('.theme-option');
    const savedTheme = localStorage.getItem('selectedTheme') || 'theme-white';

    // Remover todos os temas existentes primeiro
    document.body.classList.remove('theme-white', 'theme-dark', 'theme-warm', 'theme-purple', 'theme-ocean');

    // Adicionar o tema salvo
    document.body.classList.add(savedTheme);

    // Atualizar estado ativo
    themeOptions.forEach(option => {
        if (option.dataset.theme === savedTheme) {
            option.classList.add('active');
        } else {
            option.classList.remove('active');
        }

        option.addEventListener('click', () => {
            // Remover todos os temas existentes
            document.body.classList.remove('theme-white', 'theme-dark', 'theme-warm', 'theme-purple', 'theme-ocean');

            // Adicionar novo tema
            document.body.classList.add(option.dataset.theme);
            localStorage.setItem('selectedTheme', option.dataset.theme);

            // Atualizar estado ativo
            themeOptions.forEach(opt => opt.classList.remove('active'));
            option.classList.add('active');

            // Propagar mudança de tema para o iframe ativo
            const iframe = document.getElementById('exerciseFrame');
            if (iframe && iframe.contentWindow) {
                iframe.contentWindow.postMessage({
                    type: 'themeChange',
                    theme: option.dataset.theme
                }, '*');
            }
        });
    });
}

function changeUserName() {
    Swal.fire({
        title: 'Mudar Nome',
        text: 'Como você gostaria de ser chamado?',
        input: 'text',
        inputValue: localStorage.getItem("nomeUsuario") || '',
        inputPlaceholder: 'Digite seu nome...',
        showCancelButton: true,
        confirmButtonText: 'Salvar',
        cancelButtonText: 'Cancelar',
        showClass: {
            popup: 'animate__animated animate__fadeInDown'
        },
        hideClass: {
            popup: 'animate__animated animate__fadeOutUp'
        }
    }).then((result) => {
        if (result.isConfirmed && result.value) {
            const nome = result.value;
            localStorage.setItem("nomeUsuario", nome);
            updateUserName(nome);

            Swal.fire({
                title: 'Nome Atualizado!',
                text: `Bem-vindo(a), ${nome}!`,
                icon: 'success',
                timer: 2000,
                showConfirmButton: false
            });
        }
    });
}

function updateUserName(name) {
    const userNameSpan = document.getElementById('userName');
    if (userNameSpan) {
        userNameSpan.textContent = name;
    }
}

function askForUserName() {
    let nome = localStorage.getItem("nomeUsuario");
    if (!nome) {
        Swal.fire({
            title: 'Bem-vindo(a)!',
            text: 'Como podemos te chamar?',
            input: 'text',
            inputPlaceholder: 'Digite seu nome...',
            allowOutsideClick: false,
            confirmButtonText: 'Continuar',
            showClass: {
                popup: 'animate__animated animate__fadeInDown'
            },
            hideClass: {
                popup: 'animate__animated animate__fadeOutUp'
            }
        }).then((result) => {
            if (result.value) {
                nome = result.value;
                localStorage.setItem("nomeUsuario", nome);
                updateUserName(nome);
            } else {
                nome = "visitante";
                updateUserName(nome);
            }
        });
    } else {
        updateUserName(nome);
    }
    return nome;
}

document.addEventListener("DOMContentLoaded", () => {
    // Initialize themes
    initializeThemes();

    // Ask for user name
    const userName = askForUserName();

    const descricoes = [
        "É preciso fazer todos exe...", "Já chega de JavaScript!", "O Formando está Aprovado?",
        "Eu sou... e tenho...anos", "Mostra na console", "Programa que leia do utilizador...",
        "...Data atual do sistema...", "Olá  usuário... Saudação", "Impressao com botão...",
        "Exemplo de Mostrar URL", "Positivo ou negativo?", "Maior ou menor???",
        "Adivinhe o Número...rnd", "Números em ordem crescente", "Mais Perto de 100...",
        "leia a nota quantitativa...", "...Não. Não diga Não...", "...Contar  numéricos...",
        "...Inversor de  Frases...", "Converter -> Euro -> Dólar", "...Converter para negativo...",
        "...Retira o Imposto...", "Calcula valor com imposto", "Gerador de Senha Aleatória...",
        "Encontrar Maior Número gerado", "...Encontrar Menor...", "consumo médio de combustível",
        "diferença entre o maior e o menor", "lançamento de um dado 35.000x", "O valor digitado é um número?",
        "As senhas são iguais?", "Desenha o retangulo", "Desenha o círculo com canvas",
        "Esconde a metade do Email", "Parte a string em pedaços", "Gera asteriscos em linhas",
        "Soma numeros de 1 ate...", "Múltiplos de 3 de 0 a 100", "Formata Data mostra mes",
        "Controle hora funcionarios", "Verificar Dia da Semana", "Calcula idade em anos",
        "Preco certo jogo acerte o preco", "Eleiçoes. Quem ganha?", "quantas vezes cada numero? ",
        "Remover Nrs Duplicados", "numero que ocorre mais vezes ", "separa pares a partir de 2 digitos",
        "Soma de Arrays Aleatórios", "Matriz de Nrs Aleatórios", "Caracteres Especiais",
        "Conv Decimal para Binário", "Cor de Fundo Aleatória", "Cor de Fundo do Parágrafo",
        "Gerar colunas e linhas Tabela", "Escreve na tabela 3x3 indice", "Dimensões da Janela",
        "Ordenação com Bubble Sort", "Ordenação com Insertion Sort", "Ordenação com Selection Sort", "Jogo da Forca"
    ];

    const emojis = ["📘", "📗", "📕", "🧮", "🧠", "🎯", "🧩", "📐", "💡", "🎲", "🎮"];
    const container = document.getElementById("exercises-container");

    descricoes.forEach((desc, i) => {
        const card = document.createElement("div");
        card.className = "card";
        const emoji = emojis[i % emojis.length];
        card.innerHTML = `
            <span class="label">${emoji} Exercício ${i + 1}</span>
            <p class="desc">${desc}</p>
        `;

        // Abre o exercício na pasta correta
        if (i + 1 === 61) {
            card.onclick = () => openExercise('jogo_da_forca/index.html');
        } else {
            card.onclick = () => openExercise(`Exercicios/exercicio${i + 1}/index.html`);
        }

        container.appendChild(card);
    });

    const cards = document.querySelectorAll(".card");
    cards.forEach((card, index) => {
        setTimeout(() => {
            card.classList.add("show");
        }, index * 40);
    });

    const input = document.getElementById("search-input");
    if (input) {
        input.addEventListener("input", () => {
            const value = input.value.toLowerCase();
            document.querySelectorAll(".card").forEach(card => {
                const text = card.textContent.toLowerCase();
                card.style.display = text.includes(value) ? "block" : "none";
            });
        });
    }
});