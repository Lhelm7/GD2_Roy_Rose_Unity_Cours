using UnityEngine;

public class PlateformUpDown : MonoBehaviour
{
    public Transform pointA; // Premier point
    public Transform pointB; // Second point
    public float speed = 2f; // Vitesse du déplacement

    private Transform targetPoint;

    void Start()
    {
        // On démarre en direction du point B
        targetPoint = pointB;
    }

    void Update()
    {
        // Déplacement vers le point cible
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);

        // Si la plateforme atteint le point cible, on change de direction
        if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f)
        {
            targetPoint = (targetPoint == pointA) ? pointB : pointA;
        }
    }
}

   
