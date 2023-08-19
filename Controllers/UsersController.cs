using inventory_system_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace inventory_system_API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{

    private readonly ILogger<UsersController> _logger;

    public UsersController(ILogger<UsersController> logger)
    {
        _logger = logger;
    }

    //get all UsersTypes
    [HttpGet(Name = "Users")]
    public object Users()
    {

        //ID	Name	E-mail	phone Number	address	User Type ID	password
        var context = new InventorySystemContext();
        var usersList = context.Users.ToList();
        // var ob=new{ID=1,Name="hkalifa",Email= "ksjdf@lsdjf.com",phoneNumber="9845948",address=".kasfksmdv-a.skfma-", userIdType=2 }; 
        return (usersList);
    }

    //get  UsersType by ID
    [HttpGet("GetUsersTypeeById")]
    public object GetUsersTypeeById(int ID)
    {

        //  var ob=new{ID=ID,Name="hkalifa",Email= "ksjdf@lsdjf.com",phoneNumber="9845948",address=".kasfksmdv-a.skfma-", userIdType=2 }; 
        var context = new InventorySystemContext();
        var usersList = context.Users.Where(u => u.Id == ID).ToList().FirstOrDefault();

        return (usersList);
    }
    //get  UsersType by Name 
    [HttpGet("GetUsersTypeeByName")]
    public object GetUsersTypeeByName(string Name)
    {

        //  var ob=new{ID=1,Name=Name,Email= "ksjdf@lsdjf.com",phoneNumber="9845948",address=".kasfksmdv-a.skfma-", userIdType=2 };  
        var context = new InventorySystemContext();
        var usersList = context.Users.Where(u => u.Name == Name).ToList().FirstOrDefault();
        return (usersList);
    }
    //update  UsersType 
    [HttpPost("UpdateUsersTypee")]
    public object UpdateUsersTypee(int ID, string Name, string Email, string phoneNumber, string address, int userIdType)
    {
        //ID	Name	
        //1 electronics	ksdf;sf
        
        var context = new InventorySystemContext();
        var User = context.Users.FirstOrDefault(U => U.Id == ID);
        if (User != null)
        {
            User.Id = ID;
            User.Name = Name;
            User.EMail = Email;
            User.PhoneNumber = phoneNumber;
            User.Address = address;
            User.UserTypeId = userIdType;
            context.SaveChanges();
            return (User);
        }
        
        else{
            return(new { ID = ID,Message = $"no user found to Update" });
        }

    }
    //delete  UsersType   
    [HttpDelete("DeteUsersTypee")]
    public object DeteUsersTypee(int ID)
    {
        var context = new InventorySystemContext();
        var User = context.Users.FirstOrDefault(U => U.Id == ID);
        if(User != null){
            context.Users.Remove(User);
             context.SaveChanges();

             var ob = new { ID = ID, Message = $"the Users withe id {ID} was deletd" };
            return (ob);
        }else{
            return(new { ID = ID,Message = $"no user found to delte" });
        }
        
    }

}
