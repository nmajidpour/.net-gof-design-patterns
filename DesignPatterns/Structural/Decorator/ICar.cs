
using System.Collections.Generic;

public interface ICar
{
    int Price { get; set; }
    List<string> Components { get; set; }
    void Assemble();
}