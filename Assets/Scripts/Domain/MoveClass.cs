class MoveClass {

    public const string LINEAL = "LINEAL";
    public const string STRAIGHT = "STRAIGHT";
    public const string DIAGONAL = "DIAGONAL";
    public const string RADIAL = "RADIAL";

    private string moveClass;

    public MoveClass(string s)
    {
        if (s != LINEAL && s != STRAIGHT && s != DIAGONAL && s != RADIAL) throw new System.Exception("Unknown MoveClass");
        else this.moveClass = s;
    }
}
