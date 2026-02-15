using UnityEditor;
using UnityEngine;

public class YouLie : MonoBehaviour
{
    
    public GameObject Text;
    private System.Random rnd = new System.Random();
    int x = 0;
    int y = 0;
    void Start()
    {
        // YouLiee();
    }
    public void YouLiee()
    {
        while(true)
        {
            int x = rnd.Next(-750, 750);
            int y = rnd.Next(-350, 350);
            gameObject.GetComponent<RectTransform>().position = new Vector3(x, y, 0);
        }
    }

}
