using inventory_system_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace inventory_system_API.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemsController : ControllerBase
{
    
    private readonly ILogger<ItemsController> _logger;

    public ItemsController(ILogger<ItemsController> logger)
    {
        _logger = logger;
    }

//get all Items
    [HttpGet(Name = "Items")]
    public object Items(){
     
        var context = new InventorySystemContext();
        var ItemsList = context.Items.ToList();
        
        return (ItemsList);
    }

    //get  Items by ID
    [HttpGet("GetItemsById")]
    public object GetItemsById(int ID){
        
         var context = new InventorySystemContext();
        var ItemsList = context.Items.Where(i=>i.Id==ID).ToList();
        
        return (ItemsList);
    }
    //get  Items by Name 
    [HttpGet("GetItemseByName")]
    public object GetItemseByName(string Name){
        
        var context = new InventorySystemContext();
        var ItemsList = context.Items.Where(i=>i.Name==Name).ToList();
        
        return (ItemsList);
    }
    //update  Items 
    [HttpPost("UpdateItemse")]
    public object UpdateItemse(int ID,string Name,string Descrption,int quantity){
      
        var context = new InventorySystemContext();
        var Items = context.Items.FirstOrDefault(I => I.Id == ID);
        if (Items != null)
        {
            Items.Id = ID;
            Items.Name = Name;
            Items.Quantity = quantity;
            Items.Description= Descrption;
            context.SaveChanges();
            return (Items);
        }
        
        else{
            return(new { ID = ID,Message = $"no Items found to Update" });
        }
    }
    //delete  Items   
    [HttpDelete("DeteItemse")]
    public object DeteItemse(int ID){
        //ID	Name
	    //1 electronics
       var context = new InventorySystemContext();
        var Items = context.Items.FirstOrDefault(I => I.Id == ID);
        if (Items != null){
             context.Items.Remove(Items);
             context.SaveChanges();
             return(Items);
        }
        else{
             return(new { ID = ID,Message = $"no Items found to Delet" });
        }
    }


}
