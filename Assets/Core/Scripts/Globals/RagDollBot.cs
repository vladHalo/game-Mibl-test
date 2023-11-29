using UnityEngine;

public class RagDollBot : MonoBehaviour
{
    [SerializeField] private Rigidbody[] _rb;

    public void IsKinematic(bool enable)
    {
        for (int i = 0; i < _rb.Length; i++)
            _rb[i].isKinematic = enable;
    }
}