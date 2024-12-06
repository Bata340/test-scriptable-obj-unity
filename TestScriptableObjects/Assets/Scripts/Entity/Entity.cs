using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] private MovementSO movementSO;
    private Rigidbody rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        Debug.Log("[" + gameObject.name + "]My movementSO Instance ID is: " + movementSO.GetInstanceID());
        Debug.Log("[" + gameObject.name + "]My movementSO is: " + movementSO.ToString());
    }

    private void Update()
    {
        movementSO.Move(rigidBody);
    }
}
