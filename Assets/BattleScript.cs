using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//[System.Serializable]
public class BattleScript : MonoBehaviour
{
    Scene scene;
   /* [SerializeField] */PlayerBehaviour PlayerPrefab;
  

  

   
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        PlayerPrefab = Spawnpoint.playerRef;
     
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TestAttack();
        }
    }
    public void OnFlee()
    {
        Debug.Log("current Scene = " + scene);
            int prevSceneIndex = scene.buildIndex -1 ; //prev scene
            SceneManager.LoadScene(prevSceneIndex, LoadSceneMode.Single);
        Debug.Log("prev scene = " + prevSceneIndex);
    }

    public void onLightAttack()
    {
        Debug.Log("Using Light attack");
        //PlayerPrefab.SetActive(true); //why is my animator still inactive???? 
        //PlayerPrefab.GetComponent<Animator>().Play("LightSmash");
        PlayerPrefab.GetComponent<Animator>().SetTrigger("LAttack");
        //playerAnim.SetInteger("AnimationState", (int)AnimationState.LSMASH); //idle state
        //State = AnimationState.LSMASH;
    }
    public void onHeavyAttack()
    {
        Debug.Log("Using Heavy attack");
        //PlayerPrefab.SetActive(true);
        PlayerPrefab.GetComponent<Animator>().SetTrigger("HAttack");
        //playerAnim.SetBool("HeavyAttack", true);
        //playerAnim.SetInteger("AnimationState", (int)AnimationState.HSMASH); //idle state
        //State = AnimationState.HSMASH;
    }
    public void onBlock()
    {
        Debug.Log("Using Block");
        //PlayerPrefab.SetActive(true);
        //PlayerPrefab.SetActive(true);
        PlayerPrefab.GetComponent<Animator>().SetTrigger("Block");

    }
    public void onMarch()
    {
        Debug.Log("Using March");
        //PlayerPrefab.SetActive(true);
        PlayerPrefab.GetComponent<Animator>().SetTrigger("March");

    }
    public void TestAttack()
    {
        PlayerPrefab.GetComponent<Animator>().SetTrigger("Attacking");
    }
}
