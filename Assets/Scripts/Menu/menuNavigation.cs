//using statements
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class MainMenu : MonoBehaviour
{
 
    //declares components needed for audio
    AudioSource soundEffect;


    //--------MAIN MENU-----------

    public void onClick_LevelSelect(){ 
        
        //plays sound effect
        soundEffect.Play();
        MenuManager.changeMenu("LevelSelect", MenuManager.Main); 
        
        
    }

    public void close(){ 
        
        //plays sound effect
        soundEffect.Play();
        Application.Quit(); 
        
    }


    //--------LEVEL SELECT-----------

    public void onClick_Easy(){

        //plays sound effect
        soundEffect.Play();
        MenuManager.changeMenu("Easy", MenuManager.LevelSelect);

    }

    public void onClick_Medium(){

        //plays sound effect
        soundEffect.Play();
        MenuManager.changeMenu("Medium", MenuManager.LevelSelect);

    }

    public void onClick_Hard(){

        //plays sound effect
        soundEffect.Play();
        MenuManager.changeMenu("Hard", MenuManager.LevelSelect);

    }

    public void onClick_backLevelSelect(){

        //plays sound effect
        soundEffect.Play();
        MenuManager.changeMenu("MainMenu", MenuManager.LevelSelect);

    }



    //--------EASY-----------

    public void onClick_backEasy(){

        //plays sound effect
        soundEffect.Play();
        MenuManager.changeMenu("LevelSelect", MenuManager.Easy);

    }

    //--------MEDIUM-----------

    public void onClick_backMedium(){

        //plays sound effect
        soundEffect.Play();
        MenuManager.changeMenu("LevelSelect", MenuManager.Medium);

    }

    //--------HARD-----------

    public void onClick_backHard(){

        //plays sound effect
        soundEffect.Play();
        MenuManager.changeMenu("LevelSelect", MenuManager.Hard);

    }
    



    //-------FOR LEVELS------

    //changes scene to the one given in the button onclick
    public void sceneChange(string name){
        MenuManager.isReady = false;

        //initializes and plays button sound effect before changing scene
        soundEffect = GetComponent<AudioSource>();
        StartCoroutine(WaitAndLoadScene(.2f, name));
        
    }






    //------USED FOR PLAYING SOUND EFFECT-----
    private IEnumerator WaitAndLoadScene(float clipLength, string sceneName)
    {
        //plays sound effect
        soundEffect.Play();
        
        //load the scene asynchrounously, it's important you set allowsceneactivation to false
        //in order to wait for the audioclip to finish playing
        AsyncOperation sceneLoading = SceneManager.LoadSceneAsync(sceneName);
        sceneLoading.allowSceneActivation = false;
        
        //wait for the audioclip to end
        yield return new WaitForSeconds(clipLength);
        //wait for the scene to finish loading (it will always stop at 0.9 when allowSceneActivation is false
        while (sceneLoading.progress < 0.9f) yield return null;
        //allow the scene to load
        sceneLoading.allowSceneActivation = true;
    }



    //START

    void Start(){

        //initializes and plays button sound effect before changing scene
        soundEffect = GetComponent<AudioSource>();
    }

    

    

}
