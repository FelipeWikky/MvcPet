using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace MvcPet.Models
{

  [NotMapped]
  public partial class Message
  {
    public Message(){}

    public Message(int status){
      statusType = status;
    }
    public Message(int status, string message){
      statusType = status;
      statusMessage = message;
    }


    [TempData]
    public int statusType { get; set; }
    [TempData]
    public string statusMessage { get; set; }
    
    public bool isSucced { get; set; }
    public string successMessage { get; set; }

    public bool isWarning { get; set; }
    public string warningMessage { get; set; }

    public bool isDanger { get; set; }
    public string dangerMessage { get; set; }

  }

}