using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public void GetPlayername(TMP_InputField name)
    {
        GameManager.Instance.playerName = name.text;
    }

    public void StartClicked()
    {
        SceneManager.LoadScene(1);
    }
}
