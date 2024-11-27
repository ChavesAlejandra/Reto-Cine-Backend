using back.Models;

namespace Models;

public class Ticket
{
    private int _id { set; get; }

    public string _shownId { set; get; }

    public int _room { set; get; }

    public Session _session { set; get; }

    public Seat _seat { set; get; }

    public Menu _menu { set; get;}

    public Ticket () {}

    public Ticket (int room, Session session, Seat seat, Menu menu)
    {
        _id++;
        _shownId = String.Concat('T', _id);
        _room = room;
        _session = session;
        _seat = seat;
        _menu = menu;
    }

    public void ShowData ()
    {
        Console.WriteLine("Seat:\n{" + $"\n\tId: { _shownId }\n\tRoom: { _room }\n\tSession: { _session }\n\tSeat: { _seat }\n\tMenu: { _menu }\n" + "}");
    }
}
