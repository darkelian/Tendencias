using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueAssignment : Bloque
{
    static int count;
    public bool isSelect;
    public string name;
    public string value;
    public string type = "int";
    public string valorXML;

    public BloqueAssignment()
    {
        count++;
        name = "variable" + count;
        value = count.ToString();
        valorXML = $"<assignment name=\"{name}\" value=\"{value}\" type=\"{type}\"/>";
    }

}

