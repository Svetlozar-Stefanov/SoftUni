namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IStreamable streamable;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IStreamable streamable)
        {
            this.streamable = streamable;
        }

        public int CalculateCurrentPercent()
        {
            return (streamable.BytesSent * 100) / streamable.Length;
        }
    }
}
