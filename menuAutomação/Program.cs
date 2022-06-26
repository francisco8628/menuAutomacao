using menuAutomação;

public class Program
{
    private static void Main(string[] args)
    {

        string recebeOpcaoDigitada = OpcoesUsuario();

        List<Usuario> usuarios = new List<Usuario>();
        usuarios.Add(new Usuario() { Nome = "Francisco",Idade = 35});
        usuarios.Add(new Usuario() { Nome = "Benjamin", Idade = 3 });
        usuarios.Add(new Usuario() { Nome = "Renata", Idade = 37 });

        while (recebeOpcaoDigitada.ToUpper() != "X")
        {

            switch (recebeOpcaoDigitada)
            {
                case "1":
                    ListaUsuario();
                    break;
                case "2":
                    ConsultaUsuario();
                    break;
                case "3":
                    CadastraUsuario();
                    break;
                case "4":
                    DeletaUsuario();
                    break;
                default:
                    OpcaoInvalida();
                    break;                  
            }

        }

        string OpcoesUsuario()
        {       

            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 - Lista Usuarios");
            Console.WriteLine("2 - Consulta Usuario");
            Console.WriteLine("3 - Cadastra Uusuarios");
            Console.WriteLine("4 - Deleta Usuario");
            Console.WriteLine("X - Sair");
            string opcao = Console.ReadLine();
            Console.WriteLine();

            return opcao;

        }

        void ListaUsuario()
        {
            Console.WriteLine("Lista Todos os usuarios");
            Console.WriteLine();

            foreach (var user in usuarios) {
                Console.WriteLine($"Codigo: {user.Codigo}, Nome: {user.Nome}, Idade: {user.Idade}");
            }

            Console.WriteLine("quantidade de usuarios: "+ usuarios.Count);
            Console.WriteLine();
            recebeOpcaoDigitada = OpcoesUsuario();
        }

        void ConsultaUsuario()
        {
            Console.WriteLine("Consulta usuario pelo Id");

            Console.WriteLine("Digite o ID do usuario que quer pesquisar");

            int id = Convert.ToInt32(Console.ReadLine());

            if (id < usuarios.Count)
            {   
                Usuario usarioConsulta = usuarios[id-1];
                Console.WriteLine($"Codigo: { usarioConsulta.Codigo}, Nome: { usarioConsulta.Nome}, Idade: { usarioConsulta.Idade}");
            }
            else
            {
                Console.WriteLine("Id invalido");
            }

            Console.WriteLine();
            recebeOpcaoDigitada = OpcoesUsuario();

        }

        void CadastraUsuario()
        {    
            Usuario usuario= new Usuario();           

            Console.WriteLine("Cadastra Usuario");

            Console.WriteLine("Digite um nome para o usuario: ");            
            usuario.Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade do usuario: ");
            usuario.Idade =Convert.ToInt32(Console.ReadLine());

            usuarios.Add(usuario);         
           
            Console.WriteLine();
            recebeOpcaoDigitada = OpcoesUsuario();

        }

        void DeletaUsuario()
        {
            Console.WriteLine("Deleta Usuarios");
            Console.WriteLine("Digite o ID do usuario para deletar ");

            int id = Convert.ToInt32(Console.ReadLine());

            foreach (Usuario usarioDelete in usuarios)
            {
                if (usarioDelete.Codigo == id)
                {
                    usuarios.Remove(usarioDelete);
                    Console.WriteLine($"Codigo: {usarioDelete.Codigo}, Nome: {usarioDelete.Nome}, Idade: {usarioDelete.Idade} , Foi Deletado");
                    break;
                }             
                   
            }         
            Console.WriteLine();
            recebeOpcaoDigitada = OpcoesUsuario();

        }

        void OpcaoInvalida()
        {
            Console.WriteLine("EScolha uma opção Valida !!!!!");
            Console.WriteLine();
            recebeOpcaoDigitada = OpcoesUsuario();

        }
    }
}