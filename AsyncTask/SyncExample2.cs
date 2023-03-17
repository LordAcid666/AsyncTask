using System.Diagnostics;

namespace AsyncTask
{
    public static class SyncExample2
    {
        public static int IstruzioneA()
        {
            Console.WriteLine("A Start");
            Thread.Sleep(4000);
            Console.WriteLine("A End");

            return 5;
        }

        public static int IstruzioneB()
        {
            Console.WriteLine("B Start");
            Thread.Sleep(3000);
            Console.WriteLine("B End");

            return 7;
        }

        public static void IstruzioneC(int inputIstruzioneA, int inputIstruzioneB)
        {
            Console.WriteLine("C Start");
            Thread.Sleep(2000);

            int somma = inputIstruzioneA + inputIstruzioneB;

            Console.WriteLine($"C End - Risultato: {somma}");
        }

        public static void Execute()
        {
            Console.WriteLine("---------- Esecuzione Sincrona Esempio 1 ----------");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var resultA = IstruzioneA();
            var resultB = IstruzioneB();
            IstruzioneC(resultA, resultB);

            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = string.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds);

            Console.WriteLine("Tempo di esecuzione: " + elapsedTime);
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
