using UnityEngine;
using UnityEngine.EventSystems;

public class DragSprite : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    private Vector3 offset;
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main; // Obtiene la cámara principal
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // Convierte la posición del mouse/tacto a coordenadas del mundo
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(eventData.position);
        offset = transform.position - new Vector3(mousePos.x, mousePos.y, transform.position.z);
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Convierte la posición del mouse/tacto a coordenadas del mundo
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(eventData.position);
        transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z) + offset;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Se puede agregar lógica al soltar el objeto
    }
}
