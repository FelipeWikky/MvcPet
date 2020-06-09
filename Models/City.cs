using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

using System.Web;
using System.Net;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;

using Newtonsoft.Json;

namespace MvcPet.Models {
  public class City {
    public int id {get;set;}
    
    public string nome {get;set;}

    public static List<City> getCitys(string uf){
      List<City> list = new List<City>();

      //recebendo cities de uma api
      string url = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/" + uf + "/municipios";

      var request = WebRequest.CreateHttp(url);
      request.Method = "GET";
      request.UserAgent = "RequisicaoWebDemo";

      using (var response = request.GetResponse())
      {
        var streamDados = response.GetResponseStream();
        StreamReader reader = new StreamReader(streamDados);
        object objResponse = reader.ReadToEnd();

        var cities = JsonConvert.DeserializeObject<City[]>(objResponse.ToString());

        foreach(var city in cities){
          list.Add(city);
        }

        streamDados.Close();
        response.Close();
      }

      return list;
    }
  }
}