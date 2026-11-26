
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Player cần theo dõi")]
    public Transform player;

    [Header("Khoảng cách Camera")]
    public Vector3 offset = new Vector3(0f, 10f, -10f);

    [Header("Tốc độ Camera")]
    public float smoothSpeed = 5f;

    private void LateUpdate()
    {
        // Kiểm tra Player
        if (player == null)
        {
            return;
        }

        // Tính vị trí Camera mong muốn
        Vector3 targetPosition = player.position + offset;

        // Di chuyển Camera mượt mà
        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            smoothSpeed * Time.deltaTime
        );
    }
}
