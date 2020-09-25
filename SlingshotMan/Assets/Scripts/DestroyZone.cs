using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    [SerializeField] private bool _needDestroyPlayer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.GetComponent<Wall>() != null || collision.GetComponent<Point>() != null) && !_needDestroyPlayer)
            Destroy(collision.gameObject);

        if (collision.GetComponent<Player>() != null && _needDestroyPlayer)
            GameManager.instance.GameOver();
    }
}
