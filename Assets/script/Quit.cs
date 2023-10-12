using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    // ���� ���� ��ư�� ������ ȣ��Ǵ� �Լ�
    public void QuitGame()
    {
        Debug.Log("Quit button pressed"); // ����� ���� �߰�
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // �����Ϳ����� ���� ����
#else
        Application.Quit(); // ����� ���ӿ����� Application.Quit() ȣ��
#endif
    }
}

