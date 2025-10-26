using UnityEngine;

public class Trap : MonoBehaviour
{
    private Renderer _Render;
    private Collider _Collider;

    void Start()
    {
        _Render = GetComponent<Renderer>();
        _Collider = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerCollect>() != null)
        {
            _Render.enabled = false;
            _Collider.enabled = false;
        }
    }
    void OnTriggerExit(Collider other)
            {
                if (other.GetComponent<PlayerCollect>() != null)
                {
                    _Render.enabled = true;
                    _Collider.enabled = true;
                }
            }
        }
 
