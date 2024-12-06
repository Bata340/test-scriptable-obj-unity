using UnityEngine;

public abstract class MovementSO : ScriptableObject
{
    protected float rotationDegree = 0;
    [SerializeField] protected float speed;

    public abstract void Move(Rigidbody moveable);
}
