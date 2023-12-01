using UnityEngine;
using UnityEngine.EventSystems;


public class SpawnPrefab : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    public GameObject prefabToSpawn; // Arrastra tu prefab aquí en el Inspector
    public Transform spawnPoint; // Punto donde se instanciará el prefab. Si no se define, usará la posición del objeto actual.
    public bool statusMouse;
    private void Update()
    {
        if (Input.GetMouseButton(0) && statusMouse)
        {
            SpawnObject();
        }
    }
    // Esta función se vinculará al botón de la UI
    public void SpawnObject()
    {
        if (prefabToSpawn != null)
        {
            Transform parentTransform = spawnPoint ? spawnPoint : transform;

            // Comprobar si ya hay un hijo con el tag "Bloque"
            bool hasBlockChild = false;
            foreach (Transform child in parentTransform)
            {
                if (child.CompareTag("Bloque"))
                {
                    hasBlockChild = true;
                    break;
                }
            }

            // Si no hay un hijo con el tag "Bloque", entonces instanciamos el objeto
            if (!hasBlockChild)
            {
                Vector3 position = parentTransform.position;
                GameObject newObject = Instantiate(prefabToSpawn, position, Quaternion.identity);
                newObject.transform.SetParent(parentTransform);
            }
        }
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        statusMouse = true;   
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        statusMouse = false;
    }

    
}
