using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleItem : Item
{
    private string puzzleRiddle;
    private string puzzleAwnser;
    private bool puzzleResult;

    public PuzzleItem(string name, float weight, string puzzleRiddle, string puzzleAwnser) : base(name, weight)
    {
        this.puzzleRiddle = puzzleRiddle;
        this.puzzleAwnser = puzzleAwnser;
    }

    public string GetpuzzleRiddle()
    {
        return puzzleRiddle;
    }

    public string GetpuzzleAwnser()
    {
        return puzzleAwnser;
    }

    public bool PuzzleResult(string yourAwnser)
    {
        if (yourAwnser == puzzleAwnser)
        {
            puzzleResult = true;

            return true;
        }

        return false;
    }
}
