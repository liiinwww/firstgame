using UnityEngine;


public class SideScrolling : MonoBehaviour
{
    private new Camera camera;
    private Transform player;

    public float height = 5.5f;
    public float undergroundHeight = -10.5f;
    public float undergroundThreshold = 0f;

    private void Awake()
    {
        camera = GetComponent<Camera>();
        player = GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        
        Vector3 cameraPosition = transform.position;
        cameraPosition.x = Mathf.Max(cameraPosition.x, player.position.x);
        transform.position = cameraPosition;
    }

    public void SetUnderground(bool underground)
    {
        
        Vector3 cameraPosition = transform.position;
        cameraPosition.y = underground ? undergroundHeight : height;
        transform.position = cameraPosition;
    }

}