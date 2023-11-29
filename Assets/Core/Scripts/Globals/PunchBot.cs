using UnityEngine;

public class PunchBot : MonoBehaviour
{
    [SerializeField] private Vector2 _randTorque;

    public void Punch(Rigidbody rigidbody)
    {
        rigidbody.isKinematic = false;
        rigidbody.velocity = Vector3.zero;

        float randTorque = Random.Range(_randTorque.x, _randTorque.y);

        rigidbody.AddForce(Vector3.up * 1, ForceMode.Impulse);
        rigidbody.AddTorque(Vector3.right * randTorque + Vector3.forward * randTorque, ForceMode.Impulse);
        rigidbody.velocity = Random.onUnitSphere * randTorque;
    }
}