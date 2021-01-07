using UnityEngine;
using UnityEngine.UI;

public class ScrollbarFix : MonoBehaviour
{

    public Scrollbar scrollbar;
    public ScrollRect scrollRect;
    // Use this for initialization
    private void Update()
    {
        scrollbar.size = 0.2f;
        scrollRect.horizontalNormalizedPosition = 0.4f;

    }

    public void ChangeScrollPos()
    {
        scrollRect.horizontalNormalizedPosition = scrollbar.value;
    }
}