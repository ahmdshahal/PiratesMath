using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class stage : MonoBehaviour
{
    public void play(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
   
