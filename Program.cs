using AwesomeProgram;

namespace AwesomeProgram
{
    public interface IFileWriter
    {
        string Extention { get; }
        void Write(string filename);
    }
}