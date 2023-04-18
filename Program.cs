string PalavraProibida = "@#$!%*";
string fraseEscrita, fraseCensura;

Console.WriteLine("Escreva uma frase: ");
fraseEscrita = Console.ReadLine()!;

fraseCensura = fraseEscrita

.Replace("chato", PalavraProibida)
    .Replace("chata", PalavraProibida)
    .Replace("bobo", PalavraProibida)
    .Replace("boba", PalavraProibida)
    .Replace("feio", PalavraProibida)
    .Replace("feia", PalavraProibida)
    .Replace("boboca", PalavraProibida)
    .Replace("bocó", PalavraProibida)
    .Replace("tonto", PalavraProibida)
    .Replace("tonta", PalavraProibida)
   .Replace("palerma", PalavraProibida)
   .Replace("paspalho", PalavraProibida)
   .Replace("paspalha", PalavraProibida)
    .Replace("tantã", PalavraProibida)
    .Replace("panaca", PalavraProibida)
    .Replace("pentelho", PalavraProibida)
    .Replace("pentelha", PalavraProibida)
    .Replace("burro", PalavraProibida)
    .Replace("burra", PalavraProibida)
    .Replace("besta", PalavraProibida)
    .Replace("CHATO", PalavraProibida)
    .Replace("CHATA", PalavraProibida)
    .Replace("BOBO", PalavraProibida)
    .Replace("BOBA", PalavraProibida)
    .Replace("FEIO", PalavraProibida)
    .Replace("FEIA", PalavraProibida)
    .Replace("BOBOCA", PalavraProibida)
    .Replace("BOCÓ", PalavraProibida)
    .Replace("TONTO", PalavraProibida)
    .Replace("TONTA", PalavraProibida)
    .Replace("PALERMA", PalavraProibida)
    .Replace("PASPALHO", PalavraProibida)
    .Replace("PASPALHA", PalavraProibida)
    .Replace("TANTÃ", PalavraProibida)
    .Replace("PANACA", PalavraProibida)
    .Replace("PENTELHO", PalavraProibida)
    .Replace("PENTELHA", PalavraProibida)
    .Replace("BURRO", PalavraProibida)
    .Replace("BURRA", PalavraProibida)
    .Replace("BESTA", PalavraProibida);

    Console.WriteLine(fraseCensura);