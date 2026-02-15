using UnityEngine;

public class TutorialScr : MonoBehaviour
{
    public Canvas TutorialCanvas;
    public Canvas MainCanvas;  
    public void HideTutorial()
    {
        TutorialCanvas.gameObject.SetActive(false);
        MainCanvas.gameObject.SetActive(true);
    }

}
