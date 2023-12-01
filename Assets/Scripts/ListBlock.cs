using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListBlock : MonoBehaviour
{
    public GameObject content;
    public List<Bloque> blocks;


    public void GetListBlockContent()
    {
        // Asegúrate de limpiar la lista antes de empezar a agregar elementos
        blocks.Clear();

        // Recorrer cada hijo del objeto 'content'
        foreach (Transform childTransform in content.transform)
        {
            // Obtener el componente Bloque del hijo
            Bloque bloque = childTransform.GetComponent<Bloque>();

            // Comprobar si el hijo tiene el componente Bloque
            if (bloque != null)
            {
                // Agregar el componente Bloque a la lista
                blocks.Add(bloque);
            }
        }
    }
}
