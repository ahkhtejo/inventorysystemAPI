using inventory_system_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace inventory_system_API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersTypesController : ControllerBase
{
    
    private readonly ILogger<UsersTypesController> _logger;

    public UsersTypesController(ILogger<UsersTypesController> logger)
    {
        _logger = logger;
    }

 //get all UsersTypes
    [HttpGet(Name = "GetUsersTypes")]
    public object GetUsersTypes(){
         var context = new InventorySystemContext();
        var UsersTypesList = context.UsersTypes.ToList();
        // var ob=new{ID=1,Name="hkalifa",Email= "ksjdf@lsdjf.com",phoneNumber="9845948",address=".kasfksmdv-a.skfma-", userIdType=2 }; 
        return (UsersTypesList);
    }

    //get  UsersType by ID
    [HttpGet("GetUsersTypeeById")]
    public object GetUsersTypeeById(int ID){
         var context = new InventorySystemContext();
        var UsersTypesList = context.UsersTypes.Where(u => u.Id == ID).ToList().FirstOrDefault();

        return (UsersTypesList);
    }
    //get  UsersType by Name 
    [HttpGet("GetUsersTypeeByName")]
    public object GetUsersTypeeByName(string Name){
        //ID	Name
	    //1 khalifa;
          var context = new InventorySystemContext();
        var UsersTypesList = context.UsersTypes.Where(u => u.Name == Name).ToList().FirstOrDefault();

        return (UsersTypesList);
    }
    //update  UsersType 
    [HttpPost("UpdateUsersTypee")]
    public object UpdateUsersTypee(int ID,string Name){
        var context = new InventorySystemContext();
        var UsersTypee = context.UsersTypes.FirstOrDefault(U => U.Id == ID);
        if (User != null)
        {
            UsersTypee.Id = ID;
            UsersTypee.Name = Name;
            context.SaveChanges();
            return (User);
        }
        
        else{
            return(new { ID = ID,Message = $"no Users Typee found to Update" });
        }
    }
    //delete  UsersType   
    [HttpDelete("DeteUsersTypee")]
    public object DeteUsersTypee(int ID){

        var context = new InventorySystemContext();
        var UsersTypee = context.UsersTypes.FirstOrDefault(U => U.Id == ID);
        if(User != null){
            context.UsersTypes.Remove(UsersTypee);
             context.SaveChanges();

             var ob = new { ID = ID, Message = $"the Users Types withe id {ID} was deletd" };
            return (ob);
        }else{
            return(new { ID = ID,Message = $"no Users Types found to delte" });
        }
    }


}
