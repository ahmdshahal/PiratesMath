using UnityEngine;
using UnityEngine.SceneManagement;


public class Backsound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(GameObject.Find("backsound on")==null)
        {
            DontDestroyOnLoad(gameObject);
            GetComponent<AudioSource>().Play();
            gameObject.name = "backsound on";
            PlayerPrefs.SetFloat("volume",1);
            Scene scene = SceneManager.GetActiveScene();
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("volume");        
    }
}