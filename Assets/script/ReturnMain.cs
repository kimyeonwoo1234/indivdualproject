using UnityEngine;
using UnityEngine.SceneManagement;

public class MyButton : MonoBehaviour
{
    public void LoadScene()
    {
        // "MainScene"���� ���� �ε��մϴ�.
        SceneManager.LoadScene("MainScene");
    }
}

