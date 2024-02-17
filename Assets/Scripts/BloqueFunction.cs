using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueFunction : Bloque
{
    public bool isSelect;

    static int count;
    public string name;
    public string returnType = "int";
    public string valorXML;

    public BloqueFunction()
    {
        count++;
        name = "function" + count;
        valorXML = $"<function name=\"{name}\" return_type=\"{returnType}\"></function>";
    }

}
