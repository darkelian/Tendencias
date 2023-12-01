using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionsManagerButton : MonoBehaviour
{
    private bool status;
    public void ShowObjects(GameObject gameObject)
    {
        if (!status)
        {
            gameObject.SetActive(true);
            status = true;
        }
        else
        {
            gameObject.SetActive(false);
            status = false;
        }
        
    }
}
