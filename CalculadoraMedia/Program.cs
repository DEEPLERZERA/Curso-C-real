// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo!"); //Imprime na tela bem vindo
float somamedia = 0; //Declaração de variável
int cont = 0; //Declaração de variável
while(true) //Enquanto for true
{
    Console.WriteLine($"Digite uma nota {cont}: "); //Imprime na tela Digite uma nota
    float n = float.Parse(Console.ReadLine()); //Lê a entrada do usuário
    somamedia += n; //Soma a nota
    cont++; ///Incrementa o contador

    string saair = " "; //Declaração de variável

     

    while(saair != "S" || saair != "N") //enquanto saair for diferente de S ou N 
  {
    Console.WriteLine("Quer sair do programa[S/N]");  //Imprime na tela Quer sair do programa
    saair = Console.ReadLine().ToUpper();  //Lê a entrada do usuário e passa para upper case
    if(saair == "S") {  //Se saair for igual a S
        break; //Sai do laço
    }
    else if(saair == "N") { //Se saair for igual a N

        break; //Sai do laçoo
    }
    else {  //Se saair for diferente de S ou N
        Console.WriteLine("Digite uma opcao valida");  //Imprime na tela Digite uma opcao valida
    }
    
       }
       if(saair == "S") { //Se saair for igual a S
           break; //Sai do laço
       }
}

       float r = somamedia/cont; //Divide a soma das notas por o contador
       if(r > 7) { //Se r for maior que 7
           Console.WriteLine($"Aprovado sua média é {r}"); //Imprime na tela Aprovado sua média é
       }
       else { //Se r for menor que 7
          Console.WriteLine($"Reprovado sua média é {r}"); //Imprime na tela Reprovado sua média é
       }
       Console.WriteLine("     Voce saiu do programa!"); //Imprime na tela Voce saiu do programa
       Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~"); //Imprime na tela ~~~~~~~~~~~~~~~~~~~~~~~~
      

