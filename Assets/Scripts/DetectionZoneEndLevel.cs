using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectionZoneEndLevel : MonoBehaviour
{
    private string _EndLevel1 = "MapLevel2";

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerCollect>() != null)
        {
            SceneManager.LoadScene(_EndLevel1);
        }
    }
}

