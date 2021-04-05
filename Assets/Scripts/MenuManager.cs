using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public CanvasGroup mainMenuPanel;
    public CanvasGroup creditsPanel;

    public void OpenMainMenu()
    {
        SetPanelActive(mainMenuPanel, true);
        SetPanelActive(creditsPanel, false);
    }

    public void OpenCredits()
    {
        SetPanelActive(mainMenuPanel, false);
        SetPanelActive(creditsPanel, true);
    }

    private void SetPanelActive(CanvasGroup panel, bool active)
    {
        panel.alpha = active ? 1 : 0;
        panel.blocksRaycasts = active;
    }
}
