using System;
using System.Collections.Generic;


class HelloWorld {
     
  public struct amigos {
          public string nome;
          public int idade;
          public List<string> qualidades;
          
 } 
 
 
 
  static void Main() {
      Console.WriteLine("Hello World");
      
      amigos a1;
      
      a1.nome = "Velma";
      a1.idade = 16;
      a1.qualidades = new List<string> {"Inteligente", "Agil", "Companheira"};

      amigos a2;
      a2.nome = "Salsicha";
      a2.idade = 17;
      a2.qualidades = new List<string> {"Engraçado", "Topa tudo em troca de uma comidinha", "Companheiro"};
     
     amigos a3;
      a3.nome = "Dafhny";
      a3.idade = 16;
      a3.qualidades = new List<string> {"Vaidosa", "Esperta", "Conhece muitos truques de make"};
    
     Console.WriteLine("Scooby é um cachorro muito medroso que ama biscoitos scoobys e adora se aventurar com sua turma.");
     
     Console.WriteLine("Escolha um de seus amigos para saber mais sobre eles:");
     Console.WriteLine("1.Velma");
     Console.WriteLine("2.Salsicha");
     Console.WriteLine("3.Dafhny");
     int escolha = int.Parse(Console.ReadLine());
     
     switch(escolha){
         case 1:
         Console.WriteLine("Seu nome é " + a1.nome);
         Console.WriteLine("Sua idade é " + a1.idade);
         Console.WriteLine("Suas qualidades são :");
         foreach (string qualidade in a1.qualidades){
         Console.WriteLine(qualidade);
     }
         break;
         
         case 2:
         Console.WriteLine("Seu nome é " + a2.nome);
         Console.WriteLine("Sua idade é " + a2.idade);
         Console.WriteLine("Suas qualidades são :");
         foreach (string qualidade in a2.qualidades){
         Console.WriteLine(qualidade);
     }
         break;
         
         case 3:
         Console.WriteLine("Seu nome é " + a3.nome);
         Console.WriteLine("Sua idade é " + a3.idade);
         Console.WriteLine("Suas qualidades são :");
         foreach (string qualidade in a3.qualidades){
         Console.WriteLine(qualidade);
     }
         break;
         
         
         
     }
     

      
  }
}