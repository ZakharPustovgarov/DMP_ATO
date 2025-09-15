using UnityEngine;

public class FollowObject : MonoBehaviour
{
    [SerializeField]
    protected GameObject followTarget;
    [SerializeField]
    protected Vector3 followOffset;

    void LateUpdate()
    {
        FollowTarget();
    }

    protected virtual void FollowTarget()
    {
        Debug.Log("FOLLOWING " + followTarget.name);
    }
}
