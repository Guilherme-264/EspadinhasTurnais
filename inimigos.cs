public class Inimigo
{
    public string? nomeInimigo;
    public int vida;
    public int ataque1;
    public int ataque2;
    public int ataque3;
    public int precisao1;
    public int precisao2;
    public int precisao3;

    public void escolheInimigo(int contador)
    {
        string caminhoArquivo = @"bancoDados/listaInimigos";
        using (StreamReader sr = new StreamReader(caminhoArquivo))
        {
            string linha;
            List<string> todosOsInimigos = new List<string>();
            while((linha = sr.ReadLine())!=null)
            {
                //colocando os inimigos em uma lista
                todosOsInimigos.Add(linha);
            }


            //selecionando a arma escolhida
            Console.Clear();
            string statusInimigo = todosOsInimigos[contador];
            string [] inimigo = statusInimigo.Split(',');

            nomeInimigo  = inimigo[0];
            vida = Convert.ToInt32(inimigo[1]);
            ataque1 = Convert.ToInt32(inimigo[2]);
            ataque2 = Convert.ToInt32(inimigo[3]);
            ataque3 = Convert.ToInt32(inimigo[4]);
            precisao1 = Convert.ToInt32(inimigo[5]);
            precisao2 = Convert.ToInt32(inimigo[6]);
            precisao3 = Convert.ToInt32(inimigo[7]);
        }
    }


    
}