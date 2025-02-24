string creo(string nome,string cogn, string[] data ,string sesso)
{
    char[] vocali ={ 'a', 'e','i','o','u' };
    string codice="",lettera="",conscogn="",vocalicogn="", consnom = "", vocalinom = "";
    int si = 0,ok=0,pos=0,a=0,lung=0;
    string mese = " ABCDEHLMPRST";
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
        if(codice.Length < 3)
        {
            for (int i = codice.Length; i < 3; i++)
            {
                codice += "X";
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
        if (codice.Length < 6)
        {
            for (int i = codice.Length; i < 6; i++)
            {
                codice += "X";
                ok++;

            }
        }
    }
    ok = 0;
    //NASCITA
    while (ok < 5)
    {
        if (ok < 3)
        {
            codice += data[2];
            ok = 3;
        }
        else if(ok>2 && ok < 4)
        {
            string valore = data[1];
            int val = int.Parse(valore);
            codice += mese[val];
            ok++;
        }
        else
        {
            if (sesso == "f")
            {
                int g = int.Parse(data[0]) + 40;
                codice += g;
            }
            else
            {
                codice += data[0];
            }
            ok++;
        }
    }
    codice = codice.ToUpper();
    Console.WriteLine(codice);
    return codice;
}
Console.WriteLine("Dimmi il tuo nome (se ne hai due scrivili attaccati senza spazio)");
string nome = Console.ReadLine();
Console.WriteLine("Dimmi il tuo cognome (se ne hai due scrivili attaccati senza spazio)");
string cognome = Console.ReadLine();
Console.WriteLine("Quando sei nato? (gg/mm/aaaa)");
string data = Console.ReadLine();
Console.WriteLine("Qual'è il tuo sesso (m o f)");
string sesso = Console.ReadLine();
nome = nome.Trim();
nome = nome.ToLower();
cognome = cognome.Trim();
cognome = cognome.ToLower();
data = data.Trim();
data = data.ToLower();
string[] data1 = data.Split('/');
data1[2] = data.Substring(8);
sesso = sesso.Trim();
sesso=sesso.ToLower();
creo(nome, cognome, data1,sesso);

