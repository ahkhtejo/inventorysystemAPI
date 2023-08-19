using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Protocol;

namespace inventory_system_API.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoriesController : ControllerBase
{
    
    private readonly ILogger<CategoriesController> _logger;

    public CategoriesController(ILogger<CategoriesController> logger)
    {
        _logger = logger;
    }

    //get all Categories
    [HttpGet(Name = "GetCategories")]
    public object GetCategories(){
        //ID	Name	Description
	    //1 electronics	ksdf;sf
        var ob=new{ID=1,Name="electronics",Description="ksdf;sf"}; 
        return(ob) ;
    }


    //get  Categori by ID
    [HttpGet("GetCategorieById")]
    public object GetCategorieById(int ID){
        //ID	Name	Description
	    //1 electronics	ksdf;sf
        var ob=new{ID=1,Name="electronics",Description="ksdf;sf"}; 
        return(ob) ;
    }
    //get  Categori by Name 
    [HttpGet("GetCategorieByName")]
    public object GetCategorieByName(string Name){
        //ID	Name	Description
	    //1 electronics	ksdf;sf
        var ob=new{ID=1,Name="electronics",Description="ksdf;sf"}; 
        return(ob) ;
    }
    //update  Categori 
    [HttpPost("UpdateCategorie")]
    public object UpdateCategorie(int ID,string Name, string Description){
        //ID	Name	Description
	    //1 electronics	ksdf;sf
        var ob=new{ID=ID,Name=Name,Description=Description}; 
        return(ob) ;
    }
    //delete  Categori   
    [HttpDelete("DeteCategorie")]
    public object DeteCategorie(int ID){
        //ID	Name	Description
	    //1 electronics	ksdf;sf
        var ob=new{ID=ID,Message=$"the Categorie withe id {ID} was deletd"}; 
        return(ob) ;
    }

}
