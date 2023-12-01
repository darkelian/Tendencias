using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public RectTransform contentTransform;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
