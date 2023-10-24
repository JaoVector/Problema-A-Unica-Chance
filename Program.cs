class Program
{
    
    public static void UltimaChance(string ordenada, string palavra)
    {
        int count = 0;

        for (int i = 0; i < ordenada.Length; i++)
        {
            var index = palavra.IndexOf(ordenada[i]);
            if(index != palavra.IndexOf(palavra[i]))
            {
                count += 1;
            }
        }

        if(count > 2)
        {
            Console.WriteLine("There aren't the chance.");
        }
        else 
        {
            Console.WriteLine("There are the chance.");
        }
    }

    public static void ValidaPalavra()
    {

        Console.WriteLine("Tamanho da Palavra: ");
        var tampalavra = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite: ");
        var palavra = Console.ReadLine();

        if(tampalavra > 26)
            throw new Exception("A palavra deve ter 26 caracteres");
        else if(palavra.Length < tampalavra)
            throw new Exception("A palavra deve ser do tamanho escolhido");


        palavra.ToUpper();

        char aux;
        for(int i = 0; i < palavra.Length; i++)
        {
            
            if(i == 0)
            {
               aux = palavra[i];

            } else
            {
                aux = palavra[i - 1];

                if(aux == palavra[i])
                {
                    throw new Exception("Alafabeto não possouí letras iguais");
                }
            }

        }

        var word = palavra.ToCharArray();
        Array.Sort(word);
        var ordenada = new String(word);

        UltimaChance(ordenada.ToUpper(), palavra.ToUpper());
    }

    static void Main(string[] args)
    {
    
        Console.WriteLine("Qtde de Casos: ");
        var casos = Convert.ToInt32(Console.ReadLine());
        

        int j = 0;

        while(j < casos)
        {
            ValidaPalavra();
            j++;
        }
        
    }
}
