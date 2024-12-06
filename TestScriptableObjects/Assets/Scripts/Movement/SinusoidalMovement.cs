using UnityEngine;

[CreateAssetMenu(menuName = "Movement/Sinusoidal Movement")]
public class SinusoidalMovement : MovementSO
{

    private int currentSign = 1;
    private float DELTA_DEGREE = 0.2f;

    public override void Move(Rigidbody moveable)
    {
        if (rotationDegree >= 90)
        {
            currentSign = -1;
        } else if (rotationDegree <= -90)
        {
            currentSign = 1;
        }
        rotationDegree = currentSign * DELTA_DEGREE + rotationDegree;
        var initialVector = new Vector3(0, 0, this.speed);
        moveable.velocity = Quaternion.AngleAxis(rotationDegree, Vector3.up) * initialVector + new Vector3(0, moveable.velocity.y, 0);
    }
}
