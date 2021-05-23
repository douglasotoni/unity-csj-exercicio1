using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estatico : MonoBehaviour
{
  public static Estatico estaticos;
  private int Vida = 100;

  // Start is called before the first frame update
  void Start()
  {
    estaticos = this;
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void AumentarVida(int saude) 
  {
    Vida += saude;
  }

  public void ReduzVida(int dano)
  {
    Vida += dano;
  }

  public void MostraVida()
  {
    Debug.Log("Seu vital é: " + Vida);
  }
}
