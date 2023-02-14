using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reloadDeath : MonoBehaviour
{
    
    void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
