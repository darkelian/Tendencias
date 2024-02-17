using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueConditional : Bloque
{
    public bool isSelect;

    public string variableName1 = "x";
    public string variableName2 = "y";
    public string comparison = "<";
    public string valorXML;

    public BloqueConditional()
    {
        valorXML = $"<conditional variable1=\"{variableName1}\" variable2=\"{variableName2}\" comparison=\"{comparison}\"></conditional>";
    }
}

