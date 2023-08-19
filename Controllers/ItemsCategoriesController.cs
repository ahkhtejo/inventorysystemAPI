using Microsoft.AspNetCore.Mvc;

namespace inventory_system_API.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemsCategoriesController : ControllerBase
{
    
    private readonly ILogger<ItemsCategoriesController> _logger;

    public ItemsCategoriesController(ILogger<ItemsCategoriesController> logger)
    {
        _logger = logger;
    }
//get all ItemsCategories
    [HttpGet(Name = "ItemsCategories")]
    public object ItemsCategories(){
    
    //id    items id     category id
    
        var ob=new{ID=1,itemsID=20,CategoryID=30 }; 
        return(ob) ;
    }

    //get  ItemsCategories by CategoryID
    [HttpGet("GetItemsCategoriesByCategoryID")]
    public object GetItemsCategoriesByCategoryID(int CategoryID){
        
        
        var ob=new{ID=1,itemsID=20,CategoryID=30 }; 
        return(ob) ;
    }
    //get  ItemsCategories by CategoryID 
    [HttpGet("GetItemsCategorieseByitemsId")]
    public object GetItemsCategorieseByitemsId(int itemsID){
        
        var ob=new{ID=1,itemsID=50,TransactionsID=1 }; 
        return(ob) ;
    }
    //update  ItemsCategories 
    [HttpPost("UpdateItemsCategoriese")]
    public object UpdateItemsCategoriese(int ID,int itemsID,int CategoryID){
        //ID	Name	
	    //1 electronics	ksdf;sf
        var ob=new{ID=ID,itemsID=itemsID,CategoryID=CategoryID}; 
        return(ob) ;
    }
    //delete  ItemsCategories   
    [HttpDelete("DeteItemsCategoriese")]
    public object DeteItemsCategoriese(int ID){
        //ID	Name
	    //1 electronics
        var ob=new{ID=ID,Message=$"the ItemsCategories withe id {ID} was deletd"}; 
        return(ob) ;
    }

}
