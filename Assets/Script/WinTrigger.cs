using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
