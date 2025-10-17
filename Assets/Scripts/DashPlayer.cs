using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class DashPlayer : MonoBehaviour
{
    public float dashSpeed = 20f; // vitesse du dash
    //public float dashTime = 0.2f;      // durée du dash
    //public float dashCooldown = 1f;    

    [SerializeField] private Image _DashBar;
    private bool _hasDash = false;
    private bool _canDash = false;
    private float _DashDuration;
    private float _remainingDashTime;
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
        // On calcule la direction selon les touches et la caméra
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 dir = (_cameraTransform.forward * v + _cameraTransform.right * h);
        dir.y = 0;
        dir.Normalize();

        // Quand on appuie sur Shift et qu’on peut dash
        if (_hasDash && Input.GetKey(KeyCode.LeftShift) && !_canDash && dir.magnitude > 0)
        {
            StartCoroutine(Dash(dir));
        }
    }

    IEnumerator Dash(Vector3 dir)
    {
        _canDash = false;

        float startTime = Time.time;

        // Pendant la durée du dash → on pousse légèrement à chaque frame
        while (Time.time < startTime + _DashDuration)
        {
            _rb.linearVelocity = dir * dashSpeed;
            yield return null; // attend la frame suivante
        }

        // On arrête le mouvement du dash
        _rb.linearVelocity = Vector3.zero;

        _remainingDashTime = 1 - ((Time.time - startTime) / _remainingDashTime);
        if (_DashBar != null)
            _DashBar.fillAmount = _remainingDashTime;

        yield return null;

        if (_DashBar != null)
        {
            _DashBar.fillAmount = 0f;

            _canDash = false;
            _hasDash = false;
        }
    }

    public void ActivateBoost(float duration)
        {
            _DashDuration = duration;
            _hasDash = true;
            if (_DashBar != null)
                _DashBar.fillAmount = 1f;
        }
    }


    



