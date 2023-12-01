using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueConditional : Bloque
{
    public bool isSelect;

    public string variableName1 = "x"; 
    public string variableName2 = "y"; 
    public string comparison = "<";

    public string valorXML = "<conditional variable1="${0}" variable2="${1}" comparison="${2}">", variableName1, variableName2, comparison;

}

