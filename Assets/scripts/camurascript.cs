using UnityEngine;

public class camurascript : MonoBehaviour
{
    public Transform attachedPlayer;
    Camera thisCamera;
    public float blendAmount = 0.05f;
    // Use this for initialization
    void Start()
    {
        thisCamera = GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 player = attachedPlayer.transform.position;
        Vector3 newCamPos = player * blendAmount + transform.position * (1.0f - blendAmount);
        transform.position = new Vector3(newCamPos.x, newCamPos.y, transform.position.z);
    }
}

