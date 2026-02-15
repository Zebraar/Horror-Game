using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class ButtonsLogic : MonoBehaviour
{
    public Sprite[] Memasiki;
    public Sprite[] ScaryImages;
    public Sprite[] NormalImages;
    public Image MainImage;
    
    private int CurrentImage = 0;
    private System.Random rnd = new System.Random();
    public int TotalSkippedImages = 0;
    private int ScaryChance = 0;

    void Start()
    {
        UpdateImage();
    }

    public void OnClickApprove()
    {
        NextImage();
        Debug.Log("Одобрили изображение");
    }

    public void OnClickReject()
    {
        NextImage();
        Debug.Log("Отклонили изображение");
    }

    private void NextImage()
    {
        CurrentImage++;
        TotalSkippedImages++;
        UpdateImage();
    }

    private void UpdateImage()
    {
        int chance = rnd.Next(2); 
        int ShowScaryImageChance = rnd.Next(ScaryChance);
        Debug.Log("Шанс (1 = Normal): " + chance);

        if (chance == 1 && NormalImages.Length > 0)
        {
            int index = CurrentImage % NormalImages.Length;
            MainImage.sprite = NormalImages[index];
            return; 
        }

        switch (TotalSkippedImages)
        {
            case 20:
                ScaryChance = 10;
                break;
            case 30:
                ScaryChance = 5;
                break;
            case 50:
                ScaryChance = 2;
                break;        
        }
        if (ShowScaryImageChance == 1 && ScaryImages.Length > 0)
        {
            int index = CurrentImage % ScaryImages.Length;
            MainImage.sprite = ScaryImages[index];
            return;
        }

        if (Memasiki.Length > 0)
        {
            int index = CurrentImage % Memasiki.Length;
            MainImage.sprite = Memasiki[index];
        }
    }
}