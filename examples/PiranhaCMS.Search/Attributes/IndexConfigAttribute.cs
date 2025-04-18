﻿namespace PiranhaCMS.Search.Attributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class IndexConfigAttribute : Attribute
{
    public string IndexName { get; set; }
}
