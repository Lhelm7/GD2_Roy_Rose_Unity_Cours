using UnityEngine;

public class CollectibleRespawn : MonoBehaviour
{
    private Vector3 _originalPosition;
    private Quaternion _originalRotation;
    private bool _isCollected = false;

    private void Start()
    {
        _originalPosition = transform.position;
        _originalRotation = transform.rotation;

        if (CollectibleManager.Instance != null)
            CollectibleManager.Instance.RegisterCollectible(this);
    }

    public void Collect()
    {
        _isCollected = true;
        gameObject.SetActive(false);
    }

    public void Respawn()
    {
        if (_isCollected)
        {
            transform.position = _originalPosition;
            transform.rotation = _originalRotation;
            gameObject.SetActive(true);
            _isCollected = false;
        }
    }

    public bool IsCollected() => _isCollected;
}
