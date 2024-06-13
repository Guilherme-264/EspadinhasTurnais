public class statusPersonagem 
{
    public int vida = 30;
    public int precisao = 0;
    public int ataque = 0;
    public int itemCura = 2;
    public int inimigo;

    public void upgrad(Batalha b1)
    {
        int vidaSoma = 5;
        int precisaoSoma = 8;
        int ataqueSoma = 5;
        itemCura = b1.itemCura;

        Console.Write($"Escolha sua recompensa:\n1. +{vidaSoma} vida\n2. +{precisaoSoma} precição\n3. +{ataqueSoma} ataque\n4. +1 poção de cura ");
        int atributo = Convert.ToInt32(Console.ReadLine());

        
        if(atributo == 1 )
        {
            vida += vidaSoma;
        }
        else if(atributo == 2)
        {
            precisao += precisaoSoma;
        }
        else if(atributo == 3)
        {
            ataque += ataqueSoma;
        }
        else if (atributo == 4)
        {
            itemCura ++;
        }
        else
        {
            Console.WriteLine("Número inválido");
            upgrad(b1);
            Thread.Sleep(3000);
            Console.Clear();
        }
        Console.Clear();

    }

}
