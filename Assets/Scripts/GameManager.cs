
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float Dealay = 2f;
    public GameObject gameComepleteUI;


    public void EndGame() {

        if (gameHasEnded == false) {

            gameHasEnded = true;
            Debug.Log("over");
            Invoke("Restart",Dealay);
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void levelComplete() {
        gameComepleteUI.SetActive(true);
    }
}
