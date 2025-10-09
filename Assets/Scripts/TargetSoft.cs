using System.Collections;
using UnityEngine;

public class TargetSoft : MonoBehaviour
{
   [SerializeField] private int _targetValue = 1;
   [SerializeField] private float _shadowDuration = 3f;
   [SerializeField] private GameObject _particuleEffect;
   private bool _isInShadows = false;
   private float _shadowTimer = 0f;
   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.GetComponent<PlayerCollect>() != null)
      {
         other.gameObject.GetComponent<PlayerCollect>().UpdateScore(_targetValue);
         //Destroy(gameObject);
         //TODO : Hide Target
         ToggleVisibility(false);
         //TODO : Start Timer
         //_isInShadows = true;
         Instantiate(_particuleEffect.transform);
         StartCoroutine(shadowtimerControl());

      }
   }
   
    
      
   //TODO : Timer by delta time
   private void ToggleVisibility(bool newVisibility)
   {
      GetComponent<MeshRenderer>().enabled = !GetComponent<MeshRenderer>().enabled;
      GetComponent<Collider>().enabled = !GetComponent<Collider>().enabled;
   }
   /*private void Update()
   {
      if (_isInShadows)
      {
         _shadowTimer += Time.deltaTime;
         if (_shadowTimer >= _shadowDuration)
         {
            //TODO Show Target
            ToggleVisibility(true);
            //TODO Stop Timer 
            _shadowTimer = 0f;
            _isInShadows = false;
         }
      }
   }*/

   private IEnumerator shadowtimerControl()
   {
      yield return new WaitForSeconds(_shadowDuration);
      ToggleVisibility(true);
   }

}
