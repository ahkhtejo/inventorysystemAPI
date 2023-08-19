using Microsoft.AspNetCore.Mvc;

namespace inventory_system_API.Controllers;

[ApiController]
[Route("[controller]")]
public class TransactionsController : ControllerBase
{
    
    private readonly ILogger<TransactionsController> _logger;

    public TransactionsController(ILogger<TransactionsController> logger)
    {
        _logger = logger;
    }

//get all Transactions
    [HttpGet(Name = "Transactions")]
    public object Transactions(){
    
    //ID	Name	orderdate	deliverydate	itemsID TransactionId	UserId

        var ob=new{ID=1,Name="hkalifa",OrderDate= "20/5/2023",DeliveryDate= "26/5/2023",ItemsId=1, TransactionId=2, UserId=3 }; 
        return(ob) ;
    }

    //get  TransactionsType by ID
    [HttpGet("GetTransactionsTypeeById")]
    public object GetTransactionsTypeeById(int ID){
        
        var ob=new{ID=1,Name="hkalifa",OrderDate= "20/5/2023",DeliveryDate= "26/5/2023",ItemsId=1, TransactionId=2, UserId=3 }; 
        return(ob) ;
    }
    //get  TransactionsType by Name 
    [HttpGet("GetTransactionsTypeeByName")]
    public object GetTransactionsTypeeByName(string Name){
        
         var ob=new{ID=1,Name="hkalifa",OrderDate= "20/5/2023",DeliveryDate= "26/5/2023",ItemsId=1, TransactionId=2, UserId=3 }; 
        return(ob) ;
    }
    //update  TransactionsType 
    [HttpPost("UpdateTransactionsTypee")]
    public object UpdateTransactionsTypee(int ID,string Name,DateTime OrderDate, DateTime DeliveryDate, int ItemsId,int TransactionId, int UserId){
        //ID	Name	
	    //1 electronics	ksdf;sf
        var ob=new{ID=1,Name=Name,OrderDate= OrderDate,DeliveryDate=DeliveryDate,ItemsId=ItemsId,TransactionId= TransactionId, UserId= UserId}; 
        return(ob) ;
    }
    //delete  TransactionsType   
    [HttpDelete("DeteTransactionsTypee")]
    public object DeteTransactionsTypee(int ID){
        //ID	Name
	    //1 electronics
        var ob=new{ID=ID,Message=$"the Transactions withe id {ID} was deletd"}; 
        return(ob) ;
    }

}
