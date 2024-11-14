namespace back.Models;

public enum FilmGenres
{
    horror,
    romantic,
    scienceFiction,
    animation
}

public enum FilmAgeRestrictions
{
    allPublic = 0,
    overTwelve = 12,
    overSixteen = 16,
    overEighteen = 18
}

public class Film
{
    public int _id { set; get; }
    public string _title { set; get; }

    public string _director { set; get; } // full name

    public int _duration { set; get; } // in minutes

    public int _ageRestriction { set; get; }

    public string[] _genres { set; get; }

    public Film () {}
    public Film (string title, string director, int duration, int ageRestriction, string[] genres)
    {
        _id++;
        _title = title;
        _director = director;
        _duration = duration;
        _ageRestriction = ageRestriction;
        _genres = genres;
    }

    private void ShowSeatData ()
    {
        Console.WriteLine("Seat:\n{" + $"\n\tId: { _id }\n\tTitle: { _title }\n\tDirector: { _director }\n\tDuration: { _duration }\n\tAge Restriction: { _ageRestriction }\n\tGenres: { _genres }\n" + "}");
    }
}