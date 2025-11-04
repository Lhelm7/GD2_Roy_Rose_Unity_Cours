using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rb;
    private float _horizontalMovement;
    private float _verticalMovement;
    private Vector3 _movement;
    [SerializeField]  private float speed = 2f;
    [SerializeField] private float highJump;
    [SerializeField] private AudioSource _jumpSound;
    public LayerMask layerMask;  
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        _horizontalMovement = Input.GetAxis("Horizontal");
        _verticalMovement = Input.GetAxis("Vertical");
        _movement = new Vector3(_horizontalMovement, 0f, _verticalMovement);
        _movement.Normalize();
        _movement *= speed;
        _movement.y = _rb.linearVelocity.y;
        if ( _rb != null)
        {
            _rb.linearVelocity = _movement;
        }
        else
        {
            Debug.LogError("No RigidBody Attached !");
        }

        //Code du Saut
            bool saut = Input.GetButtonDown("Jump");
            if (saut && Physics.Raycast(transform.position,Vector3.down,0.8f,layerMask))
                {
                _rb.AddForce(Vector3.up * highJump,ForceMode.Impulse);
                if (_jumpSound != null)
                    _jumpSound.Play();
                }
                
        
    }
}
