using UnityEngine;

public class DisappearTrap : MonoBehaviour
{
    public float visibleTime = 3f;
    public float invisibleTime = 2f;

    private Renderer rend;
    private Collider col;
    private bool isVisible = true;
    private float timer;

    void Start()
    {
        rend = GetComponent<Renderer>();
        col = GetComponent<Collider>();
        timer = visibleTime;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (isVisible && timer <= 0)
        {
            rend.enabled = false;
            col.enabled = false;
            isVisible = false;
            timer = invisibleTime;
        }
        else if (!isVisible && timer <= 0)
        {
            rend.enabled = true;
            col.enabled = true;
            isVisible = true;
            timer = visibleTime;
        }
    }
}

