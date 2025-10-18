using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class DashPlayer : MonoBehaviour
    {
          [Header("Paramètres du Dash")]
    public float dashSpeed = 20f;
    public float maxDashDuration = 5f; // Durée max d'utilisation après avoir ramassé un collectible
    [SerializeField] private Image _DashBar;

    private bool _canDash = false;     // Si le joueur a le droit de dasher (après collectible)
    private bool _isDashing = false;   // Si le joueur dash actuellement
    private float _remainingDashTime;  // Temps restant d'utilisation du pouvoir
    private Rigidbody _rb;
    private Transform _cameraTransform;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _cameraTransform = Camera.main.transform;
        if (_DashBar != null)
            _DashBar.fillAmount = 0f;
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = (_cameraTransform.forward * v + _cameraTransform.right * h);
        dir.y = 0;
        dir.Normalize();

        // Si on a le pouvoir du dash
        if (_canDash)
        {
            // Si le joueur maintient Shift
            if (Input.GetKey(KeyCode.LeftShift) && _remainingDashTime > 0f)
            {
                _isDashing = true;
                _remainingDashTime -= Time.deltaTime; // Le temps diminue

                if (_DashBar != null)
                    _DashBar.fillAmount = _remainingDashTime / maxDashDuration;

                // Déplacement rapide
                _rb.MovePosition(_rb.position + dir * dashSpeed * Time.deltaTime);
            }
            else
            {
                // Si le joueur relâche la touche ou que le temps est écoulé
                if (_isDashing)
                {
                    _isDashing = false;
                    _rb.linearVelocity = Vector3.zero;
                }

                // Si le temps est fini → le pouvoir disparaît
                if (_remainingDashTime <= 0f)
                {
                    _canDash = false;
                    if (_DashBar != null)
                        _DashBar.fillAmount = 0f;
                }
            }
        }
    }

    // Appelée quand on ramasse un collectible
    public void ActivateBoost(float duration)
    {
        maxDashDuration = duration;
        _remainingDashTime = duration;
        _canDash = true;

        if (_DashBar != null)
            _DashBar.fillAmount = 1f;
    }
}


    



