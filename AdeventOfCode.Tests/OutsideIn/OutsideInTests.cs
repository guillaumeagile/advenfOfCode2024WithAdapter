using AdventOfCode.Src;
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
        
        // mais qui a besoin de la partie technique, en l'occurence qque chose pour lire les fichiers
        ForReadingFile fileReaderAdapter;
        //voulons nous vraiment toute la compléxité de la partie technique?
        // non, nous voulons un test rapide
        // partons sur le fake
        fileReaderAdapter = new FakeForReadingFile();
        
        // le Use Case a besoin du métier; est-il complétement lié au métier ou devons nous abstraire aussi ?
        // notre Metier étant pur, ce sont des méthodes pures, donc statique, nous allons donc laisser le UseCase se brancher sur le métier
        
        //celui ci à émergé pendant le design:
        ColumnAdapter columnAdapter;
        //ca devient une dépendance, comment la faire vivre dans le test?
        columnAdapter = new FakeColumnAdapter();
        
        // assemblons les éléments
        useCases = new UseCases( fileReaderAdapter, columnAdapter );
        // un nouveau comportement à émerger, il est necessaire pour faire fonctionner le UseCase
        
        
        // pour faire quelque chose d'utile
         var actual  = useCases.UserWantsToReadFileAndComputeDistance();
         
         //regardons le résultat
         actual.Should().Be(1);

    }
    
}

public class FakeColumnAdapter : ColumnAdapter
{
}

public class FakeForReadingFile : ForReadingFile
{
    public IEnumerable<string> ReadFile(string inputTxt)
    {
        throw new NotImplementedException();
    }
}

public interface ForReadingFile
{
    IEnumerable<string>  ReadFile(string inputTxt);
}

public class UseCases(ForReadingFile fileReaderAdapter, ColumnAdapter columnAdapter)
{
    public int UserWantsToReadFileAndComputeDistance()
    {
        //comment écrire le code le plus simple possible ?
        
        //on a la fonction pure
        var result = (IEnumerable<int> l1, IList<int>  l2) => CoreDomain.GlobalDistance(l1, l2);
        // probleme, il nouss faut 2 listes d'entiers
        
        //mais comment les lire ?
        // il y a du chemin à parcourir....
        // l'adapteur par défaut nous donne une liste de ligne
        //  var listOfLines = fileReaderAdapter.ReadFile("input.txt");
        //à priori la lecture du fichier ne nous donne pas du tout ce qui est "pratique" pour le métier :(
        
        //RAPPEL le métier est indépendant de la technique
        
        // il faut ré adapter l'adapteur
     //   var columnAdapter = new ColumnAdapter(); // par contre, il faut l'injecter
        // plein d'option de design s'offrent à nous
       // var (list1, list2) = columnAdapter.ExtractTwoColumns( fileReaderAdapter, "input.txt" );
        
        //ooooooooh, probleme, ca fait beaucoup de choses à tester, non?
        //prendrez vous le risque ???
        
     // est ce que vous mockez ici pour faire passer le test coute que coute ? 
     //London School ?
     // et vous prenez le risque de livrer de la merde ?
     
     // approche pragmatique : un nouveau besoin émerge, il faut l'expliciter
      // ExtractTwoColumns -> besoin d'attribuer cette responsabilité
      // -> besoin de la tester pour elle meme
      // -> ensuite, juste besoin de brancher sur l'adapteur par defaut

      return CoreDomain.GlobalDistance(columnAdapter.ExtractTwoColumns(fileReaderAdapter, "input.txt"));
    }
}

public class ColumnAdapter
{
    public (IEnumerable<int> l1, IEnumerable<int>  l2) ExtractTwoColumns(ForReadingFile fileReaderAdapter, string inputTxt)
    {
        throw new NotImplementedException();
    }
}