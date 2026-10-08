using UnityEngine;

public class Die : MonoBehaviour
{
    public Vector3 posInicial = new Vector3(-8.75f, 5.3f, 0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("PaChocarloPegao");

        if (collision.gameObject.CompareTag("ENEMY"))
        {
            Debug.Log("MUERTO");
            Muerte();
        }
        if (collision.gameObject.CompareTag("WIN"))
        {
            Debug.Log("WIN");
            Win();
        }
    }
    public void Muerte()
    {
        Debug.Log("Eres más malo que el hambre");
        transform.position = posInicial;
    }
    public void Win()
    {
        Debug.Log("Eres mejor que Ixeia");
        transform.position = posInicial;
    }
}
