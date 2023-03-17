namespace AsyncTask
{
    public static class SyncExample1
    {
        public static void IstruzioneA()
        {
            Console.WriteLine("A Start");
            Thread.Sleep(4000);
            Console.WriteLine("A End");
        }

        public static void IstruzioneB()
        {
            Console.WriteLine("B Start");
            Thread.Sleep(4000);
            Console.WriteLine("B End");
        }

        public static void IstruzioneC()
        {

        }

        public static void Execute()
        {

        }
    }
}
