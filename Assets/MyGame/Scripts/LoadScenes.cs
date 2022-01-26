using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    //When called upon loads main scene
    public void MainScene()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }

    //When called upon loads intro scene
    public void IntroScene()
    {
        SceneManager.LoadScene("IntroScene", LoadSceneMode.Single);
    }
}
