using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{ 
    public GameObject originalBlock;
    public Transform workArea; // Arrastra aquí el "Área de Trabajo" desde el Inspector
    public ScrollRect workAreaScrollRect;
    public bool isOverDropArea = false;


    private Vector3 originalPosition;

    private GameObject draggingObject;

    public void OnBeginDrag(PointerEventData eventData)
    {
        
        draggingObject = Instantiate(originalBlock, transform.position, Quaternion.identity, transform.parent);
        draggingObject.GetComponent<DragAndDrop>().originalBlock = originalBlock;
    }


    public void OnDrag(PointerEventData eventData)
    {
        isOverDropArea = false;
        workAreaScrollRect.enabled = true;
        Vector3 screenPoint = Input.mousePosition;
        screenPoint.z = 10.0f;
        draggingObject.transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            GameObject obj = EventSystem.current.currentSelectedGameObject;
            if (obj != null && obj.tag == "WorkArea")
            {
                draggingObject.transform.SetParent(workArea);
                draggingObject.transform.localPosition = Vector3.zero;
            }
            else
            {
                Destroy(draggingObject);
            }
        }
        else
        {
            Destroy(draggingObject);
        }
    }


    public void OnPointerEnterDropArea()
    {
        isOverDropArea = true;
        Debug.Log("Si funciona enter");
    }

    public void OnPointerExitDropArea()
    {
        isOverDropArea = false;
        Debug.Log("Si funciona exit");
    }
    private bool IsPointerOverWorkArea()
    {
        RectTransform workAreaRect = workArea.GetComponent<RectTransform>();
        Vector2 localMousePosition = workAreaRect.InverseTransformPoint(Input.mousePosition);
        return workAreaRect.rect.Contains(localMousePosition);
    }



}
