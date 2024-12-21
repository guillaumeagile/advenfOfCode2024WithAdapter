namespace AdventOfCode.Src;

public class LinesParser
{
    public (int, int) SingleLine(string input)
    {
        var x = input.Split(" ")
            .Where( x => !string.IsNullOrEmpty(x))
            .Select( int.Parse).ToArray();
        return (x[0], x[1]);
    }

    public IEnumerable<(int, int)> MultiLines(IEnumerable<string> inputs)
    {
         return   new List<(int, int)>() { (2, 3), (2, 4) };
    }
   
    
    //TODO: essayer avec une version Observable Rx (Reactive Extensions) in C#
    
    // TODO: essayer une version avec des Stream
    
    // notre adapteur devrait pouvoir s'adapter à
    // 1) lecture sur disque (fichier à plat)
    // 2) lecture depuis S3 (MinIo)
    // 3) lecture depuis une requete Mongo
 
    // de la stabilité des interfaces (abstractions) et du mode de transmission des données
    // 3 familles de type "de transition"
    
    // funA :: _ -> List<T> | funB :: List<T> -> List<T> | funC :: List<T> -> List<T>
    
    // funA :: _ -> IEnumerable<T> | funB :: IEnumerable<T> -> IEnumerable<T> | funC :: IEnumerable<T> -> IEnumerable<T>
    // (remark): IAsyncEnumerable also exist 
    
    // funA :: _ -> IObservable<T> | funB :: IObservable<T> -> IObservable<T> | funC :: IObservable<T> -> IObservable<T>
    
    //The difference is in how code consumes those values.
    //Whereas IEnumerable<T> enables code to retrieve values (typically with a foreach loop),
    //an IObservable<T> provides values when they become available.
    //This distinction is sometimes characterised as push vs pull.
    //We can pull values out of an IEnumerable<T> by executing a foreach loop, but an IObservable<T> will push values into our code.
    
    
}