using UnityEngine;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // 아이템과 상호작용 (예: 아이템 비활성화 또는 제거)

            // 승리 씬으로 전환
            SceneManager.LoadScene("WinScene"); // "WinScene"은 승리 씬의 이름입니다.
        }
    }
}