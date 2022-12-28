using UnityEngine;

public class InputManager : MonoBehaviour
{


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)), Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.TryGetComponent(out Wood tree))
                {
                    tree.Damage(1);
                }
                /*   if (hit.collider.gameObject.CompareTag("Egg"))
                   {
                       managerEffects.VFXEscapeEgg(hit.collider.gameObject.transform.position);
                       Destroy(hit.collider.gameObject);
                       managerSpawn.RecalListMonstr(-1);
                       managerSpawn.SpawnMonster(1, hit.collider.gameObject.transform.position);

                   }
                   if (hit.collider.gameObject.CompareTag("Bonus"))
                   {
                       managerEffects.VFXEscapeEgg(hit.collider.gameObject.transform.position);
                       Destroy(hit.collider.gameObject);
                       managerSpawnBonus.OnBonus();

                   }*/
            }
        }

    }
}
