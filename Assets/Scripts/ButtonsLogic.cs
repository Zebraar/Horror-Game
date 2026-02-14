using UnityEngine;
using UnityEngine.UI;

public class UpvoteLogic : MonoBehaviour
{

    public Sprite[] images;
    public Image MainImage;
    public int CurrentImage = 0;

    public void OnClickApprove()
    {
        CurrentImage++;
        MainImage.GetComponent<Image>().sprite = images[CurrentImage];
        Debug.Log("Одобрили изображение");
    }

    public void OnClickReject()
    {
        CurrentImage++;
        MainImage.GetComponent<Image>().sprite = images[CurrentImage];
        Debug.Log("Отклонили изображение");

    }

}
