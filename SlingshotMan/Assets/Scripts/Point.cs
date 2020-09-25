using UnityEngine;

public class Point : MonoBehaviour
{
    public int PointCost;
    public GameObject TouchEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            GameManager.instance.PlusScore(PointCost);

            GameObject effect = (GameObject)Instantiate(TouchEffect, transform.position, Quaternion.identity);
            Destroy(effect, 2f);

            Destroy(gameObject);
        }
    }
}
