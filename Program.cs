using System;
using RestSharp;
using System.Net;
using System.IO;
using System.Collections.Generic;

namespace almeidaAPI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //DEPOIS DE ESTABELECIMENTO PASSAR O ID DA LOJA 
            var url = "http://www.donuz.co/api/v1/estabelecimento/35369";
            var authToken = "a25fd9dd924553ff1104091c853bfda0";
            var requisicaoWeb = WebRequest.CreateHttp(url);           
            requisicaoWeb.Method = "GET";
            requisicaoWeb.UserAgent = "RequisicaoDONUZ";
            requisicaoWeb.Headers.Add("Token", authToken);
            
           

            using (var resposta = requisicaoWeb.GetResponse())
            {
                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();
                Console.WriteLine(objResponse.ToString());
                Console.ReadLine();
                streamDados.Close();
                resposta.Close();
                Console.WriteLine("Cheguei aqui");
            }

            
        }         
    }
}
