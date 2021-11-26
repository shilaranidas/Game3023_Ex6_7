using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrassEncounter : MonoBehaviour
{
    //[SerializeField] public Transform player;
    Scene scene;

    // Start is called before the first frame update
    void Start()
    {
      
        scene = SceneManager.GetActiveScene();
    }
    //void Awake()
    //{
    //    player = GameObject.FindGameObjectWithTag("Player").transform;
    //}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //player = Spawnpoint.playerRef.transform;
            int rnd = Random.Range(0, 2);
            if (rnd == 0)//trigger 1
            {

                    SceneManager.LoadScene("Battle");
                    Debug.Log("Loaded Battle Scene");
                
            }

            else
            {
                Debug.Log("Bad Roll");
            }

        }
    }
}