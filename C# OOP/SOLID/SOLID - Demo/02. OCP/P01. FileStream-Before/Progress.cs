using P01._FileStream_Before.Contracts;

namespace P01._FileStream_Before
{
    public class Progress
    {
        private readonly IStreamable streamable;

        public Progress(IStreamable streamable)
        {
            this.streamable = streamable;
        }

        public int CurrentPercent()
        {
            return this.streamable.Sent * 100 / this.streamable.Length;
        }
    }
}
