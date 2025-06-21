int seuDia, seuMes;
string decisao;


    string[] mes = {
    "O Zumbi",
    "O Assassino",
    "O Psicopata",
    "O Alienígena",
    "O Carniceiro",
    "O Matador",
    "O Vampiro",
    "O Maluco",
    "O Vingador",
    "O Monstro",
    "O Bruxo",
    "O Demônio"
};

string[] dia = {
    "Endiabrado",
    "Radioativo",
    "Endemoniado",
    "Vermelho",
    "Possuído",
    "Macabro",
    "Sombrio",
    "Sem Cabeça",
    "Desconhecido",
    "Inconsciente",
    "Oculto",
    "Esquecido",
    "Lúgubre",
    "Invocado",
    "Caído",
    "Costurado",
    "Amaldiçoado",
    "Anormal",
    "Perturbado",
    "Sanguinário",
    "Tenebroso",
    "Imortal",
    "Ressuscitado",
    "do Pântano",
    "da Encruzilhada",
    "do Porão",
    "do Velho Poço",
    "sem Perdão",
    "do Cemitério",
    "da Meia-Noite",
    "da Lua Cheia"
};

while (true)
{

    Console.WriteLine("Bem-vindo a noite de terror");
    Console.WriteLine("Venha descobrir qual o monstro ira te perseguir nessa sexta-feira 13");

    Console.WriteLine("----- O começo da noite de Terror -----");

    Console.WriteLine("Por favor digite o dia do seu nascimento (de 1 a 31): ");
    seuDia = Convert.ToInt16(Console.ReadLine()!);

    Console.WriteLine("Por favor digite o mês do seu nascimento (de 1 a 12): ");
    seuMes = Convert.ToInt16(Console.ReadLine()!);


    if (seuMes == 12 && seuDia == 25)
    {
        Console.WriteLine("\nHo Ho Ho! alguem nasceu em clima natalino em, pode para de correr, ninguem vai te pegar hahaha");
        break;
    }
    else
    {
        Console.WriteLine("----- O Momento de terror começou -----");
        Console.WriteLine($"Corra {mes[seuMes - 1]} {dia[seuDia - 1]} esta vindo atras de você!");
    }
    


    Console.WriteLine("\nDeseja tentar novamente para talvez se salvar?");
    decisao = Console.ReadLine()!.ToUpper();

    if (decisao == "S")
    {
        Console.WriteLine("Vamos novamente! salve se puder hahahaha");
        Console.Clear();
        continue;
    }
    else
    {
        Console.WriteLine("Continue correndo então hahahaha");
        break;
    }

}