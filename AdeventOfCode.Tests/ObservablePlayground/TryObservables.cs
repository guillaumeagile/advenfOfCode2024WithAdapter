using System.Reactive.Disposables;
using Xunit.Abstractions;

namespace AdventOfCode.Src.ObservablePlayground
{
    public class TryObservables
    {
        private readonly ITestOutputHelper output;

        public TryObservables(ITestOutputHelper output)
        {
            this.output = output;
        }
    
        [Fact]
        public void Test1()
        {
            var observable = new MySequenceOfNumbers();

            observable.Subscribe(
                x => output.WriteLine(x.ToString()), 
                () => output.WriteLine("Completed")
            );
        }
    }

    public class MySequenceOfNumbers : IObservable<int>
    {
        public IDisposable Subscribe(IObserver<int> observer)
        {
            observer.OnNext(1);
            observer.OnNext(2);
            observer.OnNext(4);
            observer.OnCompleted();
            return Disposable.Empty; // Handy do-nothing IDisposable
        }
    }
}