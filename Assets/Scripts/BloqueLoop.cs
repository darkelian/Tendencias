using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueLoop : Bloque
{
    public bool isSelect;

    public string type = "int";
    public string range = "range(5)";
    public string i = "i";
    public string valorXML;

    public BloqueLoop()
    {
        valorXML = $"<loop type=\"{type}\" variable=\"{i}\" range=\"{range}\"></loop>";
    }
}
