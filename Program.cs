Arma arma = new Arma();
Inimigo i1 = new Inimigo();
statusPersonagem p1 = new statusPersonagem();
Batalha b = new Batalha();

Console.Clear();

bool condicao = true;
Console.WriteLine(@"Em um mundo à beira da destruição, um dragão feroz espalha o caos e terror. 
Apenas um herói destemido pode salvar a humanidade. Enfrentando inimigos implacáveis e 
superando desafios mortais, ele deve reunir forças e coragem para, 
finalmente, confrontar e derrotar a besta que ameaça a todos.");


Thread.Sleep(5000);
Console.WriteLine("\ndigite qualquer tecla para continuar");
Console.ReadKey();
Console.Clear();
for (int i = 0; i< 5; i++)
{
    arma.ModeloArma();
    i1.escolheInimigo(i);
    condicao = b.batalha(arma, i1, p1);
    Console.Clear();
    if(condicao == true)
    {
        p1.upgrad(b);
    }
    else
    {
        break;
    }
}

if (condicao == true)
{
    Console.WriteLine("Você derrotou o dragão feroz e salvou o mundo :)\nObrigado por jogar");
}
else
{
    Console.WriteLine("O mundo foi destruido pelo dragão :(");
}