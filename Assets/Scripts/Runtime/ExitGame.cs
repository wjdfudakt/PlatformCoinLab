using UnityEngine;

public sealed class ExitGame : MonoBehaviour
{
    [SerializeField] private GameSession session;

    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBGL
        // Web에서는 탭을 강제로 닫는 대신 메뉴로 돌아가 종료 방법을 안내합니다.
        session.ReturnToMenu();
        session.SetStatus("Use the page navigation or close the tab.");
#else
        Application.Quit();
#endif
    }
}