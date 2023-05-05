using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labirinto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] labirinto = new string[20, 30]
           {
                {"*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"},
                {"*"," "," ","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"},
                {"*","*","Q","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"},
                {"*","*"," ","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"},
                {"*","*"," ","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"},
                {"*","*"," ","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"},
                {"*","*"," ","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"," ","Q"," ","F"},
                {"*","*","Q","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"," ","*","*","*"},
                {"*","*"," ","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"," ","*","*","*"},
                {"*","*"," ","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"," ","*","*","*"},
                {"*","*"," ","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"," ","*","*","*"},
                {"*","*"," ","*","*"," "," "," ","Q","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"," ","*","*","*"},
                {"*","*"," ","*","*"," ","*","*"," ","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","Q","*","*","*"},
                {"*","*"," ","*","*"," ","*","*"," ","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"," ","*","*","*"},
                {"*","*","Q"," "," "," ","*","*"," ","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"," ","*","*","*"},
                {"*","*","*","*","*","*","*","*"," ","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"," ","*","*","*"},
                {"*","*","*","*","*","*","*","*","Q"," "," "," "," "," "," "," "," ","Q"," "," "," "," "," "," "," "," ","Q","*","*","*"},
                {"*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"},
                {"*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"},
                {"*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"}
           };

            string jog = "\x01";
            labirinto[1, 1] = jog;
            // setas de direção
            // 37 - esquerda
            // 38 - cima
            // 39 - direita
            // 40 - baixo

            bool sair = false;
            int dir, pergunta=0;
            int l = 1, c = 1;
            int[] respostas = new int[9];

            Console.SetWindowSize(120, 35); // Define o tamanho da janela de saida

            while (sair == false)
            {
                Console.Clear();
                Console.Title = "LABIRINTO MÁGICO";
                // Mostra o futuro labirinto
                for (int i = 0; i < labirinto.GetLength(0); i++)
                {
                    for (int j = 0; j < labirinto.GetLength(1); j++)
                        Console.Write(labirinto[i, j]);
                    Console.WriteLine();
                }

                Console.WriteLine("\nLABIRINTO MÁGICO\nUse as setas de deslocamento:");
                dir = Convert.ToInt32(Console.ReadKey().Key);
                if (dir == 39) // desloca para a direita
                {
                    if (labirinto[l, c + 1] == " ")
                    {
                        labirinto[l, c] = " ";
                        labirinto[l, ++c] = jog;
                    }
                    else
                    {
                        if (labirinto[l, c + 1] == "F")
                            sair = true;

                        if (labirinto[l, c + 1] == "Q")
                        {

                            if (pergunta == 0)
                                Console.WriteLine("\nVocê está a passear a pé por um caminho. O que vê a sua volta?\n1) uma floresta escura, com enormes árvores, que impedem até a passagem dos raios de sol.\n2) um campo de milho, debaixo de um céu fantástico.\n3) montanhas grandes, cobertas por árvores bem verdes.");

                            if (pergunta == 1)
                                Console.WriteLine("\nEm que objeto você quase tropeçaria?\n1) um espelho.\n2) um anel.\n3) uma garrafa.");

                            if (pergunta == 2)
                                Console.WriteLine("\nVocê apanhou algum um deles?\n1) sim\n2) não");

                            if (pergunta == 3)
                                Console.WriteLine("\nSeguindo pela mesma trilha, você tem que atravessar um pedaço cheio  de água. O que seria?\n1) um limpo, claro e sereno lago\n2) uma ruidosa cachoeira\n3) um borbulhante riacho");

                            if (pergunta == 4)
                                Console.WriteLine("\nNo meio da travessia, você vê uma chave dentro da água. Como ela é?\n1) normal, de uma casa\n2) uma bonita chave antiga\n3) bem pequena, de cadeado");

                            if (pergunta == 5)
                                Console.WriteLine("\nDepois de passar pela água, você continua a andar e, logo a frente, vê uma casa. De que estilo?\n1) uma mansão à la Hollywood\n2) uma cabana com relva bem aparada\n3) um lindo castelo em ruínas");

                            if (pergunta == 6)
                                Console.WriteLine("\nO que você faz?\n1) entra\n2) olha pela janela\n3) não se interessa");

                            if (pergunta == 7)
                                Console.WriteLine("\nDe repente algo cruza seu caminho e assusta você. O que é?\n1) um urso\n2) um mágico\n3) um gnomo");

                            if (pergunta == 8)
                                Console.WriteLine("\nAgora, você chega a um muro com uma porta e dá uma espiada no  buraco da fechadura. O que vê do outro lado?\n1) um jardim maravilhoso\n2) uma lagoa no meio do deserto\n3) uma praia com ruidosas ondas");

                            respostas[pergunta] = int.Parse(Console.ReadLine());
                            ++pergunta;
                            labirinto[l, c] = " ";
                            labirinto[l, ++c] = jog;
                        }
                    }



                }

                if (dir == 40) // desloca para baixo
                {
                    if (labirinto[l + 1, c] == " ")
                    {
                        labirinto[l, c] = " ";
                        labirinto[++l, c] = jog;
                    }
                    else
                        if (labirinto[l + 1, c] == "Q")
                        {
                            
                            if (pergunta == 0)
                            Console.WriteLine("\nVocê está a passear a pé por um caminho. O que vê a sua volta?\n1) uma floresta escura, com enormes árvores, que impedem até a passagem dos raios de sol.\n2) um campo de milho, debaixo de um céu fantástico.\n3) montanhas grandes, cobertas por árvores bem verdes.");

                            if (pergunta == 1)
                            Console.WriteLine("\nEm que objeto você quase tropeçaria?\n1) um espelho.\n2) um anel.\n3) uma garrafa.");

                            if (pergunta == 2)
                            Console.WriteLine("\nVocê apanhou o objeto?\n1) sim\n2) não");

                            if (pergunta == 3)
                            Console.WriteLine("\nSeguindo pela mesma trilha, você tem que atravessar um pedaço cheio  de água. O que seria?\n1) um limpo, claro e sereno lago\n2) uma ruidosa cachoeira\n3) um borbulhante riacho");

                            if (pergunta == 4)
                            Console.WriteLine("\nNo meio da travessia, você vê uma chave dentro da água. Como ela é?\n1) normal, de uma casa\n2) uma bonita chave antiga\n3) bem pequena, de cadeado");

                            if (pergunta == 5)
                            Console.WriteLine("\nDepois de passar pela água, você continua a andar e, logo a frente, vê uma casa. De que estilo?\n1) uma mansão à la Hollywood\n2) uma cabana com relva bem aparada\n3) um lindo castelo em ruínas");

                            if (pergunta == 6)
                            Console.WriteLine("\nO que você faz?\n1) entra\n2) olha pela janela\n3) não se interessa");

                            if (pergunta == 7)
                            Console.WriteLine("\nDe repente algo cruza seu caminho e assusta você. O que é?\n1) um urso\n2) um mágico\n3) um gnomo");

                            if (pergunta == 8)
                            Console.WriteLine("\nAgora, você chega a um muro com uma porta e dá uma espiada no  buraco da fechadura. O que vê do outro lado?\n1) um jardim maravilhoso\n2) uma lagoa no meio do deserto\n3) uma praia com ruidosas ondas");

                            respostas[pergunta] = int.Parse(Console.ReadLine());
                            ++pergunta;
                            labirinto[l, c] = " ";
                            labirinto[++l, c] = jog;
                        }

                    }

                if (dir == 38) // desloca para cima
                {
                    if (labirinto[l - 1, c] == " ")
                    {
                        labirinto[l, c] = " ";
                        labirinto[--l, c] = jog;
                    }
                    else
                        if (labirinto[l - 1, c] == "Q")
                    {
                        
                        if (pergunta == 0)
                            Console.WriteLine("\nVocê está a passear a pé por um caminho. O que vê a sua volta?\n1) uma floresta escura, com enormes árvores, que impedem até a passagem dos raios de sol.\n2) um campo de milho, debaixo de um céu fantástico.\n3) montanhas grandes, cobertas por árvores bem verdes.");

                        if (pergunta == 1)
                            Console.WriteLine("\nEm que objeto você quase tropeçaria?\n1) um espelho.\n2) um anel.\n3) uma garrafa.");

                        if (pergunta == 2)
                            Console.WriteLine("\nVocê apanhou o objeto?\n1) sim\n2) não");

                        if (pergunta == 3)
                            Console.WriteLine("\nSeguindo pela mesma trilha, você tem que atravessar um pedaço cheio  de água. O que seria?\n1) um limpo, claro e sereno lago\n2) uma ruidosa cachoeira\n3) um borbulhante riacho");

                        if (pergunta == 4)
                            Console.WriteLine("\nNo meio da travessia, você vê uma chave dentro da água. Como ela é?\n1) normal, de uma casa\n2) uma bonita chave antiga\n3) bem pequena, de cadeado");

                        if (pergunta == 5)
                            Console.WriteLine("\nDepois de passar pela água, você continua a andar e, logo a frente, vê uma casa. De que estilo?\n1) uma mansão à la Hollywood\n2) uma cabana com relva bem aparada\n3) um lindo castelo em ruínas");

                        if (pergunta == 6)
                            Console.WriteLine("\nO que você faz?\n1) entra\n2) olha pela janela\n3) não se interessa");

                        if (pergunta == 7)
                            Console.WriteLine("\nDe repente algo cruza seu caminho e assusta você. O que é?\n1) um urso\n2) um mágico\n3) um gnomo");

                        if (pergunta == 8)
                            Console.WriteLine("\nAgora, você chega a um muro com uma porta e dá uma espiada no  buraco da fechadura. O que vê do outro lado?\n1) um jardim maravilhoso\n2) uma lagoa no meio do deserto\n3) uma praia com ruidosas ondas");

                        respostas[pergunta] = int.Parse(Console.ReadLine());
                        ++pergunta;
                        labirinto[l, c] = " ";
                        labirinto[--l, c] = jog;
                    }
                }

                if (dir == 37) // desloca para esquerda
                {
                    if (labirinto[l, c - 1] == " ")
                    {
                        labirinto[l, c] = " ";
                        labirinto[l, --c] = jog;
                    }
                }

            }

            Console.WriteLine("\n\n\t\tPARABENS, CHEGOU AO FIM!!");
            for (int i = 0; i < 9; i++)
            {

                if (i == 0 && respostas[i] == 1)
                {
                    //Console.ForegroundColor = ConsoleColor.Yellow;
                   // Console.WriteLine("\n\nA VIDA COMO VOCÊ A VÊ:");

                    Console.WriteLine("\n\nA VIDA COMO VOCÊ A VÊ: A floresta indica que você vai fundo nas coisas que quer, sabe identificar os seus objetivos e conciliar as suas metas, porém é quieto(a), calmo(a) e cauteloso(a)..Todos os que te conhecem o(a) acham interessante e não se cansam de elogiar o seu ar misterioso, já que, por nada neste mundo, mostra o seu verdadeiro eu logo de cara. Sabe ser um bom ouvinte.");
                }
                if (i == 0 && respostas[i] == 2)
                    Console.WriteLine("\n\nA VIDA COMO VOCÊ A VÊ: O campo de milho indica que você é brilhante, sociável, amável, brincalhão(ona). Faz amigos com facilidade e raramente se sente sozinho(a).. Aonde quer que vá, é sempre o centro das atenções e, por isso, sente-se feliz e se diverte, digamos, até com uma certa facilidade.");
                if (i == 0 && respostas[i] == 3)
                    Console.WriteLine("\n\nA VIDA COMO VOCÊ A VÊ: Caso tenha escolhido as montanhas, é sinal de que você é prático(a), tem senso de justiça, pés no chão e conquista as pessoas pela sua honestidade. Uma prova disso é a sua atitude quando alguém pede que ajude a resolver um problema. Antes de tomar qualquer partido, ouve as partes envolvidas.");

                if (i == 1 && respostas[i] == 1)
                    Console.WriteLine("\n\nA PESSOA DOS SEUS SONHOS: A escolha do espelho mostra que você não acredita que os 'pólos opostos se atraem', quando isto é em relação ao amor, e que, só vai sossegar quando encontrar a sua 'alma gêmea', a pessoa que tenha os mesmos ideais que os seus. Nada mais justo. Só que é bom olhar um pouco mais a sua volta, porque de repente a pessoa perfeita para si pode ser alguém que normalmente você não olharia duas vezes.");
                if (i == 1 && respostas[i] == 2)
                    Console.WriteLine("\n\nA PESSOA DOS SEUS SONHOS: A escolha do anel significa que você coloca os sentimentos acima de qualquer outra coisa na vida, até de seu amor próprio. Romântico(a),  acredita em amor eterno, e rima 'amor com dor'. Mesmo quando está sofrendo e sendo rejeitado(a), continua a acreditar que a pessoa um dia vai descobrir que te ama. No seu projeto de vida, embora não admita, quer que seu parceiro(a) cuide de si e supra as suas carências.");
                if (i == 1 && respostas[i] == 3)
                    Console.WriteLine("\n\nA PESSOA DOS SEUS SONHOS: Se escolheu a garrafa você é ambicioso(a) , inteligente, prático(a) e quer um(a) companheiro(a) que ajude e batalhe ao seu lado, mais do que amor, paixão, busca, companheirismo e um parceiro(a) esperto(a), disposto (a), colaborador(a). Dos chamados 'moscas mortas', você prefere manter distância.");

                if (i == 2 && respostas[i] == 1)
                    Console.WriteLine("\n\nVOCÊ QUER UM COMPROMISSO SÉRIO? Se respondeu sim, você não vê a hora de encontrar a pessoa certa, ou estando com alguém não tem problemas em se envolver.");
                if (i == 2 && respostas[i] == 2)
                    Console.WriteLine("\n\nVOCÊ QUER UM COMPROMISSO SÉRIO? Se respondeu não, tem outras prioridades, pelo menos por enquanto.");

                if (i == 3 && respostas[i] == 1)
                    Console.WriteLine("\n\nLIMITES DA PAIXÃO: O lago reflete o seu desejo de querer se ver livre de relacionamentos superficiais. Porém, só quando encontrar alguém muito especial, é que vai mergulhar de cabeça.");
                if (i == 3 && respostas[i] == 2)
                    Console.WriteLine("\n\nLIMITES DA PAIXÃO: A cachoeira revela que você gosta de conquistar, esbanjar o seu charme e saber que as pessoas se apaixonam facilmente por si, mesmo que para si logo tudo perca a graça. Mas sempre aparece alguém novo, aliás, muito natural.");
                if (i == 3 && respostas[i] == 3)
                    Console.WriteLine("\n\nLIMITES DA PAIXÃO: O que um riacho é capaz de fazer, não? Você vive apaixonado(a) e sempre por alguém diferente. Você é movido à paixões e emoções intensas, passionais. Não dá outra: está sempre com uma pessoa diferente e sempre jurando que encontrou o amor de sua vida.");

                if (i == 4 && respostas[i] == 1)
                    Console.WriteLine("\n\nFUTURO BRILHANTE: Se viu a chave de uma casa, você tem uma vontade secreta de abrir novos horizontes na sua vida, só não sabe que rumo seguir.");
                if (i == 4 && respostas[i] == 2)
                    Console.WriteLine("\n\nFUTURO BRILHANTE: Se viu a chave antiga, mostra que você tem garra e uma vontade ilimitada de aprender tudo o que puder e que vai atrás e luta por seus objetivos.");
                if (i == 4 && respostas[i] == 3)
                    Console.WriteLine("\n\nFUTURO BRILHANTE: Ver a chave do cadeado significa que, você acredita na sua intuição para ajudá-lo(a) a encontrar um caminho, fora do comum, que te abrirá as portas do sucesso.");

                if (i == 5 && respostas[i] == 1)
                    Console.WriteLine("\n\nQUEM É QUE NÃO TEM AMBIÇÃO? Escolher a mansão, quer dizer que você possui vários objetivos na vida, e muito legais. Além disso, se esforça para ser o(a) melhor em tudo que faz e sente-se atraído(a) por atividades que dão oportunidade de expressar a sua criatividade.");
                if (i == 5 && respostas[i] == 2)
                    Console.WriteLine("\n\nQUEM É QUE NÃO TEM AMBIÇÃO? A cabana é a visão de uma pessoa realista sobre seu próprio futuro e que tem os pés firmemente plantados no chão. E provavelmente vencerá em qualquer atividade usando o esforço próprio.");
                if (i == 5 && respostas[i] == 3)
                    Console.WriteLine("\n\nQUEM É QUE NÃO TEM AMBIÇÃO? Caso tenha achado o castelo mais simpático, é porque ainda não conseguiu decifrar muito bem o que deseja para o amanhã. Enquanto isso, para não se desapontar, caso alguma coisa dê errado, prefere sonhar com o que vai fazer com o dinheiro todo que irá ganhar, quando ficar milionário.");

                if (i == 6 && respostas[i] == 1)
                    Console.WriteLine("\n\nQUANDO O SUCESSO CHEGAR. Entrar na casa é ter confiança em tudo o que faz, sabendo que existe sempre a possibilidade de erro ou acerto. Sendo assim, nada consegue atrapalhar seu caminho.");
                if (i == 6 && respostas[i] == 2)
                    Console.WriteLine("\n\nQUANDO O SUCESSO CHEGAR. Se você olhou pela janela, é porque tem medo de falhar e por isso, desiste de tudo, sem ao menos ter tentado.");
                if (i == 6 && respostas[i] == 3)
                    Console.WriteLine("\n\nQUANDO O SUCESSO CHEGAR. Caso não tenha se interessado, é porque você se contenta com coisas simples e prefere não correr atrás do sucesso.");

                if (i == 7 && respostas[i] == 1)
                    Console.WriteLine("\n\nMEDO DE QUE? Para si, que escolheu o urso, depender de alguém é a coisa pior que pode acontecer na vida. Na sua opinião, uma pessoa alcança a felicidade a partir do momento em que estiver pronta para andar com os próprios pés.");
                if (i == 7 && respostas[i] == 2)
                    Console.WriteLine("\n\nMEDO DE QUE? Através do mágico, você demonstra o receio que tem com as situações que estão fora do seu controle. Porém, para aliviar tamanha tensão, procura ajuda com um poderoso gurú e explicações sobrenaturais  para seus problemas pessoais.");
                if (i == 7 && respostas[i] == 3)
                    Console.WriteLine("\n\nMEDO DE QUE? O gnomo é o retrato de uma pessoa preocupada com que os outros vão pensar dela, como os outros vão reagir se disser ou fizer coisas que elas não gostam ou aprovam. Afinal por que tanto medo de não ser aceito(a)?");

                if (i == 8 && respostas[i] == 1)
                    Console.WriteLine("\n\nSEU EU MAIS PROFUNDO. Escolhendo o jardim, você provou que é maduro(a), honesto(a), sensível e dono(a) de uma inteligência privilegiada. Não é a toa que todos confiam em você de olhos fechados.");
                if (i == 8 && respostas[i] == 2)
                    Console.WriteLine("\n\nSEU EU MAIS PROFUNDO. Se escolheu a lagoa, ela apenas reforça a sua necessidade de ter seu próprio espaço, até para se isolar quando sente que as coisas não andam lá como tinha planejado. Chegará um dia em que você descobrirá que compartilhar os sentimentos com alguém de sua confiança poderá ajudá-lo(a) a ficar melhor.");
                if (i == 8 && respostas[i] == 3)
                    Console.WriteLine("\n\nSEU EU MAIS PROFUNDO. A praia é a escolha de quem é apaixonado(a) pela vida, nada convencional, com opiniões próprias e nem um pingo de receio de defendê-las e mudá-las, se for preciso.");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nCarregue numa tecla para continuar...");
                Console.ResetColor();
                Console.ReadKey();
            }


                                

            Console.ReadKey();
        }
    }
}

