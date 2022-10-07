using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_detect : MonoBehaviour
{
     List <GameObject> currentCollisions = new List <GameObject> ();
     
     void OnCollisionEnter (Collision col) {
 
         currentCollisions.Add (col.gameObject);
 
         foreach (GameObject gObject in currentCollisions) {
             print (gObject.name);
         }
     }
 
     void OnCollisionExit (Collision col) {
 
         currentCollisions.Remove (col.gameObject);
 
         foreach (GameObject gObject in currentCollisions) {
             print (gObject.name);
         }
     }
}
