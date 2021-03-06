using Dio.Serles;

namespace Dio.Serles{
    public  class Program{
        static SerieRepositorio repositorio = new SerieRepositorio();
        
        public static void Main(){

            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X"){
                
                switch(opcaoUsuario){
                    case "1":
                        ListarSeries();
                    break;
                    case "2":
                        InserirSerie();
                    break;
                    case "3":
                        AtualizaSerie();
                    break;
                    case "4":
                        ExcluirSeries();
                    break;
                    case "5":
                        VisualizarSeries();
                    break;
                    case "C":
                        Console.Clear();
                    break;
                    default:
                        throw new ArgumentOutOfRangeException(); 
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            System.Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void ExcluirSeries(){
            System.Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Enclui(indiceSerie);
        }
        private static void VisualizarSeries(){
            System.Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaId(indiceSerie);

            Console.WriteLine(serie);
        }
        

        private static void AtualizaSerie(){
            System.Console.WriteLine("Digite o id da Série");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero))){
                System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            System.Console.WriteLine("Digite o genero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Titulo da Série: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }
        private static void InserirSerie(){
            System.Console.WriteLine("Inserir nova Série");
            foreach(int i in Enum.GetValues(typeof(Genero))){
                System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            System.Console.WriteLine("Digite o genero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Titulo da Série: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.insere(novaSerie);
        }

        private static void ListarSeries(){
            System.Console.WriteLine("Listar Séries");

            var lista = repositorio.Lista();
            if(lista.Count == 0){
                System.Console.WriteLine("Nenhuma série cadastrada.");
            }
            foreach(var serie in lista){
               
               var excluido = serie.retornaExcluido();

                System.Console.WriteLine("#ID {0}: - {1} - {2}", serie.retornaID(), serie.retornaTitulo(), (excluido ? "'Excluido'" : ""));
            }
        }

        private static string ObterOpcaoUsuario(){
            System.Console.WriteLine();
            System.Console.WriteLine("DIO Séries a seu dispor!!!");
            System.Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar series");
            System.Console.WriteLine("2- Inserir nova série");
            System.Console.WriteLine("3- Atualizar nova série");
            System.Console.WriteLine("4- Excluir série");
            System.Console.WriteLine("5- Visualizar série");
            System.Console.WriteLine("C- Limpar Tela");
            System.Console.WriteLine("X- Sair");
            System.Console.WriteLine();

            string opcaousuario = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return opcaousuario;
        }
    
    }
}