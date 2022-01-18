using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MvcProject.Models;

public class MockUser
{
    [CsvColumn(Name = "id")]
    public int Id { get; set; }

    [CsvColumn(Name = "first_name")]
    [DisplayName("First name")]
    public string FirstName { get; set; }

    [CsvColumn(Name = "last_name")]
    public string LastName { get; set; }

    [CsvColumn(Name = "email")]
    public string Email { get; set; }

    [CsvColumn(Name = "country")]
    public string Country { get; set; }

    [CsvColumn(Name = "favourite_colour")]
    public string FavouriteColour { get; set; }
}