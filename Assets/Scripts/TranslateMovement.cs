using UnityEngine;

public class TranslateMovement : Movement
{
    public override void Move(Vector3 direction)
    {
        this.transform.Translate(direction * speedMultiplier * Time.deltaTime);
    }
}
