// Gerenciamento de temas
window.addEventListener('message', (event) => {
    if (event.data.type === 'themeChange') {
        // Remover todos os temas existentes
        document.body.classList.remove('theme-white', 'theme-dark', 'theme-warm', 'theme-purple', 'theme-ocean');
        // Adicionar o novo tema
        document.body.classList.add(event.data.theme);
    }
});

// Função utilitária para obter o nome do usuário
function getUserName() {
    return localStorage.getItem('nomeUsuario') || '';
}