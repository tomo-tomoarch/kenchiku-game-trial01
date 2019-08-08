using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Information : MonoBehaviour
{
    public string Incident;
    public int yearStart;
    public int yearEnd;
    public string Place;
    public string Description;

    //public float placeX;
    //public float placeY;
    Vector3 position;
    Vector3 cubeposition;
    Vector3 tempPosition;
    Vector3 scale = new Vector3(3,3,1);
    

    public GameObject cube;
    public GameObject incident;
    public GameObject description;
    public GameObject year;
    public GameObject place;

    // Start is called before the first frame update
    void Start()
    {
        tempPosition = this.transform.position;
        position.x = tempPosition.x;
        position.y = tempPosition.y;
        cubeposition.x = tempPosition.x;
        cubeposition.y = tempPosition.y;

        position.z = yearStart * 10;
        cubeposition.z = yearStart * 10 + 10 * (yearEnd - yearStart) / 2;
        // position.x = placeX;
        // position.y = placeY;

        this.transform.position = position;
        cube.transform.position = cubeposition;

        scale.z = (yearEnd - yearStart) * 10;
        cube.transform.localScale = scale;

        TextMeshPro tmp = incident.GetComponent<TextMeshPro>();
        tmp.text = Incident;

        TextMeshPro tmp1 = description.GetComponent<TextMeshPro>();
        tmp1.text = Description;

        TextMeshPro tmp2 = place.GetComponent<TextMeshPro>();
        tmp2.text = Place;

        TextMeshPro tmp3 = year.GetComponent<TextMeshPro>();
        tmp3.text = ("" + yearStart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
