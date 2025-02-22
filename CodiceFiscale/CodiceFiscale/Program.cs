string creo(string nome,string cogn, string[] data)
{
    char[] vocali ={ 'a', 'e','i','o','u' };
    string codice="",lettera="",conscogn="",vocalicogn="", consnom = "", vocalinom = "";
    int si = 0,ok=0,pos=0,a=0,lung=0;
    //nome
    for(int i = 0; i < nome.Length; i++)
    {
        if (!vocali.Contains(nome[i]))
        {
            if (consnom.Length < 3)
            {
                consnom += nome[i];
            }
            
        }
        else
        {
            vocalinom+= nome[i];
        }
    }
    if(consnom.Length > 3)
    {
        consnom = consnom[0]+consnom.Substring(2);
        consnom=consnom.Substring(0,3);
    }
    //cogn
    for (int i = 0; i < cogn.Length; i++)
    {
        if (!vocali.Contains(cogn[i]))
        {
            if (conscogn.Length < 3)
            {
                conscogn += cogn[i];
            }

        }
        else
        {
            vocalicogn += cogn[i];
        }
    }
    //COGNOME
    while (ok<=2)
    {
        codice = conscogn;
        ok = codice.Length;
        if (codice.Length < 3)
        {
           for(int i=codice.Length;i < 3; i++)
            {
                codice += vocalicogn;
                ok++;
            }
        }
    }
    
    ok = 0;
    //NOME
    while (ok <= 2)
    {
        codice += consnom;
        ok = codice.Length;
        if (codice.Length < 6)
        {
            for (int i = codice.Length; i < 6; i++)
            {
                codice += vocalinom;
                ok++;
                
            }
        }
    }
    codice=codice.Substring(0,6);
    codice = codice.ToUpper();
    Console.WriteLine(codice);
    return codice;
}

Console.WriteLine("Dimmi il tuo nome");
string nome = Console.ReadLine();
Console.WriteLine("Dimmi il tuo cognome");
string cognome = Console.ReadLine();
Console.WriteLine("Quando sei nato? (gg/mm/aaaa)");
string data = Console.ReadLine();
nome = nome.Trim();
nome = nome.ToLower();
cognome = cognome.Trim();
cognome = cognome.ToLower();
data = data.Trim();
data = data.ToLower();
string[] data1 = data.Split('/');
creo(nome, cognome, data1);

