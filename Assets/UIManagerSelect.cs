using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIManagerSelect : MonoBehaviour
{
    private GameObject selectedObject;
    public Color selectedColor = Color.yellow; // Color para el elemento seleccionado
    private Color originalColor; // Color original del elemento

    // Método para llamar cuando se clickea un elemento de UI
    public void OnElementClicked(PointerEventData eventData)
    {
        GameObject element = eventData.pointerCurrentRaycast.gameObject;
        if (element.GetComponent<Bloque>() != null)
        {
            // Deseleccionar si el mismo elemento es clickeado nuevamente
            if (selectedObject == element)
            {
                element.GetComponent<Image>().color = originalColor;
                element.GetComponent<Bloque>().isSelect = false; // Cambiar isSelect a false
                selectedObject = null;
            }
            else
            {
                // Deseleccionar el objeto anterior
                if (selectedObject != null)
                {
                    selectedObject.GetComponent<Image>().color = originalColor;
                    selectedObject.GetComponent<Bloque>().isSelect = false; // Cambiar isSelect a false para el objeto previamente seleccionado
                }

                // Seleccionar el nuevo objeto
                selectedObject = element;
                originalColor = element.GetComponent<Image>().color; // Guardar el color original
                element.GetComponent<Image>().color = selectedColor; // Resaltar el objeto seleccionado
                element.GetComponent<Bloque>().isSelect = true; // Cambiar isSelect a true para el nuevo objeto seleccionado
            }
        }

    }
}
