using System;
using UnityEngine;

public class DisappearDoor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerCollect>() != null)
        {
         Destroy(gameObject);    
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
