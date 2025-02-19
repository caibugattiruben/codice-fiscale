string creo(string nome,string cogn, string[] data)
{
    char[] vocali ={ 'a', 'e','i','o','u' };
    string codice="",lettera="",vocalicogn="";
    int si = 0,ok=0,pos=0,a=0,lung=0;
    //cogn
    for(int i = 0; i < cogn.Length; i++)
    {
        if (cogn[i] == vocali[0] || cogn[i] == vocali[1] || cogn[i] == vocali[2] || cogn[i] == vocali[3] || cogn[i] == vocali[4])
        {
            vocalicogn += cogn[i];
        }
    }
    //COGNOME
    while(ok!=3)
    {
        if (cogn[pos] != vocali[0] && cogn[pos] != vocali[1] && cogn[pos] != vocali[2] && cogn[pos] != vocali[3] && cogn[pos] != vocali[4])
        {
            lettera = cogn[pos].ToString().ToUpper();
            codice += lettera;
            ok++;
            
        }
        else
        {
            
            if (si > 0)
            {
                codice += vocalicogn[a];
                pos++;
                a++;
                ok++;
                
            }
            
        }
        pos++;
        if (ok == 3 && codice.Length!=3)
        {
            si++;
            ok = codice.Length;
        }
        lung = codice.Length;
    }
    //NOME
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

