
using Microsoft.AspNetCore.Authentication;

public class AvailableColors
{
    public enum Color
    {
        Red,
        Blue,
        Green,
        Yellow,
        Orange,
        Purple,
        Pink
    }
    public Color PieceColor { get; set; }

}