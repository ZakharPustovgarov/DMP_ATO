using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speedMultiplier = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Move(Vector3 direction)
    {
        this.transform.Translate(direction * speedMultiplier * Time.deltaTime);
    }
}
