using UnityEngine;
using UnityEngine.SceneManagement;

public class MyButton : MonoBehaviour
{
    public void LoadScene()
    {
        // "MainScene"으로 씬을 로드합니다.
        SceneManager.LoadScene("MainScene");
    }
}

