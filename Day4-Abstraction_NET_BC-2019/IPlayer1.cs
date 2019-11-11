namespace Day4_Abstraction_NET_BC_2019
{
    public interface IPlayer1
    {
        string GetName();
        int GuessNumber();
        bool IsNumberGuessed(int number);
    }
}