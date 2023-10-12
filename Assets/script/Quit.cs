using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    // 게임 종료 버튼을 누르면 호출되는 함수
    public void QuitGame()
    {
        Debug.Log("Quit button pressed"); // 디버그 문구 추가
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // 에디터에서는 게임 종료
#else
        Application.Quit(); // 빌드된 게임에서는 Application.Quit() 호출
#endif
    }
}

