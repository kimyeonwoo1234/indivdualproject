using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void LoadGameScene()
    {
        // "GameScene"���� ���� �ε��մϴ�.
        SceneManager.LoadScene("GameScene");
    }
}

