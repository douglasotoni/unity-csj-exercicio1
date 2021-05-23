using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoPlayer : MonoBehaviour
{
  public float Velocidade = 100;
  public float Rotacao = 30;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey(KeyCode.UpArrow))
    {
      transform.Translate(Vector3.forward * Velocidade * Time.deltaTime);
    }

    if (Input.GetKey(KeyCode.DownArrow))
    {
      transform.Translate(-Vector3.forward * Velocidade * Time.deltaTime);
    }

    if (Input.GetKey(KeyCode.RightArrow))
    {
      transform.Rotate(Vector3.up * Rotacao * Time.deltaTime);
    }

    if (Input.GetKey(KeyCode.LeftArrow))
    {
      transform.Rotate(-Vector3.up * Rotacao * Time.deltaTime);
    }
  }
}
