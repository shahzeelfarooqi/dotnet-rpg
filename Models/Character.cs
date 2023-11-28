global using dotnet_rpg.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;

public class Character
{

    public int Id { get;set;}

    public String Name {get; set;} = "Frodo";

    public int HitPoints { get; set;} = 100;

    public int Strength { get; set;} = 10;

    public int Defense { get; set;} = 10;

    public int Intelligence { get; set;} = 10;

    public RpgClass MyProperty { get; set; } = RpgClass.Knight;


    
}