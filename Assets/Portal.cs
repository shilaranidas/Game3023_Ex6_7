using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Portal : MonoBehaviour
{
   
    //gets called anytime a collider moves over it
    private void OnTriggerEnter2D(Collider2D other)
    {
        WorldTraveler worldTravelerObject = other.GetComponent<WorldTraveler>();
        if(worldTravelerObject != null)
        {
            Debug.Log("Traveling to: " + tag + " Bye!");
            SceneManager.LoadScene(tag);
        }
    }
}
