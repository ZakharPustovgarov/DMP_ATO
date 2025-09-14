using UnityEngine;
using UnityEngine.InputSystem;

public class RotationToPointer : MonoBehaviour
{
    [SerializeField]
    private LayerMask groundLayer;
    [SerializeField]
    private float rotationMultiplier = 1f;

    private Camera mainCamera;
    private Mouse currentMouse;


    private void Start()
    {
        mainCamera = Camera.main;
        currentMouse = Mouse.current;
    }

    void Update()
    {
        // Создаем луч от камеры через позицию курсора
        Ray ray = mainCamera.ScreenPointToRay(currentMouse.position.ReadValue());
        RaycastHit hit;

        // Бросаем луч только по указанному слою
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, groundLayer))
        {
            Vector3 targetPoint = hit.point;
            targetPoint.y = transform.position.y; // Сохраняем высоту объекта

            // Плавный поворот
            Vector3 direction = (targetPoint - transform.position).normalized;
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationMultiplier * Time.deltaTime);
        }
    }
}
