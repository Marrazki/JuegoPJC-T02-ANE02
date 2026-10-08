using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    public Transform posPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(posPlayer.position.x, posPlayer.position.y,-4);
    }
}
