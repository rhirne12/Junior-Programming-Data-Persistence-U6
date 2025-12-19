using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public string playerName;
    public int highScore = 0;  // default score if there is not high score recorded

    private void Start()
    {
        // make sure there is only one instance of this singleton
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
