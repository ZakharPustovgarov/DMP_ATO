using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    protected float speedMultiplier = 1f;
    [SerializeField]
    protected Vector3 currentDirection = Vector3.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void Update()
    {
        if (currentDirection == Vector3.zero) return;

        Move(currentDirection);
    }

    public void ChangeMoveDirection(Vector3 direction)
    {
        currentDirection = direction;
    }

    protected virtual void Move(Vector3 direction)
    {
        Debug.Log("MOVE");
    }
}
