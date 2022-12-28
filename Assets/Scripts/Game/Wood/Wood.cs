using UnityEngine;

public class Wood : MonoBehaviour
{

    private int _health;

    public void Damage(int dmg)
    {
        _health -= dmg;
        if(_health <= 0)
        {
            EventManager.TreeIsCut?.Invoke();
            EventManager.PlaySound?.Invoke(0);
            gameObject.SetActive(false);
        }
    }

    public void RecalHealth(int health)
    {
        _health = health;
    }

    

}
