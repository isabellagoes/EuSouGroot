const string FraseSaida = "tchau";

Console.WriteLine("----- Groot Chatbot -----\n");

string Você;
do
{
    Console.Write("Você: ");
    Você = Console.ReadLine()!;

    string Groot = ObtemRespostaGroot(Você);

    ExibeResposta(ObtemRespostaGroot(Você));

}

while (Você.Trim().ToLower() != FraseSaida);

void ExibeResposta(string Groot)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"                          Groot: {Groot}");
    Console.ResetColor();
}

string ObtemRespostaGroot(string Você)
{
    return Você.Trim().ToLower() == FraseSaida ?
        "Eu sou Groot!" :
        "Eu sou Groot.";
}