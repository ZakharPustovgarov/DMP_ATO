using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    protected float speedMultiplier = 1f;

    protected Vector3 currentDirection = Vector3.zero;
    protected Space moveSpace;

    void Start()
    {
        
    }

    private void Update()
    {
        if (currentDirection == Vector3.zero) return;

        Move(currentDirection, moveSpace);
    }

    public void ChangeMoveDirection(Vector3 direction, Space moveSpace = Space.World)
    {
        currentDirection = direction;
        this.moveSpace = moveSpace;
    }

    protected virtual void Move(Vector3 direction, Space moveSpace = Space.World)
    {
        Debug.Log("MOVE");
    }
}
