
using UnityEngine;

public class Coin : MonoBehaviour
{
    [Header("Coin Effect")]
    public GameObject coinEffectPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Tạo hiệu ứng tại vị trí Coin
            if (coinEffectPrefab != null)
            {
                Instantiate(
                    coinEffectPrefab,
                    transform.position,
                    Quaternion.identity
                );
            }

            // Cộng điểm
            GameManager.Instance.AddScore();

            // Xóa Coin
            Destroy(gameObject);
        }
    }
}
