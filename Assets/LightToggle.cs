using UnityEngine;
using UnityEngine.UI;

public class LightToggle : MonoBehaviour
{
    public void ToggleButton()
    {
        Button button;

        ToggleSelf();

        button = (Button)GetComponent<Button>().FindSelectableOnLeft();

        if (button != null)
        {
            ToggleAdjacent(button);
        }

        button = (Button)GetComponent<Button>().FindSelectableOnRight();

        if (button != null)
        {
            ToggleAdjacent(button);
        }

        button = (Button)GetComponent<Button>().FindSelectableOnUp();

        if (button != null)
        {
            ToggleAdjacent(button);
        }

        button = (Button)GetComponent<Button>().FindSelectableOnDown();

        if (button != null)
        {
            ToggleAdjacent(button);
        }

    }

    void ToggleAdjacent(Button btn)
    {
        LightToggle lt = btn.GetComponent<LightToggle>();
        if (lt != null)
        {
            lt.ToggleSelf();
        }
    }
    public void ToggleSelf()
    {
        Image bi = GetComponent<Button>().GetComponent<Image>();

        if (bi != null)
        {
            if (bi.color == Color.black)
            {
                bi.color = Color.yellow;
            }
            else
            {
                bi.color = Color.black;
            }
        }
    }

    public void Reset()
    {
        Image bi = GetComponent<Button>().GetComponent<Image>();

        if (bi != null)
        {
            bi.color = Color.black;
        }
    }
}
