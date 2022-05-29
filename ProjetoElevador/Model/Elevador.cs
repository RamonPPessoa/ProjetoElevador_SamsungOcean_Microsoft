using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    class Elevador
    {

        public int totalAndares { get; set; }
        public int elevadorCapacidade { get; set; }
        public int qtdePessoas { get; set; }
        public int andarAtual { get; set; }




        public Elevador()
        {

            Console.WriteLine("===== Bem-vindo ao Edifico Manaós =====");

            //Capacidade do elevador
            Console.Write("Por favor, informe a capacidade máxima do elevador ");
            elevadorCapacidade = Convert.ToInt32(Console.ReadLine());

            //Total de andares do edifico
            Console.Write("=> Informe a quantidade de andares do edifico  ");
            totalAndares = Convert.ToInt32(Console.ReadLine());

            //Estado atual do elevador
            andarAtual = 0;

            //Quantidade atual de pessoas
            qtdePessoas = 0;

            Console.WriteLine("Capacidade máxima do Elevador: " + elevadorCapacidade + " pessoas");
            Console.WriteLine("Total de Andares é: " + totalAndares + " andares");
            Console.Write("Pressione qualquer tecla para Continuar...");

            //Esse bloco tem a funcionalidade de quanto pressionado qualquer tecla irá seguir para  o menu inicial
            if (Console.ReadKey().Key != null)
            {
                Inicializar();
            }
        }
        public void Inicializar()
        {
            //Vai limpar a tela deixando a mesma mais legivel para o usuário
            Console.Clear();
            //Menu principal com as opções para interação com o usuário
            Console.WriteLine("===== MENU PRINCIPAL =====");
            Console.WriteLine("( 1 ) Entrar no Elevador");
            Console.WriteLine("( 2 ) Sair do Elevador");
            Console.WriteLine("( 3 ) Exibir informações elevador");
            Console.WriteLine("( 4 ) Subir ");
            Console.WriteLine("( 5 ) Descer");
            Console.WriteLine("( 0 ) Parar");
            Console.Write("Por favor, digite aopção desejada : ");
            //De acordo com a opção recebida a mesma sera convertida para um inteiro convertemos em um Inteiro para poder ser validada na SWITCH
            int opcaoElevador = Convert.ToInt32(Console.ReadLine());

            switch (opcaoElevador)
            {
                case 1:
                    Entrar();
                    break;
                case 2:
                    Sair();
                    break;
                case 3:
                    exibirConsultar();
                    break;
                case 4:
                    Subir();
                    break;
                case 5:
                    Descer();
                    break;
                case 0:
                    PararElevador();
                    break;
                default:
                    //O usuário não escolhendo nenhuma opção o mesmo será redirecionado a tela inicial ou seja o menu principal
                    Console.WriteLine("Opção inválida, pro favor tente novamente.");
                    Console.Write("Para continuar pressione qualquer tecla para continuar...");
                    if (Console.ReadKey().Key != null)
                    {
                        Inicializar();
                    }
                    break;
            }

        }
        public void Entrar()
        {
            Console.Clear();
            //Verificando a quantidade pessoas presentes no elevador
            if (qtdePessoas < elevadorCapacidade)
            {
                if (qtdePessoas == 0)
                {
                    Console.WriteLine("No momento voce é a unica pessoa no elevador");
                }
                else
                {
                    Console.WriteLine("você e " + qtdePessoas + " pessoas estão no elevador");
                }
                //Incrementando a quantidade de pessoas
                qtdePessoas++;

                if (andarAtual == 0)
                {
                    Console.WriteLine(" Você ainda está no (TERREO). Favor escolher uma opcao");
                }
                else
                {
                    Console.WriteLine("Atualmente voce esta no " + andarAtual + "  escolha uma opcao");
                }
                //Menu com as opções da pessoa no elevador
                Console.WriteLine("\n===== MENU OPCOES  =====");
                Console.WriteLine("( 1 ) Subi andar");
                Console.WriteLine("( 2 ) Descer  andar ");
                Console.WriteLine("( 3 ) Sair do Elevador");
                Console.Write("Digite a opção desejada: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Subir();
                        break;
                    case 2:
                        Descer();
                        break;
                    case 3:
                        Sair();
                        break;
                    default:
                        Console.WriteLine("Opcao Inválida, pro favor tente novamente.");
                        Console.Write("Pressione qualquer tecla para continuar...");
                        if (Console.ReadKey().Key != null)
                        {
                            Inicializar();
                        }
                        break;
                }
            }
            else
            {
                //Não havendo mais vagas no elevador,o usuário receberá um aviso
                Console.WriteLine("Capacidade máxima atingida,aguarde o proximo.");
                Console.Write("Tecle 0 para eseperar o proximo elevador: ");
                int opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        Inicializar();
                        break;
                }
            }
        }
        public void Sair()
        {
            Console.Clear();
            if (qtdePessoas > 0)
            {
                qtdePessoas--;
                Console.WriteLine("Saiu passageiro do elevador, agora: " + qtdePessoas + " pessoas no levador");
                Console.Write("Pressione qualquer tecla para continuar...");
                if (Console.ReadKey().Key != null)
                {
                    Inicializar();
                }
            }
            else
            {
                Console.WriteLine("Nao tem Passageiros no Elevador.");
                Console.Write("Pressione qualquer teca para continuar...");
                if (Console.ReadKey().Key != null)
                {
                    Inicializar();
                }
            }
        }
        public void Subir()
        {
            Console.Clear();
            if (andarAtual >= totalAndares)
            {
                Console.WriteLine("Fim!!! Nao é possivel subir mais  andares " + andarAtual + " ultimo andar");
                Console.WriteLine("\n===== MENU OPCOES =====");
                Console.WriteLine("( 1 ) Descer ");
                Console.WriteLine("( 2 ) Sai");
                Console.Write("Por favor, digite uma opcao que desejada: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Descer();
                        break;
                    case 2:
                        Sair();
                        break;
                    default:
                        Console.WriteLine("Opcao incorreta.Por favor tente novamente");
                        Console.Write("Pressione qualquer tecla para continuar...");
                        if (Console.ReadKey().Key != null)
                        {
                            Inicializar();
                        }
                        break;
                }
            }
            else
            {
                andarAtual++;
                Console.WriteLine("Subindo e  chegando no proximo andar: " + andarAtual);
                Console.Write("Pressione qualquer tecla para continuar...");
                if (Console.ReadKey().Key != null)
                {
                    Inicializar();
                }
            }
        }
        public void Descer()
        {
            Console.Clear();
            if (andarAtual == 0)
            {
                Console.WriteLine("Não é possivel mais descer andares, elevador ja está no terreo");
                Console.WriteLine("\n===== MENU OPCOES =====");
                Console.WriteLine("( 1 ) Subir andar");
                Console.WriteLine("( 2 ) Sair");
                Console.Write("Por favor, digite a opcao desejada: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Subir();
                        break;
                    case 2:
                        Sair();
                        break;
                    default:
                        Console.WriteLine("Opcao Invalida, inicie novamente o Elevador.");
                        Console.Write("Pressione qualquer tecla para continuar...");
                        if (Console.ReadKey().Key != null)
                        {
                            Inicializar();
                        }
                        break;
                }
            }
            else
            {
                andarAtual--;
                Console.WriteLine("Chegou no  andar: " + andarAtual);
                Console.Write("Pressione qualquer tecla para continuar...");
                if (Console.ReadKey().Key != null)
                {
                    Inicializar();
                }
            }
        }
        public void PararElevador()
        {
            Console.Clear();
            if (qtdePessoas > 0)
            {
                Console.WriteLine("IMpossivel parar o elevador dentro.");
                Console.Write("Tecle 1 para voltar a tela anterior: ");
                int opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Inicializar();
                        break;
                    default:
                        Console.WriteLine("Opcao invalida, voce sera Redirecionado para o Menu Principal.");
                        Console.Write("Pressione qualquer tecla para continuar...");
                        if (Console.ReadKey().Key != null)
                        {
                            Inicializar();
                        }
                        break;
                }
            }
            if (andarAtual != 0)
            {
                Console.WriteLine("Nao e' possivel Desligar o Elevador sem que ele esteja no Andar 0 (Terreo)");
                Console.WriteLine("Voce sera Redirecionado para o Menu Principal.");
                Console.Write("Pressione qualquer tecla para continuar...");
                if (Console.ReadKey().Key != null)
                {
                    Inicializar();
                }
            }
        }
        public void exibirConsultar()
        {
            Console.Clear();
            Console.WriteLine("\n=== MENU CONSULTA ===");
            Console.WriteLine("( 1 ) Quantidade Passageiros");
            Console.WriteLine("( 2 ) Qual Andar esta' o Elevador");
            Console.Write("=> Por favor, digite qual opcao deseja Consultar: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Existem " + qtdePessoas + " pessoas no Elevador");
                    if (qtdePessoas == elevadorCapacidade)
                    {
                        Console.WriteLine("Caapcidade máxima,: " + elevadorCapacidade + " pessoas");
                    }
                    Console.Write("Pressione qualquer tecla para continuar...");
                    if (Console.ReadKey().Key != null)
                    {
                        Inicializar();
                    }
                    break;
                case 2:
                    Console.WriteLine("Elevador no andar " + andarAtual);
                    Console.Write("Pressione qualquer tecla para continuar...");
                    if (Console.ReadKey().Key != null)
                    {
                        Inicializar();
                    }
                    break;
                default:
                    Console.WriteLine("Opção incorreta, por favor tente.");
                    Console.Write("Pressione qualquer tecla para continuar...");
                    if (Console.ReadKey().Key != null)
                    {
                        Inicializar();
                    }
                    break;
            }
        }

    }





}










