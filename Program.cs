// See https://aka.ms/new-console-template for more information
string palavraCensurada = "$@#%*!&";

string fraseDigitada, fraseCensurada;
Console.Write("digite uma frase qualquer:");
fraseDigitada = Console.ReadLine()!;

 fraseCensurada = fraseDigitada 
.Replace("chato", palavraCensurada)
.Replace("chata", palavraCensurada)
.Replace("bobo", palavraCensurada)
.Replace("boba", palavraCensurada)
.Replace("feio", palavraCensurada)
.Replace("feia", palavraCensurada)
.Replace("boboca", palavraCensurada)
.Replace("bocó", palavraCensurada)
.Replace("tonto", palavraCensurada)
.Replace("tonta", palavraCensurada)
.Replace("palerma", palavraCensurada)
.Replace("paspalho", palavraCensurada)
.Replace("paspalha", palavraCensurada)
.Replace("tantã", palavraCensurada)
.Replace("panaca", palavraCensurada)
.Replace("pentelho", palavraCensurada)
.Replace("pentelha", palavraCensurada)
.Replace("burro", palavraCensurada)
.Replace("burra", palavraCensurada)
.Replace("besta", palavraCensurada)
.Replace("CHATO", palavraCensurada)
.Replace("CHATA", palavraCensurada)
.Replace("BOBO", palavraCensurada)
.Replace("BOBA", palavraCensurada)
.Replace("FEIO", palavraCensurada)
.Replace("FEIA", palavraCensurada)
.Replace("BOBOCA", palavraCensurada)
.Replace("BOCÓ", palavraCensurada)
.Replace("TONTO", palavraCensurada)
.Replace("TONTA", palavraCensurada)
.Replace("PALERMA", palavraCensurada)
.Replace("PASPALHO", palavraCensurada)
.Replace("PASPALHA", palavraCensurada)
.Replace("TANTÃ", palavraCensurada)
.Replace("PANACA", palavraCensurada)
.Replace("PENTELHO", palavraCensurada)
.Replace("PENTELHA", palavraCensurada)
.Replace("BURRO", palavraCensurada)
.Replace("BURRA", palavraCensurada)
.Replace("BESTA", palavraCensurada)
.Replace("OTARIO", palavraCensurada )
.Replace("OTARIA", palavraCensurada);

Console.WriteLine($"Eu sou uma criança educada. No seu lugar eu diria:{fraseCensurada}");