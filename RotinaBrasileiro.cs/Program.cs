using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== ROTINA DO BRASILEIRO - SITUAÇÕES DO COTIDIANO ===\n");

        Console.WriteLine("Escolha uma situação típica do dia a dia:");
        Console.WriteLine("1 - Horário de acordar");
        Console.WriteLine("2 - Tempo no trânsito");
        Console.WriteLine("3 - Horas de trabalho");
        Console.WriteLine("4 - Tempo de almoço");
        Console.WriteLine("5 - Horário de dormir");
        Console.WriteLine("6 - Tempo livre no dia");
        Console.WriteLine("7 - Quantas refeições por dia");

        Console.Write("\nEscolha uma opção (1-7): ");
        string input = Console.ReadLine();

        // Valida a entrada
        if (int.TryParse(input, out int opcao))
        {
            // Verifica se a opção é válida
            if (opcao < 1 || opcao > 7)
            {
                Console.WriteLine("Opção inválida! Digite um número entre 1 e 7.");
            }
            else
            {
                ProcessarSituacao(opcao);
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida! Digite apenas números de 1 a 7.");
        }

        // Pausa para ver o resultado no console
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static void ProcessarSituacao(int opcao)
    {
        switch (opcao)
        {
            case 1:
                VerificarHorarioAcordar();
                break;
            case 2:
                VerificarTempoTransito();
                break;
            case 3:
                VerificarHorasTrabalho();
                break;
            case 4:
                VerificarTempoAlmoco();
                break;
            case 5:
                VerificarHorarioDormir();
                break;
            case 6:
                VerificarTempoLivre();
                break;
            case 7:
                VerificarRefeicoes();
                break;
        }
    }

    static void VerificarHorarioAcordar()
    {
        Console.WriteLine("\nHORÁRIO DE ACORDAR");
        Console.Write("Que horas você acorda? (formato 24h, ex: 06:30): ");
        string horario = Console.ReadLine();

        if (TimeSpan.TryParse(horario, out TimeSpan hora))
        {
            Console.WriteLine($"\nVocê acorda às {hora:hh\\:mm}");

            if (hora.Hours <= 5)
            {
                Console.WriteLine("Voce e um guerreiro! Acordar antes das 5h e para poucos");
                Console.WriteLine("Dica: Certifique-se de dormir pelo menos 7-8 horas");
            }
            else if (hora.Hours <= 6)
            {
                Console.WriteLine("Madrugador classico! Aproveitando o dia desde cedo");
                Console.WriteLine("Horario comum entre brasileiros que trabalham");
            }
            else if (hora.Hours <= 8)
            {
                Console.WriteLine("Horario padrao brasileiro para trabalho");
                Console.WriteLine("Equilibrado para a maioria das pessoas");
            }
            else if (hora.Hours <= 10)
            {
                Console.WriteLine("Acordando com calma - trabalho flexivel ou estudante?");
                Console.WriteLine("Muitos brasileiros sonham com essa flexibilidade");
            }
            else
            {
                Console.WriteLine("Dorminhoco assumido! Trabalho noturno ou fim de semana?");
                Console.WriteLine("Talvez voce seja daqueles que vira a noite no WhatsApp");
            }
        }
        else
        {
            Console.WriteLine("Formato invalido! Use o formato HH:MM (ex: 07:30)");
        }
    }

    static void VerificarTempoTransito()
    {
        Console.WriteLine("\nTEMPO NO TRÂNSITO");
        Console.Write("Quanto tempo voce gasta no transito por dia? (em minutos): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int tempo))
        {
            Console.WriteLine($"\nVocê gasta {tempo} minutos no transito por dia");

            if (tempo == 0)
            {
                Console.WriteLine("Home office ou trabalha muito perto!");
                Console.WriteLine("Voce esta vivendo o sonho brasileiro!");
            }
            else if (tempo <= 30)
            {
                Console.WriteLine("Sortudo! Transito rapido - talvez andando ou transporte eficiente");
                Console.WriteLine("Situacao invejavel para a maioria dos brasileiros");
            }
            else if (tempo <= 60)
            {
                Console.WriteLine("Tempo razoavel - media brasileira nas cidades medias");
                Console.WriteLine("Da para ouvir podcast ou musica");
            }
            else if (tempo <= 120)
            {
                Console.WriteLine("Transito pesado - realidade das grandes cidades");
                Console.WriteLine("Tempo para audiobooks e playlists longas");
                Console.WriteLine("Voce conhece bem a frustracao do brasileiro urbano");
            }
            else
            {
                Console.WriteLine("Transito extremo! Mais de 2h por dia");
                Console.WriteLine("Grande metropole brasileira detectada!");
                Console.WriteLine("Voce faz parte do grupo que mais reclama do transito");
            }
        }
        else
        {
            Console.WriteLine("Digite apenas numeros (minutos)");
        }
    }

    static void VerificarHorasTrabalho()
    {
        Console.WriteLine("\nHORAS DE TRABALHO");
        Console.Write("Quantas horas você trabalha por dia?: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int horas))
        {
            Console.WriteLine($"\nVoce trabalha {horas} horas por dia");

            if (horas <= 6)
            {
                Console.WriteLine("Carga horaria leve - meio periodo ou flexivel");
                Console.WriteLine("Tempo para outras atividades");
            }
            else if (horas == 8)
            {
                Console.WriteLine("Jornada padrao brasileira - CLT classica");
                Console.WriteLine("Equilibrio entre trabalho e vida pessoal");
            }
            else if (horas <= 10)
            {
                Console.WriteLine("Rotina puxada - comum entre brasileiros");
                Console.WriteLine("Muito cafe deve estar envolvido");
            }
            else if (horas <= 12)
            {
                Console.WriteLine("Workaholic brasileiro detectado!");
                Console.WriteLine("Cuidado com o burnout - muito comum no Brasil");
            }
            else
            {
                Console.WriteLine("Voce esta no modo 'empreendedor brasileiro'");
                Console.WriteLine("Ou esta fazendo freela alem do trabalho");
                Console.WriteLine("Cuide da saude mental!");
            }
        }
        else
        {
            Console.WriteLine("Digite apenas numeros");
        }
    }

    static void VerificarTempoAlmoco()
    {
        Console.WriteLine("\nTEMPO DE ALMOÇO");
        Console.Write("Quantos minutos voce tem para almocar?: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int tempo))
        {
            Console.WriteLine($"\nSeu tempo de almoco: {tempo} minutos");

            if (tempo <= 15)
            {
                Console.WriteLine("Almoco no modo 'correria brasileira'");
                Console.WriteLine("Provavelmente come sanduiche em pe");
            }
            else if (tempo <= 30)
            {
                Console.WriteLine("Almoco rapido - realidade de muitos brasileiros");
                Console.WriteLine("Fast food ou marmita no escritorio");
            }
            else if (tempo <= 60)
            {
                Console.WriteLine("Tempo adequado - padrao CLT brasileiro");
                Console.WriteLine("Da para comer com calma no restaurante");
            }
            else if (tempo <= 90)
            {
                Console.WriteLine("Almoco civilizado - tempo para digestao");
                Console.WriteLine("Empresa que respeita o funcionario");
            }
            else
            {
                Console.WriteLine("Almoco VIP! Tempo para socializar e relaxar");
                Console.WriteLine("Da ate para ir em casa ou restaurante chique");
            }
        }
        else
        {
            Console.WriteLine("Digite apenas numeros (minutos)");
        }
    }

    static void VerificarHorarioDormir()
    {
        Console.WriteLine("\nHORÁRIO DE DORMIR");
        Console.Write("Que horas voce vai dormir? (formato 24h, ex: 23:30): ");
        string horario = Console.ReadLine();

        if (TimeSpan.TryParse(horario, out TimeSpan hora))
        {
            Console.WriteLine($"\nVocê dorme as {hora:hh\\:mm}");

            if (hora.Hours <= 21 || hora.Hours >= 22 && hora.Minutes == 0)
            {
                Console.WriteLine("Dorme cedo! Provavelmente acorda antes das 6h");
                Console.WriteLine("Rotina saudavel que poucos brasileiros conseguem manter");
            }
            else if (hora.Hours <= 23)
            {
                Console.WriteLine("Horario equilibrado - bom para a saude");
                Console.WriteLine("Tempo para assistir o jornal e relaxar");
            }
            else if (hora.Hours == 0 || hora.Hours == 1)
            {
                Console.WriteLine("Noitada moderada - padrao de muitos brasileiros");
                Console.WriteLine("Provavelmente fica no celular ate tarde");
            }
            else
            {
                Console.WriteLine("Coruja noturna! Vira a noite no WhatsApp?");
                Console.WriteLine("Vai precisar de muito cafe amanha");
                Console.WriteLine("Netflix, redes sociais ou jogos ate tarde?");
            }
        }
        else
        {
            Console.WriteLine("Formato invalido! Use o formato HH:MM (ex: 23:30)");
        }
    }

    static void VerificarTempoLivre()
    {
        Console.WriteLine("\nTEMPO LIVRE NO DIA");
        Console.Write("Quantas horas livres você tem por dia?: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int horas))
        {
            Console.WriteLine($"\nSeu tempo livre: {horas} horas por dia");

            if (horas <= 1)
            {
                Console.WriteLine("Vida corrida! Tipico do brasileiro urbano");
                Console.WriteLine("Cuidado com o estresse - muito comum no Brasil");
            }
            else if (horas <= 3)
            {
                Console.WriteLine("Tempo apertado mas da para algumas coisas");
                Console.WriteLine("WhatsApp, TV e Netflix basico");
            }
            else if (horas <= 5)
            {
                Console.WriteLine("Tempo razoavel para lazer");
                Console.WriteLine("Da para academia, series e amigos");
            }
            else if (horas <= 8)
            {
                Console.WriteLine("Tempo bom para hobbies e socializacao");
                Console.WriteLine("Pode desenvolver habilidades extras");
            }
            else
            {
                Console.WriteLine("Muito tempo livre! Trabalho flexivel ou estudante?");
                Console.WriteLine("Aproveite para projetos pessoais");
            }
        }
        else
        {
            Console.WriteLine("Digite apenas numeros");
        }
    }

    static void VerificarRefeicoes()
    {
        Console.WriteLine("\nREFEIÇÕES POR DIA");
        Console.Write("Quantas refeicoes voce faz por dia?: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int refeicoes))
        {
            Console.WriteLine($"\nVoce faz {refeicoes} refeicoes por dia");

            if (refeicoes <= 2)
            {
                Console.WriteLine("Rotina corrida! Muitos brasileiros pulam refeicoes");
                Console.WriteLine("Cuidado: pode afetar a saude a longo prazo");
                Console.WriteLine("Tente incluir pelo menos um lanche saudavel");
            }
            else if (refeicoes == 3)
            {
                Console.WriteLine("Padrao classico brasileiro: cafe, almoco e jantar");
                Console.WriteLine("27% dos brasileiros fazem 3 refeicoes por dia");
                Console.WriteLine("Esta dentro da recomendacao basica");
            }
            else if (refeicoes == 4)
            {
                Console.WriteLine("Boa frequencia! Inclui um lanche extra");
                Console.WriteLine("36% dos brasileiros comem 4 vezes ao dia");
                Console.WriteLine("Padrao recomendado por especialistas");
            }
            else if (refeicoes <= 6)
            {
                Console.WriteLine("Excelente! Varias pequenas refeicoes");
                Console.WriteLine("Metabolismo acelerado e energia constante");
                Console.WriteLine("Padrao recomendado por nutricionistas");
            }
            else
            {
                Console.WriteLine("Beliscando o dia todo? Ou trabalha com comida?");
                Console.WriteLine("Verifique se nao esta exagerando nos lanches");
            }

            ExibirDicasAlimentacao(refeicoes);
        }
        else
        {
            Console.WriteLine("Digite apenas numeros");
        }
    }

    static void ExibirDicasAlimentacao(int refeicoes)
    {
        Console.WriteLine("\nDICAS SOBRE ALIMENTAÇÃO:");

        if (refeicoes <= 2)
        {
            Console.WriteLine("• Tente incluir frutas como lanche");
            Console.WriteLine("• Mantenha nuts ou barras de cereal por perto");
            Console.WriteLine("• Hidrate-se bastante");
        }
        else if (refeicoes >= 3 && refeicoes <= 4)
        {
            Console.WriteLine("• Continue mantendo horarios regulares");
            Console.WriteLine("• Inclua proteinas em cada refeicao");
            Console.WriteLine("• Evite pular o cafe da manha");
        }
        else
        {
            Console.WriteLine("• Otima distribuicao ao longo do dia");
            Console.WriteLine("• Mantenha porcoes menores e mais frequentes");
            Console.WriteLine("• Priorize alimentos naturais");
        }

        Console.WriteLine("\nCURIOSIDADE BRASILEIRA:");
        Console.WriteLine("• Brasileiro medio gasta 1h30 preparando/comendo");
        Console.WriteLine("• Arroz e feijao ainda dominam o almoco nacional");
        Console.WriteLine("• Acai e cafe sao praticamente uma religiao");
    }
}
