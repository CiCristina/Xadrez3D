using UnityEngine;
using tabuleiro;
using xadrez;



class GameController : MonoBehaviour {


    public GameObject reibranco = null;
    public GameObject reipreto = null;


    PartidaDeXadrez partida;

    void Start() {
        partida = new PartidaDeXadrez();
        Util.instanciarRei('e', 1, Cor.Branca, partida, reibranco);
        Util.instanciarRei('e', 8, Cor.Preta, partida, reipreto);

    }
}
