using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIObjectSelector : MonoBehaviour, IPointerClickHandler
{
    private GameObject selectedObject;
    public Color highlightColor = Color.yellow; // Color de resaltado
    private Color originalColor; // Para almacenar el color original

    public void OnPointerClick(PointerEventData eventData)
    {
        // Deseleccionar el objeto anterior
        if (selectedObject != null)
        {
            selectedObject.GetComponent<Image>().color = originalColor;
        }

        // Seleccionar nuevo objeto
        selectedObject = eventData.pointerCurrentRaycast.gameObject;
        originalColor = selectedObject.GetComponent<Image>().color;
        selectedObject.GetComponent<Image>().color = highlightColor; // Resaltar el objeto seleccionado
    }
}
