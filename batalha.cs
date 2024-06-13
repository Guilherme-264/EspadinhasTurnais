public class Batalha
{
public bool final = false;
private int vez;

//definindo atributos da arma
public int ataque1;
public int ataque2;
public int ataque3;
public int precisao1;
public int precisao2;
public int precisao3;

public int itemCura;

//deffinindo atributos do inimigo
public string? inimigo;
public int vidaICompleta;
public int vidaI;
public int ataqueI1;
public int ataqueI2;
public int ataqueI3;
public int precisaoI1;
public int precisaoI2;
public int precisaoI3;
public int vezI;

// definindo atributos do jogador
public int vida;
public int vidaInicial;
public int ataque;
public int precisao;

Random aleatorio = new Random();
int acerto;
//função HUD da vida
void mostraVida()
{   
    Console.WriteLine($"você {vida}/{vidaInicial}");
    Console.WriteLine($"{inimigo} {vidaI}/{vidaICompleta}");
    Console.WriteLine("--------------------");
}



public bool batalha(Arma a1,Inimigo i1,statusPersonagem s1)
{
    //definindo atributos do jogador
    vida = vidaInicial =  s1.vida;
    precisao = s1.precisao;
    ataque = s1.ataque;
    itemCura = s1.itemCura;


    //definindo atributos da arma usada na batalha
    ataque1 = a1.ataque1 + ataque;
    ataque2 = a1.ataque2 + ataque;
    ataque3 = a1.ataque3 + ataque;
    precisao1 = a1.precisao1 - precisao;
    precisao2 = a1.precisao2 - precisao;
    precisao3 = a1.precisao3 - precisao;
    
    //definindo atributos do inimigo
    inimigo = i1.nomeInimigo;
    vidaICompleta = i1.vida;
    vidaI = i1.vida;
    ataqueI1 = i1.ataque1;
    ataqueI2 = i1.ataque2;
    ataqueI3 = i1.ataque3;
    precisaoI1 = i1.ataque1;
    precisaoI2 = i1.ataque2;
    precisaoI3 = i1.ataque3;


    //loop while onde ocorre a batalha
    while (true)
    {
        while(true)
        {
            //Mostra a sua e a vida do inimigo
            mostraVida();

            //seleciona o tipo do ataque
            Console.WriteLine($"1. Ataque rápido \n2. Ataque médio \n3. Ataque forte\n4. Poção de cura +10 ({itemCura}) ");
            string stringVez = Console.ReadLine()!;

                if (int.TryParse(stringVez, out vez) & (vez ==1 || vez == 2 || vez == 3 || vez ==4))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Número inválido");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
        }
        //ataque rapido
        switch (vez)
        {
        case 1:
            acerto = aleatorio.Next(0, 100);
            if (acerto >= precisao1)
            {
                vidaI = vidaI - ataque1;
                Console.Write("Você acertou o inimigo");
            }else
            {
                Console.WriteLine("Você errou o ataque\n");
            }
        break;

        //ataque médio
        case 2:
        
            acerto = aleatorio.Next(0, 100);
            if (acerto >= precisao2)
            {
                vidaI = vidaI - ataque2;
                Console.Write("Você acertou o inimigo");
            }else
            {
                Console.WriteLine("Você errou o ataque\n");
            }
        break;

        //ataque forte
        case 3:
        
            acerto = aleatorio.Next(0, 100);
            if (acerto >= precisao3)
            {
                vidaI = vidaI - ataque3;
                Console.Write("Você acertou o inimigo");
            }else
            {
                Console.WriteLine("Você errou o ataque\n");
            }
        break;

        case 4:
            if(itemCura > 0)
            {
                vida += 10;
                if (vida > vidaInicial)
                {
                    vida = vidaInicial;
                };
                itemCura --;
            }
        break;
        }

        
        Thread.Sleep(3000);
        Console.Clear();
        mostraVida();


        //verificando se vida do inimigo não zerou
        if (vidaI <= 0)
        {
            Console.WriteLine("Você venceu, o inimigo morreu");
            return true;
            
        }

        //ataque inimigo
        vezI = aleatorio.Next(1, 4);
        //ataque rapido
        if (vezI == 1)
        {
            acerto = aleatorio.Next(0, 100);
            if (acerto >= precisaoI1)
            {
                vida = vida - ataqueI1;
                Console.Write("O inimigo acertou o ataque rapido\n");
            }else
            {
                Console.WriteLine("O inimigo errou o ataque\n");
            }
        //ataque médio
        }else if(vezI == 2)
        {
            acerto = aleatorio.Next(0, 100);
            if (acerto >= precisaoI2)
            {
                vida = vida - ataqueI2;
                Console.Write("O inimigo acertou o ataque médio\n");
            }else
            {
                Console.WriteLine("O inimigo errou o ataque\n");
            }
        //ataque forte
        }else if(vezI == 3)
        {
            acerto = aleatorio.Next(0, 100);
            if (acerto >= precisaoI3)
            {
                vida = vida - ataqueI3;
                Console.Write("O inimigo acertou o ataque forte\n");
            }else
            {
                Console.WriteLine("O inimigo errou o ataque\n");
            }
        }

        if (vida <= 0)
        {
            Console.WriteLine("Você morreu");
            return false;
        }
        Thread.Sleep(3000);

        Console.Clear();
    }
    }
}
