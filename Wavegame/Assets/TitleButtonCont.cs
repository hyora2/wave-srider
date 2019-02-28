using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtonCont : MonoBehaviour {



    public void Gamestart(){
        SceneManager.LoadScene("Maingame");
    }
    public void Tutorialstart(){
        SceneManager.LoadScene("tutorial");
    }

    public void GOtotitle(){
        SceneManager.LoadScene("title");
    }



}
