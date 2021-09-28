using UnityEngine.UI;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public InputField inputField;
    bool isActive;
    private void Start()
    {
        if (!GameManager.instance.userName.Equals(""))
            inputField.gameObject.SetActive(false);
    }
    private void Update()
    {
        if(inputField.isActiveAndEnabled)
            GameManager.instance.userName = inputField.text;
    }

    public void ChangeName()
    {
        isActive = !isActive;
        if(isActive)
            inputField.gameObject.SetActive(true);
        if (!isActive)
            inputField.gameObject.SetActive(false);
    }
}
