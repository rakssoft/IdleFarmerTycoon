using UnityEngine;

public class ManagerWood : MonoBehaviour
{
    [SerializeField] private Wood[] _woods;
    [SerializeField] private  int _maxHealthTree;


    private void OnEnable()
    {
        EventManager.TreeIsCut += WoodInHome;
    }

    private void OnDisable()
    {
        EventManager.TreeIsCut -= WoodInHome;
    }
    public void StartThreeGame()
    {
        for (int i = 0; i < _woods.Length; i++)
        {
            _woods[i].gameObject.SetActive(true);
            _woods[i].RecalHealth(_maxHealthTree);
        }
    }

    private void WoodInHome()
    {
        print("plus derevo");
    }
}
