using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadlevel : MonoBehaviour
{
    bool isgameend = false;

    public void LoadLevel()
    {
        if (isgameend == false)
        {
            isgameend = true;
            Invoke("Level", 1f);

        }
    }

    public void Quit()
    {
        Invoke("Finish", 1f);

    }

    void Level()
    {
        SceneManager.LoadScene("Level");
    }

    void Finish()
    {
        Application.Quit();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
        
    }


}
