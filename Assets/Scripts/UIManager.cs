using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject opcionesMenu;
    public static UIManager Instance { get; private set; } 
  
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
