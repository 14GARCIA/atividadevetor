using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ficha[] fichas = new Ficha[10];
            int i = 0;

            string ope;
                Console.WriteLine("Olá!!\nBem vindo ao nosso sistema");

            while (true)
            {
                Console.WriteLine("Escolha a opção  referente ao que voce deseja fazer no sistema: \n1- fazer uma ficha de um paciente \n2-Adicionar uma paciente na fila de espera \n3-Atender um paciente \n q-sair do sistema ");
                ope = Console.ReadLine();
                switch (ope) 
                {
                    case "1":
                        {
                            if ( i < 10) 
                            {
                                fichas[i] = new Ficha(); 
                                Console.WriteLine("Digite o nome do paciente:");
                                fichas[i].Nome = Console.ReadLine();
                                do
                                {
                                    Console.WriteLine("Digite o CPF do paciente:");
                                    fichas[i].Cpf = Console.ReadLine();
                                    if (fichas[i].Cpf.Length != 11)
                                    {
                                        Console.WriteLine("CPF invalido");
                                    }
                                } while (fichas[i].Cpf.Length != 11);


                                do {
                                    Console.WriteLine("Digite o número de telefone do paciente:");
                                    fichas[i].NumeroTel = Console.ReadLine();
                                    fichas[i].NumeroTel = fichas[i].NumeroTel.Replace(" ", "");

                                    if (fichas[i].NumeroTel.Length != 11 || !long.TryParse(fichas[i].NumeroTel, out _))
                                    {
                                        Console.WriteLine("Telefone invalido, o numero de telefone deve conter 11 numeros contando com o dd");
                                    }
                                }while (fichas[i].NumeroTel.Length != 11 || !long.TryParse(fichas[i].NumeroTel, out _));


                                Console.WriteLine("Digite o email:");
                                fichas[i].Email = Console.ReadLine();

                                Console.WriteLine("Digite a data de nascimento do paciente:");
                                Console.WriteLine("dia:");
                                fichas[i].Dia=int.Parse(Console.ReadLine());
                                Console.WriteLine("Mes:");
                                fichas[i].Mes=int.Parse(Console.ReadLine());
                                Console.WriteLine("Ano:");
                                fichas[i].Ano=int.Parse(Console.ReadLine());
                                fichas[i].DataNasc = fichas[i].Dia + "/" + fichas[i].Mes + "/" + fichas[i].Ano;

                                Console.WriteLine("Informe a idade:");
                                fichas[i].Idade = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite a altura do paciente:");
                                fichas[i].Altura = double.Parse(Console.ReadLine());

                                Console.WriteLine("Informe o peso do paciente:");
                                fichas[i].Peso = double.Parse(Console.ReadLine());

                                Console.WriteLine("Digite o CEP:");
                                fichas[i].Cep = Console.ReadLine();

                                Console.WriteLine("Cadastre a rua do paciente:");
                                fichas[i].Rua = Console.ReadLine();

                                Console.WriteLine("Digite o bairro:");
                                fichas[i].Bairro = Console.ReadLine();

                                Console.WriteLine("Digite o nome da cidade:");
                                fichas[i].Cidade = Console.ReadLine();

                                Console.WriteLine("Número da casa:");
                                fichas[i].NumeroCasa = int.Parse(Console.ReadLine());

                                Console.WriteLine("Se houver, digite o complemento do endereço:");
                                fichas[i].Complemento = Console.ReadLine();

                               
                                int tipo;
                                do
                                {
                                    Console.WriteLine("Selecione o tipo de consulta: \n1 - Particular\n2 - Convênio");
                                    tipo = int.Parse(Console.ReadLine());

                                    switch (tipo)
                                    {
                                        case 1:
                                            fichas[i].TipoConsulta = "Consulta Particular";
                                            break;
                                        case 2:
                                            fichas[i].TipoConsulta = "Consulta pelo Convênio";
                                            break;
                                        default:
                                            Console.WriteLine("Digite uma opção válida.");
                                            break;
                                    }
                                } while (tipo != 1 && tipo != 2);
                                Console.WriteLine("Quais sintomas o paciente esta sentindo:");
                                fichas[i].Sintomas = Console.ReadLine();

                                Console.WriteLine("ha quanto tempo o paciente esses sentindo esses sintomas:");
                                fichas[i].TempoSintomas = Console.ReadLine();

                                Console.WriteLine("Qual a temperatura do corpo do paciente: ");
                                fichas[i].TempCorporal = Console.ReadLine();
                                int cle;
                                Console.WriteLine("Digite qual a classificação de risco do paciente:\n1- atendimento imediato \n2- emergente \n3-urgente \n4- menos urgente \n5-não urgente");
                                cle=int.Parse(Console.ReadLine());
                                switch (cle)
                                {
                                    case 1:
                                        {
                                            fichas[i].ClassifcRisc = "Atendimento imediato";
                                            break;
                                        }
                                    case 2:
                                        {
                                            fichas[i].ClassifcRisc = "Emergente";
                                            break;
                                        }
                                    case 3:
                                        {
                                            fichas[i].ClassifcRisc = "Urgente";
                                            break;
                                        }
                                    case 4:
                                        {
                                            fichas[i].ClassifcRisc = "Menos urgente";
                                            break;
                                        }
                                    case 5:
                                        {
                                            fichas[i].ClassifcRisc = "Não urgente";
                                            break;
                                        }
                                }

                                i++; 
                                Console.WriteLine("Ficha cadastrada com sucesso!");
      
                            }
                            else
                            {
                                Console.WriteLine("Número máximo de fichas atingido.");
                            }
                            int visu;
                            do
                            {

                                Console.WriteLine("voce deseja visualizar todas as fichas cadastradas?\n1-sim\n2-nao");
                                visu = int.Parse(Console.ReadLine());

                                switch (visu)
                                {
                                    case 1:
                                        {
                                            for (int j = 0; j <= i; j++)
                                            {
                                                Console.WriteLine($"\n Dados do Paciente {j + 1} ");
                                                Console.WriteLine($"Nome: {fichas[j].Nome}");
                                                Console.WriteLine($"CPF: {fichas[j].Cpf}");
                                                Console.WriteLine($"Número de Telefone: {fichas[j].NumeroTel}");
                                                Console.WriteLine($"Email: {fichas[j].Email}");
                                                Console.WriteLine($"Data de Nascimento: {fichas[j].DataNasc}");
                                                Console.WriteLine($"Idade: {fichas[j].Idade}");
                                                Console.WriteLine($"Altura: {fichas[j].Altura}");
                                                Console.WriteLine($"Peso: {fichas[j].Peso}");
                                                Console.WriteLine($"CEP: {fichas[j].Cep}");
                                                Console.WriteLine($"Rua: {fichas[j].Rua}");
                                                Console.WriteLine($"Bairro: {fichas[j].Bairro}");
                                                Console.WriteLine($"Cidade: {fichas[j].Cidade}");
                                                Console.WriteLine($"Número da Casa: {fichas[j].NumeroCasa}");
                                                Console.WriteLine($"Complemento: {fichas[j].Complemento}");
                                                Console.WriteLine($"Tipo de Consulta: {fichas[j].TipoConsulta}");
                                                Console.WriteLine($"Sintomas: {fichas[j].Sintomas}");
                                                Console.WriteLine($"Tempo dos Sintomas: {fichas[j].TempoSintomas}");
                                                Console.WriteLine($"Temperatura Corporal: {fichas[j].TempCorporal}");
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Obrigado por cdastrar o paciente");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Digite uma opcao valida");
                                            break;
                                        }
                                }
                            } while ( visu  != 1 && visu != 2);
                            break;
                            }
                    case "2":
                        {

                            break;
                        }
                    case "3": 
                        {
                            break;
                        }
                    case "q": 
                        {
                            Console.WriteLine("voce quis sair do sistema!!");
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Opção inválida, tente novamente.");
                            break;
                        }

                        }

                }

            Console.ReadKey();
        }

            
        
    }
}
