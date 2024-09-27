class TelaInicial
{
    public TelaInicial() {
        ExibirTela();
    }

    public void ExibirTela() {
        int valor;
        System.Console.WriteLine("Cantina Senac - Bem-vind@!\n");
        System.Console.WriteLine("O que deseja fazer?\n");
        System.Console.WriteLine("1 - Cadastrar-se");
        System.Console.WriteLine("2 - Logar-se");
        valor = Convert.ToInt32(Console.ReadLine());
        switch (valor) {
            case 1:
                new TelaCadastroAdministrador();
                break;
            case 2:
                new TelaLogin();
                break;
            default:
                System.Console.WriteLine("Tenha um bom dia!");
                return;
        }
    }
}