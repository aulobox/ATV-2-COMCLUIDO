using System;

class Program {
  public static void Main (string[] args) {

    Double nota1, nota2, nota3, mediaF;
    String media1, media2, media3;
    
    Console.Write("Digite a primeira nota :");
    media1=Console.ReadLine();  
    nota1=Double.Parse(media1);

    Console.Write("Digite a segunda nota :");
    media2=Console.ReadLine();  
    nota2=Double.Parse(media2);

    Console.Write("Digite a terceira nota :");
    media3=Console.ReadLine();  
    nota3=Double.Parse(media3);


   mediaF = (nota1*2 + nota2*3 + nota3*5) /10;

  Console.Write("A nota média do aluno é: " + mediaF);
    






    

  }
}