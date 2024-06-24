using Exercicio3;
using System.Globalization;

List<Cliente> listaClientes = new();
List<Funcionario> listaFuncionarios = new();
List<Servico> listaServicos = new();
List<Agendamento> listaAgendamentos = new();

bool loop = true;

while (loop)
{
    try
    {
        Cliente cliente = new();
        Funcionario funcionario = new();
        Servico servico = new();
        Agendamento agendamento = new();

        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1-Cadastrar um cliente");
        Console.WriteLine("2-Remover um cliente");
        Console.WriteLine("3-Atualizar um cliente");
        Console.WriteLine("4-Listar todos os clientes\n");

        Console.WriteLine("5-Cadastrar um funcionário");
        Console.WriteLine("6-Remover um funcionário");
        Console.WriteLine("7-Atualizar um funcionário");
        Console.WriteLine("8-Listar todos os funcionários\n");

        Console.WriteLine("9-Cadastrar um serviço");
        Console.WriteLine("10-Remover um serviço");
        Console.WriteLine("11-Atualizar um serviço");
        Console.WriteLine("12-Listar todos os serviços\n");

        Console.WriteLine("13-Realizar um agendamento");
        Console.WriteLine("14-Listar agendamentos realizados\n");

        Console.WriteLine("15-Sair");

        int escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.Write("Digite o nome do cliente: ");
                cliente.Nome = Console.ReadLine();

                Console.Write("Digite o telefone do cliente: ");
                cliente.Telefone = Console.ReadLine();

                Console.WriteLine();

                listaClientes.Add(cliente);

                break;

            case 2:
                if (listaClientes.Count == 0)
                {
                    Console.WriteLine("Não há clientes cadastrados");
                    break;
                }

                for (int i = 0; i < listaClientes.Count; i++)
                {
                    Console.WriteLine(i + 1 + $"-{listaClientes.ElementAt(i).Nome}");
                }

                Console.Write("Escolha o cliente a ser excluído: ");

                int escolhaExcluirCliente = Convert.ToInt32(Console.ReadLine()) - 1;

                if (escolhaExcluirCliente < 0 || escolhaExcluirCliente >= listaClientes.Count)
                {
                    Console.WriteLine("Escolha inválida");
                    break;
                }

                listaClientes.RemoveAt(escolhaExcluirCliente);
                Console.WriteLine("Cliente removido com sucesso");

                Console.WriteLine();

                break;

            case 3:
                if (listaClientes.Count == 0)
                {
                    Console.WriteLine("Não há clientes cadastrados");
                    break;
                }

                for (int i = 0; i < listaClientes.Count; i++)
                {
                    Console.WriteLine(i + 1 + $"-{listaClientes.ElementAt(i).Nome}/{listaClientes.ElementAt(i).Telefone}");
                }

                Console.Write("Escolha o cliente a ser atualizado: ");

                int escolhaAtualizarCliente = Convert.ToInt32(Console.ReadLine()) - 1;

                if (escolhaAtualizarCliente < 0 || escolhaAtualizarCliente >= listaClientes.Count)
                {
                    Console.WriteLine("Escolha inválida");
                    break;
                }

                Console.WriteLine("Selecione a informação a ser atualizada:");

                Console.WriteLine("1-Nome");
                Console.WriteLine("2-Telefone");

                int escolhaInformacao = Convert.ToInt32(Console.ReadLine());

                if (escolhaInformacao == 1)
                {
                    Console.Write("Digite o novo nome: ");
                    listaClientes.ElementAt(escolhaAtualizarCliente).Nome = Console.ReadLine();

                    Console.WriteLine("Nome atualizado com sucesso\n");
                }
                else if (escolhaInformacao == 2)
                {
                    Console.Write("Digite o novo telefone: ");
                    listaClientes.ElementAt(escolhaAtualizarCliente).Telefone = Console.ReadLine();

                    Console.WriteLine("Telefone atualizado com sucesso\n");
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }

                break;

            case 4:
                if(listaClientes.Count == 0)
                {
                    Console.WriteLine("Não há clientes cadastrados");
                    break;
                }

                foreach (Cliente cli in listaClientes)
                {
                    Console.WriteLine($"Nome: {cli.Nome}");
                    Console.WriteLine($"Telefone: {cli.Telefone}");
                    Console.WriteLine();
                }

                break;

            case 5:
                Console.Write("Digite o nome do funcionário: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("Digite o cpf do funcionário: ");
                funcionario.CPF = Console.ReadLine();

                Console.WriteLine();

                listaFuncionarios.Add(funcionario);
                break;

            case 6:
                if (listaFuncionarios.Count == 0)
                {
                    Console.WriteLine("Não há funcionários cadastrados");
                    break;
                }

                for (int i = 0; i < listaFuncionarios.Count; i++)
                {
                    Console.WriteLine(i + 1 + $"-{listaFuncionarios.ElementAt(i).Nome}");
                }

                Console.Write("Escolha o funcionário a ser excluído: ");

                int escolhaExcluirFuncionario = Convert.ToInt32(Console.ReadLine()) - 1;

                if (escolhaExcluirFuncionario < 0 || escolhaExcluirFuncionario >= listaFuncionarios.Count)
                {
                    Console.WriteLine("Escolha inválida");
                    break;
                }

                listaFuncionarios.RemoveAt(escolhaExcluirFuncionario);
                Console.WriteLine("Funcionário removido com sucesso");

                Console.WriteLine();

                break;

            case 7:
                if (listaFuncionarios.Count == 0)
                {
                    Console.WriteLine("Não há funcionários cadastrados");
                    break;
                }

                for (int i = 0; i < listaFuncionarios.Count; i++)
                {
                    Console.WriteLine(i + 1 + $"-{listaFuncionarios.ElementAt(i).Nome}/{listaFuncionarios.ElementAt(i).CPF}");
                }

                Console.Write("Escolha o funcionário a ser atualizado: ");

                int escolhaAtualizarFuncionario = Convert.ToInt32(Console.ReadLine()) - 1;

                if (escolhaAtualizarFuncionario < 0 || escolhaAtualizarFuncionario >= listaFuncionarios.Count)
                {
                    Console.WriteLine("Escolha inválida");
                    break;
                }

                Console.WriteLine("Selecione a informação a ser atualizada:");

                Console.WriteLine("1-Nome");
                Console.WriteLine("2-CPF");

                int escolhaInformacaoFuncionario = Convert.ToInt32(Console.ReadLine());

                if (escolhaInformacaoFuncionario == 1)
                {
                    Console.Write("Digite o novo nome: ");
                    listaFuncionarios.ElementAt(escolhaInformacaoFuncionario).Nome = Console.ReadLine();

                    Console.WriteLine("Nome atualizado com sucesso\n");
                }
                else if (escolhaInformacaoFuncionario == 2)
                {
                    Console.Write("Digite o novo cpf: ");
                    listaFuncionarios.ElementAt(escolhaAtualizarFuncionario).CPF = Console.ReadLine();

                    Console.WriteLine("CPF atualizado com sucesso\n");
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }

                break;

            case 8:
                if(listaFuncionarios.Count == 0)
                {
                    Console.WriteLine("Não há funcionários cadastrados");
                    break;
                }

                foreach (Funcionario func in listaFuncionarios)
                {
                    Console.WriteLine($"Nome: {func.Nome}");
                    Console.WriteLine($"CPF: {func.CPF}");
                    Console.WriteLine();
                }

                break;

            case 9:
                Console.Write("Digite a descrição do serviço: ");
                servico.Descricao = Console.ReadLine();

                Console.WriteLine();

                listaServicos.Add(servico);
                break;

            case 10:
                if (listaServicos.Count == 0)
                {
                    Console.WriteLine("Não há serviços cadastrados");
                    break;
                }

                for (int i = 0; i < listaServicos.Count; i++)
                {
                    Console.WriteLine(i + 1 + $"-{listaServicos.ElementAt(i).Descricao}");
                }

                Console.Write("Escolha o serviço a ser excluído: ");

                int escolhaExcluirServico = Convert.ToInt32(Console.ReadLine()) - 1;

                if (escolhaExcluirServico < 0 || escolhaExcluirServico >= listaServicos.Count)
                {
                    Console.WriteLine("Escolha inválida");
                    break;
                }

                listaServicos.RemoveAt(escolhaExcluirServico);
                Console.WriteLine("Serviço removido com sucesso");

                Console.WriteLine();

                break;

            case 11:
                if (listaServicos.Count == 0)
                {
                    Console.WriteLine("Não há servicos cadastrados");
                    break;
                }

                for (int i = 0; i < listaServicos.Count; i++)
                {
                    Console.WriteLine(i + 1 + $"-{listaServicos.ElementAt(i).Descricao}");
                }

                Console.Write("Escolha o servico a ser atualizado: ");

                int escolhaAtualizarServico = Convert.ToInt32(Console.ReadLine()) - 1;

                if (escolhaAtualizarServico < 0 || escolhaAtualizarServico >= listaServicos.Count)
                {
                    Console.WriteLine("Escolha inválida");
                    break;
                }

                Console.Write("Digite a nova descrição do serviço: ");

                listaServicos.ElementAt(escolhaAtualizarServico).Descricao = Console.ReadLine();

                Console.WriteLine("Serviço atualizado com sucesso\n");

                break;

            case 12:
                if(listaServicos.Count == 0)
                {
                    Console.WriteLine("Não há serviços cadastrados");
                    break;
                }

                foreach (Servico s in listaServicos)
                {
                    Console.WriteLine($"Descrição: {s.Descricao}");
                    Console.WriteLine();
                }

                break;

            case 13:
                if (listaClientes.Count == 0)
                {
                    Console.WriteLine("Não há clientes cadastrados");
                    break;
                }

                if (listaFuncionarios.Count == 0)
                {
                    Console.WriteLine("Não há funcionários cadastrados");
                    break;
                }

                if (listaServicos.Count == 0)
                {
                    Console.WriteLine("Não há serviços cadastrados");
                    break;
                }

                for (int i = 0; i < listaClientes.Count; i++)
                {
                    Console.WriteLine(i + 1 + $"-{listaClientes.ElementAt(i).Nome}");
                }

                Console.Write("Escolha o cliente para realizar o agendamento: ");

                int escolhaAgendamentoCliente = Convert.ToInt32(Console.ReadLine()) - 1;

                if (escolhaAgendamentoCliente < 0 || escolhaAgendamentoCliente >= listaClientes.Count)
                {
                    Console.WriteLine("Escolha inválida");
                    break;
                }

                agendamento.NomeCliente = listaClientes.ElementAt(escolhaAgendamentoCliente).Nome;



                for (int i = 0; i < listaFuncionarios.Count; i++)
                {
                    Console.WriteLine(i + 1 + $"-{listaFuncionarios.ElementAt(i).Nome}");
                }

                Console.Write("Escolha o funcionário para realizar o agendamento: ");

                int escolhaAgendamentoFuncionario = Convert.ToInt32(Console.ReadLine()) - 1;

                if (escolhaAgendamentoFuncionario < 0 || escolhaAgendamentoFuncionario >= listaFuncionarios.Count)
                {
                    Console.WriteLine("Escolha inválida");
                    break;
                }

                agendamento.NomeFuncionario = listaFuncionarios.ElementAt(escolhaAgendamentoFuncionario).Nome;



                for (int i = 0; i < listaServicos.Count; i++)
                {
                    Console.WriteLine(i + 1 + $"-{listaServicos.ElementAt(i).Descricao}");
                }

                Console.Write("Escolha o serviço para realizar o agendamento: ");

                int escolhaAgendamentoServico = Convert.ToInt32(Console.ReadLine()) - 1;

                if (escolhaAgendamentoServico < 0 || escolhaAgendamentoServico >= listaServicos.Count)
                {
                    Console.WriteLine("Escolha inválida");
                    break;
                }

                agendamento.NomeServico = listaServicos.ElementAt(escolhaAgendamentoServico).Descricao;

                Console.Write("Digite a data do agendamento(dia/mes/ano): ");

                string dataString = Console.ReadLine();

                string[] dataSeparada = dataString.Split("/");

                int dia = Convert.ToInt32(dataSeparada[0]);
                int mes = Convert.ToInt32(dataSeparada[1]);
                int ano = Convert.ToInt32(dataSeparada[2]);

                DateTime dataAgendamento = new DateTime(ano, mes, dia);

                agendamento.DataAgendamento = Convert.ToDateTime(dataAgendamento);

                listaAgendamentos.Add(agendamento);

                Console.WriteLine("Agendamento realizado com sucesso\n");

                break;

            case 14:
                if (listaAgendamentos.Count == 0)
                {
                    Console.WriteLine("Não há agendamentos cadastrados");
                    break;
                }

                foreach (Agendamento a in listaAgendamentos)
                {
                    Console.WriteLine($"Cliente: {a.NomeCliente}");
                    Console.WriteLine($"Funcionário: {a.NomeFuncionario}");
                    Console.WriteLine($"Serviço: {a.NomeServico}");
                    Console.WriteLine($"Data do agendamento: {a.DataAgendamento:dd/MM/yyyy}");
                    Console.WriteLine();
                }

                break;

            case 15:
                loop = false;
                break;

            default:
                Console.WriteLine("Opção inválida, tente novamente");
                break;
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro - {ex.Message}");
    }
}