using UnityEngine;

public class Gamecontroler : MonoBehaviour
{
    public GameObject Hoa;
    public float SpeedDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float CountTime = 0;
    // Update is called once per frame
    void Update()
    {
        CountTime -= Time.deltaTime;

        float possitionx = Random.Range(-8, 8);

        if (CountTime <= 0)
        {
            Instantiate(Hoa, new Vector3(possitionx, 7, 0), new Quaternion());
            CountTime = 2;
        }
    }
}
