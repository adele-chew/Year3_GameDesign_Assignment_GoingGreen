using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MenuManger : MonoBehaviour
{
    public GameObject TitleScreen;
    public GameObject Instruction;
    public GameObject Level;
    public GameObject Options;

    /*
    //script for main menu scene
    public AudioMixer mixer;
    */

    public void Start()
    {
        MainMenu();
    }

    //button to move into mainScene
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //button to exit the application software
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    //Show main menu 
    public void MainMenu()
    {
        TitleScreen.SetActive(true);
        Instruction.SetActive(false);
        Level.SetActive(false);
        Options.SetActive(false);
    }

    //Instruction button
    public void InstructionButton()
    {
        TitleScreen.SetActive(false);
        Instruction.SetActive(true);
        Level.SetActive(false);
        Options.SetActive(false);
    }

    //Levels button
    public void LevelsButton()
    {
        TitleScreen.SetActive(false);
        Instruction.SetActive(false);
        Level.SetActive(true);
        Options.SetActive(false);
    }

    //Options button
    public void OptionsButton()
    {
        TitleScreen.SetActive(false);
        Instruction.SetActive(false);
        Level.SetActive(false);
        Options.SetActive(true);
    }


    /*
    //slider for volume control
    public void SetVolume(float volume)
    {
        mixer.SetFloat("Volume", Mathf.Log10(volume) * 20);
    }

    //toggle for full screen button
    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
        Debug.Log("Full Screen is " + isFullScreen);
    }
    */
}
