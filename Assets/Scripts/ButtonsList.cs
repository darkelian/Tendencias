using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonsList : MonoBehaviour
{
    public List<GameObject> buttons;
    public GameObject content;

    public void isShow(GameObject gameObject)
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
    public void DeleteBlock()
    {
        // Recorrer cada hijo del objeto padre
        foreach (Transform child in content.transform)
        {
            // Obtener el componente Bloque del hijo
            Bloque bloque = child.GetComponent<Bloque>();

            // Comprobar si el componente Bloque existe y si isSelect es true
            if (bloque != null && bloque.isSelect)
            {
                Destroy(child.gameObject);
                break;
            }
        }
    }
    public void ShowButton(int index)
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            if (index == i)
            {
                buttons[i].SetActive(true);
            }
            else
            {
                buttons[i].SetActive(false);
            }
        }
    }

}
