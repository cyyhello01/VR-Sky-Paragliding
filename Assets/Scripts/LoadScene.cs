using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    //public Animator cutsceneAnim;

    // Start is called before the first frame update
    void Start()
    {
        //cutsceneAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartGame()
    {
        StartGame();
    }

    public void StartGame()
    {
        
        SceneManager.LoadScene(1);
        //cutsceneAnim.SetTrigger("FadeToBlack");
    }
    public void ExitGame()
    {
       Application.Quit();
    }
}
