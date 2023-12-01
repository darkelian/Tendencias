using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueFunction : Bloque
{
    public bool isSelect;

    static int count;
    public BloqueFunction(){
        count++;
    }

    public string name = "function"+conut;

    public string returnType = "int";

    public string valorXML = "<function name="${0}" return_type="${1}">", name, returnType;

}
