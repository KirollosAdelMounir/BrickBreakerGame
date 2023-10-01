using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class ResetZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            FindObjectOfType<GameManager>().Miss();
        }
    }

}
