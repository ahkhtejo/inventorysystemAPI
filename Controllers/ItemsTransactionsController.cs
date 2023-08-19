using Microsoft.AspNetCore.Mvc;

namespace inventory_system_API.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemsTransactionsCategoriesController : ControllerBase
{
    
    private readonly ILogger<ItemsTransactionsCategoriesController> _logger;

    public ItemsTransactionsCategoriesController(ILogger<ItemsTransactionsCategoriesController> logger)
    {
        _logger = logger;
    }

//get all ItemsTransactions
    [HttpGet(Name = "ItemsTransactions")]
    public object ItemsTransactions(){
    
    //id    items id     transaction id
    
        var ob=new{ID=1,itemsID=20,TransactionsID=30 }; 
        return(ob) ;
    }

    //get  ItemsTransactions by TransactionID
    [HttpGet("GetItemsTransactionsByTransactionID")]
    public object GetItemsTransactionsByTransactionID(int TransactionID){
        
        var ob=new{ID=1,itemsID=50,TransactionsID=1 }; 
        return(ob) ;
    }
    //get  ItemsTransactions by TransactionID 
    [HttpGet("GetItemsTransactionseByName")]
    public object GetItemsTransactionseByName(int TransactionID){
        
        var ob=new{ID=1,itemsID=50,TransactionsID=1 }; 
        return(ob) ;
    }
    //update  ItemsTransactions 
    [HttpPost("UpdateItemsTransactionse")]
    public object UpdateItemsTransactionse(int ID,int itemsID,int TransactionID){
        //ID	Name	
	    //1 electronics	ksdf;sf
        var ob=new{ID=ID,itemsID=itemsID,TransactionID=TransactionID}; 
        return(ob) ;
    }
    //delete  ItemsTransactions   
    [HttpDelete("DeteItemsTransactionse")]
    public object DeteItemsTransactionse(int ID){
        //ID	Name
	    //1 electronics
        var ob=new{ID=ID,Message=$"the ItemsTransactions withe id {ID} was deletd"}; 
        return(ob) ;
    }


}
