﻿namespace NetCoreMongoDB.Entities;

public class Book : Base
{
    public string BookName { get; set; }
    public int Price { get; set; }
    public List<Category> Categories { get; set; }
    public string Author { get; set; }
}