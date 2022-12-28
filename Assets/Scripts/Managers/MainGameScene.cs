
using UnityEngine;

public class MainGameScene : MonoBehaviour
{
    [SerializeField] private GameObject _mainLevel;
    [SerializeField] private GameObject _mainLevelUI;
    [SerializeField] private GameObject _woodLevel;
    [SerializeField] private GameObject _woodLevelUI;
    void Start()
    {
        _mainLevel.SetActive(true);
        _mainLevelUI.SetActive(true);
        _woodLevel.SetActive(false);
        _woodLevelUI.SetActive(false);
    }

}
