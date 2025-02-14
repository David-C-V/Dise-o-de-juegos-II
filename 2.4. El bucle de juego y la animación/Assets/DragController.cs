using UnityEngine;


public class DragController : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 mousePos;
    private void OnMouseDown()
    {
        startPosition = transform.position;
    }

    private void OnMouseDrag()
    {
        mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);

    }
}
