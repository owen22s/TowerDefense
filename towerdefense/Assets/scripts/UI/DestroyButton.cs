using UnityEngine;
using UnityEngine.UI;

using UnityEngine;
using UnityEngine.UI;

public class DestroyButton : MonoBehaviour
{
    public Button[] buttonsToDestroy;

    void Update()
    {
        foreach (Button button in buttonsToDestroy)
        {
            button.onClick.AddListener(() => DestroyButtonClicked(button));
        }
    }

    void DestroyButtonClicked(Button clickedButton)
    {
        if (Playerstats.money >= 100)
        {
            Debug.Log("test");
            Destroy(clickedButton.gameObject);
        }
    }
}
