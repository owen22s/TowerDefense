using UnityEngine;
using UnityEngine.UI;

public class DestroyButton : MonoBehaviour
{
    public Button[] buttonsToDestroy;

    void Start()
    {
        foreach (Button button in buttonsToDestroy)
        {
            button.onClick.AddListener(() => DestroyButtonClicked(button));
        }
    }

    void DestroyButtonClicked(Button button)
    {
     
        Destroy(button.gameObject);
    }
}
