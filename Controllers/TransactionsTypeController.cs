using Microsoft.AspNetCore.Mvc;

namespace inventory_system_API.Controllers;

[ApiController]
[Route("[controller]")]
public class TransactionsTypeController : ControllerBase
{
    
    private readonly ILogger<TransactionsTypeController> _logger;

    public TransactionsTypeController(ILogger<TransactionsTypeController> logger)
    {
        _logger = logger;
    }


//get all TransactionsType
    [HttpGet(Name = "TransactionsType")]
    public object TransactionsType(){
    
   //ID	    Name	Description
//1	purchasing	purchase transaction
    
        var ob=new{ID=1,Name="purchasing",Descrption= "purchase transaction"}; 
        return(ob) ;
    }

    //get  TransactionsType by ID
    [HttpGet("GetTransactionsTypeById")]
    public object GetTransactionsTypeById(int ID){
        
        var ob=new{ID=1,Name="purchasing",Descrption= "purchase transaction"};
        return(ob) ;
    }
    //get  TransactionsType by Name 
    [HttpGet("GetTransactionsTypeByName")]
    public object GetTransactionsTypeeByName(string Name){
        
        var ob=new{ID=1,Name="purchasing",Descrption= "purchase transaction"};
        return(ob) ;
    }
    //update  TransactionsType 
    [HttpPost("UpdateTransactionsTypeById")]
    public object UpdateTransactionsTypeById(int ID,string Name,string Descrption){
        //ID	Name	
	    
       var ob=new{ID=1,Name=Name,Descrption= Descrption};
        return(ob) ;
    }
    //delete  TransactionsType   
    [HttpDelete("DeteTransactionsTypee")]
    public object DeteTransactionsTypee(int ID){
        //ID	Name
	    //1 electronics
        var ob=new{ID=ID,Message=$"the TransactionsType withe id {ID} was deletd"}; 
        return(ob) ;
    }
}
