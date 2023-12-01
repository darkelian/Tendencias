using UnityEngine;
using UnityEngine.EventSystems;

public class SpawnPrefab : MonoBehaviour, IPointerDownHandler
{
    public GameObject prefabToSpawn;
    public Transform spawnPoint; // Asegúrate de que este tenga un VerticalLayoutGroup
    public UIManagerSelect uiManagerSelect; // Referencia al UIManager que maneja la selección

    // Se ha eliminado el método Update porque la lógica se manejará con IPointerDownHandler

    public void OnPointerDown(PointerEventData eventData)
    {
        // Comprobar que el clic es con el botón izquierdo del mouse
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            SpawnObject();
        }
    }

    public void SpawnObject()
    {
        if (prefabToSpawn != null && uiManagerSelect != null)
        {
            Transform parentTransform = spawnPoint ? spawnPoint : transform;

            // Instanciar el objeto como hijo de parentTransform
            GameObject newObject = Instantiate(prefabToSpawn, parentTransform, false);

            // Añadir el EventTrigger al objeto instanciado
            EventTrigger trigger = newObject.AddComponent<EventTrigger>();

            // Crear una nueva entrada de evento para el clic
            EventTrigger.Entry clickEntry = new EventTrigger.Entry();
            clickEntry.eventID = EventTriggerType.PointerClick;
            // Asignar una llamada al método OnElementClicked en UIManagerSelect
            clickEntry.callback.AddListener((data) => { uiManagerSelect.OnElementClicked((PointerEventData)data); });

            // Añadir la entrada al EventTrigger del objeto
            trigger.triggers.Add(clickEntry);
        }
    }
}
