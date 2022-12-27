using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 10f;
    float move;

    public float jumpspeed =10f;

    bool isground;

    bool ispannel;
    bool ispannel2;

    
    

    public GameObject pannel;
    public GameObject pannel2;

   
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");

        if (ispannel == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                GameObject des = GameObject.FindWithTag("Destroy");
                Destroy(des);

             
                Destroy(pannel);

            }

        }

        if (ispannel2 == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                GameObject des = GameObject.FindWithTag("Destroy2");
                Destroy(des);

                
                Destroy(pannel2);

            }

        }




    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isground==true) {
            rb.velocity = Vector2.up * jumpspeed;          
            isground = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isground = true;
        }

       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Key")
        {
            ispannel = true;
            pannel.SetActive(true);
            
  
        }

        if(collision.gameObject.tag == "Key2")
        {
            ispannel2 = true;
            pannel2.SetActive(true);
       
        }


   
    }

}
