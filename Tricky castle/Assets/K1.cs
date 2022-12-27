using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class K1 : MonoBehaviour
{
    bool isnewpannel1;

    public GameObject pannel;

    public GameObject Plateform1;

    private void Update()
    {
        if (isnewpannel1 == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Plateform1.SetActive(true);
                Destroy(pannel);

            }
          

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isnewpannel1 = true;
            pannel.SetActive(true);
        }
    }

    



}
