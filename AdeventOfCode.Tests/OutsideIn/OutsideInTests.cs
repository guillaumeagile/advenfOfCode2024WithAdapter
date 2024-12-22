using FluentAssertions;
using Microsoft.Win32;

namespace AdeventOfCode.Tests.OutsideIn;


// ok, un mot poli pour ne pas dire End2End testing
public class OutsideInTests
{
    [Fact]
    public void FailingFromTheOutside()
    {
        // mais qu'est ce que l'extérieur ????
        
        // depuis l' IHM ?  non! trop complexe
        
        
        //restons dans le metier avec les Use Case
        UseCases useCases;
        
        // mais qui a besoin de la partie technique
        ForReadingFile fileReaderAdapter;
        //voulons nous vraiment toute la compléxité de la partie technique?
        // non, nous voulons un test rapide
        // partons sur le fake
        fileReaderAdapter = new FakeForReadingFile();
        
        // le Use Case a besoin du métier; est-il complétement lié au métier ou devons nous abstraire aussi ?
        // notre Metier étant pur, ce sont des méthodes pures, donc statique, nous allons donc laisser le UseCase se brancher sur le métier
        
        // assemblons les éléments
        useCases = new UseCases( fileReaderAdapter );
        
        // pour faire quelque chose d'utile
         var actual  = useCases.UserWantsToReadFileAndComputeDistance();
         
         //regardons le résultat
         actual.Should().Be(1);

    }
    
}

public class FakeForReadingFile : ForReadingFile
{
}

public interface ForReadingFile
{
}

public class UseCases(ForReadingFile fileReaderAdapter)
{
    public int UserWantsToReadFileAndComputeDistance()
    {
        return 0;
    }
}