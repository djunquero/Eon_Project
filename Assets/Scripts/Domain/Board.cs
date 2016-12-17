class Board{

    private Box[,] board;

    public Board(int variant)
    {
        variant0();
    }

    private void variant0()
    {
        this.board = new Box[8,12];
    }

    public int heigth() { return board.GetLength(1); }
    public int width() { return board.GetLength(0); }

    public string toString()
    {
        string output="";
        for (int i = 0; i < board.GetLength(1); i++)
        {
            for (int j = 0; j < board.GetLength(0); j++)
            {
                if (board[i, j].hasUnit()) output += "[" + board[i, j].getContent().getID() + "]";
                else output += "[ ]";
            }
            output+='\n';
        }
        return output;
    }
}
