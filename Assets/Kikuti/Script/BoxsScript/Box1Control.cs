using UnityEngine;

public class Box1Control : MonoBehaviour
{
    //�ʏ��

    public GameObject attackUpBook;
    public GameObject attackSpeedBook;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {

            float rnd = Random.Range(0, 1f);
            Destroy(gameObject);

            if (rnd <= 0.6f)
            {
                Instantiate(attackUpBook, this.transform.position, this.transform.rotation);
                //�U����UP
            }
            else if(rnd <= 0.8f)
            {
                Instantiate(attackSpeedBook, this.transform.position, this.transform.rotation);
                //�U�����xUP
            }
            else
            { 
                //�h���UP
            }
        }

    }
}
