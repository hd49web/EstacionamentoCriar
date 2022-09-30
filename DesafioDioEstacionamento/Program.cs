using EstacionamentoCriar.Modelos;

decimal precoInicio = 0 ;
decimal precoHora = 0 ;

Console.WriteLine("Valor principal");
precoInicio = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Valor por Hora");
precoHora = Convert.ToDecimal(Console.ReadLine());

 Estacionamento es = new Estacionamento(precoInicio , precoHora);

 //es.AdicionarVeiculo();

 bool exibirMenu = true;
 while(exibirMenu){
    Console.Clear();
    Console.WriteLine(" Digite a Opção Desejada ");
    Console.WriteLine("");
    Console.WriteLine(" 1º Cadastrar Veiculo ");
    Console.WriteLine(" 2º Remover Veiculo ");
    Console.WriteLine(" 3º Listar o Veiculo ");
    Console.WriteLine(" 4º Encerrar ");
switch(Console.ReadLine()){
    case "1":
    es.AdicionarVeiculo();
    break;
    case "2":
    es.RemoverVeiculo();
    break;
    case "3":
    es.ListarVeiculo();
    break;
    case "4":
    exibirMenu = false;
    break;
    default:
    Console.WriteLine("Opção Invalida");
    break;
}
    Console.WriteLine("Pressione uma tecla");    
    Console.ReadLine();

 }
    Console.WriteLine("O Programa fechou");