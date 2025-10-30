using UnityEngine;

public class TrampolineZone : MonoBehaviour

{

    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private AudioSource _jumpSound;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);

        }
    }
}



