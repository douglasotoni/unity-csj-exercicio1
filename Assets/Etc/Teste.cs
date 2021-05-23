using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    Estatico.estaticos.MostraVida();
    Estatico.estaticos.ReduzVida(10);
    Estatico.estaticos.MostraVida();
    Estatico.estaticos.ReduzVida(10);
    Estatico.estaticos.MostraVida();
    Estatico.estaticos.ReduzVida(10);
    Estatico.estaticos.MostraVida();
    Estatico.estaticos.AumentarVida(100);
    Estatico.estaticos.MostraVida();
  }

  // Update is called once per frame
  void Update()
  {

  }
}
