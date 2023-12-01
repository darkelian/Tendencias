using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueAssignment : Bloque
{
    static int count;
    public BloqueAssignment(){
        count++;
    }

    public bool isSelect;

    public string name = "variable"+conut;
    public string value = count;
    public string type = "int";

    public string valorXML = "<assignment name="${0}" value="${1}" type="${2}"/>", name, value, type;

}

