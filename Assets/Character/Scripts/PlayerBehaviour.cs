using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    [SerializeField]
    private float moveSpeed = 1.0f;

    //referances
    private Rigidbody2D p_rb;

    //Animations 
    [Header("Animation")]
    public AnimationState State;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        p_rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        //LightAttack();
        //HeavyAttack();
        //Block();
        //March();
       
    }

    private void Move()
    {
        //Setting battle anims as false 
        //anim.SetBool("Block", false);
        //anim.SetBool("LightAttack", false);
        //anim.SetBool("HeavyAttack", false);
        //anim.SetBool("March", true); 

        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
        
        transform.position += new Vector3(inputX * moveSpeed * Time.deltaTime, inputY * moveSpeed * Time.deltaTime, 0);
      
        p_rb.velocity = new Vector2 (inputX * moveSpeed, inputY * moveSpeed);
        if (inputX != 0 || inputY != 0)
        {
           
            anim.SetInteger("AnimationState", (int)AnimationState.WALK); //Walk state
            State = AnimationState.WALK;
        }
        else
        {
            anim.SetInteger("AnimationState", (int)AnimationState.IDLE); //idle state
            State = AnimationState.IDLE;
        }

    }
    //private void Block()
    //{
    //    anim.SetBool("Block", true);
    //}
    public void LightAttack()
    {
        anim.SetTrigger("LAttack");
    }
    private void HeavyAttack()
    {
        anim.SetTrigger("HAttack");
    }
    //private void March()
    //{
    //    anim.SetBool("March", true);
    //}
}