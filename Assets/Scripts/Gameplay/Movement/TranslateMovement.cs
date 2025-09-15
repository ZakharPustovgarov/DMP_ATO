using UnityEngine;

public class TranslateMovement : Movement
{
    protected override void Move(Vector3 direction)
    {
        this.transform.Translate(direction * speedMultiplier * Time.deltaTime, Space.World);
    }
}
