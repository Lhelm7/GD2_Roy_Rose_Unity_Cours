using System.Collections;
using UnityEngine;

public class DashPlayer : MonoBehaviour
{
    public float dashSpeed = 20f;      // vitesse du dash
    public float dashTime = 0.2f;      // durée du dash
    public float dashCooldown = 1f;    // temps avant de pouvoir redash

    private bool _canDash = true;
    private Rigidbody _rb;
    private Transform _cameraTransform;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _cameraTransform = Camera.main.transform;
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
        if (Input.GetKeyDown(KeyCode.LeftShift) && _canDash && dir.magnitude > 0)
        {
            StartCoroutine(Dash(dir));
        }
    }

    IEnumerator Dash(Vector3 dir)
    {
        _canDash = false;

        float startTime = Time.time;

        // Pendant la durée du dash → on pousse légèrement à chaque frame
        while (Time.time < startTime + dashTime)
        {
            _rb.linearVelocity = dir * dashSpeed;
            yield return null; // attend la frame suivante
        }

        // On arrête le mouvement du dash
        _rb.linearVelocity = Vector3.zero;

        // On attend avant de pouvoir redash
        yield return new WaitForSeconds(dashCooldown);
        _canDash = true;
    }
}
    



