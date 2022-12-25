// See https://aka.ms/new-console-template for more information

/*Console.WriteLine("entrer la valeur");

int nombre = Convert.ToInt32(Console.ReadLine());

if (nombre % 2 == 0)
{
    Console.WriteLine("le nombre " + nombre + " est paire");
}
else
{
    Console.WriteLine("le nombre " + nombre + " est paire");

}

Console.WriteLine("veuillez rentrer la lettre");

char lettre = Console.ReadLine()[0];

if (lettre == 'a' || lettre == 'e' || lettre == 'i' || lettre == 'o'
   || lettre == 'u' || lettre == 'A' || lettre == 'E' || lettre == 'I'
   || lettre == 'O' || lettre == 'U')
{
    Console.WriteLine("est une voyelle.");
}
else
{
    Console.WriteLine("est une consonne.");
}


int[] tab = new int[5];


for(int i =0; i < tab.Length; i++)
{
    Console.WriteLine("saisir l'element " +(i+1));
    tab[i] = Convert.ToInt32(Console.ReadLine());
}

int somme = 0;

foreach (var e in tab) { 

    Console.WriteLine(e+"\t");
    somme += e;
}

Console.WriteLine();
Console.WriteLine("la somme des elements est: "+ somme);
int io = 0;
while (io < 5 / 2)
{
    int temp = tab[io];
    //n-1 parce que le tableau commence par 0
    tab[io] = tab[5 - 1 - io];
    tab[ 5- 1 - io] = temp;
    io++;
}

foreach (var e in tab)
{

    Console.WriteLine(e + "\t");
    somme += e;
Console.WriteLine("entrer la valeur");
int nombre = Convert.ToInt32(Console.ReadLine());
int somme = 0;
int cpt=0;

for (int i = 0; i < nombre; i++)
{
    for (int j = 0; j <i ; j++)
    {
        if(j%i==0)
        {
            somme = somme + j;
        }
    }
    if (somme == i)
    {
        cpt= cpt+ 1;
    }

    somme = 0;
}


Console.WriteLine('le nombre de nombre parfait est :');
}




using System.ComponentModel.DataAnnotations;

Console.WriteLine("------------exo1-----------------");

int nombre,cpt=0;
Console.WriteLine("veuillez rentrez un nombre superieure ou egale 10000");

do
{
    nombre = Convert.ToInt32(Console.ReadLine());
}while(nombre<10000);

for (int i = 0; i < nombre; i++)
{
    for (int j = 1; j < i; j++)
    {
        if (i % j == 0)
        {
            cpt = cpt + j;
        }
    }
    if(cpt==i)
    {
        Console.WriteLine(i);
    }
    cpt= 0;
}

Console.WriteLine("------------exo2-----------------");
int nbr;

Console.WriteLine("veuiller un nombre entier positive");

do
{
     nbr = Convert.ToInt32(Console.ReadLine());
} while (nbr <= 0);

Console.WriteLine("les nombres entier compris entre un et ce nombre sont: ");

for (int k = nbr;k >= 1; k--)
{
    Console.WriteLine(k);
}


Console.WriteLine("------------exo3-----------------");

Console.WriteLine("les anne bisextille compris entre 1990 et 2022 sont :");

for(int i = 1990;i<= 2022; i++)
{
    if((i%4==0 && i%100!=0) || i % 400 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("------------exo4-----------------");

int[] tab = new int[10];
int n=0,de=0;

for (int i = 0; i < tab.Length; i++)
{
    Console.WriteLine("veuillez entrez la valeur "+ i+1);
    tab[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("les 5 premiers nombre premier sont: ");


for (int i = 0; i < tab.Length; i++)
{
    n=0;
    for (int j = 1; j <= tab[i]; j++)
    {
        if (tab[i] % j == 0)
        {
            n = n + 1; 
        }
    }
    if (n == 2)
    {
        Console.WriteLine(tab[i]);
        de=de+1;
    }
    if (de == 5)
    {
        break;
    }

   
}

Console.WriteLine("---------------------exo5-------------------");



Console.WriteLine("---------------------exo1-------------------");

Console.WriteLine("veuillez entre un nombre entier");
int nombre = Convert.ToInt32(Console.ReadLine());
int cpt = 0;

while(nombre != 0)
{
    cpt++;
    nombre = nombre / 10;
}
Console.WriteLine("le nombre de chiffre qui compose ce nombre est: "+cpt);


Console.WriteLine("---------------------exo2-------------------");

int nbr;


do
{
    Console.WriteLine("veuillez rentrer un nombre superieure ou egale a 20");
    nbr = Convert.ToInt32(Console.ReadLine());


} while (nbr<20);

for(int i = 1; i < nbr; i++)
{
    if (i % 2 == 0)
    {
        if (i % 4 != 0 & i % 6 !=0) {
            Console.WriteLine(i);
        }
    }
}

Console.WriteLine("---------------------exo3-------------------");


int[] tab = new int[8];
int n = 0, de = 1;

for (int i = 0; i < tab.Length; i++)
{
    Console.WriteLine("veuillez entrez la valeur " + i);
    tab[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 1;i< tab.Length; i++)
{
    if(i%2==0 || i%3==0 || i % 4 == 0) {
        de = de * i;
    }
   
}
if (de == 1)
{
    Console.WriteLine("pas de nombre premier dans le tableau");
}
else
{
    Console.WriteLine( "le produit des nombres divisible par 2 3 4 est: "+de);
}


Console.WriteLine("---------------------exo4-------------------");


int[] tabl = new int[10];
int nb = 0;

for (int i = 0; i < tab.Length; i++)
{
    Console.WriteLine("veuillez entrez la valeur " + i);
    tabl[i] = Convert.ToInt32(Console.ReadLine());
}

for(int i = tabl.Length -1; i>0 ; i--)
{
    Console.WriteLine(tabl[i]);
}

Console.WriteLine("---------------------exo5-------------------");

int[] ta = new int[10];
int nbi = 0 , cp=0;

for (int i = 0; i < ta.Length; i++)
{
    Console.WriteLine("veuillez entrez la valeur " + i);
    ta[i] = Convert.ToInt32(Console.ReadLine());
}

for(int i =0;i<ta.Length; i++)
{
    for(int j=1; j <= ta[i]; j++)
    {
        if (ta[i] % j==0)
        {
            nbi=nbi+1;
        }
    }
    if (nbi == 2)
    {
        cp = cp + 1;
    }
    nbi = 0;
}
int nn = 10 - cp;

Console.WriteLine("ce tableau contient " +cp+ " nombre premier et "+nn+" non premier");
*/

for(int i = 00; i < 100; i++)
{
    for (int j = 00; j < 100; j++)
    {
        Console.WriteLine(i + " " + j + ",");
    }
    
}




