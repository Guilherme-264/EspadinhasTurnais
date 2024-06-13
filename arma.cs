
public class Arma
{
    public string? NomeArma;
    public int ataque1;
    public int ataque2;
    public int ataque3;
    public int precisao1;
    public int precisao2;
    public int precisao3;
    private int armaEscolhida;

    //classe para escolher a arma usada
    public void ModeloArma()
    {
        //procurando as armas no arquivo "listaArmas"
        string caminhoArquivo = @"bancoDados/listaArmas";
        using (StreamReader sr = new StreamReader(caminhoArquivo))
        {
            string linha;
            List<string> todasAsArmas = new List<string>();
            while((linha = sr.ReadLine())!=null)
            {
                //colocando as armas em uma lista
                todasAsArmas.Add(linha);
            }

            while(true)
            {
                //mostrando a lista das armas
                int contador = 1;
                foreach(string i in todasAsArmas)
                {
                    string[] escolheArmas = i.Split(',');
                    Console.WriteLine($"{contador}. {escolheArmas[0]}");
                    contador++;
                };
                
                //selecionando a arma escolhida
                Console.WriteLine("Qual arma você deseja escolher:");
                string armaString = Console.ReadLine();

                if (int.TryParse(armaString, out armaEscolhida))
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

            armaEscolhida --;
            if(!(armaEscolhida == 0 || armaEscolhida == 1 || armaEscolhida == 2))
            {
                Console.WriteLine($"Número inválido");
                Thread.Sleep(3000);
                Console.Clear();
                ModeloArma();
            }
            Console.Clear();

            //passando os dados dos atributos da arma
            string statusArma = todasAsArmas[armaEscolhida];
            string [] arma = statusArma.Split(',');
            NomeArma = arma[0];
            ataque1 = Convert.ToInt32(arma[1]);
            ataque2 = Convert.ToInt32(arma[2]);
            ataque3 = Convert.ToInt32(arma[3]);
            precisao1 = Convert.ToInt32(arma[4]);
            precisao2 = Convert.ToInt32(arma[5]);
            precisao3 = Convert.ToInt32(arma[6]);
        }
    }
}

