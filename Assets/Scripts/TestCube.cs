using UnityEngine;

public class TestCube : MonoBehaviour
{
    public GameObject CubeTest;
    public float moveDistance = 2; // Distance à déplacer vers la droite

    private bool hasMoved = false; // Pour éviter que ça se répète à l'infini

    private void OnTriggerEnter(Collider other)
    {
        // Vérifie si le joueur entre dans la box
        if (other.CompareTag("Player") && !hasMoved)
        {
            // Déplace la caisse vers la droite (axe X positif)
            CubeTest.transform.position += Vector3.right * moveDistance;

            hasMoved = true; // Empêche un deuxième déclenchement
        }
    }
}
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     
    
        
   

