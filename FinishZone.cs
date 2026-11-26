
using UnityEngine;

public class FinishZone : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Kiểm tra FinishZone có phát hiện va chạm không
        Debug.Log("FinishZone đã phát hiện va chạm!");

        // Kiểm tra vật thể va chạm có phải Player không
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }

        // Kiểm tra người chơi đã thu thập đủ Coin chưa
        if (GameManager.Instance.HasEnoughCoins)
        {
            Debug.Log("Đã đủ Coin! YOU WIN!");

            // Gọi chức năng chiến thắng
            GameManager.Instance.WinGame();
        }
        else
        {
            Debug.Log("Bạn cần thu thập đủ 5 Coin để chiến thắng!");
        }
    }
}
