using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class DowntheHall : MonoBehaviour
{
    public void DownTheHall()
    {
        
     
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


}
