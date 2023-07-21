using _TicTacToe.Scripts.Categories;
using UnityEngine;

namespace _TicTacToe.Scripts.Board
{
    [System.Serializable]
    public struct BoardRow
    {
        public BoardRowElement[] boardRowElements;
    }

    [System.Serializable]
    public struct BoardRowElement
    {
        public Transform visualElementTransform;
        public PlayerSymbols playerSymbol;
    }
}