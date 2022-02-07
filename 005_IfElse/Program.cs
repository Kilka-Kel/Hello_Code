Console.WriteLine("Введите имя для приветствия");
string username = Console.ReadLine();
if (username.ToLower() == "килька")
{
   Console.ForegroundColor=ConsoleColor.DarkGreen;
   Console.Write("Привет Килька, держи сердешко");
}
else
{
    Console.Write("Не то что для мення было бы важно твоё имя. Но  привет, ");
    Console.WriteLine(username);
}    
    
    
