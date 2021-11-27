using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class IntoTheExhibit : MonoBehaviour
{
    public void IntoExhibit()
    {


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
