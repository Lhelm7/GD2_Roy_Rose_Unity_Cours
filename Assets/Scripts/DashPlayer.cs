using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class DashPlayer : MonoBehaviour
    {
    public float dashSpeed = 20f;
    public float maxDashDuration = 5f; 
    [SerializeField] private Image _DashIcon;
    [SerializeField] private Image _DashBar;
    [SerializeField] private AudioSource _DashSound;
    [SerializeField] private AudioSource _DashSoundActivated;

    private bool _canDash = false;     
    private bool _isDashing = false;   
    private bool _dashTimerStarted = false; 
    private float _remainingDashTime;  
    private Rigidbody _rb;
    private Transform _cameraTransform;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _cameraTransform = Camera.main.transform;

        if (_DashBar != null)
            _DashBar.fillAmount = 0f;
        
        if (_DashIcon != null)
            _DashIcon.enabled = false; 
        
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
            // Si on appuie sur Shift pour la première fois → démarrer le chrono global
            if (Input.GetKeyDown(KeyCode.LeftShift) && !_dashTimerStarted)
                
            {
                _dashTimerStarted = true;
                _remainingDashTime = maxDashDuration;
                
                if (_DashSoundActivated != null && !_DashSoundActivated.isPlaying)
                    _DashSoundActivated.Play();
            }

            // Si le chrono global est en cours
            if (_dashTimerStarted)
            {
                _remainingDashTime -= Time.deltaTime;

                if (_DashBar != null)
                    _DashBar.fillAmount = _remainingDashTime / maxDashDuration;

                // Si le joueur maintient Shift → dash actif
                if (Input.GetKey(KeyCode.LeftShift) && _remainingDashTime > 0f)
                {
                    _isDashing = true;
                    _rb.MovePosition(_rb.position + dir * dashSpeed * Time.deltaTime);
                }
                else
                {
                    // Si le joueur relâche Shift
                    if (_isDashing)
                    {
                        _isDashing = false;
                        _rb.linearVelocity = Vector3.zero;
                    }
                    if (_DashSoundActivated != null && _DashSoundActivated.isPlaying)
                        _DashSoundActivated.Stop();
                }

                // Si le temps est écoulé → désactiver le dash
                if (_remainingDashTime <= 0f)
                {
                    _canDash = false;
                    _dashTimerStarted = false;

                    if (_DashBar != null)
                        _DashBar.fillAmount = 0f;
                    
                    if (_DashIcon != null)
                        _DashIcon.enabled = false; 
                    
                    if (_DashSoundActivated != null && _DashSoundActivated.isPlaying)
                        _DashSoundActivated.Stop();
                }
            }
        }
    }

    // Appelée quand le joueur ramasse un collectible
    public void ActivateBoost(float duration)
    {
        
        maxDashDuration = duration;
        _canDash = true;
        _dashTimerStarted = false; // le chrono ne démarre pas encore
        _isDashing = false;

        if (_DashSound != null)
            _DashSound.Play();
        
        if (_DashBar != null)
            _DashBar.fillAmount = 1f;
        
        if (_DashIcon != null)
            _DashIcon.enabled = true;
    }
}

    



