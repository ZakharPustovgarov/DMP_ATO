using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    protected float speedMultiplier = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public virtual void Move(Vector3 direction)
    {
        Debug.Log("MOVE");
    }
}
