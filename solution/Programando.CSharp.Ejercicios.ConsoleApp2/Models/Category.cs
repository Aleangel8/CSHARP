﻿using System;
using System.Collections.Generic;

namespace Programando.CSharp.Ejercicios.ConsoleApp2.Models;

public partial class Category
{
    public int CategoryID { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }

    public byte[]? Picture { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
