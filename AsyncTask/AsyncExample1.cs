using System.Diagnostics;

namespace AsyncTask
{
    public static class AsyncExample1
    {
        public static Task AsyncIstruzioneA()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("A Start");
                Thread.Sleep(4000);
                Console.WriteLine("A End");
            });
        }

        public static Task AsyncIstruzioneB()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("B Start");
                Thread.Sleep(3000);
                Console.WriteLine("B End");
            });
        }

        public static Task AsyncIstruzioneC()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("C Start");
                Thread.Sleep(2000);
                Console.WriteLine("C End");
            });
        }

        public static async Task Execute()
        {
            Console.WriteLine("---------- Esecuzione Asincrona Esempio 1 ----------");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            await AsyncIstruzioneA();
            await AsyncIstruzioneB();
            await AsyncIstruzioneC();

            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = string.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds);

            Console.WriteLine("Tempo di esecuzione: " + elapsedTime);
            Console.WriteLine("---------------------------------------------------");
        }

        public static async Task Execute1()
        {
            Console.WriteLine("---------- Esecuzione Asincrona Esempio 2 ----------");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var task1 = AsyncIstruzioneA();
            var task2 = AsyncIstruzioneB();
            var task3 = AsyncIstruzioneC();

            await task1;
            await task2;
            await task3;

            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = string.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds);

            Console.WriteLine("Tempo di esecuzione: " + elapsedTime);
            Console.WriteLine("---------------------------------------------------");
        }

        public static async Task Execute2()
        {
            Console.WriteLine("---------- Esecuzione Asincrona Esempio 3 ----------");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var task1 = AsyncIstruzioneA();
            var task2 = AsyncIstruzioneB();
            var task3 = AsyncIstruzioneC();

            await Task.WhenAll(task1, task2, task3);

            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = string.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds);

            Console.WriteLine("Tempo di esecuzione: " + elapsedTime);
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
