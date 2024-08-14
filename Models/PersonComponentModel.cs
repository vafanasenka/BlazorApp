using Microsoft.AspNetCore.Components;

namespace BlazorApp.Models;

public class PersonComponentModel : ComponentBase
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public PersonComponentModel()
    {
        FirstName = "John";
        LastName = "Doe";
    }
}
