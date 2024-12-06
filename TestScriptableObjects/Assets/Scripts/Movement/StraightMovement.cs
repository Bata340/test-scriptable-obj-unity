using UnityEngine;

[CreateAssetMenu(menuName = "Movement/Straight Movement")]
public class StraightMovement : MovementSO
{
    public override void Move(Rigidbody moveable)
    {
        moveable.velocity = new Vector3(0, moveable.velocity.y, this.speed);
    }
}
