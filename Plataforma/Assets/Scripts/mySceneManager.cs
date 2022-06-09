using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mySceneManager : MonoBehaviour
{
    
    static public void ReloadScene() {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

     public static void ChangeScene(string name) {
        SceneManager.LoadScene(name);
     }

}
