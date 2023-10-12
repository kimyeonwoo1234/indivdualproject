using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void LoadGameScene()
    {
        // "GameScene"으로 씬을 로드합니다.
        SceneManager.LoadScene("GameScene");
    }
}

