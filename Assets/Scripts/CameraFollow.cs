using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject player;

    void Update()
    {
        transform.position = player.transform.position;
    }

}

