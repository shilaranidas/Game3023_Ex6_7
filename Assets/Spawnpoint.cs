using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    [SerializeField] GameObject PlayerPrefab;
    public static PlayerBehaviour playerRef = null;
    // Start is called before the first frame update
    void Start()
    {
        if(playerRef == null)
        {
            GameObject newPlayerObject = Instantiate(PlayerPrefab, transform.position, transform.rotation);
            playerRef = newPlayerObject.GetComponent<PlayerBehaviour>();
        }
    }

}
