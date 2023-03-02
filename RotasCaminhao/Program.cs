namespace Principal
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Rastreio de Caminhões: ");
            int opcao = 0;
            do {
                Console.WriteLine("1 - Cadastrar Rota");
                Console.WriteLine("2 - Alterar Rota");
                Console.WriteLine("3 - Excluir Rota");
                Console.WriteLine("4 - Listar Rotas");
                Console.WriteLine("5 - Media Rota");
                Console.WriteLine("6 - Cadastrar Caminhão");
                Console.WriteLine("7 - Alterar Caminhão");  
                Console.WriteLine("8 - Excluir Caminhão");
                Console.WriteLine("9 - Listar Caminhões");
                Console.WriteLine("10 - Total de rotas por caminhao");
                Console.WriteLine("11 - Valor das rotas por caminhao");
                Console.WriteLine("12 - Cadastrar Cidade");
                Console.WriteLine("13 - Alterar Cidade");
                Console.WriteLine("14 - Excluir Cidade");
                Console.WriteLine("15 - Listar Cidades");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Opção:");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    case 1:
                        View.Rota.CadastrarRota();
                        break;
                    case 2:
                        View.Rota.AlterarRota();
                        break;
                    case 3:
                        View.Rota.ExcluirRota();
                        break;
                    case 4:
                        View.Rota.ListarRotas();
                        break;
                        
                    case 5:
                        View.Rota.MediaRota();
                        break;
                    case 6:  
                        View.Caminhao.CadastrarCaminhao();
                        break;
                    case 7:
                        View.Caminhao.AlterarCaminhao();
                        break;
                    case 8:
                        View.Caminhao.ExcluirCaminhao();
                        break;
                    case 9:
                        View.Caminhao.ListarCaminhoes();
                        break;
                    case 10:
                     View.Caminhao.TotalRotasCaminhao(); 
                        break;
                    case 11:
                     View.Caminhao.ValorRotasCaminhao();
                       break;         
                    case 12:
                    View.Cidade.CadastrarCidade();
                        break;  
                    case 13:
                        View.Cidade.AlterarCidade();
                        break;
                    case 14:
                        View.Cidade.ExcluirCidade();
                        break;
                    case 15:
                        View.Cidade.ListarCidades();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 0);
        }
    }
}