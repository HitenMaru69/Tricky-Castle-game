using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class K3 : MonoBehaviour
{
    public GameObject Plateform3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Plateform3.SetActive(true);

        }
    }



}
