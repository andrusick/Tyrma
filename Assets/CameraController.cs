using UnityEngine;

public class CameraController : MonoBehaviour
{


    [Header("Settings")]
    [SerializeField]
    protected CameraState currentState = CameraState.FollowPlayer;
    [SerializeField]
    protected float smoothSpeed = 5f;
    [SerializeField]
    protected float pointReachThreshold = 0.1f;

    [Header("References")]
    [SerializeField]
    protected Transform playerTransform;
    [SerializeField]
    protected Transform startPoint;

    protected Vector3 targetPoint;
    protected bool isMovingToPoint = false;
    protected bool isSmooth = false;

    protected virtual void Start()
    {
        targetPoint = startPoint.position;
    }

    protected virtual void LateUpdate()
    {
        switch (currentState)
        {
            case CameraState.FollowPlayer:
                FollowPlayer();
                break;
            case CameraState.MoveToPoint:
                if (isMovingToPoint)
                {
                    MoveToTargetPoint();
                }
                break;
            default:
                Debug.Log("афываыфва");
                break;
        }
    }

    protected virtual void FollowPlayer()
    {
        if (playerTransform == null) return;

        Vector3 desiredPosition = transform.position;
        desiredPosition.x = playerTransform.position.x; // Передаём X персонажа

        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
    }

    protected virtual void MoveToTargetPoint()
    {
        Vector3 targetPosition = targetPoint;
        targetPosition.z = transform.position.z; // Сохраняем Z-координату камеры

        if (isSmooth)
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
        else
            transform.position = targetPosition;
        // Проверяем, достигли ли мы точки
        if (Vector3.Distance(transform.position, targetPosition) <= pointReachThreshold)
        {
            isMovingToPoint = false;
        }
    }

    // Метод для переключения состояния камеры
    public virtual void SetCameraState(CameraState newState)
    {
        currentState = newState;
    }

    // Метод для установки точки, к которой нужно переместиться
    public virtual void SetTargetPoint(Vector3 point, bool isSmoothParam)
    {
        targetPoint = point;
        isMovingToPoint = true;
        currentState = CameraState.MoveToPoint;
        isSmooth = isSmoothParam;
    }

    // Метод для возврата к слежению за игроком
    public virtual void ReturnToPlayer()
    {
        currentState = CameraState.FollowPlayer;
        isMovingToPoint = false;
    }
}
public enum CameraState
    {
        FollowPlayer,
        MoveToPoint,
    }