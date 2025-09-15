using UnityEngine;

public class FollowObjectHard : FollowObject
{
    protected override void FollowTarget()
    {
        Vector3 targetPsoition = followTarget.transform.position + followOffset;

        transform.position = targetPsoition;
    }
}
