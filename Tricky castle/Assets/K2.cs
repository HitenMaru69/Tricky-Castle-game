using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class K2 : MonoBehaviour
{
    bool isnewpannel2;

    public GameObject pannel2;

    public GameObject Plateform2;

    private void Update()
    {
        if (isnewpannel2 == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Plateform2.SetActive(true);
                Destroy(pannel2);

            }
            

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isnewpannel2 = true;
            pannel2.SetActive(true);
        }
    }
}
