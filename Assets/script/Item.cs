using UnityEngine;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // �����۰� ��ȣ�ۿ� (��: ������ ��Ȱ��ȭ �Ǵ� ����)

            // �¸� ������ ��ȯ
            SceneManager.LoadScene("WinScene"); // "WinScene"�� �¸� ���� �̸��Դϴ�.
        }
    }
}