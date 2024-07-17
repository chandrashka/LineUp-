using UnityEngine;

public class StartMenuMV : MonoBehaviour
{
    private bool _isActive = true;

    public bool IsActive
    {
        get => _isActive;

        set
        {
            if (_isActive == value)
                return;

            _isActive = value;
            gameObject.SetActive(_isActive);
        }
    }

    public void OnClick()
    {
        IsActive = false;
    }
}