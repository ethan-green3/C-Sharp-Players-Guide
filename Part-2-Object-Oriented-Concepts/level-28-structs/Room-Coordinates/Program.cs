
Coordinate coord1 = new(1,1);
Coordinate coord2 = new(1,2);
Coordinate coord3 = new(5,5);

Console.WriteLine(coord1.IsAdjacent(coord2));
Console.WriteLine(coord2.IsAdjacent(coord1));
Console.WriteLine(coord2.IsAdjacent(coord3));

public readonly struct Coordinate(int row, int col)
{
    int Row {get;} = row;    
    int Column {get;} = col;

    public bool IsAdjacent(Coordinate coord)
    {
        if ((Row + 1 == coord.Row || Row - 1 == coord.Row) && Column == coord.Column)
        {
            return true;
        }

        if ((Column + 1 == coord.Column || Column - 1 == coord.Column) && Row == coord.Row)
        {
            return true;
        }

        return false;
    }
}