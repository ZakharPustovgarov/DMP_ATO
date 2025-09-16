using UnityEngine;

public class TranslateMovement : Movement
{
    protected override void Move(Vector3 direction, Space moveSpace = Space.World)
    {
        this.transform.Translate(direction * speedMultiplier * Time.deltaTime, moveSpace);
    }
}
