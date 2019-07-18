using P01._FileStream_Before.Contracts;

namespace P01._FileStream_Before
{
    public class File : IStreamable
    {
        public string Name { get; set; }

        public int Length { get; set; }

        public int Sent { get; set; }
    }
}
