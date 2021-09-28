using UnityEngine.UI;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public InputField inputField;

    private void Update()
    {
        GameManager.instance.userName = inputField.text;
    }
}
