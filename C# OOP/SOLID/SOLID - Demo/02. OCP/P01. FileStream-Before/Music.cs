using P01._FileStream_Before.Contracts;

namespace P01._FileStream_Before
{
    class Music : IStreamable
    {
        public int Length { get; set; }

        public int Sent { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }
    }
}
