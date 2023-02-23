using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour {

    public bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject CompleteLevelUI;


    public void CompleteLevel(){
        CompleteLevelUI.SetActive(true);
    }

    public void EndGame () {

        if (gameHasEnded == false) {
            
            gameHasEnded = true;
            Debug.Log("GAME OVER!");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart() {
        //restarts to the current scene/level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
