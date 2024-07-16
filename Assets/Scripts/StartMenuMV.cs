using UnityEngine;

public class StartMenuMV : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("Clicked");
        gameObject.SetActive(false);
    }
}