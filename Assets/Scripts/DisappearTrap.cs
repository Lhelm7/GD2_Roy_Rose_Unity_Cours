using System.Collections;
using UnityEngine;

public class DisappearTrap : MonoBehaviour
{
    [SerializeField] private float _visibleTime = 3f;
    [SerializeField] private float _invisibleTime = 2f;
    [SerializeField] private GameObject _disappearEffect;

    private bool _isVisible = true;
    private Renderer _renderer;
    private Collider _collider;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _collider = GetComponent<Collider>();
        StartCoroutine(VisibilityCycle());
    }

    private IEnumerator VisibilityCycle()
    {
        while (true)
        {
            ToggleVisibility(true);
            if (_disappearEffect != null)
                Instantiate(_disappearEffect, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(_visibleTime);

            ToggleVisibility(false);
            yield return new WaitForSeconds(_invisibleTime);
        }
    }

private void ToggleVisibility(bool newVisibility)
    {
        _isVisible = newVisibility;
        _renderer.enabled = newVisibility;
        _collider.enabled = newVisibility;
    }
}

