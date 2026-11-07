using UnityEngine;

public class HeartBeat : MonoBehaviour
{

    float latido = 100f;

    void Start()
    {

    }

    void Update()
    {
        latido -= 10f * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            latido += 15f;
        }

        if (latido <= 0)
        {
            ParoCardiaco();
        }

        Debug.Log(latido);
    }

    public void ParoCardiaco()
    {
        Destroy(gameObject);
    }
}
