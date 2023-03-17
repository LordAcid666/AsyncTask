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
    }
}
