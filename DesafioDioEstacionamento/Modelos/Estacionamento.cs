using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamentoCriar.Modelos
{
    public class Estacionamento
    {
        private decimal precoInicio = 0 ;
        private decimal precoHora = 0 ;
        private List<string> veiculos = new List<string>();
        public Estacionamento(decimal precoInicio, decimal precoHora){
            this.precoInicio = precoInicio;
            this.precoHora = precoHora;
       }  

      //    ADICIONAR VEICULOS ////

        public void AdicionarVeiculo()
        {

            Console.WriteLine("Digite a placa do seu carro");
            var placa = Console.ReadLine();
     
     // VERIFICAR SE JA FOI CADASTRADO O VEICULO ////
            if (veiculos.Any(x => x.ToUpper()== placa.ToUpper()))
            {
                Console.WriteLine("Placa ja Cadastrada");
            }
           else
          {
            veiculos.Add(placa.Trim());
            Console.WriteLine($"Cadastrado a sua placa : {placa}");
          }
        }
      
      //    REMOVER VEICULO ////
      
        public void RemoverVeiculo()


        {
            int horas;
            Console.WriteLine("Digite a placa");
            var placa = Console.ReadLine();

        // VERIFICAR SE EXISTE A PLACA   CADASTRADA DO VEICULO ////

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
            Console.WriteLine("quantas horas ficou no estacionamento ");
            horas = int.Parse(Console.ReadLine());
            decimal valorTotal = 0;
            valorTotal = (precoHora + precoInicio) * horas;
             
        /// EXCLUIR VEICULO ////  REMOVER VEICULO //// 

            veiculos.Remove(placa);
            Console.WriteLine($"Veiculo com o numero de Placa: {placa} e o valor total é: R${valorTotal}");
            }
            else
            {
                Console.WriteLine("veiculos não encontrado");
            }

        }

        ///  LISTAR VEICULOS   ////

        public void ListarVeiculo()
        {
        if (veiculos.Any())
        {
        int contador = 0;
        foreach (String placa in veiculos)
        {
        Console.WriteLine(placa);
        contador++ ;
        }
        Console.WriteLine("");
        }
        else
        {
        Console.WriteLine("Sem veiculos");        
        }    
        }
    }
}