using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleIDMatchBehaviour : MonoBehaviour
{
   public ID id;
   public UnityEvent matchEvent, noMatchEvent;

   private void OnTriggerEnter(Collider other)
   {
      var otherID = other.GetComponent<SimpleIDBehaviour>();

      if (otherID.id == id)
      {
         //Debug.Log("Matched ID: " + id); 
         matchEvent.Invoke();
      }
      else
      {
         Debug.Log("No match ID: " + id);
         noMatchEvent.Invoke();
      }
   }
}
