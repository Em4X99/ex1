using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //variables
    public static GameManager Instance;

    private bool scene = true;

    //awake is called instead of start

    private void Awake()
    {
        //a singleton must only have one instance, check to make sure this is the only instance
        //If tis s, make sure its not destroyed, if its not destroy this instance
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartScene ()
    {
        if (scene)
        {
            SceneManager.LoadScene("SampleScene");
            scene = false;
        }
    }
}
