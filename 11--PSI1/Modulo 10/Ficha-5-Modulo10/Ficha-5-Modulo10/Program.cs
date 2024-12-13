using Ficha_5_Modulo10;

class Program
{
    static void Main(string[] args)
    {
        Garagem garagem = new Garagem("Minha Garagem");

        // Criar veículos
        Carro carro = new Carro("Toyota", "Corolla", 2022, 4);
        Motor motor = new Motor("Diesel", 400);
        Camiao camiao = new Camiao("Volvo", "FH", 2020, motor);

        // Adicionar veículos
        garagem.AdicionarVeiculo(carro);
        garagem.AdicionarVeiculo(camiao);

        // Listar veículos
        garagem.ListarVeiculos();

        // Remover veículo
        garagem.RetirarVeiculo(carro);
        garagem.ListarVeiculos();

        // Tentativa de remover novamente
        garagem.RetirarVeiculo(carro);
    }
}
